using API.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace NewAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : BaseController
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        /// <summary>
        /// Get the Books
        /// </summary>
        /// <returns></returns>
        [HttpGet("getbooks")]
        [ProducesResponseType(typeof(List<string>), 200)]
        public IActionResult GetBooks()
        {
            var books = _booksService.GetBooks();

            if(books.Any())
                return Ok(books);

            return BadRequest("Please try after some time");
        }
    }
}
