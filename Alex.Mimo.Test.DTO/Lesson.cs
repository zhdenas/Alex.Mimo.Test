namespace Alex.Mimo.Test.DTO
{
    public class Lesson
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public int ChapterNumber { get; set; }

        public string CourseType { get; set; }

        public TimeInterval Attempts { get; set; }
    }
}
