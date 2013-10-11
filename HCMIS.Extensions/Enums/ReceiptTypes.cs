using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCMIS.Extensions.Attributes;
using HCMIS.Extensions.Models;

namespace HCMIS.Extensions.Enums
{
    [ModelClass(typeof(ReceiptType))]
    [CodeColumn("ReceiptTypeCode")]
    public enum ReceiptTypes
    {
        [TableCode("STDR")]
        StandardReceipt,

        [TableCode("DN")]
        DeliveryNote,

        [TableCode("BBAL")]
        BeginningBalance
    }
}
