using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using HCMIS.Extensions.Binding;
using HCMIS.Extensions.Enums;
using HCMIS.Extensions.Lookups;
using HCMIS.Extensions.Models;

namespace HCMIS.Extensions.Services
{
    public sealed class LookupService<TType> : ILookupService<TType>
        where TType : class
    {
        #region Fields
        private readonly DbSet<TType> _dbSet;
        private readonly BindingManager _bindingManager;

        #endregion

        #region Constructors

        public LookupService(DbSet<TType> dbSet, BindingManager bindingManager)
        {
            _dbSet = dbSet;
            _bindingManager = bindingManager;
        }

        #endregion

        #region ILookupService Implementation

        public TType Get(IConvertible value)
        {
            // Assert that 'value' is an enum type bound to TType
            if (value.GetType().FullName != _bindingManager.Get<TType>().FullName)
            {
                throw new Exception("Invalid parameter");
            }

            string columnCode = GetColumnCode(value.GetType());
            string tableCode = GetTableCode(value);
            return Query(columnCode, tableCode);
        }

        #endregion

        #region Private Helpers
        private TType Query(string columnCode, string tableCode)
        {
            throw new NotImplementedException();
        }

        private string GetTableCode(IConvertible value)
        {
            throw new NotImplementedException();
        }

        private string GetColumnCode(Type type)
        {
            var attributes = type.GetCustomAttributes(type, false);

            if (attributes.Length > 0)
            {
                attributes.Where()

                if (attribute != null)
                {
                    attributeValue = attribute.Value;
                }
            }
        }
            throw new NotImplementedException();
        }

        #endregion
    }
}
