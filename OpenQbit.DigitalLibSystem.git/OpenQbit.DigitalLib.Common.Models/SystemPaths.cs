using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.DigitalLib.Common.Models
{
    public class SystemPaths
    {
        public int ID { get; set; }
        public byte[] Path { get; set; }
        public virtual ICollection<ResourcePath> ResourcePath { get; set; }
        public virtual System System { get; set; }
    }
}
