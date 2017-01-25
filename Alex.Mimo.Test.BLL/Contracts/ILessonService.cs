using System.Threading.Tasks;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.BLL.Contracts
{
    public interface ILessonService
    {
        void SetCompleted(CheckLessonModel checkLesson);
        Task SetCompletedAsync(CheckLessonModel checkLesson);
    }
}