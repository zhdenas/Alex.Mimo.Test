using System;
using Microsoft.Build.Framework;

namespace Alex.Mimo.Test.BLL.Models
{
    public class CheckLessonModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }
    }
}