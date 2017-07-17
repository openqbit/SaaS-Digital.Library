﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.DigitalLib.TestClient.Web.Models
{
    public class ResourcePath
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public virtual DigitalItem DigitalItem { get; set; }
        public virtual SystemPaths SystemPaths { get; set; }
    }
}