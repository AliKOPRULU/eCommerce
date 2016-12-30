using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Contracts.Models
{
    public interface IVoucherType
    {
        string Description { get; set; }
        string Type { get; set; }
        string VoucherModule { get; set; }
        int VoucherTypeId { get; set; }
    }
}
