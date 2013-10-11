using System;
using System.Linq;
using System.Collections.Generic;

namespace HCMIS.Extensions.Binding
{
    public abstract class BindingManager
    {
        #region Dictionary
        protected static Dictionary<Type, Type> _bindings;

        #endregion

        #region Methods
        public abstract void Load();

        protected BindType<TModelType> Bind<TModelType>() where TModelType : class
        {
            return new BindType<TModelType>(this);
        }

        public Type Get<TType>()
        {
            return Bindings.SingleOrDefault(m => m.Key == typeof (TType)).Value;
        }
        #endregion

        #region Properties
        public Dictionary<Type,Type> Bindings
        {
            get { return _bindings ?? (_bindings = new Dictionary<Type, Type>()); }
        }
        #endregion
    }
}
