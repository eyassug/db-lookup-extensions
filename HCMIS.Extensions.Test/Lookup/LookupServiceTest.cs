using System;
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
        public void TestMethod1()
        {
            var lookupService = new LookupKernel(new HCMISEntities(), new SampleBindingManager());
            var standardReceipt = lookupService.From<ReceiptType>().Get(ReceiptTypes.StandardReceipt);
            Assert.IsNotNull(standardReceipt);
        }
    }
}
