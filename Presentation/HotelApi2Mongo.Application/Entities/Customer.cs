using HotelApi2Mongo.Application.Entities.Common;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Entities
{
    public class Customer : BaseEntity
    {
        [BsonElement("CustomerName")]
        public string CustomerName { get; set; }

        [BsonElement("CustomerSurname")]
        public string CustomerSurname { get; set; }

        [BsonElement("CustomerId")]
        public int CustomerIdNumber { get; set; } // "CustomerId" adı zaten kullanıldığı için değiştirdim.

        [BsonElement("CustomerPhoneNumber")]
        public int CustomerPhoneNumber { get; set; }
    }
}
