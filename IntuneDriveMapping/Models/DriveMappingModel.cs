﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntuneDriveMapping.Models
{
    public class DriveMappingModel
    {
        public string Path { get; set; }
        public string DriveLetter { get; set; }
        public string Label { get; set; }
        public int id { get; set; }
        public string GroupFilter { get; set; }
    }
}
