using DAL.Models;
using DAL.Repository;

namespace DAL.UoW
{
    public interface IUoW
    {
        IRepository<Dish> GetDishRepo();
        IRepository<Ingredients> GetIngredientsRepository();
        IRepository<Recipe> GetRecipeRepository();
    }
}