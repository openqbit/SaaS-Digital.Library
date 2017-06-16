using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.DigitalLib.Common.Models
{
    public class Systems
    {
        
        public int ID { get; set; }
        public string SystemName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string GuardianName { get; set; }
        public virtual ICollection<SystemPaths> SystemPaths { get; set; }


    }
}
