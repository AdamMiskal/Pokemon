﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Models
{
    public class Pack
    {
        public int PackId { get; set; }
        public List<Card> Cards { get; set; }
    }
}