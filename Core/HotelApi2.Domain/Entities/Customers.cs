using HotelApi2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Domain.Entities
{
    public class Customers : BaseEntity
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CustomerId { get; set; }
        public int CustomerPhoneNumber { get; set; }

    }
}
