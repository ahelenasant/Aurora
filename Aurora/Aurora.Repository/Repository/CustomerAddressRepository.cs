using MoonLight.Application.Repositories;
using MoonLight.Domain.Entities;

namespace MoonLight.SqlServerData.Repository
{
    public class CustomerAddressRepository : ICustomerAddressRepository
    {
        public CustomerAddress Get(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertRange(IEnumerable<CustomerAddress> addresses)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<CustomerAddress> customerAddress)
        {
            throw new NotImplementedException();
        }
    }
}
