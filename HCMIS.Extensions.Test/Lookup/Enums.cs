using HCMIS.Extensions.Attributes;

namespace HCMIS.Extensions.Test.Lookup.Enums
{
    [CodeColumn("ABCCode")]
    enum ABCTypes
    {
        [TableCode("CODEA")]
        A,
        [TableCode("CODEB")]
        B,
        [TableCode("CODEC")]
        C
    }

    [CodeColumn("ReceiptTypeCode")]
    enum ReceiptTypes
    {
        [TableCode("STDR")]
        StandardReceipt,
        [TableCode("DN")]
        DeliveryNote,
        [TableCode("SRM")]
        SRM,
        [TableCode("BB")]
        BeginningBalance
    }

}
