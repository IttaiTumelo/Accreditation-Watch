namespace AccreditationWatch.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PendingImplimentationController : ControllerBase
    {
        private readonly DataContext _context;
        public PendingImplimentationController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PendingImplimentation>>> GetPendingImplimentations()
        {
            return await _context.PendingImplimentations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PendingImplimentation>> GetPendingImplimentation(int id)
        {
            var pendingImplimentation = await _context.PendingImplimentations.FindAsync(id);

            if (pendingImplimentation == null)
            {
                return NotFound();
            }

            return pendingImplimentation;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPendingImplimentation(int id, PendingImplimentation pendingImplimentation)
        {
            if (id != pendingImplimentation.Id)
            {
                return BadRequest();
            }

            _context.Entry(pendingImplimentation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PendingImplimentationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<PendingImplimentation>> PostPendingImplimentation(PendingImplimentation pendingImplimentation)
        {
            _context.PendingImplimentations.Add(pendingImplimentation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPendingImplimentation", new { id = pendingImplimentation.Id }, pendingImplimentation);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PendingImplimentation>> DeletePendingImplimentation(int id)
        {
            var pendingImplimentation = await _context.PendingImplimentations.FindAsync(id);
            if (pendingImplimentation == null)
            {
                return NotFound();
            }

            _context.PendingImplimentations.Remove(pendingImplimentation);
            await _context.SaveChangesAsync();

            return pendingImplimentation;
        }

        private bool PendingImplimentationExists(int id)
        {
            return _context.PendingImplimentations.Any(e => e.Id == id);
        }
        
        
        
    }
}

