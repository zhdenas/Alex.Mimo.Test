using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements
{
    internal class FiftyLessonsAchievementControl : LessonsAchievementControl
    {
        internal FiftyLessonsAchievementControl(MimoContext context)
            : base(context)
        {
        }

        public override Task<bool> IsCompleted(int userId, CancellationToken cancellationToken)
        {
            return base.IsCompleted(userId, 50, cancellationToken);
        }
    }
}