﻿using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);
        Task<List<CartItem>> GetCartItems();
    }
}
