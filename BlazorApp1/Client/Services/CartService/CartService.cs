using BlazorApp1.Client.Services.ProductService;
using BlazorApp1.Shared;
using Blazored.LocalStorage;

namespace BlazorApp1.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IProductService _productService;

        public CartService(
            ILocalStorageService  localStorage,
            IProductService productService
            )
        {
            _localStorage = localStorage;
            _productService = productService;
        }

        public event Action OnChange;

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            await _localStorage.SetItemAsync("cart", cart);
        }
    }
}
