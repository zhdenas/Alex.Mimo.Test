using System.ComponentModel.DataAnnotations;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class CourseType
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }
    }
}
