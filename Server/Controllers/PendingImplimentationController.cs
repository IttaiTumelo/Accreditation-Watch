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
        public async Task<ActionResult<IEnumerable<PendingImplementation>>> GetPendingImplimentations()
        {
            return await _context.PendingImplementations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PendingImplementation>> GetPendingImplimentation(int id)
        {
            var pendingImplimentation = await _context.PendingImplementations.FindAsync(id);

            if (pendingImplimentation == null)
            {
                return NotFound();
            }

            return pendingImplimentation;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPendingImplimentation(int id, PendingImplementation pendingImplementation)
        {
            if (id != pendingImplementation.Id)
            {
                return BadRequest();
            }

            _context.Entry(pendingImplementation).State = EntityState.Modified;

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
        public async Task<ActionResult<PendingImplementation>> PostPendingImplimentation(PendingImplementation pendingImplementation)
        {
            _context.PendingImplementations.Add(pendingImplementation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPendingImplimentation", new { id = pendingImplementation.Id }, pendingImplementation);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PendingImplementation>> DeletePendingImplimentation(int id)
        {
            var pendingImplimentation = await _context.PendingImplementations.FindAsync(id);
            if (pendingImplimentation == null)
            {
                return NotFound();
            }

            _context.PendingImplementations.Remove(pendingImplimentation);
            await _context.SaveChangesAsync();

            return pendingImplimentation;
        }

        private bool PendingImplimentationExists(int id)
        {
            return _context.PendingImplementations.Any(e => e.Id == id);
        }
        
        
        
    }
}

