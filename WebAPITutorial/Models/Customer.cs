using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPITutorial.Models
{
    [Index("Code", IsUnique = true)]    //Need this code in order to mark a column as unique
    public class Customer
    {
        [Key]
        public int Id { get; set; }         //PK

        [StringLength(140)]
        public string Name { get; set; }

        [StringLength(4)]
        public string Code { get; set; }

        [Column(TypeName ="Decimal (11,2)")]    //This will line up what type of data this prop has
        public decimal Sales { get; set; }

        [StringLength(255)]
        public string? Notes { get; set; }

    }
}
