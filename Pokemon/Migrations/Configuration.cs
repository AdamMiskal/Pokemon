namespace Pokemon.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
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

            ApplicationUser us1 = null;
            ApplicationUser us2 = null;

            PokemonType t1 = new PokemonType() { Kind = "Grass" };
            PokemonType t2 = new PokemonType() { Kind = "Water" };
            PokemonType t3 = new PokemonType() { Kind = "Fire" };
            PokemonType t4 = new PokemonType() { Kind = "Flying" };
            PokemonType t5 = new PokemonType() { Kind = "Bug" };
            PokemonType t6 = new PokemonType() { Kind = "Normal" };
            PokemonType t7 = new PokemonType() { Kind = "Poison" };
            PokemonType t8 = new PokemonType() { Kind = "Electric" };
            
            Image i1 = new Image() { Url = "/Assets/Images/001.png" };
            Image i2 = new Image() { Url = "/Assets/Images/004.png" };
            Image i3 = new Image() { Url = "/Assets/Images/007.png" };
            Image i4 = new Image() { Url = "/Assets/Images/010.png" };
            Image i5 = new Image() { Url = "/Assets/Images/013.png" };
            Image i6 = new Image() { Url = "/Assets/Images/016.png" };
            Image i7 = new Image() { Url = "/Assets/Images/023.png" };
            Image i8 = new Image() { Url = "/Assets/Images/025.png" };
            
            Card c1 = new Card() { Name = "Bulbasaur", SerialNumber = 1, Attack = 1, Defence = 1, Rarity = Rarity.Common,Market=true};
            Card c2 = new Card() { Name = "Bulbasaur", SerialNumber = 2, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c3 = new Card() { Name = "Bulbasaur", SerialNumber = 3, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            
            Card c4 = new Card() { Name = "Charmander", SerialNumber = 1, Attack = 1, Defence = 1, Rarity = Rarity.Common,Market=true };
            Card c5 = new Card() { Name = "Charmander", SerialNumber = 2, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c6 = new Card() { Name = "Charmander", SerialNumber = 3, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            
            Card c7 = new Card() { Name = "Squirtle", SerialNumber = 1, Attack = 1, Defence = 1, Rarity = Rarity.Common, Market = true };
            Card c8 = new Card() { Name = "Squirtle", SerialNumber = 2, Attack = 1, Defence = 1, Rarity = Rarity.Common, Market = true };
            Card c9 = new Card() { Name = "Squirtle", SerialNumber = 3, Attack = 1, Defence = 1, Rarity = Rarity.Common, Market = true };
            
            Card c10 = new Card() { Name = "Caterpie", SerialNumber = 1, Attack = 1, Defence = 1, Rarity = Rarity.Common, Market = true };
            Card c11 = new Card() { Name = "Caterpie", SerialNumber = 2, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c12 = new Card() { Name = "Caterpie", SerialNumber = 3, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            
            Card c13 = new Card() { Name = "Weedle", SerialNumber = 1, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c14 = new Card() { Name = "Weedle", SerialNumber = 2, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c15 = new Card() { Name = "Weedle", SerialNumber = 3, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            
            Card c16 = new Card() { Name = "Pidgey", SerialNumber = 1, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c17 = new Card() { Name = "Pidgey", SerialNumber = 2, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c18 = new Card() { Name = "Pidgey", SerialNumber = 3, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            
            Card c19 = new Card() { Name = "Ekans", SerialNumber = 1, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c20 = new Card() { Name = "Ekans", SerialNumber = 2, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c21 = new Card() { Name = "Ekans", SerialNumber = 3, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            
            Card c22 = new Card() { Name = "Pikachu", SerialNumber = 1, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c23 = new Card() { Name = "Pikachu", SerialNumber = 2, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            Card c24 = new Card() { Name = "Pikachu", SerialNumber = 3, Attack = 1, Defence = 1, Rarity = Rarity.Common };
            
            t1.Cards = new List<Card>() { c1, c2, c3 };
            t2.Cards = new List<Card>() { c4, c5, c6 };
            t3.Cards = new List<Card>() { c7, c8, c9 };
            t4.Cards = new List<Card>() { c16, c17, c18 };
            t5.Cards = new List<Card>() { c13, c14, c15 };
            t6.Cards = new List<Card>() { c16, c17, c18 };
            t7.Cards = new List<Card>() { c19, c20, c21 };
            t8.Cards = new List<Card>() { c22, c23, c24 };
            
            
            c1.PokemonTypes = new List<PokemonType>() { t1 };
            c2.PokemonTypes = new List<PokemonType>() { t1 };
            c3.PokemonTypes = new List<PokemonType>() { t1 };
            c4.PokemonTypes = new List<PokemonType>() { t2 };
            c5.PokemonTypes = new List<PokemonType>() { t2 };
            c6.PokemonTypes = new List<PokemonType>() { t2 };
            c7.PokemonTypes = new List<PokemonType>() { t3 };
            c8.PokemonTypes = new List<PokemonType>() { t3 };
            c9.PokemonTypes = new List<PokemonType>() { t3 };
            c10.PokemonTypes = new List<PokemonType>() { t5 };
            c11.PokemonTypes = new List<PokemonType>() { t5 };
            c12.PokemonTypes = new List<PokemonType>() { t5 };
            c13.PokemonTypes = new List<PokemonType>() { t5 };
            c14.PokemonTypes = new List<PokemonType>() { t5 };
            c15.PokemonTypes = new List<PokemonType>() { t5 };
            c16.PokemonTypes = new List<PokemonType>() { t6, t4 };
            c17.PokemonTypes = new List<PokemonType>() { t6, t4 };
            c18.PokemonTypes = new List<PokemonType>() { t6, t4 };
            c19.PokemonTypes = new List<PokemonType>() { t7 };
            c20.PokemonTypes = new List<PokemonType>() { t7 };
            c21.PokemonTypes = new List<PokemonType>() { t7 };
            c22.PokemonTypes = new List<PokemonType>() { t8 };
            c23.PokemonTypes = new List<PokemonType>() { t8 };
            c24.PokemonTypes = new List<PokemonType>() { t8 };
            
            
            
            i1.Cards = new List<Card>() { c1, c2, c3 };
            i2.Cards = new List<Card>() { c4, c5, c6 };
            i3.Cards = new List<Card>() { c7, c8, c9 };
            i4.Cards = new List<Card>() { c10, c11, c12 };
            i5.Cards = new List<Card>() { c13, c14, c15 };
            i6.Cards = new List<Card>() { c16, c17, c18 };
            i7.Cards = new List<Card>() { c19, c20, c21 };
            i8.Cards = new List<Card>() { c22, c23, c24 };            
            
            var cards = new List<Card>() { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24 };
            var pokemonTypes = new List<PokemonType>() { t1, t2, t3, t2, t3, t4, t5, t6, t7, t8 };
            var images = new List<Image>() { i1, i2, i3, i4, i5, i6, i7, i8 };
            
            context.Cards.AddRange(cards);
            context.PokemonType.AddRange(pokemonTypes);
            context.Images.AddRange(images);


            if (!context.Roles.Any(r => r.Name == "Customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Customer" };
            
                manager.Create(role);
                
            }

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };
                 
                manager.Create(role);
                
            }

            if (!context.Users.Any(u => u.UserName == "admin@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(store);
            
                var passwordHash = new PasswordHasher();
            
                us1 = new ApplicationUser()
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    Balance = 1000,
                    //Cards = new List<Card>() { c4,c5},
                    PasswordHash = passwordHash.HashPassword("Admin1234!")
                };
            
                 c1.User = us1;
                 c4.User = us1;
                 c6.User = us1;
                c7.User = us1;
                c8.User = us1;
                c9.User = us1;
                c10.User = us1;
                c7.Price = 150;
                c8.Price = 220;
                c9.Price = 100;
                c10.Price = 200;
                c1.Price = 200;
                c4.Price = 300;
                c6.Price = 100;


                userManager.Create(us1);
                userManager.AddToRole(us1.Id, "Admin");

            }

            if (!context.Users.Any(u => u.UserName == "Test1@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(store);

                var passwordHash = new PasswordHasher();

                us2 = new ApplicationUser()
                {
                    UserName = "Test1@gmail.com",
                    Email = "Test1@gmail.com",
                    Balance = 10000,
                    PasswordHash = passwordHash.HashPassword("Test1234!")
                };

                userManager.Create(us2);
                userManager.AddToRole(us2.Id, "Customer");


            }

            //context.Cards.Add(c1);

            context.SaveChanges();

        }
    }
}

