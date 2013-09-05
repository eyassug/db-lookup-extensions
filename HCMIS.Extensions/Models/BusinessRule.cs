using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HCMIS.Extensions.Models
{
    [Table("BusinessRule", Schema = "BusinessRule")]
    public class BusinessRule
    {
        [Key]
        public string BusinessRuleID { get; set; }
        public string Description { get; set; }
        [Column("Definition", TypeName = "xml")]
        public string DefinitionString { get; set; }

        [NotMapped]
        public XElement Definition { get; set; }
    }
}
