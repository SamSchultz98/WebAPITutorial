using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPITutorial.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName ="Decimal(11,2)")]
        public decimal Price { get; set; }

        public virtual IEnumerable<OrderLine> OrderLines { get; set; }
    }
}
