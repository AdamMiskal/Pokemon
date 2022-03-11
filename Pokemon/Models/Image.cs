using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}