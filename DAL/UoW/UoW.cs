using DAL.Models;
using DAL.Repository;
namespace DAL.UoW
{
    public class UoW
    {
        public Repository<Dish> GetDishRepo=new Repository<Dish>();
        public Repository<Ingredients> GetIngredientsRepo=new Repository<Ingredients>();
        public Repository<Recipe> GetRecipeRepo=new Repository<Recipe>();
    }
}