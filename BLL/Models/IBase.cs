using System.ComponentModel.DataAnnotations;

namespace BLL.Models
{
    public interface IBase
    {
        [Key]
        int Id { get; set; }
        string Name { get; set; }
    }
}