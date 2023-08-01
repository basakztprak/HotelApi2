using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Domain.Repositories.CustomerRoomRepository
{
    public interface ICustomerRoomRepository : IReadRepository<CustomerRooms> , IWriteRepository<CustomerRooms>
    {
    }
}
