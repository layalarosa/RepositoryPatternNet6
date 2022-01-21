using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternNet6.Data;
using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly ApplicationDbContext _context;

        public AuthorController(ILogger<AuthorController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var users = await _context.Users.ToListAsync();
            //return Ok(users);

            return Ok(await _context.Authors.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
                return NotFound(); // 404 http status code 

            return Ok(author);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Author author)
        {
            if (ModelState.IsValid)
            {
                _context.Authors.Add(author);
                await _context.SaveChangesAsync();

                return Ok(await _context.Authors.ToListAsync());
            }
            //return Ok(await _context.Users.ToListAsync());
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Author request)
        {
            var item = await _context.Authors.FindAsync(request.Id);
            if (item == null)
                return BadRequest("User not found.");

            item.Name = request.Name;
            

            await _context.SaveChangesAsync();

            return Ok(await _context.Authors.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Authors.FindAsync(id);

            if (item == null)
                return BadRequest("User not found");

            _context.Authors.Remove(item);
            await _context.SaveChangesAsync();

            return Ok(await _context.Authors.FindAsync());
        }
    }
}
