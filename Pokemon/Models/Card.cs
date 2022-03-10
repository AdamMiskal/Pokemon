using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Pokemon.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SerialNumber { get; set; }




        //Navigation Properties
        public int PokemonTypeId { get; set; }
        public PokemonType PokemonType { get; set; }
        //LISTA APO TYPES

        //images

        //user-card polla pros ena

        //rarity ENUM



    }
}