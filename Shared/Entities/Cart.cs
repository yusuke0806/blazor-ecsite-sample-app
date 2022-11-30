using System;
namespace BlazorECSiteSample.Shared.Entities;

public class Cart
{
    public int Quantity { get; set; }
    public Product Product { get; init; } = new();

    public CartStorage ToCartStorage()
    {
        return new CartStorage
        {
            ProductId = Product.Id,
            Quantity = Quantity
        };
    }
}

