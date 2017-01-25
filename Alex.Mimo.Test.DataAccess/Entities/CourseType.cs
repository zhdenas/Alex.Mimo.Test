using System.ComponentModel.DataAnnotations;
using Alex.Mimo.Test.Core;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class CourseType
    {
        [Key]
        public int CourseTypeId { get; set; }

        public string Name { get; set; }

        public CourseTypeEnum Type { get; set; }
    }
}