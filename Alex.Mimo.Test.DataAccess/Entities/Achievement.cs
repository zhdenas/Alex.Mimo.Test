using System.ComponentModel.DataAnnotations;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class Achievement
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
