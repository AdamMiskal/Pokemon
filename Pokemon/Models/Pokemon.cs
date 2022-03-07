using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Pokemon.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Navigation Properties
        public int? TypeId { get; set; }
        public Type Type { get; set; }


    }
}