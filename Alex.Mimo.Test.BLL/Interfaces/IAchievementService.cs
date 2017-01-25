using System.Collections.Generic;
using System.Threading.Tasks;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.BLL.Interfaces
{
    public interface IAchievementService
    {
        List<AchievementModel> GetAll(int userId);
        Task<List<AchievementModel>> GetAllAsync(int userId);
    }
}