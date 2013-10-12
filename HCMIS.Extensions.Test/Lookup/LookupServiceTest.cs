using HCMIS.Extensions.Services;
using HCMIS.Extensions.Test.Lookup.Enums;
using HCMIS.Extensions.Test.Lookup.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HCMIS.Extensions.Test.Lookup
{
    [TestClass]
    public class LookupServiceTest
    {

        [TestMethod]
        public void TestDaTest()
        {
            var context = new HCMISEntities();
            context.ReceiptTypes.Add(new ReceiptType() {ID = 1,Name = "StandardReceipt", ReceiptTypeCode = "STDR"});
            context.SaveChanges();
            var receiptTypes = context.ReceiptTypes.Find(1);
            Assert.AreEqual("STDR", receiptTypes.ReceiptTypeCode);
        }
        [TestMethod]
        public void GetMethod_Should_Return()
        {
            var context = new HCMISEntities();
            context.ReceiptTypes.Add(new ReceiptType() { ID = 1, Name = "StandardReceipt", ReceiptTypeCode = "STDR" });
            context.SaveChanges();
            var lookupService = new LookupKernel(new HCMISEntities(), new SampleBindingManager());
            var standardReceipt = lookupService.From<ReceiptType>().Get(ReceiptTypes.StandardReceipt);
            
            Assert.IsNotNull(standardReceipt);
        }
    }
}
