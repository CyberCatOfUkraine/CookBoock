using System.ComponentModel.DataAnnotations;

namespace PL.Models
{
    public class Ingredients:IBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; } 
    }
}