using Alex.Mimo.Test.BLL.Contracts;
using Alex.Mimo.Test.BLL.Services;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Alex.Mimo.Test.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAchievementService>().To<AchievementService>().InRequestScope();
            this.Bind<ILessonService>().To<LessonService>().InRequestScope();
            this.Bind<IFakeDataService>().To<FakeDataService>().InRequestScope();
        }
    }
}