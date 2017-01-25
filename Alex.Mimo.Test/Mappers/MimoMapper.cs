using Alex.Mimo.Test.Models;
using AutoMapper;
using AchievementModel = Alex.Mimo.Test.BLL.Models.AchievementModel;

namespace Alex.Mimo.Test.Mappers
{
    public class MimoMapper
    {
        private readonly IMapper _mapper;

        public MimoMapper()
        {
            this._mapper = this.InitializeMapper();
        }

        private IMapper InitializeMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CheckLessonModel, BLL.Models.CheckLessonModel>();
                cfg.CreateMap<AchievementModel, Models.AchievementModel>();
            });

            mapperConfiguration.AssertConfigurationIsValid();

            var mapper = new Mapper(mapperConfiguration);
            return mapper;
        }

        public TDestination Map<TDestination>(object source)
        {
            return this._mapper.Map<TDestination>(source);
        }
    }
}