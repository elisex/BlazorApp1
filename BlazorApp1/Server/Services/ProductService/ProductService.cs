using BlazorApp1.Server.Data;
using BlazorApp1.Server.Services.CategoryService;
using BlazorApp1.Shared;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace BlazorApp1.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService=categoryService;
            _context=context;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.Include(p => p.Variants).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products.Include(p => p.Variants)
                .Include(p => p.Variants)
                .ThenInclude(v => v.Edition) 
                .FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Include(p => p.Variants).Where(p => p.CategoryId ==category.Id).ToListAsync();
        }
    }
}
