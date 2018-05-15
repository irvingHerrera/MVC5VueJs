using Model.Auth;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Domain
{
    public class CourseLessonLearnedsPerStudent
    {
        public int Id { get; set; }

        public LessonsPerCourse Lessons { get; set; }
        public int LessonsId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}
