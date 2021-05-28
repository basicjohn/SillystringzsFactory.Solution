using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities1 = new HashSet<CourseStudent>();
      this.JoinEntities2 = new HashSet<CourseDepartment>();
    }

    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseNumber { get; set; }
    public string Description { get; set; }
    public string CourseSchedule { get; set; }
    public string TeacherName { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities1 { get; set; }
    public virtual ICollection<CourseDepartment> JoinEntities2 { get; set; }
  }
}