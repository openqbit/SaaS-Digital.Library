﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQubit.DigitalLib.TestClient.web.Models
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