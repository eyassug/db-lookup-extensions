﻿using System;

namespace HCMIS.Extensions.Services
{
    public interface ILookupService<TType> where TType : class
    {
        TType Get(IConvertible value);
    }
}
