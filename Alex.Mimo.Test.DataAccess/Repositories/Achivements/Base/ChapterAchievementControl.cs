using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Contexts;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base
{
    internal abstract class ChapterAchievementControl : AchievementControl
    {
        protected ChapterAchievementControl(MimoContext context)
            : base(context)
        {
        }

        public override async Task<int> GetAchievementProgress(int userId, CancellationToken cancellationToken)
        {
            return
                await
                    this.Context.Chapter.CountAsync(
                        chapter =>
                            chapter.Lessons.All(
                                lesson =>
                                    lesson.LessonAttempts.Any(
                                        attempt => attempt.Finished != null && attempt.UserId == userId)),
                        cancellationToken);
        }
    }
}