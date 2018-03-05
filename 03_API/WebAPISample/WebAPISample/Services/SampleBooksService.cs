using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPISample.Models;

namespace WebAPISample.Services
{
    public class SampleBooksService : IBooksService
    {
        private List<Book> _books = new List<Book>()
        {
            new Book { BookId = 1, Title = "Professional C# 8"},
            new Book { BookId = 2, Title = "Professional C# 7"}
        };
        public IEnumerable<Book> GetAllBooks() => _books;
    }
}
