using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.BLL.Interfaces
{
    internal interface ILessonService
    {
        bool Add(LessonModel lesson);
    }
}