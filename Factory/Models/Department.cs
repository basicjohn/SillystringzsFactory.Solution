using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public Department()
    {
      this.JoinEntities2 = new HashSet<CourseDepartment>();
    }
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public string Description { get; set; }
    public string DeanName { get; set; }
    public string ContactInfo { get; set; }
    public virtual ICollection<CourseDepartment> JoinEntities2 { get; set; }
  }
}