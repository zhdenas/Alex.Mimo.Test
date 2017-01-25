using Alex.Mimo.Test.Core;
using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Repositories.Achivements.Base;

namespace Alex.Mimo.Test.DataAccess.Repositories.Achivements.Factory
{
    public class AchievementControlFactory : IAchievementControlFactory
    {
        public AchievementControl Create(AchievementTypeEnum type, MimoContext context)
        {
            AchievementControl result = null;
            switch (type)
            {
                case AchievementTypeEnum.CSharpCourse:
                    result = new CSharpCourseAchievementControl(context);
                    break;
                case AchievementTypeEnum.SwiftCourse:
                    result = new SwiftCourseAchievementControl(context);
                    break;
                case AchievementTypeEnum.JavascriptCourse:
                    result = new JavascriptCourseAchievementControl(context);
                    break;
                case AchievementTypeEnum.FiveLessons:
                    result = new FiveLessonsAchievementControl(context);
                    break;
                case AchievementTypeEnum.TwentyFiveLessons:
                    result = new TwentyFiveLessonsAchievementControl(context);
                    break;
                case AchievementTypeEnum.FiftyLessons:
                    result = new FiftyLessonsAchievementControl(context);
                    break;
                case AchievementTypeEnum.OneChapter:
                    result = new OneChapterAchievementControl(context);
                    break;
                case AchievementTypeEnum.FiveChapters:
                    result = new FiveChaptersAchievementControl(context);
                    break;
                    
            }
            return result;
        }
    }
}
