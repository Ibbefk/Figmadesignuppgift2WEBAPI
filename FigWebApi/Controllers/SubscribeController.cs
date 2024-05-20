using Microsoft.AspNetCore.Mvc;
using FigWebApi.Data; 
using FigWebApi.Models; 
using System.Linq;
using System.Threading.Tasks;

namespace FigWebApi.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscribeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubscribeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe([FromBody] Subscription subscription)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Subscriptions.Add(subscription);
            await _context.SaveChangesAsync();
            return Ok(subscription);
        }

        [HttpDelete("{email}")]
        public async Task<IActionResult> Unsubscribe(string email)
        {
            var subscription = await _context.Subscriptions.FindAsync(email);
            if (subscription == null)
            {
                return NotFound();
            }

            _context.Subscriptions.Remove(subscription);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
