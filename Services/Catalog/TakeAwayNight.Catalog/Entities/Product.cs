using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TakeAwayNight.Catalog.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
