using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Models.Repository
{
    public interface IBooksRepository
    {
        List<string> GetBooks();
    }
}
