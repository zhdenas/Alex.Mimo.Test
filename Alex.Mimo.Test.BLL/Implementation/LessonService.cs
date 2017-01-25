using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.BLL.Interfaces;
using Alex.Mimo.Test.BLL.Models;
using Alex.Mimo.Test.DataAccess.Repositories.Contracts;

namespace Alex.Mimo.Test.BLL.Implementation
{
    public class LessonService:ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lessonRepository)
        {
            this._lessonRepository = lessonRepository;
        }

        public void SetCompleted(CheckLessonModel checkLesson)
        {
            throw new System.NotImplementedException();
        }

        public async Task SetCompletedAsync(CheckLessonModel checkLesson, CancellationToken cancellationToken)
        {
            await this._lessonRepository.CompleteLesson(checkLesson.UserId, checkLesson.Id, checkLesson.StartedDate,
                checkLesson.FinishedDate, cancellationToken);
        }
    }
}