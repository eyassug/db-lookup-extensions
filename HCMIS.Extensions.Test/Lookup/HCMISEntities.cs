using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCMIS.Extensions.Test.Lookup.Models;

namespace HCMIS.Extensions.Test.Lookup
{
    public class HCMISEntities : DbContext
    {
        public HCMISEntities() : base("")
        {
            
        }

        public DbSet<ABC> Abcs { get; set; }
        public DbSet<ReceiptType> ReceiptTypes { get; set; }
    }
}
