using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMIS.Extensions.Attributes
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    public class CodeColumnAttribute : Attribute
    {
        private readonly string _codeColumn;

        public CodeColumnAttribute(string codeColumn)
        {
            _codeColumn = codeColumn;
        }

        public string CodeColumn
        {
            get { return _codeColumn; }
        }
    }
}
