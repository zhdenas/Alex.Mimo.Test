using System;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Entities;
using Alex.Mimo.Test.DataAccess.Repositories.Contracts;

namespace Alex.Mimo.Test.DataAccess.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly MimoContext _context;

        internal LessonRepository(MimoContext context)
        {
            this._context = context;
        }

        public async Task CompleteLesson(int userId, int lessonId, DateTime started, DateTime finished,
            CancellationToken cancellationToken)
        {
            this._context.LessonAttempt.Add(new LessonAttempt
            {
                UserId = userId,
                LessonId = lessonId,
                Started = started,
                Finished = finished
            });
            await this._context.SaveChangesAsync(cancellationToken);
        }
    }
}