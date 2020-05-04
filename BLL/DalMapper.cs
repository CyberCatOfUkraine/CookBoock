using AutoMapper;

namespace BLL
{
    public static class DalMapper
    {
        private static MapperConfiguration _configuration;
        static DalMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DAL.Models.Dish, Models.Dish>().ReverseMap();
                cfg.CreateMap<DAL.Models.Ingredients, Models.Ingredients>().ReverseMap();
                cfg.CreateMap<DAL.Models.IBase, Models.IBase>().ReverseMap();
                cfg.CreateMap<DAL.Models.Recipe, Models.Recipe>().ReverseMap();
                
            });
            _configuration = config;
        }

        public static Mapper Mapper => new Mapper(_configuration);
    }
}