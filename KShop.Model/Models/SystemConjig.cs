using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConjig
    {
        [Key]
        public int ID { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string Code { set; get; }

        [MaxLength(50)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}