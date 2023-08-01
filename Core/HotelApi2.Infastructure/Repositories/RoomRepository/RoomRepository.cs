using HotelApi2.Domain.Entities;
using HotelApi2.Domain.Repositories.RoomRepository;
using HotelApi2.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Infastructure.Repositories.RoomRepository
{
    public class RoomRepository : Repository<Rooms> , IRoomRepository
    {
        public RoomRepository(MyDbContext context) : base(context)
        {
        }
    }
}
