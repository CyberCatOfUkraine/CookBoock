using System.ComponentModel.DataAnnotations;

namespace PL.Models
{
    public interface IBase
    {
        [Key]
        int Id { get; set; }
        string Name { get; set; }
    }
}