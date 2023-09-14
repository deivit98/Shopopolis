using MarketStore.Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MarketStore.Infrastructure
{
    public class MarketStoreDbContext
    {
        private readonly IMongoDatabase _database;

        public MarketStoreDbContext(IOptions<DatabaseSettings> options)
        {
            var connectionString = options.Value.ConnectionString;
            _database = new MongoClient(connectionString).GetDatabase(options.Value.DatabaseName);
        }

        public IMongoCollection<Product> ProductsCollection => _database.GetCollection<Product>("products");
    }
}
