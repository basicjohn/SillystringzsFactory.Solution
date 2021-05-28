using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities1 = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }

    public string StudentName { get; set; }
    [Display(Name = "Date Of Enrollment")]
    public DateTime DateOfEnrollment { get; set; }

    public virtual ICollection<CourseStudent> JoinEntities1 { get; }
  }
}



