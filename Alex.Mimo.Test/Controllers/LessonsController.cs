using System.Collections.Generic;
using System.Web.Http;
using Alex.Mimo.Test.BLL.Interfaces;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.Controllers
{
    [Route("api/[controller]")]
    public class LessonsController : BaseController
    {
        private readonly ILessonService _lessonService;
        public LessonsController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        // POST: api/Lessons
        public bool Post(LessonModel lesson)
        {
            var addResult = _lessonService.Add(lesson);
            return addResult;
        }
    }
}