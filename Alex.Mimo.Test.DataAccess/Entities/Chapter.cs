using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class Chapter
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }

        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }

        public string CourseId { get; set; }
    }
}
