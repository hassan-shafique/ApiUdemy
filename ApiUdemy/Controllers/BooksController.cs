using ApiUdemy.Data.Services;
using ApiUdemy.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ApiUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService booksService;
        public BooksController(BooksService _booksService)
        {
            booksService = _booksService;
        }
        [HttpPost("add-book-with-Authors")]
        public IActionResult AddBookWithAuthors([FromBody] BookVM book)
        {
            booksService.AddBookWithAuthors(book);
            return Ok();
        }
        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            return Ok(booksService.GetAllBooks());
        }
        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBooksById(int id)
        {
            return Ok(booksService.GetBookById(id));
        }
        [HttpPut("Update-Book/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]BookVM book)
        {
            return Ok( booksService.UpdateBook(id,book) );
        }
        [HttpDelete("Delete-Book/{id}")]
        public IActionResult DeleteBook(int id)
        {
            booksService.DeleteBookById(id);
            return Ok();
        }
    }
}
