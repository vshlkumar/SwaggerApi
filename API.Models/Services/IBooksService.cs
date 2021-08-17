using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API.Models.Services
{
    public interface IBooksService
    {
        List<string> GetBooks();
    }
}
