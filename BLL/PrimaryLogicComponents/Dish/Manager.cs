using AutoMapper;
using DAL.UoW;

namespace BLL.PrimaryLogicComponents.Dish
{
    using BLL.Models;
    public class Manager
    {
        private UoW _uow;
        private Mapper _mapper;
        public Manager(UoW uoW)
        {
            _uow = uoW;
            var config = new DalMapper().MapperConfiguration;
            _mapper=new Mapper(config);
        }
        
        public void Add(Dish dish)
        {
           _uow.GetDishRepo.Add(_mapper.Map<DAL.Models.Dish>(dish));
        }
        public void
    }
}