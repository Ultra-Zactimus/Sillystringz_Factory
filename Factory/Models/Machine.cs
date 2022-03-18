using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {

    }
    public string Hardware { get; set; }
    public int HardwareId { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}