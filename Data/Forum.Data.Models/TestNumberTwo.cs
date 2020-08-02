using Forum.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data.Models
{
    public class TestNumberTwo : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int TwoNumberOne { get; set; }

        public int TwoNumberTwo { get; set; }
    }
}
