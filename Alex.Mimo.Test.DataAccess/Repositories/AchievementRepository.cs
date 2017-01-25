using System.Collections.Generic;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Entities;
using Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base;
using Alex.Mimo.Test.DataAccess.Repositories.Achivements.Factory;
using Alex.Mimo.Test.DataAccess.Repositories.Contracts;

namespace Alex.Mimo.Test.DataAccess.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {
        private readonly IAchievementControlFactory _achievementControlFactory;
        private readonly MimoContext _context;

        internal AchievementRepository(MimoContext context, IAchievementControlFactory achievementControlFactory)
        {
            this._context = context;
            this._achievementControlFactory = achievementControlFactory;
        }

        public async Task<IList<AchievementModel>> GetAchievements(int userId, CancellationToken cancellationToken)
        {
            var achievements = await this._context.Achievement.ToListAsync(cancellationToken);
            var result = new List<AchievementModel>();
            foreach (var achievement in achievements)
            {
                result.Add(new AchievementModel()
                {
                    Achievement = achievement,
                    IsCompleted = await this.IsAchievementCompleted(userId, achievement, cancellationToken),
                    Progress = await this.GetAchievementProgress(userId, achievement, cancellationToken)
                });
            }
            return result;
        }

        private async Task<bool> IsAchievementCompleted(int userId, Achievement achievement, CancellationToken cancellationToken)
        {
            var achievementControl = this.GetAchievementControl(achievement);
            return await achievementControl.IsCompleted(userId, cancellationToken);
        }

        private async Task<int> GetAchievementProgress(int userId, Achievement achievement, CancellationToken cancellationToken)
        {
            var achievementControl = this.GetAchievementControl(achievement);
            return await achievementControl.GetAchievementProgress(userId, cancellationToken);
        }

        private AchievementControl GetAchievementControl(Achievement achievement)
        {
            var achievementType = achievement.AchievementType;
            return this._achievementControlFactory.Create(achievementType, this._context);
        }
    }
}