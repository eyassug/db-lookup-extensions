using System;

namespace HCMIS.Extensions.Services
{
    public interface ILookupKernel
    {
        //TType Get<TType, TEnum>(TEnum value) where TType : class where TEnum : struct, IComparable, IConvertible;
        ILookupService<TType> From<TType>() where TType : class;
    }
}
