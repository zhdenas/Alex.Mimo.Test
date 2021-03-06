﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.BLL.Contracts
{
    public interface IAchievementService
    {
        List<AchievementModel> GetAll(int userId);
        Task<List<AchievementModel>> GetAllAsync(int userId, CancellationToken cancellationToken);
    }
}