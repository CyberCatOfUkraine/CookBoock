namespace BLL.Models
{
    public class Ingredients:IBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PathToImg { get; set; }
    }
}