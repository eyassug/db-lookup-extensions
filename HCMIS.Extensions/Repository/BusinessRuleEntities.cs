using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apex.Common.Data;
using HCMIS.Extensions.Models;

namespace HCMIS.Extensions.Repository
{
    class BusinessRuleEntities : DbContext, IUnitOfWork
    {
        #region Constructors
        public BusinessRuleEntities()
            :base(ConnectionString)
        {

        }

        public BusinessRuleEntities(string connectionString)
            :base(connectionString)
        {
            
        }
        #endregion

        #region Db Sets
        public DbSet<BusinessRule> BusinessRules { get; set; }
        #endregion

        #region IUnitOfWork Implementation
        public void CommitChanges()
        {
            SaveChanges();
        }

        #endregion

        #region Static Members

        public static string ConnectionString { get; set; }

        #endregion

    }
}
