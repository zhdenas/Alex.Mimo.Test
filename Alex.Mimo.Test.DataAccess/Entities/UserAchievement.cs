using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class UserAchievement
    {
        public int Id { get; set; }

        [ForeignKey(nameof(UserAchievement.UserId))]
        public virtual User User { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserAchievement.AchievementId))]
        public virtual Achievement Achievement { get; set; }

        public string AchievementId { get; set; }
    }
}