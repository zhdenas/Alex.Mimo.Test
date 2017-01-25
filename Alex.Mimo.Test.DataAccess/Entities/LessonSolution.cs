using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class LessonSolution
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(LessonSolution.UserId))]
        public virtual User User { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(LessonSolution.LessonId))]
        public virtual Lesson Lesson { get; set; }

        public string LessonId { get; set; }

        public DateTime Started { get; set; }

        public DateTime? Finished { get; set; }
    }
}