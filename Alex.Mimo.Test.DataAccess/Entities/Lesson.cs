using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }

        public int Order { get; set; }

        [ForeignKey(nameof(Lesson.ChapterId))]
        public virtual Chapter Chapter { get; set; }

        public int ChapterId { get; set; }

        public virtual ICollection<LessonAttempt> LessonAttempts { get; set; }
    }
}