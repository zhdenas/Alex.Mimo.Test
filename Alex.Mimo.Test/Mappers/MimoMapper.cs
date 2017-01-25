using Alex.Mimo.Test.Models;
using AutoMapper;
using CheckLessonModel = Alex.Mimo.Test.Models.CheckLessonModel;

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
                cfg.CreateMap<BLL.Models.AchievementModel, AchievementModel>();

            });

            mapperConfiguration.AssertConfigurationIsValid();

            var mapper = new AutoMapper.Mapper(mapperConfiguration);
            return mapper;
        }

        public TDestination Map<TDestination>(object source)
        {
            return this._mapper.Map<TDestination>(source);
        }
    }
}
