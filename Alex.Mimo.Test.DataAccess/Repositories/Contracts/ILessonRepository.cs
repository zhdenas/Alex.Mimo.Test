using System;
using System.Threading;
using System.Threading.Tasks;

namespace Alex.Mimo.Test.DataAccess.Repositories.Contracts
{
    public interface ILessonRepository
    {
        Task CompleteLesson(int userId, int lessonId, DateTime started, DateTime finished, CancellationToken cancellationToken);
    }
}