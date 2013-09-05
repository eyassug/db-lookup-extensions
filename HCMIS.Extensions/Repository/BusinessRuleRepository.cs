using Apex.Common.Data;
using HCMIS.Extensions.Models;
using Ninject;

namespace HCMIS.Extensions.Repository
{
    class BusinessRuleRepository : GenericRepository<BusinessRuleEntities,BusinessRule>
    {
        public BusinessRuleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
