using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class UserAchievement
    {
        public int UserAchievementId { get; set; }

        [ForeignKey(nameof(UserAchievement.UserId))]
        public virtual User User { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(UserAchievement.AchievementId))]
        public virtual Achievement Achievement { get; set; }

        public int AchievementId { get; set; }
    }
}