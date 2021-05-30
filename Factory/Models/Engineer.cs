using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    [Display(Name = "Engineer's Name")]
    public string EngineerName { get; set; }
    [Display(Name = "Start of Employment")]

    public DateTime EmploymentStartDate { get; set; }
    // public string Description { get; set; }
    public string EngineerMachine { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}