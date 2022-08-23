using KShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace KShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public int CategoryID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }

        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual IEnumerable ProductCategory { set; get; }

        //public virtual OrderDetail OrderDetail { set; get; }
    }
}