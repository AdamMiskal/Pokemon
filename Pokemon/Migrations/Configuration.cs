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

            PokemonType t1 = new PokemonType() { Kind = "Grass"    };
            PokemonType t2 = new PokemonType() { Kind = "Water"     };
            PokemonType t3 = new PokemonType() { Kind = "Fire"      };
            PokemonType t4 = new PokemonType() { Kind = "Flying"    };
            PokemonType t5 = new PokemonType() { Kind = "Bug"       };
            PokemonType t6 = new PokemonType() { Kind = "Normal"    };
            PokemonType t7 = new PokemonType() { Kind = "Poison"    };
            PokemonType t8 = new PokemonType() { Kind = "Electric" };

            Image i1 = new Image() { Url = "/Assets/Images/Bulbasaur.png" };
            Image i2 = new Image() { Url = "/Assets/Images/Ivysaur.png" };
            Image i3 = new Image() { Url = "/Assets/Images/Venusaur.png" };
            Image i4 = new Image() { Url = "/Assets/Images/Charmander.png" };
            Image i5 = new Image() { Url = "/Assets/Images/Charmeleon.png" };
            Image i6 = new Image() { Url = "/Assets/Images/Charizard.png" };
            Image i7 = new Image() { Url = "/Assets/Images/Squirtle.png" };
            Image i8 = new Image() { Url = "/Assets/Images/Wartortle.png" };
            Image i9 = new Image() { Url = "/Assets/Images/Blastoise.png" };
            Image i10 = new Image() { Url = "/Assets/Images/Caterpie.png" };
            Image i11 = new Image() { Url = "/Assets/Images/Metapod.png" };
            Image i12 = new Image() { Url = "/Assets/Images/Butterfree.png" };
            Image i13 = new Image() { Url = "/Assets/Images/Weedle.png" };
            Image i14 = new Image() { Url = "/Assets/Images/Kakuna.png" };
            Image i15 = new Image() { Url = "/Assets/Images/Beedrill.png" };
            Image i16 = new Image() { Url = "/Assets/Images/Pidgey.png" };
            Image i17 = new Image() { Url = "/Assets/Images/Pidgeotto.png" };
            Image i18 = new Image() { Url = "/Assets/Images/Pidgeot.png" };
            Image i19 = new Image() { Url = "/Assets/Images/Rattata.png" };
            Image i20 = new Image() { Url = "/Assets/Images/Raticate.png" };
            Image i21 = new Image() { Url = "/Assets/Images/Spearow.png" };
            Image i22 = new Image() { Url = "/Assets/Images/Fearow.png" };
            Image i23 = new Image() { Url = "/Assets/Images/Ekans.png" };
            Image i24 = new Image() { Url = "/Assets/Images/Arbok.png" };
            Image i25 = new Image() { Url = "/Assets/Images/Pikachu.png" };
            Image i26 = new Image() { Url = "/Assets/Images/Raichu.png" };
            Image i27 = new Image() { Url = "/Assets/Images/Sandshrew.png" };
            Image i28 = new Image() { Url = "/Assets/Images/Sandslash.png" };
            Image i29 = new Image() { Url = "/Assets/Images/Nidoran.png" };
            Image i30 = new Image() { Url = "/Assets/Images/Nidorina.png" };

            Card c1 = new Card() { Name = "Bulbasaur", Description = "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.",  SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common };
            Card c2 = new Card() { Name = "Ivysaur", Description = "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.",  SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c3 = new Card() { Name = "Venusaur", Description = "Its plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.",  SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic };
            Card c4 = new Card() { Name = "Charmander", Description = "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.",  SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common };
            Card c5 = new Card() { Name = "Charmeleon", Description = "It has a barbaric nature. In battle, it whips its fiery tail around and slashes away with sharp claws.",  SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c6 = new Card() { Name = "Charizard", Description = "It spits fire that is hot enough to melt boulders. It may cause forest fires by blowing flames.",  SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic };
            Card c7 = new Card() { Name = "Squirtl", Description = "When it retracts its long neck into its shell, it squirts out water with vigorous force.",  SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, };
            Card c8 = new Card() { Name = "Wartortle", Description = "It is recognized as a symbol of longevity. If its shell has algae on it, that Wartortle is very old.",  SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c9 = new Card() { Name = "Blastoise", Description = "It crushes its foe under its heavy body to cause fainting. In a pinch, it will withdraw inside its shell.",  SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, };
            Card c10 = new Card() { Name = "Caterpie", Description = "For protection, it releases a horrible stench from the antenna on its head to drive away enemies.",  SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Common };
            Card c11 = new Card() { Name = "Metapod", Description = "It is waiting for the moment to evolve. At this stage, it can only harden, so it remains motionless to avoid attack.",  SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Rare };
            Card c12 = new Card() { Name = "Butterfree", Description = "In battle, it flaps its wings at great speed to release highly toxic dust into the air.",  SerialNumber = 1, Attack = 4, Defence = 3, Rarity = Rarity.Epic };
            Card c13 = new Card() { Name = "Weedle", Description = "Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves.",  SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common };
            Card c14 = new Card() { Name = "Kakuna", Description = "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy.",  SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Rare, };
            Card c15 = new Card() { Name = "Beedrill", Description = "It has three poisonous stingers on its forelegs and its tail. They are used to jab its enemy repeatedly.",  SerialNumber = 1, Attack = 4, Defence = 6, Rarity = Rarity.Epic };
            Card c16 = new Card() { Name = "Pidgey", Description = "Very docile. If attacked, it will often kick up sand to protect itself rather than fight back.",  SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common };
            Card c17 = new Card() { Name = "Pidgeotto", Description = "This Pokémon is full of vitality. It constantly flies around its large territory in search of prey.",  SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c18 = new Card() { Name = "Pidgeot", Description = "This Pokémon flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons.",  SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic };
            Card c19 = new Card() { Name = "Rattata", Description = "Will chew on anything with its fangs. If you see one, you can be certain that 40 more live in the area.", SerialNumber = 1, Attack = 2, Defence = 4, Rarity = Rarity.Common };
            Card c20 = new Card() { Name = "Raticate", Description = "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.",  SerialNumber = 1, Attack = 4, Defence = 5, Rarity = Rarity.Rare };
            Card c21 = new Card() { Name = "Spearow", Description = "Inept at flying high. However, it can fly around very fast to protect its territory.",  SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common };
            Card c22 = new Card() { Name = "Fearow", Description = "A Pokémon that dates back many years. If it senses danger, it flies high and away, instantly.",  SerialNumber = 1, Attack = 4, Defence = 6, Rarity = Rarity.Rare, };
            Card c23 = new Card() { Name = "Ekans", Description = "The older it gets, the longer it grows. At night, it wraps its long body around tree branches to rest.",  SerialNumber = 1, Attack = 6, Defence = 5, Rarity = Rarity.Common };
            Card c24 = new Card() { Name = "Arbok", Description = "The frightening patterns on its belly have been studied. Six variations have been confirmed.",  SerialNumber = 1, Attack = 6, Defence = 5, Rarity = Rarity.Rare };
            Card c25 = new Card() { Name = "Pikachu", Description = "Pikachu that can generate powerful electricity have cheek sacs that are extra soft and super stretchy.",  SerialNumber = 1, Attack = 4, Defence = 3, Rarity = Rarity.Common };
            Card c26 = new Card() { Name = "Raichu", Description = "Its long tail serves as a ground to protect itself from its own high-voltage power.",  SerialNumber = 1, Attack = 6, Defence = 4, Rarity = Rarity.Rare };
            Card c27 = new Card() { Name = "Sandshrew", Description = "It loves to bathe in the grit of dry, sandy areas. By sand bathing, the Pokémon rids itself of dirt and moisture clinging to its body.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Common };
            Card c28 = new Card() { Name = "Sandslash", Description = "The drier the area Sandslash lives in, the harder and smoother the Pokémon’s spikes will feel when touched.", SerialNumber = 1, Attack = 6, Defence = 7, Rarity = Rarity.Rare };
            Card c29 = new Card() { Name = "Nidoran", Description = "Females are more sensitive to smells than males. While foraging, they’ll use their whiskers to check wind direction and stay downwind of predators.",  SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common };
            Card c30 = new Card() { Name = "Nidorina", Description = "The horn on its head has atrophied. It’s thought that this happens so Nidorina’s children won’t get poked while their mother is feeding them.",  SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };

            t1.Cards = new List<Card>() { c1, c2, c3 };
            t2.Cards = new List<Card>() { c4, c5, c6 };
            t3.Cards = new List<Card>() { c7, c8, c9 ,c10,c11};
            t4.Cards = new List<Card>() { c12, c16, c17, c18 };
            t5.Cards = new List<Card>() { c13, c14, c15, c11 };
            t6.Cards = new List<Card>() { c16, c17, c18,c29,c30 };
            t7.Cards = new List<Card>() { c19, c20, c21,c27,c28 };
            t8.Cards = new List<Card>() { c22, c23, c24, c25, c26 };
            
            
            c1.PokemonTypes = new List<PokemonType>() { t1 };
            c2.PokemonTypes = new List<PokemonType>() { t1 };
            c3.PokemonTypes = new List<PokemonType>() { t1 };
            c4.PokemonTypes = new List<PokemonType>() { t2 };
            c5.PokemonTypes = new List<PokemonType>() { t2 };
            c6.PokemonTypes = new List<PokemonType>() { t2 };
            c7.PokemonTypes = new List<PokemonType>() { t3 };
            c8.PokemonTypes = new List<PokemonType>() { t3 };
            c9.PokemonTypes = new List<PokemonType>() { t3 };
            c10.PokemonTypes = new List<PokemonType>() { t3 };
            c11.PokemonTypes = new List<PokemonType>() { t5,t3 };
            c12.PokemonTypes = new List<PokemonType>() { t4 };
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
            c25.PokemonTypes = new List<PokemonType>() { t8 };
            c26.PokemonTypes = new List<PokemonType>() { t8 };
            c27.PokemonTypes = new List<PokemonType>() { t7 };
            c28.PokemonTypes = new List<PokemonType>() { t7 };
            c29.PokemonTypes = new List<PokemonType>() { t6 };
            c30.PokemonTypes = new List<PokemonType>() { t6 };
            
            
            
            i1.Cards = new List<Card>() { c1 };
            i2.Cards = new List<Card>() { c2 };
            i3.Cards = new List<Card>() { c3};
            i4.Cards = new List<Card>() { c4 };
            i5.Cards = new List<Card>() { c5 };
            i6.Cards = new List<Card>() { c6 };
            i7.Cards = new List<Card>() { c7 };
            i8.Cards = new List<Card>() { c8};            
            i9.Cards = new List<Card>() { c9};            
            i10.Cards = new List<Card>() { c10};            
            i11.Cards = new List<Card>() { c11};            
            i12.Cards = new List<Card>() { c12};            
            i13.Cards = new List<Card>() { c13};            
            i14.Cards = new List<Card>() { c14};            
            i15.Cards = new List<Card>() { c15};            
            i16.Cards = new List<Card>() { c16};            
            i17.Cards = new List<Card>() { c17};            
            i18.Cards = new List<Card>() { c18};            
            i19.Cards = new List<Card>() { c19};            
            i20.Cards = new List<Card>() { c20};            
            i21.Cards = new List<Card>() { c21};            
            i22.Cards = new List<Card>() { c22};            
            i23.Cards = new List<Card>() { c23};            
            i24.Cards = new List<Card>() { c24};            
            i25.Cards = new List<Card>() { c25};            
            i26.Cards = new List<Card>() { c26};            
            i27.Cards = new List<Card>() { c27};            
            i28.Cards = new List<Card>() { c28};            
            i29.Cards = new List<Card>() { c29};            
            i30.Cards = new List<Card>() { c30};            
            
            var cards = new List<Card>() { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26, c27, c28, c29, c30 };
            var pokemonTypes = new List<PokemonType>() { t1, t2, t3, t2, t3, t4, t5, t6, t7, t8 };
            var images = new List<Image>() { i1, i2, i3, i4, i5, i6, i7, i8, i9,i10,i11,i12,i13,i14,i15,i16,i17,i18,i19,i20,i21,i22,i23,i24,i25,i26,i27,i28,i29,i30 };
            
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

