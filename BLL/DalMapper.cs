using AutoMapper;

namespace BLL
{
    public  class DalMapper
    {
        public DalMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DAL.Models.Dish, BLL.Models.Dish>().ReverseMap();
                cfg.CreateMap<DAL.Models.Ingredients, Models.Ingredients>().ReverseMap();
                cfg.CreateMap<DAL.Models.IBase, Models.IBase>().ReverseMap();
                cfg.CreateMap<DAL.Models.Recipe, Models.Recipe>().ReverseMap();
                
            });
            MapperConfiguration = config;
        }

        public MapperConfiguration MapperConfiguration { get; set; }
    }
}