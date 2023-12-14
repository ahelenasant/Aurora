using MoonLight.Application.Repositories;
using MoonLight.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonLight.SqlServerData.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Product> enumerable)
        {
            throw new NotImplementedException();
        }
    }
}
