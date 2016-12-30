using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Contracts.Models
{
    public interface IVoucher
    {
        int AppliesToProductId { get; set; }
        string AssignedTo { get; set; }
        decimal MinSpend { get; set; }//harcama
        bool MultipleUse { get; set; }
        decimal Value { get; set; }
        string VoucherCode { get; set; }
        string VoucherDescription { get; set; }
        int VoucherId { get; set; }
        int VoucherTypeId { get; set; }
    }
}
