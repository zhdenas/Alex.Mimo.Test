using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.BLL.Interfaces
{
    public interface ILessonService
    {
        void SetCompleted(CheckLessonModel checkLesson);
        Task SetCompletedAsync(CheckLessonModel checkLesson, CancellationToken cancellationToken);
    }
}