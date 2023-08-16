using HotelApi2Mongo.Application.Entities.Common;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Entities
{
    public class CustomerRoom : BaseEntity
    {
        [BsonElement("CustomerId")]
        public string CustomerId { get; set; }

        [BsonElement("RoomId")]
        public string RoomId { get; set; }
    }
}
