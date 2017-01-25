using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Entities;

namespace Alex.Mimo.Test.DataAccess.Repositories.Contracts
{
    public interface ILessonRepository
    {
        Task<IEnumerable<Lesson>> GetCompletedLessons(int userId, CancellationToken cancellationToken);

        Task<IEnumerable<LessonAttempt>> GetLessonAttempts(int userId, int lessonId, CancellationToken cancellationToken);

        Task<IEnumerable<LessonAttempt>> GetFinishedLessonAttempts(int userId, int lessonId,
            CancellationToken cancellationToken);
    }
}