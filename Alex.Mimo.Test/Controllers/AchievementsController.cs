using System.Web.Http;
using Alex.Mimo.Test.BLL.Interfaces;

namespace Alex.Mimo.Test.Controllers
{
    [Route("api/[controller]")]
    public class AchievementsController : BaseController
    {
        private readonly IAchievementService _achievementService;

        public AchievementsController(IAchievementService achievementService)
        {
            this._achievementService = achievementService;
        }

        // GET: api/Achievements
        public IHttpActionResult Get()
        {
            var achievements = this._achievementService.GetAll(this.AuthUser.Id);
            return this.Ok(achievements);
        }
    }
}