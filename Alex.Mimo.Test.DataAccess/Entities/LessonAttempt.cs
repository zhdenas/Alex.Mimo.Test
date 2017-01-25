using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class LessonAttempt
    {
        [Key]
        public int LessonAttemptId { get; set; }

        [ForeignKey(nameof(LessonAttempt.UserId))]
        public virtual User User { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(LessonAttempt.LessonId))]
        public virtual Lesson Lesson { get; set; }

        public int LessonId { get; set; }

        public DateTime Started { get; set; }

        public DateTime? Finished { get; set; }
    }
}