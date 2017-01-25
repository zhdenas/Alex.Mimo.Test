using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Alex.Mimo.Test.BLL.Interfaces;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.Controllers
{
    [Route("api/[controller]")]
    public class AchievementsController : BaseController
    {
        private IAchievementService _achievementService;
        public AchievementsController(IAchievementService achievementService)
        {
            _achievementService = achievementService;
        }
        // GET: api/Achievements
        public IEnumerable<AchievementModel> Get()
        {
            var achievements = _achievementService.GetAll();
            return achievements;
        }
    }
}
