using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Alex.Mimo.Test.BLL.Contracts;
using Alex.Mimo.Test.Mappers;
using Alex.Mimo.Test.Models;

namespace Alex.Mimo.Test.Controllers
{
    public class LessonsController : BaseController
    {
        private readonly ILessonService _lessonService;
        private readonly MimoMapper _mimoMapper;

        public LessonsController(ILessonService lessonService, MimoMapper mimoMapper)
        {
            this._lessonService = lessonService;
            this._mimoMapper = mimoMapper;
        }

        // POST: api/Lessons
        [HttpPost]
        public async Task<IHttpActionResult> Post(CheckLessonModel checkLesson, CancellationToken cancellationToken)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            var checkLessonDto = this._mimoMapper.Map<BLL.Models.CheckLessonModel>(checkLesson);
            checkLessonDto.UserId = this.AuthUser.Id;
            await this._lessonService.SetCompletedAsync(checkLessonDto, cancellationToken);
            return this.Ok(checkLesson.Id);
        }
    }
}