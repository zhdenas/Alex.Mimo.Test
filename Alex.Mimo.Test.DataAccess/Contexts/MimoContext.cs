using System.Data.Entity;
using Alex.Mimo.Test.DataAccess.Entities;

namespace Alex.Mimo.Test.DataAccess.Contexts
{
    public class MimoContext : DbContext
    {
        static MimoContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MimoContext, Configuration>());
        }

        public MimoContext()
            : base("MimoConnectionString")
        {
        }

        public IDbSet<Achievement> Achievement { get; set; }

        public IDbSet<Chapter> Chapter { get; set; }

        public IDbSet<Course> Course { get; set; }

        public IDbSet<CourseType> CourseType { get; set; }

        public IDbSet<Lesson> Lesson { get; set; }

        public IDbSet<LessonAttempt> LessonAttempt { get; set; }

        public IDbSet<User> User { get; set; }

        public IDbSet<UserAchievement> UserAchievement { get; set; }
    }
}