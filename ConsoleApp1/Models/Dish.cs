using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models
{
    public class Dish:IBase
    {
        [Key]
        public int Id { get; set; }
        public string? PathToImg { get; set; }
        public string Name { get; set; }
        public virtual Recipe Recipe { get; set; }
        public string Type { get; set; }
        
    }
}