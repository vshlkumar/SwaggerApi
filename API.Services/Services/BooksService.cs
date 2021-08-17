using API.Models.Repository;
using API.Models.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _booksRepository;
        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public List<string> GetBooks()
        {
            var books = _booksRepository.GetBooks();
            return books;
        }
    }
}
