using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCMIS.Extensions.Binding;
using HCMIS.Extensions.Test.Lookup.Enums;
using HCMIS.Extensions.Test.Lookup.Models;

namespace HCMIS.Extensions.Test.Lookup
{
    class SampleBindingManager : BindingManager
    {

        public override void Load()
        {
            Bind<ABC>().To<ABCTypes>();
        }
    }
}
