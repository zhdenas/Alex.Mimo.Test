using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Repositories;
using Alex.Mimo.Test.DataAccess.Repositories.Achivements.Factory;
using Alex.Mimo.Test.DataAccess.Repositories.Contracts;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Alex.Mimo.Test.Ninject
{
    public class DataAccessModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAchievementRepository>().To<AchievementRepository>().InRequestScope();
            this.Bind<ILessonRepository>().To<LessonRepository>().InRequestScope();
            this.Bind<MimoContext>().To<MimoContext>().InRequestScope();
            this.Bind<IAchievementControlFactory>().To<AchievementControlFactory>().InSingletonScope();
        }
    }
}