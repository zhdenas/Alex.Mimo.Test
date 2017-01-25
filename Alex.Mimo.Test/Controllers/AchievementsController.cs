using System.Threading.Tasks;
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
        [HttpGet]
        // GET: api/Achievements
        public async Task<IHttpActionResult> Get()
        {
            var achievements = await this._achievementService.GetAllAsync(this.AuthUser.Id);
            return this.Ok(achievements);
        }
    }
}