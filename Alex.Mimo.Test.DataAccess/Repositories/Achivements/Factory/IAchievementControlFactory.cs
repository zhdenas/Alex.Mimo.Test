using Alex.Mimo.Test.Core;
using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements.Factory
{
    internal interface IAchievementControlFactory
    {
        AchievementControl Create(AchievementTypeEnum type, MimoContext context);
    }
}