using DAL.UoW;

namespace BLL.PrimaryLogicComponents.Dish
{
    using BLL.Models;
    public class Manager
    {
        private UoW _uow;
        public Manager(UoW uoW)
        {
            _uow = uoW;
        }
        
        public void Add(Dish dish)
        {
            
        }
    }
}