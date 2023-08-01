using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Domain.Repositories.CustomerRepository
{
    public interface ICustomerRepository : IReadRepository<Customers>, IWriteRepository<Customers>
    {
    }
}
