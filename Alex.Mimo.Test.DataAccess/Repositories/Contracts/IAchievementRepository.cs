using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Entities;

namespace Alex.Mimo.Test.DataAccess.Repositories.Contracts
{
    public interface IAchievementRepository
    {
        Task<IEnumerable<Achievement>> GetAllAchievements(CancellationToken cancellationToken);

        Task<bool> IsAchievementCompleted(int achievementId, CancellationToken cancellationToken);

        Task<int> GetAchievementProgress(int achievementId, CancellationToken cancellationToken);
    }
}