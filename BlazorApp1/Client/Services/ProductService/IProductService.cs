using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);
        Task <Product> GetProduct(int id);

    }
}
