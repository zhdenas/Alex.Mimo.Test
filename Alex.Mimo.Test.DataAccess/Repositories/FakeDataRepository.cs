﻿using System;
using System.Collections.Generic;
using System.Linq;
using Alex.Mimo.Test.Core;
using Alex.Mimo.Test.DataAccess.Contexts;
using Alex.Mimo.Test.DataAccess.Entities;

namespace Alex.Mimo.Test.DataAccess.Repositories
{
    public static class FakeDataRepository
    {
        public static void FillData()
        {
            var context = new MimoContext();
            if (!context.User.Any())
            {
                context.User.Add(new User
                {
                    UserId = 1
                });
                context.SaveChanges();
            }
            if (!context.Course.Any())
            {
                context.Course.Add(new Course
                {
                    CourseType = new CourseType
                    {
                        Name = "Javascript",
                        Type = CourseTypeEnum.Javascript
                    },
                    Chapters = new List<Chapter>
                    {
                        new Chapter
                        {
                            Order = 1,
                            Lessons = new List<Lesson>
                            {
                                new Lesson
                                {
                                    Order = 1,
                                    LessonAttempts = new List<LessonAttempt>
                                    {
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1)
                                        }
                                    }
                                },
                                new Lesson
                                {
                                    Order = 2,
                                    LessonAttempts = new List<LessonAttempt>
                                    {
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1)
                                        },
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1),
                                            Finished = new DateTime(2010, 1, 2)
                                        }
                                    }
                                },
                                new Lesson
                                {
                                    Order = 3,
                                    LessonAttempts = new List<LessonAttempt>
                                    {
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1),
                                            Finished = new DateTime(2010, 1, 2)
                                        }
                                    }
                                }
                            }
                        },
                        new Chapter
                        {
                            Order = 2,
                            Lessons = new List<Lesson>
                            {
                                new Lesson
                                {
                                    Order = 1,
                                    LessonAttempts = new List<LessonAttempt>
                                    {
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1)
                                        }
                                    }
                                },
                                new Lesson
                                {
                                    Order = 2,
                                    LessonAttempts = new List<LessonAttempt>
                                    {
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1)
                                        },
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1),
                                            Finished = new DateTime(2010, 1, 2)
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
                context.Course.Add(new Course
                {
                    CourseType = new CourseType
                    {
                        Name = "Swift",
                        Type = CourseTypeEnum.Swift
                    },
                    Chapters = new List<Chapter>
                    {
                        new Chapter
                        {
                            Order = 1,
                            Lessons = new List<Lesson>
                            {
                                new Lesson
                                {
                                    Order = 1,
                                    LessonAttempts = new List<LessonAttempt>
                                    {
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1)
                                        }
                                    }
                                },
                                new Lesson
                                {
                                    Order = 3,
                                    LessonAttempts = new List<LessonAttempt>
                                    {
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1),
                                            Finished = new DateTime(2010, 1, 2)
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
                context.Course.Add(new Course
                {
                    CourseType = new CourseType
                    {
                        Name = "C#",
                        Type = CourseTypeEnum.CSharp
                    },
                    Chapters = new List<Chapter>
                    {
                        new Chapter
                        {
                            Order = 1,
                            Lessons = new List<Lesson>
                            {
                                new Lesson
                                {
                                    Order = 1,
                                    LessonAttempts = new List<LessonAttempt>
                                    {
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1)
                                        },
                                        new LessonAttempt
                                        {
                                            UserId = 1,
                                            Started = new DateTime(2010, 1, 1),
                                            Finished = new DateTime(2010, 1, 2)
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
                context.SaveChanges();
            }
            if (!context.Achievement.Any())
            {
                context.Achievement.Add(new Achievement
                {
                    AchievementType = AchievementTypeEnum.CSharpCourse
                });
                context.Achievement.Add(new Achievement
                {
                    AchievementType = AchievementTypeEnum.SwiftCourse
                });
                context.Achievement.Add(new Achievement
                {
                    AchievementType = AchievementTypeEnum.FiftyLessons
                });
                context.Achievement.Add(new Achievement
                {
                    AchievementType = AchievementTypeEnum.FiveChapters
                });
                context.Achievement.Add(new Achievement
                {
                    AchievementType = AchievementTypeEnum.JavascriptCourse
                });
                context.Achievement.Add(new Achievement
                {
                    AchievementType = AchievementTypeEnum.FiveLessons
                });
                context.Achievement.Add(new Achievement
                {
                    AchievementType = AchievementTypeEnum.TwentyFiveLessons
                });
                context.Achievement.Add(new Achievement
                {
                    AchievementType = AchievementTypeEnum.OneChapter
                });
                context.SaveChanges();
            }
            if (!context.UserAchievement.Any())
            {
                context.UserAchievement.Add(new UserAchievement());
                context.SaveChanges();
            }
        }
    }
}