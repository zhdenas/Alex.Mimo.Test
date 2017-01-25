using System.ComponentModel.DataAnnotations;
using System.Data;
using Alex.Mimo.Test.Core;
using System.ComponentModel.DataAnnotations.Schema;

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
