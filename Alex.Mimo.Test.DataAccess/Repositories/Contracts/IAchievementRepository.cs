using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Entities;

namespace Alex.Mimo.Test.DataAccess.Repositories.Contracts
{
    public interface IAchievementRepository
    {
        Task<IList<Achievement>> GetAllAchievements(CancellationToken cancellationToken);

        Task<bool> IsAchievementCompleted(int userId, int achievementId, CancellationToken cancellationToken);

        Task<int> GetAchievementProgress(int userId, int achievementId, CancellationToken cancellationToken);
    }
}