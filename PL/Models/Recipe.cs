using System.Collections.Generic;

namespace PL.Models
{
    public class Recipe:IBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CookingTime { get; set; }
        public string Description { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        
    }
}