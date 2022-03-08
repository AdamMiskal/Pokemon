using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Models
{
    public class PokemonType
    {
        public int PokemonTypeId { get; set; }
        public string Kind { get; set; }

        //Navigation Properties
        public List<Card> Cards { get; set; }
    }
}