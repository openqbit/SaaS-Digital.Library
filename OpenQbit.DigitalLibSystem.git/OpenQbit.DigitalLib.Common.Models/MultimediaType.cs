using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.DigitalLib.Common.Models
{
    public class MultimediaType
    {
        public int ID { get; set; }
        public string name { get; set; }

        public virtual ICollection<DigitalItem> DigitalItem { get; set; }
    }
}
