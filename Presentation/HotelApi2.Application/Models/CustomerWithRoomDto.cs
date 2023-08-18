using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Models
{
    public class CustomerWithRoomDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public RoomDto Room { get; set; }
    }
}
