using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [ForeignKey(nameof(Course.CourseTypeId))]
        public virtual CourseType CourseType { get; set; }

        public int CourseTypeId { get; set; }

        public virtual ICollection<Chapter> Chapters { get; set; }
    }
}