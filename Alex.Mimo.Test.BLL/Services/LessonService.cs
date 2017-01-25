using System;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.BLL.Contracts;
using Alex.Mimo.Test.BLL.Models;
using Alex.Mimo.Test.DataAccess.Repositories.Contracts;

namespace Alex.Mimo.Test.BLL.Services
{
    public class LessonService : ILessonService
    {
        private ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
        {
            this._lessonRepository = lessonRepository;
        }

        public void SetCompleted(CheckLessonModel checkLesson)
        {
            throw new NotImplementedException();
        }

        public async Task SetCompletedAsync(CheckLessonModel checkLesson, CancellationToken cancellationToken)
        {
            await this._lessonRepository.CompleteLesson(checkLesson.UserId, checkLesson.Id, checkLesson.StartedDate,
                checkLesson.FinishedDate, cancellationToken);
        }
    }
}