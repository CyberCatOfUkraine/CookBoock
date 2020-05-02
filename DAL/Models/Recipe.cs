namespace DAL.Models
{
    public class Recipe:IBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CookingTime { get; set; }
        public string PathToImg { get; set; }
    }
}