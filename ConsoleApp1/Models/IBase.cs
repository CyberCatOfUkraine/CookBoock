using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models
{
    public interface IBase
    {
        [Key]
        int Id { get; set; }
        string Name { get; set; }
    }
}