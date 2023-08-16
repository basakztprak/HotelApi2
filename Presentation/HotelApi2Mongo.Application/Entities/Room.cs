using HotelApi2Mongo.Application.Entities.Common;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Entities
{
    public class Room : BaseEntity
    {
        [BsonElement("RoomsNumber")]
        public string RoomsNumber { get; set; }

        [BsonElement("Floor")]
        public string Floor { get; set; }

        [BsonElement("IsEmpty")]
        public bool IsEmpty { get; set; }

        [BsonElement("Customers")]
        public List<string> CustomerIds { get; set; } // Customer belgelerinin ObjectId'lerini saklayabiliriz.
    }
}
