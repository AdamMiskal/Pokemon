using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Pokemon.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public Rarity Rarity { get; set; }





        //Navigation Properties
        public List<PokemonType> PokemonTypes { get; set; }

        public int? ImageID { get; set; }
        public virtual Image Image { get; set; }

        public ApplicationUser User { get; set; }













        //user-card polla pros ena



    }
}