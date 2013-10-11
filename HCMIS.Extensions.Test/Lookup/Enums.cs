using HCMIS.Extensions.Attributes;

namespace HCMIS.Extensions.Test.Lookup.Enums
{
    [CodeColumn("ABCCode")]
    enum ABCTypes
    {
        [TableCode("E0F19")]
        A,
        [TableCode("8C5BF")]
        B,
        [TableCode("F5C2B")]
        C
    }

    [CodeColumn("ReceiptTypeCode")]
    enum ReceiptTypes
    {
        [TableCode("CBFD2")]
        StandardReceipt,
        [TableCode("12618")]
        DeliveryNote,
        [TableCode("FB6B5")]
        SRM,
        [TableCode("1E8F6")]
        BeginningBalance
    }

}
