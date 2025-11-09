using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Services.Interfaces
{
    public interface IProduct
    {
        Task<IEnumerable<Core.Entities.Product>> GetAllProductsAsync();
        Task<Core.Entities.Product> AddProductAsync(Core.Entities.Product product);
    }
}
