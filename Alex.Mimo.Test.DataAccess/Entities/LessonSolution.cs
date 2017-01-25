using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class LessonSolution
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(LessonId))]
        public virtual Lesson Lesson { get; set; }

        public string LessonId { get; set; }

        public DateTime Started { get; set; }

        public DateTime? Finished { get; set; }
    }
}
