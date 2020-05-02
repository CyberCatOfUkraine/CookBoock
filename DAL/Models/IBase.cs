using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public interface IBase
    {
        [Key]
        int Id { get; set; }
        string Name { get; set; }
    }
}