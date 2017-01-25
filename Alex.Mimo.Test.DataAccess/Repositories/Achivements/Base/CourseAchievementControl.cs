using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.Core;
using Alex.Mimo.Test.DataAccess.Contexts;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base
{
    internal abstract class CourseAchievementControl : AchievementControl
    {
        protected CourseAchievementControl(MimoContext context)
            : base(context)
        {
        }

        public async Task<int> GetAchievementProgress(int userId, CourseTypeEnum courseType,
            CancellationToken cancellationToken)
        {
            return
                await
                    this.Context.Course.CountAsync(
                        course =>
                            course.CourseType.Type == courseType &&
                            course.Chapters.All(chapter => chapter.Lessons.All(lesson =>
                                lesson.LessonAttempts.Any(
                                    attempt => attempt.Finished != null && attempt.UserId == userId))),
                        cancellationToken);
        }
    }
}