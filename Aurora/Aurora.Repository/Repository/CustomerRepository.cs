using MoonLight.Application.Repositories;
using MoonLight.Domain.Entities;
using MoonLight.Domain.ValueObjects;

namespace MoonLight.SqlServerData.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool VerifyExistingDocument(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
