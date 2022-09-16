using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPITutorial.Models
{
    
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "Decimal (11,2)")]
        public int Total { get; set; }

        [StringLength(10)]
        public string Status { get; set; }


        public DateTime Date { get; set; }

        
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }          //MUST ADD THE PUBLIC VIRTUAL AND INSTANCE TO MAKE FOREIGN KEY




    }
}
