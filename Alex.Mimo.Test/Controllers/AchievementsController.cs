using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Alex.Mimo.Test.BLL.Interfaces;
using Alex.Mimo.Test.Mappers;
using Alex.Mimo.Test.Models;

namespace Alex.Mimo.Test.Controllers
{
    public class AchievementsController : BaseController
    {
        private readonly IAchievementService _achievementService;
        private readonly MimoMapper _mimoMapper;

        public AchievementsController(IAchievementService achievementService, MimoMapper mimoMapper)
        {
            this._achievementService = achievementService;
            this._mimoMapper = mimoMapper;
        }

        [HttpGet]
        // GET: api/Achievements
        public async Task<IHttpActionResult> Get(CancellationToken cancellationToken)
        {
            var achievementsDto = await this._achievementService.GetAllAsync(this.AuthUser.Id, cancellationToken);
            var achievements = this._mimoMapper.Map<List<AchievementModel>>(achievementsDto);
            return this.Ok(achievements);
        }
    }
}