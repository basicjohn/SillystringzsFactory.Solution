using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public DateTime EmploymentStartDate { get; set; }
    // public string Description { get; set; }
    public string EngineerMachine { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}