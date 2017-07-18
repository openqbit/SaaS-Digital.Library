using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQubit.DigitalLib.TestClient.Web.Models
{
    public class MultimediaType
    {
        public int ID { get; set; }
        public string name { get; set; }

        public virtual ICollection<DigitalItem> DigitalItem { get; set; }
    }
}