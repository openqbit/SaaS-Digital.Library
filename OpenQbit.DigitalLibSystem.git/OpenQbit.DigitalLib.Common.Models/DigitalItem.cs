﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.DigitalLib.Common.Models
{
    public class DigitalItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual MultimediaType MultimediaType { get; set; }
        public virtual ICollection<ResourcePath> ResourcePath { get; set; }
    }
}
