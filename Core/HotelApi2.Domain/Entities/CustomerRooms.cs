using HotelApi2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Domain.Entities
{
    public class CustomerRooms : BaseEntity
    {
        //Customer
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }

        //Room
        public int RoomId { get; set; }
        public Rooms Rooms { get; set; }


    }
}
