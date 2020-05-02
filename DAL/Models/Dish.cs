namespace DAL.Models
{
    public class Dish:IBase
    {
        public int Id { get; set; }
        public string PathToImg { get; set; }
        public string Name { get; set; }
        public virtual Recipe Recipe { get; set; }
        
        
    }
}