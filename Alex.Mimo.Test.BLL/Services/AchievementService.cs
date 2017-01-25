using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.BLL.Contracts;
using Alex.Mimo.Test.BLL.Models;
using Alex.Mimo.Test.DataAccess.Repositories.Contracts;

namespace Alex.Mimo.Test.BLL.Services
{
    public class AchievementService : IAchievementService
    {
        private readonly IAchievementRepository _achievementRepository;

        public AchievementService(IAchievementRepository achievementRepository)
        {
            this._achievementRepository = achievementRepository;
        }

        public List<AchievementModel> GetAll(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AchievementModel>> GetAllAsync(int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}