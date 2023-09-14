using MarketStore.Domain.Models.SupportiveModels;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MarketStore.Api.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string? Name { get; set; } = default;

        public decimal? Price { get; set; }

        public FoodType Type { get; set; }

        public double? Quantity { get; set; }
    }
}
