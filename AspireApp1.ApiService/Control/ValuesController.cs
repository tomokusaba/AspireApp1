using AspireApp1.ApiService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspireApp1.ApiService.Control;

[Route("api/[controller]")]
[ApiController]
public class ValuesController(App1Context context) : ControllerBase
{
    private readonly App1Context _context = context;

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Books);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Books.Find(id));
    }

    [HttpPost]
    public IActionResult Post([FromBody] Books book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
    }
}
