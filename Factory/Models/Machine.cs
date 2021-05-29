using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }

    [Display(Name = "Name of Machine")]
    public string MachineName { get; set; }

    [Display(Name = "Machine Description")]
    public string MachineDescription { get; set; }

    [Display(Name = "Date of Installation")]
    public DateTime InstallDate { get; set; }

    [Display(Name = "Hours in Operation")]
    public int HoursOperated { get; set; }

    [Display(Name = "Date of Last Inspection")]
    public DateTime LastInspection { get; set; }

    [Display(Name = "Inspection Cycle")]
    public string InspectionCycle { get; set; }



    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}



