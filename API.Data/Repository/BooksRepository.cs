using API.Models.Repository;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using APIApplication.Infrastructure.Models;

namespace API.Data.Repository
{
    public class BooksRepository : IBooksRepository
    {
        private readonly IMongoDatabase _mongoDb;
        public BooksRepository(ConnectionStrings connectionStrings)
        {
        }

        public List<string> GetBooks()
        {
            var books = new List<string>
            {
                "Moonstar",
                "Sunshine",
                "Comics",
                "Bluestar",
                "Joker"
            };

            return books;
        }
    }
}
