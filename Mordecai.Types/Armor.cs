﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Armor : IItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Place Location { get; set; }
        public IContainer Container { get; set; }
        public int Weight { get; set; }
    }
}
