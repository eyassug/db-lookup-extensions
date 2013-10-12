using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCMIS.Extensions.Test.Lookup.Models;

namespace HCMIS.Extensions.Test.Lookup
{
    public class HCMISEntities : DbContext
    {
        public HCMISEntities()
            : base(new SqlCeConnection("Data Source=TestDb.sdf;Persist Security Info=False;"),true)
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<HCMISEntities>());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ABC> Abcs { get; set; }
        public DbSet<ReceiptType> ReceiptTypes { get; set; }
    }
}
