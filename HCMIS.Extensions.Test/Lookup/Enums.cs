using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCMIS.Extensions.Attributes;

namespace HCMIS.Extensions.Test.Lookup.Enums
{
    [CodeColumn("ABCCode")]
    enum ABCTypes
    {
        [TableCode("E0F19")]
        A,
        [TableCode("8C5BF")]
        B,
        [TableCode("F5C2B")]
        C
    }
}
