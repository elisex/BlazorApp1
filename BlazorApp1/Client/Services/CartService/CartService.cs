using BlazorApp1.Client.Services.ProductService;
using BlazorApp1.Shared;
using Blazored.Toast.Services;
using Blazored.SessionStorage;

namespace BlazorApp1.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ISessionStorageService _sessionStorage;
        private readonly IProductService _productService;
        private readonly IToastService _toastService;

        public CartService(
            ISessionStorageService sessionStorage,
            IProductService productService,
            IToastService toastService
            )
        {
            _sessionStorage = sessionStorage;
            _productService = productService;
            _toastService=toastService;
        }

        public event Action OnChange;

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await _sessionStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null )
            {
                cart = new List<ProductVariant>();
            }
            cart.Add( productVariant );
            await _sessionStorage.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(productVariant.ProductId);
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await _sessionStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                return result;
            }

            foreach (var item in cart)
            {
                var product = await _productService.GetProduct(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    EditionId = item.EditionId
                };

                var variant = product .Variants.Find(v => v.EditionId == item.EditionId);
                if(variant != null )
                {
                    cartItem.EditionName = variant.Edition?.Name;
                    cartItem.Price = variant.Price;
                }

                result.Add( cartItem );
            }

            return result;
        }
    }
}
