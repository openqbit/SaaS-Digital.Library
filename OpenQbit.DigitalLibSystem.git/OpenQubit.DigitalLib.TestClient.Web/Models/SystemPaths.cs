using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQubit.DigitalLib.TestClient.Web.Models
{
    public class SystemPaths
    {
        public int ID { get; set; }
        public byte[] Path { get; set; }
        public virtual ICollection<ResourcePath> ResourcePath { get; set; }
        public virtual Systems System { get; set; }
    }
}