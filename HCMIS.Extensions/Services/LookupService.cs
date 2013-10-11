using System;
using System.Linq;
using System.Data.Entity;
using HCMIS.Extensions.Attributes;
using HCMIS.Extensions.Binding;

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
            var entity = _dbSet.SingleOrDefault(m => m.GetType().GetProperty(columnCode).GetValue(m, null).ToString() == tableCode);
            return entity;
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
                var attribute = attributes.Single(m => m.GetType().IsEquivalentTo(typeof (CodeColumnAttribute)));
                return attribute.GetType().GetProperty("CodeColumn").GetValue(attribute, null).ToString();
            }
            return (typeof (TType).Name + "Code");
        }

        #endregion


    }
}
