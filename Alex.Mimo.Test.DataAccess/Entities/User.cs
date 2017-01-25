using System.Collections.Generic;

namespace Alex.Mimo.Test.DataAccess.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public virtual ICollection<LessonAttempt> LessonAttempts { get; set; }
    }
}