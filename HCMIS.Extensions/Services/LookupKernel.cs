using System;
using System.Data.Entity;
using HCMIS.Extensions.Binding;

namespace HCMIS.Extensions.Services
{
    public class LookupKernel : ILookupKernel
    {
        #region Fields
        private static DbContext _dbContext;
        private readonly BindingManager _bindingManager;
        #endregion

        #region Constructors
        public LookupKernel(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public LookupKernel(DbContext dbContext, BindingManager bindingManager) : this(dbContext)
        {
            _bindingManager = bindingManager;
            _bindingManager.Load(); // Load Bindings
        }

        #endregion
        
        #region ILookup Kernel Implementation
        public ILookupService<TType> From<TType>() where TType : class
        {
            if(_bindingManager.Get<TType>() == null)
                throw new Exception();
            var dbSet = _dbContext.Set<TType>();
            return new LookupService<TType>(dbSet,_bindingManager);
        }
        #endregion
    }
}
