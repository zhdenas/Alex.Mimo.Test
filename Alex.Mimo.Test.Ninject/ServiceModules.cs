
using Alex.Mimo.Test.BLL.Implementation;
using Alex.Mimo.Test.BLL.Interfaces;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Alex.Mimo.Test.Ninject
{
    public class ServiceModules : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAchievementService>().To<AchievementService>().InRequestScope();
            this.Bind<ILessonService>().To<LessonService>().InRequestScope();
            this.Bind<IFakeDataService>().To<FakeDataService>().InRequestScope();
        }
    }
}
