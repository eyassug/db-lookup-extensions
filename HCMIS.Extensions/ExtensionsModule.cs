using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apex.Common.Data;
using HCMIS.Extensions.Business;
using HCMIS.Extensions.Repository;

namespace HCMIS.Extensions
{
    public class ExtensionsModule : Ninject.Modules.NinjectModule
    {
        #region Constructors
        public ExtensionsModule(string connectionString)
        {
            BusinessRuleEntities.ConnectionString = connectionString;
        }
        #endregion

        #region Load() Method Implementation
        public override void Load()
        {
            Bind<IUnitOfWork>().To<BusinessRuleEntities>();
            Bind<IBusinessRuleWrapper<List<Guid>>>().To<BusinessRuleWrapper>();
        }
        #endregion
    }
}
