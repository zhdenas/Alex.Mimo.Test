using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Alex.Mimo.Test.Models
{
    public class CheckLessonModel : IValidatableObject
    {
        [Required(ErrorMessage = "Lesson id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Started date is required")]
        public DateTime StartedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> results = new List<ValidationResult>();

            if (this.FinishedDate.HasValue && this.FinishedDate.Value <= this.StartedDate)
            {
                results.Add(new ValidationResult("FinishedDate must be greater that StartedDate", new[] { "FinishedDate" }));
            }

            return results;
        }
    }

}