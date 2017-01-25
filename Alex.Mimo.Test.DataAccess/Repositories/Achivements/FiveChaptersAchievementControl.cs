﻿using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.Core;
using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements
{
    internal class FiveChaptersAchievementControl : ChapterAchievementControl
    {
        public FiveChaptersAchievementControl(MimoContext context) 
            : base(context)
        {            
        }

        public override Task<bool> IsCompleted(int userId, CancellationToken cancellationToken)
        {
            return base.IsCompleted(userId, 5, cancellationToken);
        }
    }
}