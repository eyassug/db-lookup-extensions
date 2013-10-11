using System;
using System.Collections.Generic;
using HCMIS.Extensions.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace HCMIS.Extensions.Test
{
    public class BusinessRuleWrapperTest
    {
        static IKernel _kernel;

        #region Constructors
        public BusinessRuleWrapperTest()
        {
            _kernel =
                new StandardKernel(
                    new ExtensionsModule("Data Source=192.168.2.58;Initial Catalog=DEV_HCMISW;UID=sa;PWD=passpass4;"));
        }
        #endregion

        [TestMethod]
        public void WrapperTest()
        {
            Assert.IsNotNull(_kernel);
            var wrapper = _kernel.Get<IBusinessRuleWrapper<List<Guid>>>();
            Assert.IsNotNull(wrapper);
        }

        [TestMethod]
        public void WrapperDataTest()
        {
            var wrapper = _kernel.Get<IBusinessRuleWrapper<List<Guid>>>();
            try
            {
                var list = wrapper.Get("BR-001");
                Assert.IsNotNull(list);
                Assert.AreEqual(2,list.Count);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.GetType().Name,"ObjectNotFoundException");
                Assert.AreEqual(ex.Message, "The specified business rule doesn't exist in the database.");
            }
        }
    }
}
