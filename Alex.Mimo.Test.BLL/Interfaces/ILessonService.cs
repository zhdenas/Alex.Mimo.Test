using System.Threading.Tasks;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.BLL.Interfaces
{
    public interface ILessonService
    {
        void SetCompleted(LessonModel lesson);
        Task SetCompletedAsync(LessonModel lesson);
    }
}