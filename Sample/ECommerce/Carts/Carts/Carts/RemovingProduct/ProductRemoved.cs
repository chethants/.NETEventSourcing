using System;
using Carts.Carts.Products;
using Core.Events;

namespace Carts.Carts.RemovingProduct;

public class ProductRemoved: IEvent
{
    public Guid CartId { get; }

    public PricedProductItem ProductItem { get; }

    public ProductRemoved(Guid cartId, PricedProductItem productItem)
    {
        CartId = cartId;
        ProductItem = productItem;
    }

    public static ProductRemoved Create(Guid cartId, PricedProductItem productItem)
    {
        if (cartId == Guid.Empty)
            throw new ArgumentOutOfRangeException(nameof(cartId));

        return new ProductRemoved(cartId, productItem);
    }
}