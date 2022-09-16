using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPITutorial.Models
{
    public class OrderLine
    {
        public int Id { get; set; }


        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }


        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }


        [Column(TypeName ="Decimal(11,2)")]
        public decimal Price { get; set; }


    }
}
