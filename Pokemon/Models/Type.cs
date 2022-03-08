﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Models
{
    public class Type
    {
        public int TypeId { get; set; }
        public string Kind { get; set; }

        //Navigation Properties
        public ICollection<Card> Cards { get; set; }
    }
}