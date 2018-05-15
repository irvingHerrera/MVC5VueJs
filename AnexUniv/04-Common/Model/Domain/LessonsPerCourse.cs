namespace Model.Domain
{
    public class LessonsPerCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Video { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
