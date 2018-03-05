using System.Collections.Generic;
using WebAPISample.Models;

namespace WebAPISample.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetAllBooks();
    }
}