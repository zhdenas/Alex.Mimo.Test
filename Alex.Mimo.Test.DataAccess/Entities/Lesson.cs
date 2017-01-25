using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }

        [ForeignKey(nameof(Lesson.ChapterId))]
        public virtual Chapter Chapter { get; set; }

        public string ChapterId { get; set; }

        public virtual ICollection<LessonSolution> LessonSolutions { get; set; }
    }
}