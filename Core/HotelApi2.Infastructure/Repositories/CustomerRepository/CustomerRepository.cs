using HotelApi2.Domain.Entities;
using HotelApi2.Domain.Repositories.CustomerRepository;
using HotelApi2.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
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
        public Customers GetCustomerWithRoom(int customerId)
        {
            return base._context.Customers
                           .Include(c => c.Room) // Room ilişkilendirmesi
                           .FirstOrDefault(c => c.Id == customerId);
        }

        public Customers GetCustomerWithRoom2(int customerId)
        {
            // Bu metodda sadece RoomId ve RoomNumber'ın döndürülmesi istendiği için 
            // aynı yukarıdaki metod gibi bir implementasyon yapabiliriz.
            // Ayrı bir Dto yapısıyla dönüşüm daha sonra yapılacak.
            return base._context.Customers
                           .Include(c => c.Room)
                           .FirstOrDefault(c => c.Id == customerId);
        }
    }
}
