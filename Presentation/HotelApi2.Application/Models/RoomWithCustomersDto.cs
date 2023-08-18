using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Models
{
    public class RoomWithCustomersDto
    {
        public int Id { get; set; }
        public string RoomsNumber { get; set; }
        public string Floor { get; set; }
        public List<CustomerDto> Customers { get; set; }

    }
}
