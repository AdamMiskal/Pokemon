using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Pokemon.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SerialNumber { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public Rarity Rarity { get; set; }
        public int? pkdxNum { get; set; }
        //PROPERTY GIA TO MARKETPLACE---------------------------------------
        public Boolean? Market { get; set; }
        public int? Price { get; set; }


        //Navigation Properties
        public List<PokemonType> PokemonTypes { get; set; }

        public int? ImageID { get; set; }
        public virtual Image Image { get; set; }


        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        
        public virtual ApplicationUser User { get; set; }
       
        











        //user-card polla pros ena



    }
}