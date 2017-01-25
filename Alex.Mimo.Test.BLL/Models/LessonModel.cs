using System;

namespace Alex.Mimo.Test.BLL.Models
{
    public class LessonModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}