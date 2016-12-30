using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Contracts.Models
{
    public interface IBasket
    {
        Guid BasketId { get; set; }
        DateTime Date { get; set; }

        ICollection<IBasketItem> IBasketItems { get; }
        ICollection<IBasketVoucher> IBasketVouchers { get; }

        void AddBasketItem(IBasketItem item);
        void AddBasketVoucher(IBasketVoucher voucher);

        decimal BasketTotal();
        decimal BasketItemCount();
    }
}
