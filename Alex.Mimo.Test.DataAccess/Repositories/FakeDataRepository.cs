using System;
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
                    Id = 1
                });
                context.SaveChanges();
            }
            if (!context.Course.Any())
            {
                context.Course.Add(new Course
                {
                    CourseType = new CourseType
                    {
                        Type = "Javascript"
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
                        Type = "Swift"
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
                        Type = "C#"
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
                context.Achievement.Add(new Achievement()
                {
                    AchievementType = new AchievementType() { }
                })
                context.SaveChanges();
            }
        }
    }
}