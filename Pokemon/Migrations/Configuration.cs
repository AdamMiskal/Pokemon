namespace Pokemon.Migrations
{
    using Pokemon.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pokemon.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Pokemon.Models.ApplicationDbContext context)
        {
            PokemonType t1 = new PokemonType() { Kind = "Grass" };
            PokemonType t2 = new PokemonType() { Kind = "Water" };
            PokemonType t3 = new PokemonType() { Kind = "Fire" };

            Image i1 = new Image() { Url = "~/Assets/Images/005.png" };
            


             Card c1 = new Card() { Name = "Pikachu", SerialNumber = 1, PokemonTypeId = 1, PokemonType = t1};
            Card c3 = new Card() { Name = "Pikachu", SerialNumber = 3, PokemonTypeId = 1, PokemonType = t1 };
            Card c4 = new Card() { Name = "Pikachu", SerialNumber = 4, PokemonTypeId = 1, PokemonType = t1 };
            Card c5 = new Card() { Name = "Pikachu", SerialNumber = 5, PokemonTypeId = 1, PokemonType = t1 };
            Card c6 = new Card() { Name = "Pikachu", SerialNumber = 6, PokemonTypeId = 1, PokemonType = t1 };
            Card c7 = new Card() { Name = "Pikachu", SerialNumber = 7, PokemonTypeId = 1, PokemonType = t1 };
            Card c2 = new Card() { Name = "Pikachu", SerialNumber = 2, PokemonTypeId = 1, PokemonType = t1 };
            Card c8 = new Card() { Name = "Pikachu", SerialNumber = 8, PokemonTypeId = 1, PokemonType = t1 };
            Card c9 = new Card() { Name = "Pikachu", SerialNumber = 9, PokemonTypeId = 1, PokemonType = t1 };
            Card c10 = new Card() { Name = "Pikachu", SerialNumber = 10, PokemonTypeId = 1, PokemonType = t1 };

            Card c11 = new Card() { Name = "Squirtle", SerialNumber = 1, PokemonTypeId = 2, PokemonType = t2 };
            Card c12 = new Card() { Name = "Squirtle", SerialNumber = 2, PokemonTypeId = 2, PokemonType = t2 };
            Card c13 = new Card() { Name = "Squirtle", SerialNumber = 3, PokemonTypeId = 2, PokemonType = t2 };
            Card c14 = new Card() { Name = "Squirtle", SerialNumber = 4, PokemonTypeId = 2, PokemonType = t2 };
            Card c15 = new Card() { Name = "Squirtle", SerialNumber = 5, PokemonTypeId = 2, PokemonType = t2 };
            Card c16 = new Card() { Name = "Squirtle", SerialNumber = 6, PokemonTypeId = 2, PokemonType = t2 };
            Card c17 = new Card() { Name = "Squirtle", SerialNumber = 7, PokemonTypeId = 2, PokemonType = t2 };
            Card c18 = new Card() { Name = "Squirtle", SerialNumber = 8, PokemonTypeId = 2, PokemonType = t2 };
            Card c19 = new Card() { Name = "Squirtle", SerialNumber = 9, PokemonTypeId = 2, PokemonType = t2 };
            Card c20 = new Card() { Name = "Squirtle", SerialNumber = 10, PokemonTypeId = 2, PokemonType = t2 };

            Card c21 = new Card() { Name = "Charmander", SerialNumber = 1, PokemonTypeId = 3, PokemonType = t3 };
            Card c22 = new Card() { Name = "Charmander", SerialNumber = 2, PokemonTypeId = 3, PokemonType = t3 };
            Card c23 = new Card() { Name = "Charmander", SerialNumber = 3, PokemonTypeId = 3, PokemonType = t3 };
            Card c24 = new Card() { Name = "Charmander", SerialNumber = 4, PokemonTypeId = 3, PokemonType = t3 };
            Card c25 = new Card() { Name = "Charmander", SerialNumber = 5, PokemonTypeId = 3, PokemonType = t3 };
            Card c26 = new Card() { Name = "Charmander", SerialNumber = 6, PokemonTypeId = 3, PokemonType = t3 };
            Card c27 = new Card() { Name = "Charmander", SerialNumber = 7, PokemonTypeId = 3, PokemonType = t3 };
            Card c28 = new Card() { Name = "Charmander", SerialNumber = 8, PokemonTypeId = 3, PokemonType = t3 };
            Card c29 = new Card() { Name = "Charmander", SerialNumber = 9, PokemonTypeId = 3, PokemonType = t3 };
            Card c30 = new Card() { Name = "Charmander", SerialNumber = 10, PokemonTypeId = 3, PokemonType = t3 };

            t1.Cards = new List<Card>() { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 };
            t2.Cards = new List<Card>() { c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 };
            t3.Cards = new List<Card>() { c21, c22, c23, c24, c25, c26, c27, c28, c29, c30 };



            var cards = new List<Card>() { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26, c27, c28, c29, c30 };
            var pokemonTypes = new List<PokemonType>() { t1, t2, t3 };

            context.Cards.AddRange(cards);
            context.PokemonType.AddRange(pokemonTypes);
            context.SaveChanges();







        }
    }
}

