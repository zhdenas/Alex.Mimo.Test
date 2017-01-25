using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Contexts;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base
{
    internal abstract class LessonsAchievementControl : AchievementControl
    {
        protected LessonsAchievementControl(MimoContext context)
            : base(context)
        {
        }

        public override async Task<int> GetAchievementProgress(int userId, CancellationToken cancellationToken)
        {
            return
                await
                    this.Context.LessonAttempt.CountAsync(
                        attempt => attempt.UserId == userId && attempt.Finished != null,
                        cancellationToken);
        }
    }
}