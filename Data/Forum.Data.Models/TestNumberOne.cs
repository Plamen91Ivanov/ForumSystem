using Forum.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data.Models
{
    public class TestNumberOne : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int NumberOne { get; set; }

        public int NumberTwo { get; set; }
    }
}
