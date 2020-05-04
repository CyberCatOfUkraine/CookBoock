using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DAL.Models
{
    public class Ingredients:IBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; } 
    }
}