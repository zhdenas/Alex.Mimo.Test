using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Alex.Mimo.Test.Core;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class Achievement
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        [Index(IsUnique = true)]
        public AchievementType AchievementType { get; set; }
    }
}