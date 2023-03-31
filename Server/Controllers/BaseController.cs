namespace Accreditation_Watch.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T, TDto> : ControllerBase where T : BaseEntity, new()  where TDto : BaseEntity
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
            var query = _context.Set<T>().AsQueryable();
            
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

                        return Ok(e.Message + "\n\n " + e.StackTrace);
                    }
                }
                //else return NotFound($"No {typeof(T).Name}(s) found");
                else return Ok(new List<T>());
              
                
            }
            else
            {
                return NotFound();
            }
            return Ok(query.ToList());
        }

        [HttpPost("byValue")]
        public virtual async Task<ActionResult<List<T>>> GetByValue(Filter filters)
        {
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
                return Ok(result.ToList());
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        public virtual async Task<ActionResult<T>> Post(TDto entity) //Post(TDto entity)
        {
            var newEntity = new T();
            newEntity = entity as T;
            //newEntity.InitializeFromDto(entity);
            //await _context.Set<T>().AddAsync(newEntity);

            await _context.Set<T>().AddAsync(newEntity);
            await _context.SaveChangesAsync();
            return Ok(entity);
        }

        [HttpPut]
        public virtual async Task<ActionResult<T>> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            MailController mailController = new MailController();
            await mailController.SendMail(new() { Email = new() { "ittaitumelo@outlook.com"}, Id = entity.Id, Message = $" Table {typeof(T).Name}s has been modified to {entity.ToString()}", Subject="data change", Name="" });
            await _context.SaveChangesAsync();
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult<T>> Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity is null)
            {
                return NotFound();
            }
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
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

