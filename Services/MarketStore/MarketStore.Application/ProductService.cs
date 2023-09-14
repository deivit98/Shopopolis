using MarketStore.Domain.Models;
using MarketStore.Infrastructure;
using MongoDB.Driver;

namespace MarketStore.Application
{
    public class ProductService
    {
        private readonly MarketStoreDbContext _context;

        public ProductService(MarketStoreDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAsync() =>
            await _context.ProductsCollection.Find(_ => true).ToListAsync();

        public async Task<Product?> GetAsync(string id) =>
            await _context.ProductsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Product newProduct) =>
            await _context.ProductsCollection.InsertOneAsync(newProduct);

        public async Task UpdateAsync(string id, Product updatedProduct) =>
            await _context.ProductsCollection.ReplaceOneAsync(x => x.Id == id, updatedProduct);

        public async Task RemoveAsync(string id) =>
            await _context.ProductsCollection.DeleteOneAsync(x => x.Id == id);
    }
}
