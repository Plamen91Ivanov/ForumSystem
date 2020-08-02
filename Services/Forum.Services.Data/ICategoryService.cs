using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Data
{
    public interface ICategoryService
    {
        IEnumerable<T> GetAll<T>(int? count = null);
    }
}
