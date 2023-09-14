using MarketStore.Domain.Models.SupportiveModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MarketStore.Domain.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRequired]
        public string? Name { get; set; } = default;

        public decimal? Price { get; set; }

        ////[BsonRequired]
        ////public FoodType Type { get; set; }

        public double? Quantity { get; set; }
    }
}
