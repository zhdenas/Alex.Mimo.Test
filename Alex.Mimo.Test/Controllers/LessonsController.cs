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
            this._lessonService = lessonService;
        }
        // POST: api/Lessons
        public IHttpActionResult Post(LessonModel lesson)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            lesson.UserId = this.AuthUser.Id;
            this._lessonService.Add(lesson);
            return this.Ok();
        }
    }
}