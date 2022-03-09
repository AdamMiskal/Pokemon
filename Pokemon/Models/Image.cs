using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Url { get; set; }

        public List<Card> Cards { get; set; }
    }
}