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
        private readonly MimoContext _context;
        private readonly IAchievementControlFactory _achievementControlFactory;

        internal AchievementRepository(MimoContext context, IAchievementControlFactory achievementControlFactory)
        {
            this._context = context;
            this._achievementControlFactory = achievementControlFactory;
        }

        public async Task<IList<Achievement>> GetAllAchievements(CancellationToken cancellationToken)
        {
            return await this._context.Achievement.ToListAsync(cancellationToken);
        }

        public async Task<bool> IsAchievementCompleted(int userId, int achievementId, CancellationToken cancellationToken)
        {
            var achievementControl = await this.GetAchievementControl(achievementId, cancellationToken);
            return await achievementControl.IsCompleted(userId, cancellationToken);
        }

        public async Task<int> GetAchievementProgress(int userId, int achievementId, CancellationToken cancellationToken)
        {
            var achievementControl = await this.GetAchievementControl(achievementId, cancellationToken);
            return await achievementControl.GetAchievementProgress(userId, cancellationToken);
        }

        private async Task<AchievementControl> GetAchievementControl(int achievementId, CancellationToken cancellationToken)
        {
            var achievementType = (await this._context.Achievement.FirstOrDefaultAsync(a => a.Id == achievementId, cancellationToken))?.AchievementType;
            if (achievementType != null)
            {
                return this._achievementControlFactory.Create(achievementType.Value, this._context);
            }
            return null;
        }
    }
}
