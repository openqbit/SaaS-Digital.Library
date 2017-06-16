using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.DigitalLib.Common.Models
{
    public class ResourcePath
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public virtual DigitalItem DigitalItem { get; set; }
        public virtual SystemPaths SystemPaths { get; set; }
    }
}
