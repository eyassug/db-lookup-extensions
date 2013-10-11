using System;

namespace HCMIS.Extensions.Attributes
{
    [AttributeUsage(AttributeTargets.Enum,AllowMultiple = false)]
    public class ModelClassAttribute : Attribute
    {
        private readonly Type _modelClass;

        public ModelClassAttribute(Type modelClass)
        {
            _modelClass = modelClass;
        }

        public Type ModelClass
        {
            get { return _modelClass; }
        }
    }
}
