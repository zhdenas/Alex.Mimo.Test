using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class UserAchievement
    {
        public int Id { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(AchievementId))]
        public virtual Achievement Achievement { get; set; }

        public string AchievementId { get; set; }
    }
}
