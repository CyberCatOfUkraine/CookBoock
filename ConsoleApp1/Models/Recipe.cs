using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models
{
    public class Recipe:IBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CookingTime { get; set; }
        public string Description { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        
    }
}