using Forum.Data.Models;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Data
{
    public interface ICategoryService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        IEnumerable<T> SearchCategory<T>(string search);
    }
}
