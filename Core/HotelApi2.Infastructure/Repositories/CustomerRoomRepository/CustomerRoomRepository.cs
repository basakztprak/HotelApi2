using HotelApi2.Domain.Entities;
using HotelApi2.Domain.Repositories.CustomerRoomRepository;
using HotelApi2.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Infastructure.Repositories.CustomerRoomRepository
{
    public class CustomerRoomRepository : Repository<CustomerRooms>, ICustomerRoomRepository
    {
        public CustomerRoomRepository(MyDbContext context) : base(context)
        {
        }

    }   
}
