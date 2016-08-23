﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.DbModels.Mcp
{
    public class Image
    {
        public int Id { get; set; }
        public int BulletinId { get; set; }
        public string Name { get; set; }
        public Bulletin Bulletin { get; set; }
    }
}
