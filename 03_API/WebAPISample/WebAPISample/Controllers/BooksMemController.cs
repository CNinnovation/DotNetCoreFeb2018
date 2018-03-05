using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPISample.Models;
using WebAPISample.Services;

namespace WebAPISample.Controllers
{
    [Produces("application/json")]
    [Route("api/Books")]
    public class BooksMemController : Controller
    {
        private readonly IBooksService _booksService;
        public BooksMemController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Book> Get() => _booksService.GetAllBooks();
    }
}