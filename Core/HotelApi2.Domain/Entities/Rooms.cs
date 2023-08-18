using HotelApi2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Domain.Entities
{
    public class Rooms : BaseEntity
    {
       
        public string RoomsNumber { get; set; }
        public string Floor { get; set; }
        public bool IsEmpty { get; set; }
        public List<Customers> Customers { get; set; }
        //public List<CustomerRooms> CustomerRooms { get; set; }

    }
}


