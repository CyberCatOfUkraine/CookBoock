namespace BLL.Models
{
    public interface IBase
    {
        int Id { get; set; }
        string Name { get; set; }
        string PathToImg { get; set; }
    }
}