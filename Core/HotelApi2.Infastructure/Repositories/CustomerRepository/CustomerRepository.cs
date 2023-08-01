using HotelApi2.Domain.Entities;
using HotelApi2.Domain.Repositories.CustomerRepository;
using HotelApi2.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Infastructure.Repositories.CustomerRepository
{
    public class CustomerRepository : Repository<Customers> , ICustomerRepository
    {
        public CustomerRepository(MyDbContext context) : base(context)
        {
        }
    }
}
