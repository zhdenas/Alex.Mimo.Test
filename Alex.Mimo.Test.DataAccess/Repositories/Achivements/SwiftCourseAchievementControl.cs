﻿using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.Core;
using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements
{
    internal class SwiftCourseAchievementControl : CourseAchievementControl
    {
        public SwiftCourseAchievementControl(MimoContext context)
            : base(context)
        {
        }

        public override Task<int> GetAchievementProgress(int userId, CancellationToken cancellationToken)
        {
            return base.GetAchievementProgress(userId, CourseTypeEnum.Swift, cancellationToken);
        }

        public override Task<bool> IsCompleted(int userId, CancellationToken cancellationToken)
        {
            return this.IsCompleted(userId, 1, cancellationToken);
        }
    }
}