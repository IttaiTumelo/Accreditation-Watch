namespace Accreditation_Watch.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T, TDto> : ControllerBase where T : BaseEntity, new() where TDto : BaseEntity
    {
        protected readonly DataContext _context;
        private readonly T _entity;
        public BaseController(DataContext context)
        {
            _context = context;
            _entity = new BaseEntity() as T;
        }
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<T>>> Get()
        {
            var accessToken = HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                ?.Substring("Bearer ".Length);
            T entity2 = new T();
            if (entity2.RequiresAuthentication() && accessToken is null) return Unauthorized("You need to be logged in to access this resource");
            User user = AWFunctions.GetDeatailsFromToken(accessToken);

            History history = new History()
            {
                Name = "Get All request",
                Description = $"User {user.Email} requested all {typeof(T).Name}(s)",
                UserId = user.Id,
                Date = DateTime.Now,
                Action = "Get All",
                Severity = Severity.Low,
                InitialState = "",
                FinalState = "",
            };
            var query = _context.Set<T>().AsQueryable();
            //remove entities that have their status set to deleted
            query = query.Where(x => !x.IsDeleted);

            if (query is not null)
            {
                if (query.ToList().Count >= 1)
                {
                    try
                    {
                        foreach (var type in query.ToList().FirstOrDefault().RelatedEntities())
                        {
                            query = query.Include(type);
                        }

                        var entity = await query.ToListAsync();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        history.ActionResult = $"Failed because of {e.Message}";
                        _context.Histories.Add(history);
                        _context.SaveChanges();
                        return Ok(e.Message + "\n\n " + e.StackTrace);
                    }
                }
                //else return NotFound($"No {typeof(T).Name}(s) found");
                else
                {
                    history.ActionResult = "Success";
                    _context.Histories.Add(history);
                    _context.SaveChanges();
                    return Ok(new List<T>());
                }
            }
            else
            {
                history.ActionResult = $"Failed because of {query}";
                _context.Histories.Add(history);
                _context.SaveChanges();
                return NotFound();
            }
            history.ActionResult = "Success";
            _context.Histories.Add(history);
            _context.SaveChanges();
            return Ok(query.ToList());
        }

        [HttpPost("byValue")]
        public virtual async Task<ActionResult<List<T>>> GetByValue(Filter filters)
        {
            var accessToken = HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                ?.Substring("Bearer ".Length);
            T entity2 = new T();
            if (entity2.RequiresAuthentication() && accessToken is null) return Unauthorized("You need to be logged in to access this resource");
            User user = AWFunctions.GetDeatailsFromToken(accessToken);

            History history = new History()
            {
                Name = "Get with filters request",
                Description = $"User {user.Email} requested get get the details of {typeof(T).Name}(s) with the following filters {filters.ToString()}",
                UserId = user.Id,
                Date = DateTime.Now,
                Action = "Get All",
                Severity = Severity.Low,
                InitialState = "",
                FinalState = "",
            };

            var query = _context.Set<T>().AsQueryable();
            if (query is not null)
            {
                foreach (var type in query.ToList().FirstOrDefault().RelatedEntities())
                {
                    query = query.Include(type);
                }
                var result = query.ToList();
                foreach (var propertyName in filters.Filters)
                    result = result.Where(x => x.GetType().GetProperty(propertyName.Key).GetValue(x).ToString() == propertyName.Value).ToList();
                history.ActionResult = "Success";
                _context.Histories.Add(history);
                _context.SaveChanges();
                return Ok(result.ToList());
            }
            else
            {
                history.ActionResult = $"Failed because of {query}";
                _context.Histories.Add(history);
                _context.SaveChanges();
                return NotFound();
            }
        }


        [HttpPost]
        public virtual async Task<ActionResult<T>> Post(TDto entity) //Post(TDto entity)
        {
            var accessToken = HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                ?.Substring("Bearer ".Length);
            T entity2 = new T();
            if (entity2.RequiresAuthentication() && accessToken is null) return Unauthorized("You need to be logged in to access this resource");
            User user = AWFunctions.GetDeatailsFromToken(accessToken);
            var query = _context.Set<T>().AsQueryable();

            History history = new History()
            {
                Name = "Create request",
                Description = $"User {user.Email} requested to add a new {typeof(T).Name} with the following details {entity.ToString()}",
                UserId = user.Id,
                Date = DateTime.Now,
                Action = "Add",
                Severity = Severity.Low,
                InitialState = $"There was no {typeof(T).Name} with the following details {entity.ToString()}, and table {typeof(T).Name}s had {query.ToList().Count} {typeof(T).Name}(s)",
                FinalState = $"entry with the following details {entity.ToString()} was added to table {typeof(T).Name}s, and table {typeof(T).Name}s now has {query.ToList().Count + 1} {typeof(T).Name}(s)",
            };

            var newEntity = new T();
            newEntity = entity as T;
            await _context.Set<T>().AddAsync(newEntity);
            history.ActionResult = "Success";
            _context.Histories.Add(history);
            await _context.SaveChangesAsync();
            return Ok(entity);
        }

        [HttpPut]
        public virtual async Task<ActionResult<T>> Update(T entity)
        {
            var accessToken = HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                ?.Substring("Bearer ".Length);
            T entity2 = new T();
            if (entity2.RequiresAuthentication() && accessToken is null) return Unauthorized("You need to be logged in to access this resource");
            User user = AWFunctions.GetDeatailsFromToken(accessToken);
            var query = _context.Set<T>().AsQueryable();
            History history = new History()
            {
                Name = "Update request",
                Description = $"User {user.Email} requested to update a {typeof(T).Name} with the following details {entity.ToString()}",
                UserId = user.Id,
                Date = DateTime.Now,
                Action = "Update",
                Severity = Severity.Low,
                InitialState = $"There was a {typeof(T).Name} with the following details {entity.ToString()}, and table {typeof(T).Name}s had {query.ToList().Count} {typeof(T).Name}(s)",
                FinalState = $"entry with the following details {entity.ToString()} was updated to table {typeof(T).Name}s, and table {typeof(T).Name}s now has {query.ToList().Count} {typeof(T).Name}(s)",
            };
            _context.Entry(entity).State = EntityState.Modified;
            MailController mailController = new MailController();
            await mailController.SendMail(new() { Email = new() { "ittaitumelo@outlook.com" }, Id = entity.Id, Message = $" Table {typeof(T).Name}s has been modified to {entity.ToString()}", Subject = "data change", Name = "" });
            await _context.SaveChangesAsync();
            history.ActionResult = $"Success: and email was sent to {user.Email}";
            _context.Histories.Add(history);
            _context.Histories.Add(new History()
            {
                Name = $"Email Sent to {user.Email}",
                Description = $"User {user.Email} was sent an email with the following details {entity.ToString()}",
                UserId = user.Id,
                Date = DateTime.Now,
                Action = "Email",
                Severity = Severity.Low,
                InitialState = $"There was a {typeof(T).Name} with the following details {entity.ToString()}, and table {typeof(T).Name}s had {query.ToList().Count} {typeof(T).Name}(s)",
                FinalState = $"entry with the following details {entity.ToString()} was updated to table {typeof(T).Name}s, and table {typeof(T).Name}s now has {query.ToList().Count} {typeof(T).Name}(s)"
            });
            _context.SaveChanges();
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult<T>> Delete(int id)
        {
            var accessToken = HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                ?.Substring("Bearer ".Length);
            T entity2 = new T();
            if (entity2.RequiresAuthentication() && accessToken is null) return Unauthorized("You need to be logged in to access this resource");
            User user = AWFunctions.GetDeatailsFromToken(accessToken);
            var query = _context.Set<T>().AsQueryable();

            History history = new History()
            {
                Name = "Delete Request",
                Description = $"User {user.Email} requested to delete a {typeof(T).Name} with the following details {query.FirstOrDefault(x => x.Id == id).ToString()}",
                UserId = user.Id,
                Date = DateTime.Now,
                Action = "Delete",
                Severity = Severity.High,
                InitialState = $"There was a {typeof(T).Name} with the following details {query.FirstOrDefault(x => x.Id == id).ToString()}, and table {typeof(T).Name}s had {query.ToList().Count} {typeof(T).Name}(s)",
                FinalState = $"entry with the following details {query.FirstOrDefault(x => x.Id == id).ToString()} was deleted from table {typeof(T).Name}s, and table {typeof(T).Name}s now has {query.ToList().Count - 1} {typeof(T).Name}(s)",
            };
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity is null)
            {
                return NotFound();
            }
            var entityToDelete = await _context.Set<T>().FindAsync(id);
            entity.IsDeleted = true;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            history.ActionResult = $"Success";
            _context.Histories.Add(history);
            _context.SaveChanges();
            // _context.Set<T>().Remove(entity);
            return Ok(entity);
        }
        [HttpGet("deleted")]
        public virtual async Task<ActionResult<IEnumerable<T>>> GetDeleted()
        {
            var accessToken = HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                ?.Substring("Bearer ".Length);
            T entity2 = new T();
            if (entity2.RequiresAuthentication() && accessToken is null) return Unauthorized("You need to be logged in to access this resource");
            User user = AWFunctions.GetDeatailsFromToken(accessToken);
            var query = _context.Set<T>().AsQueryable();
            History history = new History()
            {
                Name = "View Deleted Request",
                Description = $"User {user.Email} requested to view deleted {typeof(T).Name}s",
                UserId = user.Id,
                Date = DateTime.Now,
                Action = "View",
                Severity = Severity.Low,
                InitialState = $"There were {query.ToList().Count} {typeof(T).Name}(s) in table {typeof(T).Name}s",
                FinalState = $"There were {query.ToList().Count} {typeof(T).Name}(s) in table {typeof(T).Name}s",
            };
            var result = query.Where(x => x.IsDeleted == true);
            if (result is null)
            {
                history.ActionResult = $"Failed because of {query}";
                _context.Histories.Add(history);
                _context.SaveChanges();
                return NotFound();
            }
            else
            {
                history.ActionResult = $"Success";
                _context.Histories.Add(history);
                _context.SaveChanges();
                return Ok(result.ToList());
            }
        }

        [HttpPost("undelete/{id}")]
        public virtual async Task<ActionResult<T>> Undelete(int id)
        {
            var accessToken = HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                ?.Substring("Bearer ".Length);
            T entity2 = new T();
            if (entity2.RequiresAuthentication() && accessToken is null) return Unauthorized("You need to be logged in to access this resource");
            User user = AWFunctions.GetDeatailsFromToken(accessToken);
            var query = _context.Set<T>().AsQueryable();
            History history = new History()
            {
                Name = "Undelete Request",
                Description = $"User {user.Email} requested to undelete a {typeof(T).Name} with the following details {query.FirstOrDefault(x => x.Id == id).ToString()}",
                UserId = user.Id,
                Date = DateTime.Now,
                Action = "Undelete",
                Severity = Severity.High,
                InitialState = $"There was a {typeof(T).Name} with the following details {query.FirstOrDefault(x => x.Id == id).ToString()}, and table {typeof(T).Name}s had {query.ToList().Count} {typeof(T).Name}(s)",
                FinalState = $"entry with the following details {query.FirstOrDefault(x => x.Id == id).ToString()} was undeleted from table {typeof(T).Name}s, and table {typeof(T).Name}s now has {query.ToList().Count + 1} {typeof(T).Name}(s)",
            };
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity is null)
            {
                return NotFound();
            }
            entity.IsDeleted = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            history.ActionResult = $"Success";
            _context.Histories.Add(history);
            _context.SaveChanges();
            return Ok(entity);
        }

        [HttpDelete]
        public virtual async Task<ActionResult<T>> Delete()
        {
            var entities = await _context.Set<T>().ToListAsync();
            if (entities is null)
            {
                return NotFound();
            }
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
            return Ok(entities);
        }
    }
}

