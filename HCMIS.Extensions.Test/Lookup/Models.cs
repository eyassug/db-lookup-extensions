using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCMIS.Extensions.Test.Lookup.Models
{
    [Table("ABC")]
    public class ABC
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ABCCode { get; set; }
    }

    [Table("ReceiptType")]
    public class ReceiptType
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ReceiptTypeCode { get; set; }
    }
}
