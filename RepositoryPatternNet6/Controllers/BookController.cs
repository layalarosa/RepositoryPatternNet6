using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternNet6.Data;
using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly ApplicationDbContext _context;

        public BookController(ILogger<BookController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var users = await _context.Users.ToListAsync();
            //return Ok(users);

            return Ok(await _context.Books.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
                return NotFound(); // 404 http status code 

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                await _context.SaveChangesAsync();

                return Ok(await _context.Books.ToListAsync());
            }
            //return Ok(await _context.Users.ToListAsync());
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Book request)
        {
            var item = await _context.Books.FindAsync(request.Id);
            if (item == null)
                return BadRequest("User not found.");

            item.Title = request.Title;
            item.Year = request.Year;
            item.Price = request.Price;
            item.Genre = request.Genre;


            await _context.SaveChangesAsync();

            return Ok(await _context.Books.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Books.FindAsync(id);

            if (item == null)
                return BadRequest("User not found");

            _context.Books.Remove(item);
            await _context.SaveChangesAsync();

            return Ok(await _context.Books.FindAsync());
        }
    }
}
