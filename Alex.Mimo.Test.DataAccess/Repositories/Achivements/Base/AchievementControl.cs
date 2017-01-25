using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.Core;
using Alex.Mimo.Test.DataAccess.Contexts;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base
{
    public abstract class AchievementControl
    {
        protected readonly MimoContext Context;

        protected AchievementControl(MimoContext context)
        {
            this.Context = context;
        }

        public abstract Task<int> GetAchievementProgress(int userId, CancellationToken cancellationToken);

        public abstract Task<bool> IsCompleted(int userId, CancellationToken cancellationToken);

        protected async Task<bool> IsCompleted(int userId, int goal, CancellationToken cancellationToken)
        {
            var progress = await this.GetAchievementProgress(userId, cancellationToken);
            return progress >= goal;
        }
    }
}
