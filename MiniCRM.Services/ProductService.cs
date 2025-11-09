using MiniCRM.Core.Entities;
using MiniCRM.Core.Interfaces.Repositories;
using MiniCRM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Services
{
    public class ProductService : IProduct
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<Product> AddProductAsync(Product product)
        {
            await _repository.AddAsync(product);
            await _repository.SaveChangesAsync();
            return product;
        }
        
    }
}
