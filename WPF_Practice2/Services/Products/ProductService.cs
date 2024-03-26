using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Practice2.Model;

namespace WPF_Practice2.Services.Products
{
    public class ProductService : IDataService<Product>
    {
        public Task<Product> Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product typeClass)
        {
            throw new NotImplementedException();
        }
    }
}
