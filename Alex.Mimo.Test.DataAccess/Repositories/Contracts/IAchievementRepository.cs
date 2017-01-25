using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.DataAccess.Entities;

namespace Alex.Mimo.Test.DataAccess.Repositories.Contracts
{
    public interface IAchievementRepository
    {
        Task<IList<AchievementModel>> GetAchievements(int userId, CancellationToken cancellationToken);
    }
}