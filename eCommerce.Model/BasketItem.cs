using eCommerce.Contracts.Models;
using System;

namespace eCommerce.Model
{
    public class BasketItem : IBasketItem
    {
        public int BasketItemId { get; set; }

        public Guid BasketId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        private Product _product;

        public virtual IProduct IProduct
        {
            get{return _product as IProduct;}
            set{_product = value as Product;}
        }

        public virtual Product Product {
            get { return _product; }
            set { _product = value; }
        }
    }
}