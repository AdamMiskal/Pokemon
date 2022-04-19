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
            ApplicationUser us3 = null;
            ApplicationUser us4 = null;
            ApplicationUser us5 = null;
            ApplicationUser admn1 = null;
            ApplicationUser test1 = null;

            //========================== Pokemon Types ===================================
            PokemonType bug1 = new PokemonType() { Kind = "Bug" };
            PokemonType drg2 = new PokemonType() { Kind = "Dragon" };
            PokemonType elc3 = new PokemonType() { Kind = "Electric" };
            PokemonType fgh4 = new PokemonType() { Kind = "Fighting" };
            PokemonType fr5 = new PokemonType() { Kind = "Fire" };
            PokemonType fly6 = new PokemonType() { Kind = "Flying" };
            PokemonType gh7 = new PokemonType() { Kind = "Ghost" };
            PokemonType gras8 = new PokemonType() { Kind = "Grass" };
            PokemonType grd9 = new PokemonType() { Kind = "Ground" };
            PokemonType ice10 = new PokemonType() { Kind = "Ice" };
            PokemonType norm11 = new PokemonType() { Kind = "Normal" };
            PokemonType psn12 = new PokemonType() { Kind = "Poison" };
            PokemonType psy13 = new PokemonType() { Kind = "Psychic" };
            PokemonType roc14 = new PokemonType() { Kind = "Rock" };
            PokemonType wat15 = new PokemonType() { Kind = "Water" };

            //========================== Pokemon Images ===================================
            Image i1 = new Image() { Url = "/Assets/CardImgs/001.png" };
            Image i2 = new Image() { Url = "/Assets/CardImgs/002.png" };
            Image i3 = new Image() { Url = "/Assets/CardImgs/003.png" };
            Image i4 = new Image() { Url = "/Assets/CardImgs/004.png" };
            Image i5 = new Image() { Url = "/Assets/CardImgs/005.png" };
            Image i6 = new Image() { Url = "/Assets/CardImgs/006.png" };
            Image i7 = new Image() { Url = "/Assets/CardImgs/007.png" };
            Image i8 = new Image() { Url = "/Assets/CardImgs/008.png" };
            Image i9 = new Image() { Url = "/Assets/CardImgs/009.png" };
            Image i10 = new Image() { Url = "/Assets/CardImgs/010.png" };
            Image i11 = new Image() { Url = "/Assets/CardImgs/011.png" };
            Image i12 = new Image() { Url = "/Assets/CardImgs/012.png" };
            Image i13 = new Image() { Url = "/Assets/CardImgs/013.png" };
            Image i14 = new Image() { Url = "/Assets/CardImgs/014.png" };
            Image i15 = new Image() { Url = "/Assets/CardImgs/015.png" };
            Image i16 = new Image() { Url = "/Assets/CardImgs/016.png" };
            Image i17 = new Image() { Url = "/Assets/CardImgs/017.png" };
            Image i18 = new Image() { Url = "/Assets/CardImgs/018.png" };
            Image i19 = new Image() { Url = "/Assets/CardImgs/019.png" };
            Image i20 = new Image() { Url = "/Assets/CardImgs/020.png" };
            Image i21 = new Image() { Url = "/Assets/CardImgs/021.png" };
            Image i22 = new Image() { Url = "/Assets/CardImgs/022.png" };
            Image i23 = new Image() { Url = "/Assets/CardImgs/023.png" };
            Image i24 = new Image() { Url = "/Assets/CardImgs/024.png" };
            Image i25 = new Image() { Url = "/Assets/CardImgs/025.png" };
            Image i26 = new Image() { Url = "/Assets/CardImgs/026.png" };
            Image i27 = new Image() { Url = "/Assets/CardImgs/027.png" };
            Image i28 = new Image() { Url = "/Assets/CardImgs/028.png" };
            Image i29 = new Image() { Url = "/Assets/CardImgs/029.png" };
            Image i30 = new Image() { Url = "/Assets/CardImgs/030.png" };
            Image i31 = new Image() { Url = "/Assets/CardImgs/031.png" };
            Image i32 = new Image() { Url = "/Assets/CardImgs/032.png" };
            Image i33 = new Image() { Url = "/Assets/CardImgs/033.png" };
            Image i34 = new Image() { Url = "/Assets/CardImgs/034.png" };
            Image i35 = new Image() { Url = "/Assets/CardImgs/035.png" };
            Image i36 = new Image() { Url = "/Assets/CardImgs/036.png" };
            Image i37 = new Image() { Url = "/Assets/CardImgs/037.png" };
            Image i38 = new Image() { Url = "/Assets/CardImgs/038.png" };
            Image i39 = new Image() { Url = "/Assets/CardImgs/039.png" };
            Image i40 = new Image() { Url = "/Assets/CardImgs/040.png" };
            Image i41 = new Image() { Url = "/Assets/CardImgs/041.png" };
            Image i42 = new Image() { Url = "/Assets/CardImgs/042.png" };
            Image i43 = new Image() { Url = "/Assets/CardImgs/043.png" };
            Image i44 = new Image() { Url = "/Assets/CardImgs/044.png" };
            Image i45 = new Image() { Url = "/Assets/CardImgs/045.png" };
            Image i46 = new Image() { Url = "/Assets/CardImgs/046.png" };
            Image i47 = new Image() { Url = "/Assets/CardImgs/047.png" };
            Image i48 = new Image() { Url = "/Assets/CardImgs/048.png" };
            Image i49 = new Image() { Url = "/Assets/CardImgs/049.png" };
            Image i50 = new Image() { Url = "/Assets/CardImgs/050.png" };
            Image i51 = new Image() { Url = "/Assets/CardImgs/051.png" };
            Image i52 = new Image() { Url = "/Assets/CardImgs/052.png" };
            Image i53 = new Image() { Url = "/Assets/CardImgs/053.png" };
            Image i54 = new Image() { Url = "/Assets/CardImgs/054.png" };
            Image i55 = new Image() { Url = "/Assets/CardImgs/055.png" };
            Image i56 = new Image() { Url = "/Assets/CardImgs/056.png" };
            Image i57 = new Image() { Url = "/Assets/CardImgs/057.png" };
            Image i58 = new Image() { Url = "/Assets/CardImgs/058.png" };
            Image i59 = new Image() { Url = "/Assets/CardImgs/059.png" };
            Image i60 = new Image() { Url = "/Assets/CardImgs/060.png" };
            Image i61 = new Image() { Url = "/Assets/CardImgs/061.png" };
            Image i62 = new Image() { Url = "/Assets/CardImgs/062.png" };
            Image i63 = new Image() { Url = "/Assets/CardImgs/063.png" };
            Image i64 = new Image() { Url = "/Assets/CardImgs/064.png" };
            Image i65 = new Image() { Url = "/Assets/CardImgs/065.png" };
            Image i66 = new Image() { Url = "/Assets/CardImgs/066.png" };
            Image i67 = new Image() { Url = "/Assets/CardImgs/067.png" };
            Image i68 = new Image() { Url = "/Assets/CardImgs/068.png" };
            Image i69 = new Image() { Url = "/Assets/CardImgs/069.png" };
            Image i70 = new Image() { Url = "/Assets/CardImgs/070.png" };
            Image i71 = new Image() { Url = "/Assets/CardImgs/071.png" };
            Image i72 = new Image() { Url = "/Assets/CardImgs/072.png" };
            Image i73 = new Image() { Url = "/Assets/CardImgs/073.png" };
            Image i74 = new Image() { Url = "/Assets/CardImgs/074.png" };
            Image i75 = new Image() { Url = "/Assets/CardImgs/075.png" };
            Image i76 = new Image() { Url = "/Assets/CardImgs/076.png" };
            Image i77 = new Image() { Url = "/Assets/CardImgs/077.png" };
            Image i78 = new Image() { Url = "/Assets/CardImgs/078.png" };
            Image i79 = new Image() { Url = "/Assets/CardImgs/079.png" };
            Image i80 = new Image() { Url = "/Assets/CardImgs/080.png" };
            Image i81 = new Image() { Url = "/Assets/CardImgs/081.png" };
            Image i82 = new Image() { Url = "/Assets/CardImgs/082.png" };
            Image i83 = new Image() { Url = "/Assets/CardImgs/083.png" };
            Image i84 = new Image() { Url = "/Assets/CardImgs/084.png" };
            Image i85 = new Image() { Url = "/Assets/CardImgs/085.png" };
            Image i86 = new Image() { Url = "/Assets/CardImgs/086.png" };
            Image i87 = new Image() { Url = "/Assets/CardImgs/087.png" };
            Image i88 = new Image() { Url = "/Assets/CardImgs/088.png" };
            Image i89 = new Image() { Url = "/Assets/CardImgs/089.png" };
            Image i90 = new Image() { Url = "/Assets/CardImgs/090.png" };
            Image i91 = new Image() { Url = "/Assets/CardImgs/091.png" };
            Image i92 = new Image() { Url = "/Assets/CardImgs/092.png" };
            Image i93 = new Image() { Url = "/Assets/CardImgs/093.png" };
            Image i94 = new Image() { Url = "/Assets/CardImgs/094.png" };
            Image i95 = new Image() { Url = "/Assets/CardImgs/095.png" };
            Image i96 = new Image() { Url = "/Assets/CardImgs/096.png" };
            Image i97 = new Image() { Url = "/Assets/CardImgs/097.png" };
            Image i98 = new Image() { Url = "/Assets/CardImgs/098.png" };
            Image i99 = new Image() { Url = "/Assets/CardImgs/099.png" };
            Image i100 = new Image() { Url = "/Assets/CardImgs/100.png" };
            Image i101 = new Image() { Url = "/Assets/CardImgs/101.png" };
            Image i102 = new Image() { Url = "/Assets/CardImgs/102.png" };
            Image i103 = new Image() { Url = "/Assets/CardImgs/103.png" };
            Image i104 = new Image() { Url = "/Assets/CardImgs/104.png" };
            Image i105 = new Image() { Url = "/Assets/CardImgs/105.png" };
            Image i106 = new Image() { Url = "/Assets/CardImgs/106.png" };
            Image i107 = new Image() { Url = "/Assets/CardImgs/107.png" };
            Image i108 = new Image() { Url = "/Assets/CardImgs/108.png" };
            Image i109 = new Image() { Url = "/Assets/CardImgs/109.png" };
            Image i110 = new Image() { Url = "/Assets/CardImgs/110.png" };
            Image i111 = new Image() { Url = "/Assets/CardImgs/111.png" };
            Image i112 = new Image() { Url = "/Assets/CardImgs/112.png" };
            Image i113 = new Image() { Url = "/Assets/CardImgs/113.png" };
            Image i114 = new Image() { Url = "/Assets/CardImgs/114.png" };
            Image i115 = new Image() { Url = "/Assets/CardImgs/115.png" };
            Image i116 = new Image() { Url = "/Assets/CardImgs/116.png" };
            Image i117 = new Image() { Url = "/Assets/CardImgs/117.png" };
            Image i118 = new Image() { Url = "/Assets/CardImgs/118.png" };
            Image i119 = new Image() { Url = "/Assets/CardImgs/119.png" };
            Image i120 = new Image() { Url = "/Assets/CardImgs/120.png" };
            Image i121 = new Image() { Url = "/Assets/CardImgs/121.png" };
            Image i122 = new Image() { Url = "/Assets/CardImgs/122.png" };
            Image i123 = new Image() { Url = "/Assets/CardImgs/123.png" };
            Image i124 = new Image() { Url = "/Assets/CardImgs/124.png" };
            Image i125 = new Image() { Url = "/Assets/CardImgs/125.png" };
            Image i126 = new Image() { Url = "/Assets/CardImgs/126.png" };
            Image i127 = new Image() { Url = "/Assets/CardImgs/127.png" };
            Image i128 = new Image() { Url = "/Assets/CardImgs/128.png" };
            Image i129 = new Image() { Url = "/Assets/CardImgs/129.png" };
            Image i130 = new Image() { Url = "/Assets/CardImgs/130.png" };
            Image i131 = new Image() { Url = "/Assets/CardImgs/131.png" };
            Image i132 = new Image() { Url = "/Assets/CardImgs/132.png" };
            Image i133 = new Image() { Url = "/Assets/CardImgs/133.png" };
            Image i134 = new Image() { Url = "/Assets/CardImgs/134.png" };
            Image i135 = new Image() { Url = "/Assets/CardImgs/135.png" };
            Image i136 = new Image() { Url = "/Assets/CardImgs/136.png" };
            Image i137 = new Image() { Url = "/Assets/CardImgs/137.png" };
            Image i138 = new Image() { Url = "/Assets/CardImgs/138.png" };
            Image i139 = new Image() { Url = "/Assets/CardImgs/139.png" };
            Image i140 = new Image() { Url = "/Assets/CardImgs/140.png" };
            Image i141 = new Image() { Url = "/Assets/CardImgs/141.png" };
            Image i142 = new Image() { Url = "/Assets/CardImgs/142.png" };
            Image i143 = new Image() { Url = "/Assets/CardImgs/143.png" };
            Image i144 = new Image() { Url = "/Assets/CardImgs/144.png" };
            Image i145 = new Image() { Url = "/Assets/CardImgs/145.png" };
            Image i146 = new Image() { Url = "/Assets/CardImgs/146.png" };
            Image i147 = new Image() { Url = "/Assets/CardImgs/147.png" };
            Image i148 = new Image() { Url = "/Assets/CardImgs/148.png" };
            Image i149 = new Image() { Url = "/Assets/CardImgs/149.png" };
            Image i150 = new Image() { Url = "/Assets/CardImgs/150.png" };
            Image i151 = new Image() { Url = "/Assets/CardImgs/151.png" };

            //================================Starters Pokemons==================================
            Card c1 = new Card() { pkdxNum = 1, Name = "Bulbasaur", Description = "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.", SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common ,Market=true,Price=25 };
            Card c2 = new Card() { pkdxNum = 2, Name = "Ivysaur", Description = "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c3 = new Card() { pkdxNum = 3, Name = "Venusaur", Description = "Its plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c4 = new Card() { pkdxNum = 4, Name = "Charmander", Description = "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.", SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c5 = new Card() { pkdxNum = 5, Name = "Charmeleon", Description = "It has a barbaric nature. In battle, it whips its fiery tail around and slashes away with sharp claws.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c6 = new Card() { pkdxNum = 6, Name = "Charizard", Description = "It spits fire that is hot enough to melt boulders. It may cause forest fires by blowing flames.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c7 = new Card() { pkdxNum = 7, Name = "Squirtle", Description = "When it retracts its long neck into its shell, it squirts out water with vigorous force.", SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c8 = new Card() { pkdxNum = 8, Name = "Wartortle", Description = "It is recognized as a symbol of longevity. If its shell has algae on it, that Wartortle is very old.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c9 = new Card() { pkdxNum = 9, Name = "Blastoise", Description = "It crushes its foe under its heavy body to cause fainting. In a pinch, it will withdraw inside its shell.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c10 = new Card() { pkdxNum = 10, Name = "Caterpie", Description = "For protection, it releases a horrible stench from the antenna on its head to drive away enemies.", SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c11 = new Card() { pkdxNum = 11, Name = "Metapod", Description = "It is waiting for the moment to evolve. At this stage, it can only harden, so it remains motionless to avoid attack.", SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c12 = new Card() { pkdxNum = 12, Name = "Butterfree", Description = "In battle, it flaps its wings at great speed to release highly toxic dust into the air.", SerialNumber = 1, Attack = 4, Defence = 3, Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c13 = new Card() { pkdxNum = 13, Name = "Weedle", Description = "Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves.", SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c14 = new Card() { pkdxNum = 14, Name = "Kakuna", Description = "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy.", SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Rare, Price = 25 };
            Card c15 = new Card() { pkdxNum = 15, Name = "Beedrill", Description = "It has three poisonous stingers on its forelegs and its tail. They are used to jab its enemy repeatedly.", SerialNumber = 1, Attack = 4, Defence = 6, Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c16 = new Card() { pkdxNum = 16, Name = "Pidgey", Description = "Very docile. If attacked, it will often kick up sand to protect itself rather than fight back.", SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c17 = new Card() { pkdxNum = 17, Name = "Pidgeotto", Description = "This Pokémon is full of vitality. It constantly flies around its large territory in search of prey.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c18 = new Card() { pkdxNum = 18, Name = "Pidgeot", Description = "This Pokémon flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c19 = new Card() { pkdxNum = 19, Name = "Rattata", Description = "Will chew on anything with its fangs. If you see one, you can be certain that 40 more live in the area.", SerialNumber = 1, Attack = 2, Defence = 4, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c20 = new Card() { pkdxNum = 20, Name = "Raticate", Description = "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.", SerialNumber = 1, Attack = 4, Defence = 5, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c21 = new Card() { pkdxNum = 21, Name = "Spearow", Description = "Inept at flying high. However, it can fly around very fast to protect its territory.", SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c22 = new Card() { pkdxNum = 22, Name = "Fearow", Description = "A Pokémon that dates back many years. If it senses danger, it flies high and away, instantly.", SerialNumber = 1, Attack = 4, Defence = 6, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c23 = new Card() { pkdxNum = 23, Name = "Ekans", Description = "The older it gets, the longer it grows. At night, it wraps its long body around tree branches to rest.", SerialNumber = 1, Attack = 6, Defence = 5, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c24 = new Card() { pkdxNum = 24, Name = "Arbok", Description = "The frightening patterns on its belly have been studied. Six variations have been confirmed.", SerialNumber = 1, Attack = 6, Defence = 5, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c25 = new Card() { pkdxNum = 25, Name = "Pikachu", Description = "Pikachu that can generate powerful electricity have cheek sacs that are extra soft and super stretchy.", SerialNumber = 1, Attack = 4, Defence = 3, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c26 = new Card() { pkdxNum = 26, Name = "Raichu", Description = "Its long tail serves as a ground to protect itself from its own high-voltage power.", SerialNumber = 1, Attack = 6, Defence = 4, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c27 = new Card() { pkdxNum = 27, Name = "Sandshrew", Description = "It loves to bathe in the grit of dry, sandy areas. By sand bathing, the Pokémon rids itself of dirt and moisture clinging to its body.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c28 = new Card() { pkdxNum = 28, Name = "Sandslash", Description = "The drier the area Sandslash lives in, the harder and smoother the Pokémon’s spikes will feel when touched.", SerialNumber = 1, Attack = 6, Defence = 7, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c29 = new Card() { pkdxNum = 29, Name = "Nidoran", Description = "Females are more sensitive to smells than males. While foraging, they’ll use their whiskers to check wind direction and stay downwind of predators.", SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c30 = new Card() { pkdxNum = 30, Name = "Nidorina", Description = "The horn on its head has atrophied. It’s thought that this happens so Nidorina’s children won’t get poked while their mother is feeding them.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c31 = new Card() { pkdxNum = 31, Name = "Nidoqueen", Description = "Nidoqueen is better at defense than offense. With scales like armor, this Pokémon will shield its children from any kind of attack.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c32 = new Card() { pkdxNum = 32, Name = "Nidoran", Description = "The horn on a male Nidoran’s forehead contains a powerful poison. This is a very cautious Pokémon, always straining its large ears.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c33 = new Card() { pkdxNum = 33, Name = "Nidorino", Description = "With a horn that’s harder than diamond, this Pokémon goes around shattering boulders as it searches for a moon stone.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c34 = new Card() { pkdxNum = 34, Name = "Nidoking", Description = "When it goes on a rampage, it’s impossible to control. But in the presence of a Nidoqueen it’s lived with for a long time, Nidoking calms down.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c35 = new Card() { pkdxNum = 35, Name = "Clefairy", Description = "It is said that happiness will come to those who see a gathering of Clefairy dancing under a full moon.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c36 = new Card() { pkdxNum = 36, Name = "Clefable", Description = "A timid fairy Pokémon that is rarely seen, it will run and hide the moment it senses people.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c37 = new Card() { pkdxNum = 37, Name = "Vulpix", Description = "While young, it has six gorgeous tails. When it grows, several new tails are sprouted.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c38 = new Card() { pkdxNum = 38, Name = "Ninetales", Description = "It is said to live 1,000 years, and each of its tails is loaded with supernatural powers.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c39 = new Card() { pkdxNum = 39, Name = "Jigglypuff", Description = "Jigglypuff has top-notch lung capacity, even by comparison to other Pokémon. It won’t stop singing its lullabies until its foes fall asleep.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c40 = new Card() { pkdxNum = 40, Name = "Wigglytuff", Description = "The more air it takes in, the more it inflates. If opponents catch it in a bad mood, it will inflate itself to an enormous size to intimidate them.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c41 = new Card() { pkdxNum = 41, Name = "Zubat", Description = "It emits ultrasonic waves from its mouth to check its surroundings. Even in tight caves, Zubat flies around with skill.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c42 = new Card() { pkdxNum = 42, Name = "Golbat", Description = "It loves to drink other creatures’ blood. It’s said that if it finds others of its kind going hungry, it sometimes shares the blood it’s gathered.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c43 = new Card() { pkdxNum = 43, Name = "Oddish", Description = "If exposed to moonlight, it starts to move. It roams far and wide at night to scatter its seeds.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c44 = new Card() { pkdxNum = 44, Name = "Gloom", Description = "Its pistils exude an incredibly foul odor. The horrid stench can cause fainting at a distance of 1.25 miles.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c45 = new Card() { pkdxNum = 45, Name = "Vileplume", Description = "It has the world’s largest petals. With every step, the petals shake out heavy clouds of toxic pollen.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c46 = new Card() { pkdxNum = 46, Name = "Paras", Description = "Burrows under the ground to gnaw on tree roots. The mushrooms on its back absorb most of the nutrition.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c47 = new Card() { pkdxNum = 47, Name = "Rarasect", Description = "The bug host is drained of energy by the mushroom on its back. The mushroom appears to do all the thinking.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c48 = new Card() { pkdxNum = 48, Name = "Venonat", Description = "Its large eyes act as radar. In a bright place, you can see that they are clusters of many tiny eyes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c49 = new Card() { pkdxNum = 49, Name = "Venomoth", Description = "The powdery scales on its wings are hard to remove from skin. They also contain poison that leaks out on contact.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c50 = new Card() { pkdxNum = 50, Name = "Digglett", Description = "If a Diglett digs through a field, it leaves the soil perfectly tilled and ideal for planting crops.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c51 = new Card() { pkdxNum = 51, Name = "Dugtrio", Description = "A team of Diglett triplets. It triggers huge earthquakes by burrowing 60 miles underground.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c52 = new Card() { pkdxNum = 52, Name = "Meowth", Description = "It loves to collect shiny things. If it’s in a good mood, it might even let its Trainer have a look at its hoard of treasures.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c53 = new Card() { pkdxNum = 53, Name = "Persian", Description = "Getting this prideful Pokémon to warm up to you takes a lot of effort, and it will claw at you the moment it gets annoyed.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c54 = new Card() { pkdxNum = 54, Name = "Psyduck", Description = "Psyduck is constantly beset by headaches. If the Pokémon lets its strange power erupt, apparently the pain subsides for a while.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c55 = new Card() { pkdxNum = 55, Name = "Golduck", Description = "This Pokémon lives in gently flowing rivers. It paddles through the water with its long limbs, putting its graceful swimming skills on display.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c56 = new Card() { pkdxNum = 56, Name = "Mankey", Description = "An agile Pokémon that lives in trees. It angers easily and will not hesitate to attack anything.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c57 = new Card() { pkdxNum = 57, Name = "Primeape", Description = "It stops being angry only when nobody else is around. To view this moment is very difficult.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c58 = new Card() { pkdxNum = 58, Name = "Growlithe", Description = "It has a brave and trustworthy nature. It fearlessly stands up to bigger and stronger foes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c59 = new Card() { pkdxNum = 59, Name = "Arcanine", Description = "The sight of it running over 6,200 miles in a single day and night has captivated many people.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c60 = new Card() { pkdxNum = 60, Name = "Poliwag", Description = "For Poliwag, swimming is easier than walking. The swirl pattern on its belly is actually part of the Pokémon’s innards showing through the skin.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c61 = new Card() { pkdxNum = 61, Name = "Poliwhirl", Description = "Staring at the swirl on its belly causes drowsiness. This trait of Poliwhirl’s has been used in place of lullabies to get children to go to sleep.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c62 = new Card() { pkdxNum = 62, Name = "Poliwrath", Description = "Its body is solid muscle. When swimming through cold seas, Poliwrath uses its impressive arms to smash through drift ice and plow forward.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c63 = new Card() { pkdxNum = 63, Name = "Abra", Description = "This Pokémon uses its psychic powers while it sleeps. The contents of Abra’s dreams affect the powers that the Pokémon wields.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c64 = new Card() { pkdxNum = 64, Name = "Kadabra", Description = "Using its psychic power, Kadabra levitates as it sleeps. It uses its springy tail as a pillow.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c65 = new Card() { pkdxNum = 65, Name = "Alakazam", Description = "It has an incredibly high level of intelligence. Some say that Alakazam remembers everything that ever happens to it, from birth till death.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c66 = new Card() { pkdxNum = 66, Name = "Machop", Description = "Its whole body is composed of muscles. Even though it’s the size of a human child, it can hurl 100 grown-ups.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c67 = new Card() { pkdxNum = 67, Name = "Machoke", Description = "Its muscular body is so powerful, it must wear a power-save belt to be able to regulate its motions.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c68 = new Card() { pkdxNum = 68, Name = "Machamp", Description = "It quickly swings its four arms to rock its opponents with ceaseless punches and chops from all angles.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c69 = new Card() { pkdxNum = 69, Name = "Bellsprout", Description = "Prefers hot and humid places. It ensnares tiny bugs with its vines and devours them.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c70 = new Card() { pkdxNum = 70, Name = "Weepinbell", Description = "When hungry, it swallows anything that moves. Its hapless prey is dissolved by strong acids.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c71 = new Card() { pkdxNum = 71, Name = "Victreebel", Description = "Lures prey with the sweet aroma of honey. Swallowed whole, the prey is dissolved in a day, bones and all.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c72 = new Card() { pkdxNum = 72, Name = "Tentacool", Description = "Tentacool is not a particularly strong swimmer. It drifts across the surface of shallow seas as it searches for prey.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c73 = new Card() { pkdxNum = 73, Name = "Tentacruel", Description = "When the red orbs on Tentacruel’s head glow brightly, watch out. The Pokémon is about to fire off a burst of ultrasonic waves.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c74 = new Card() { pkdxNum = 74, Name = "Geodude", Description = "Commonly found near mountain trails and the like. If you step on one by accident, it gets angry.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c75 = new Card() { pkdxNum = 75, Name = "Graveler", Description = "Often seen rolling down mountain trails. Obstacles are just things to roll straight over, not avoid.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c76 = new Card() { pkdxNum = 76, Name = "Golem", Description = "Once it sheds its skin, its body turns tender and whitish. Its hide hardens when it’s exposed to air.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c77 = new Card() { pkdxNum = 77, Name = "Ponyta", Description = "It can’t run properly when it’s newly born. As it races around with others of its kind, its legs grow stronger.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c78 = new Card() { pkdxNum = 78, Name = "Rapidash", Description = "This Pokémon can be seen galloping through fields at speeds of up to 150 mph, its fiery mane fluttering in the wind.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c79 = new Card() { pkdxNum = 79, Name = "Slowpoke", Description = "Slow-witted and oblivious, this Pokémon won’t feel any pain if its tail gets eaten. It won’t notice when its tail grows back, either.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c80 = new Card() { pkdxNum = 80, Name = "Slowbro", Description = "Slowpoke became Slowbro when a Shellder bit on to its tail. Sweet flavors seeping from the tail make the Shellder feel as if its life is a dream.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c81 = new Card() { pkdxNum = 81, Name = "Magnemite", Description = "At times, Magnemite runs out of electricity and ends up on the ground. If you give batteries to a grounded Magnemite, it’ll start moving again.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c82 = new Card() { pkdxNum = 82, Name = "Magneton", Description = "This Pokémon is three Magnemite that have linked together. Magneton sends out powerful radio waves to study its surroundings.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c83 = new Card() { pkdxNum = 83, Name = "Farfetch'd", Description = "The stalk this Pokémon carries in its wings serves as a sword to cut down opponents. In a dire situation, the stalk can also serve as food.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c84 = new Card() { pkdxNum = 84, Name = "Doduo", Description = "Its short wings make flying difficult. Instead, this Pokémon runs at high speed on developed legs.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c85 = new Card() { pkdxNum = 85, Name = "Dodrio", Description = "One of Doduo’s two heads splits to form a unique species. It runs close to 40 mph in prairies.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c86 = new Card() { pkdxNum = 86, Name = "Seel", Description = "Loves freezing-cold conditions. Relishes swimming in a frigid climate of around 14 degrees Fahrenheit.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c87 = new Card() { pkdxNum = 87, Name = "Dewgong", Description = "Its entire body is a snowy white. Unharmed by even intense cold, it swims powerfully in icy waters.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c88 = new Card() { pkdxNum = 88, Name = "Grimer", Description = "Made of congealed sludge. It smells too putrid to touch. Even weeds won’t grow in its path.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c89 = new Card() { pkdxNum = 89, Name = "Muk", Description = "Smells so awful, it can cause fainting. Through degeneration of its nose, it lost its sense of smell.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c90 = new Card() { pkdxNum = 90, Name = "Shellder", Description = "It swims facing backward by opening and closing its two-piece shell. It is surprisingly fast.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c91 = new Card() { pkdxNum = 91, Name = "Cloyster", Description = "Its shell is extremely hard. It cannot be shattered, even with a bomb. The shell opens only when it is attacking.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c92 = new Card() { pkdxNum = 92, Name = "Gastly", Description = "Born from gases, anyone would faint if engulfed by its gaseous body, which contains poison.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c93 = new Card() { pkdxNum = 93, Name = "Haunter", Description = "Its tongue is made of gas. If licked, its victim starts shaking constantly until death eventually comes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c94 = new Card() { pkdxNum = 94, Name = "Gengar", Description = "On the night of a full moon, if shadows move on their own and laugh, it must be Gengar’s doing.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = true, Price = 25 };
            Card c95 = new Card() { pkdxNum = 95, Name = "Onix", Description = "As it digs through the ground, it absorbs many hard objects. This is what makes its body so solid.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c96 = new Card() { pkdxNum = 96, Name = "Drowzee", Description = "If you sleep by it all the time, it will sometimes show you dreams it had eaten in the past.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c97 = new Card() { pkdxNum = 97, Name = "Hypno", Description = "Avoid eye contact if you come across one. It will try to put you to sleep by using its pendulum.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c98 = new Card() { pkdxNum = 98, Name = "Krabby", Description = "It can be found near the sea. The large pincers grow back if they are torn out of their sockets.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c99 = new Card() { pkdxNum = 99, Name = "Kingler", Description = "Its large and hard pincer has 10,000-horsepower strength. However, being so big, it is unwieldy to move.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c100 = new Card() { pkdxNum = 100, Name = "Voltrob", Description = "It is said to camouflage itself as a Poké Ball. It will self-destruct with very little stimulus.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c101 = new Card() { pkdxNum = 101, Name = "Electrode", Description = "Stores electrical energy inside its body. Even the slightest shock could trigger a huge explosion.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c102 = new Card() { pkdxNum = 102, Name = "Exeggcute", Description = "Though it may look like it’s just a bunch of eggs, it’s a proper Pokémon. Exeggcute communicates with others of its kind via telepathy, apparently.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c103 = new Card() { pkdxNum = 103, Name = "Exeggutor", Description = "Each of Exeggutor’s three heads is thinking different thoughts. The three don’t seem to be very interested in one another.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c104 = new Card() { pkdxNum = 104, Name = "Cubone", Description = "When the memory of its departed mother brings it to tears, its cries echo mournfully within the skull it wears on its head.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c105 = new Card() { pkdxNum = 105, Name = "Marowak", Description = "This Pokémon overcame its sorrow to evolve a sturdy new body. Marowak faces its opponents bravely, using a bone as a weapon.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c106 = new Card() { pkdxNum = 106, Name = "Hitmonlee", Description = "This amazing Pokémon has an awesome sense of balance. It can kick in succession from any position.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c107 = new Card() { pkdxNum = 107, Name = "Hitmonchan", Description = "Its punches slice the air. They are launched at such high speed, even a slight graze could cause a burn.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c108 = new Card() { pkdxNum = 108, Name = "Lickitung", Description = "If this Pokémon’s sticky saliva gets on you and you don’t clean it off, an intense itch will set in. The itch won’t go away, either.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c109 = new Card() { pkdxNum = 109, Name = "Koffing", Description = "Its body is full of poisonous gas. It floats into garbage dumps, seeking out the fumes of raw, rotting trash.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c110 = new Card() { pkdxNum = 110, Name = "Weezing", Description = "It mixes gases between its two bodies. It’s said that these Pokémon were seen all over the Galar region back in the day.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c111 = new Card() { pkdxNum = 111, Name = "Rhyhorn", Description = "Strong, but not too bright, this Pokémon can shatter even a skyscraper with its charging tackles", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c112 = new Card() { pkdxNum = 112, Name = "Rhydon", Description = "It begins walking on its hind legs after evolution. It can punch holes through boulders with its horn.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c113 = new Card() { pkdxNum = 113, Name = "Chansey", Description = "The egg Chansey carries is not only delicious but also packed with nutrition. It’s used as a high-class cooking ingredient.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c114 = new Card() { pkdxNum = 114, Name = "Tangela", Description = "Hidden beneath a tangle of vines that grows nonstop even if the vines are torn off, this Pokémon’s true appearance remains a mystery.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c115 = new Card() { pkdxNum = 115, Name = "Kangaskhan", Description = "Although it’s carrying its baby in a pouch on its belly, Kangaskhan is swift on its feet. It intimidates its opponents with quick jabs.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c116 = new Card() { pkdxNum = 116, Name = "Horsea", Description = "Horsea makes its home in oceans with gentle currents. If this Pokémon is under attack, it spits out pitch-black ink and escapes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c117 = new Card() { pkdxNum = 117, Name = "Seadra", Description = "It’s the males that raise the offspring. While Seadra are raising young, the spines on their backs secrete thicker and stronger poison.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c118 = new Card() { pkdxNum = 118, Name = "Goldeen", Description = "Its dorsal, pectoral, and tail fins wave elegantly in water. That is why it is known as the Water Dancer.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c119 = new Card() { pkdxNum = 119, Name = "Seaking", Description = "In autumn, its body becomes more fatty in preparing to propose to a mate. It takes on beautiful colors.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c120 = new Card() { pkdxNum = 120, Name = "Staryu", Description = "If you visit a beach at the end of summer, you’ll be able to see groups of Staryu lighting up in a steady rhythm.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c121 = new Card() { pkdxNum = 121, Name = "Starmie", Description = "This Pokémon has an organ known as its core. The organ glows in seven colors when Starmie is unleashing its potent psychic powers.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c122 = new Card() { pkdxNum = 122, Name = "Mr.Mime", Description = "The broadness of its hands may be no coincidence—many scientists believe its palms became enlarged specifically for pantomiming.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c123 = new Card() { pkdxNum = 123, Name = "Scyther", Description = "As Scyther fights more and more battles, its scythes become sharper and sharper. With a single slice, Scyther can fell a massive tree.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c124 = new Card() { pkdxNum = 124, Name = "Jynx", Description = "In certain parts of Galar, Jynx was once feared and worshiped as the Queen of Ice.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c125 = new Card() { pkdxNum = 125, Name = "Electabuzz", Description = "Many power plants keep Ground-type Pokémon around as a defense against Electabuzz that come seeking electricity.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c126 = new Card() { pkdxNum = 126, Name = "Magmar", Description = "Magmar dispatches its prey with fire. But it regrets this habit once it realizes that it has burned its intended prey to a charred crisp.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c127 = new Card() { pkdxNum = 127, Name = "Pinsir", Description = "These Pokémon judge one another based on pincers. Thicker, more impressive pincers make for more popularity with the opposite gender.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c128 = new Card() { pkdxNum = 128, Name = "Tauros", Description = "When Tauros begins whipping itself with its tails, it’s a warning that the Pokémon is about to charge with astounding speed.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c129 = new Card() { pkdxNum = 129, Name = "Magikarp", Description = "It is virtually worthless in terms of both power and speed. It is the most weak and pathetic Pokémon in the world.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c130 = new Card() { pkdxNum = 130, Name = "Gyarados", Description = "It has an extremely aggressive nature. The Hyper Beam it shoots from its mouth totally incinerates all targets.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = true, Price = 25 };
            Card c131 = new Card() { pkdxNum = 131, Name = "Lapras", Description = "A smart and kindhearted Pokémon, it glides across the surface of the sea while its beautiful song echoes around it.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c132 = new Card() { pkdxNum = 132, Name = "Ditto", Description = "It can reconstitute its entire cellular structure to change into what it sees, but it returns to normal when it relaxes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c133 = new Card() { pkdxNum = 133, Name = "Eevee", Description = "It has the ability to alter the composition of its body to suit its surrounding environment.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = true, Price = 25 };
            Card c134 = new Card() { pkdxNum = 134, Name = "Vaporeon", Description = "When Vaporeon’s fins begin to vibrate, it is a sign that rain will come within a few hours.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c135 = new Card() { pkdxNum = 135, Name = "Jolteon", Description = "If it is angered or startled, the fur all over its body bristles like sharp needles that pierce foes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c136 = new Card() { pkdxNum = 136, Name = "Flareon", Description = "Once it has stored up enough heat, this Pokémon’s body temperature can reach up to 1,700 degrees Fahrenheit.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c137 = new Card() { pkdxNum = 137, Name = "Porygon", Description = "State-of-the-art technology was used to create Porygon. It was the first artificial Pokémon to be created via computer programming.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c138 = new Card() { pkdxNum = 138, Name = "Omanyte", Description = "Because some Omanyte manage to escape after being restored or are released into the wild by people, this species is becoming a problem.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c139 = new Card() { pkdxNum = 139, Name = "Omastar", Description = "Weighed down by a large and heavy shell, Omastar couldn’t move very fast. Some say it went extinct because it was unable to catch food.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c140 = new Card() { pkdxNum = 140, Name = "Kabuto", Description = "This species is almost entirely extinct. Kabuto molt every three days, making their shells harder and harder.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c141 = new Card() { pkdxNum = 141, Name = "Kabutops", Description = "Kabutops slices its prey apart and sucks out the fluids. The discarded body parts become food for other Pokémon.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c142 = new Card() { pkdxNum = 142, Name = "Aerodactyl", Description = "This is a ferocious Pokémon from ancient times. Apparently even modern technology is incapable of producing a perfectly restored specimen.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c143 = new Card() { pkdxNum = 143, Name = "Snorlax", Description = "It is not satisfied unless it eats over 880 pounds of food every day. When it is done eating, it goes promptly to sleep.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c144 = new Card() { pkdxNum = 144, Name = "Articuno", Description = "It’s said that this Pokémon’s beautiful blue wings are made of ice. Articuno flies over snowy mountains, its long tail fluttering along behind it.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = true, Price = 25 };
            Card c145 = new Card() { pkdxNum = 145, Name = "Zapdos", Description = "This Pokémon has complete control over electricity. There are tales of Zapdos nesting in the dark depths of pitch-black thunderclouds.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = true, Price = 25 };
            Card c146 = new Card() { pkdxNum = 146, Name = "Moltres", Description = "It’s one of the legendary bird Pokémon. When Moltres flaps its flaming wings, they glimmer with a dazzling red glow.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = true, Price = 25 };
            Card c147 = new Card() { pkdxNum = 147, Name = "Dratini", Description = "Dratini dwells near bodies of rapidly flowing water, such as the plunge pools of waterfalls. As it grows, Dratini will shed its skin many times.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = true, Price = 25 };
            Card c148 = new Card() { pkdxNum = 148, Name = "Dragonair", Description = "This Pokémon lives in pristine oceans and lakes. It can control the weather, and it uses this power to fly into the sky, riding on the wind.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = true, Price = 25 };
            Card c149 = new Card() { pkdxNum = 149, Name = "Dragonite", Description = "It’s a kindhearted Pokémon. If it spots a drowning person or Pokémon, Dragonite simply must help them.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = true, Price = 25 };
            Card c150 = new Card() { pkdxNum = 150, Name = "Mewtwo", Description = "Its DNA is almost the same as Mew’s. However, its size and disposition are vastly different.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = true, Price = 25 };
            Card c151 = new Card() { pkdxNum = 151, Name = "Mew", Description = "When viewed through a microscope, this Pokémon’s short, fine, delicate hair can be seen.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = true, Price = 25 };

            i1.Cards = new List<Card>() { c1 };
            i2.Cards = new List<Card>() { c2 };
            i3.Cards = new List<Card>() { c3 };
            i4.Cards = new List<Card>() { c4 };
            i5.Cards = new List<Card>() { c5 };
            i6.Cards = new List<Card>() { c6 };
            i7.Cards = new List<Card>() { c7 };
            i8.Cards = new List<Card>() { c8 };
            i9.Cards = new List<Card>() { c9 };
            i10.Cards = new List<Card>() { c10 };
            i11.Cards = new List<Card>() { c11 };
            i12.Cards = new List<Card>() { c12 };
            i13.Cards = new List<Card>() { c13 };
            i14.Cards = new List<Card>() { c14 };
            i15.Cards = new List<Card>() { c15 };
            i16.Cards = new List<Card>() { c16 };
            i17.Cards = new List<Card>() { c17 };
            i18.Cards = new List<Card>() { c18 };
            i19.Cards = new List<Card>() { c19 };
            i20.Cards = new List<Card>() { c20 };
            i21.Cards = new List<Card>() { c21 };
            i22.Cards = new List<Card>() { c22 };
            i23.Cards = new List<Card>() { c23 };
            i24.Cards = new List<Card>() { c24 };
            i25.Cards = new List<Card>() { c25 };
            i26.Cards = new List<Card>() { c26 };
            i27.Cards = new List<Card>() { c27 };
            i28.Cards = new List<Card>() { c28 };
            i29.Cards = new List<Card>() { c29 };
            i30.Cards = new List<Card>() { c30 };
            i31.Cards = new List<Card>() { c31 };
            i32.Cards = new List<Card>() { c32 };
            i33.Cards = new List<Card>() { c33 };
            i34.Cards = new List<Card>() { c34 };
            i35.Cards = new List<Card>() { c35 };
            i36.Cards = new List<Card>() { c36 };
            i37.Cards = new List<Card>() { c37 };
            i38.Cards = new List<Card>() { c38 };
            i39.Cards = new List<Card>() { c39 };
            i40.Cards = new List<Card>() { c40 };
            i41.Cards = new List<Card>() { c41 };
            i42.Cards = new List<Card>() { c42 };
            i43.Cards = new List<Card>() { c43 };
            i44.Cards = new List<Card>() { c44 };
            i45.Cards = new List<Card>() { c45 };
            i46.Cards = new List<Card>() { c46 };
            i47.Cards = new List<Card>() { c47 };
            i48.Cards = new List<Card>() { c48 };
            i49.Cards = new List<Card>() { c49 };
            i50.Cards = new List<Card>() { c50 };
            i51.Cards = new List<Card>() { c51 };
            i52.Cards = new List<Card>() { c52 };
            i53.Cards = new List<Card>() { c53 };
            i54.Cards = new List<Card>() { c54 };
            i55.Cards = new List<Card>() { c55 };
            i56.Cards = new List<Card>() { c56 };
            i57.Cards = new List<Card>() { c57 };
            i58.Cards = new List<Card>() { c58 };
            i59.Cards = new List<Card>() { c59 };
            i60.Cards = new List<Card>() { c60 };
            i61.Cards = new List<Card>() { c61 };
            i62.Cards = new List<Card>() { c62 };
            i63.Cards = new List<Card>() { c63 };
            i64.Cards = new List<Card>() { c64 };
            i65.Cards = new List<Card>() { c65 };
            i66.Cards = new List<Card>() { c66 };
            i67.Cards = new List<Card>() { c67 };
            i68.Cards = new List<Card>() { c68 };
            i69.Cards = new List<Card>() { c69 };
            i70.Cards = new List<Card>() { c70 };
            i71.Cards = new List<Card>() { c71 };
            i72.Cards = new List<Card>() { c72 };
            i73.Cards = new List<Card>() { c73 };
            i74.Cards = new List<Card>() { c74 };
            i75.Cards = new List<Card>() { c75 };
            i76.Cards = new List<Card>() { c76 };
            i77.Cards = new List<Card>() { c77 };
            i78.Cards = new List<Card>() { c78 };
            i79.Cards = new List<Card>() { c79 };
            i80.Cards = new List<Card>() { c80 };
            i81.Cards = new List<Card>() { c81 };
            i82.Cards = new List<Card>() { c82 };
            i83.Cards = new List<Card>() { c83 };
            i84.Cards = new List<Card>() { c84 };
            i85.Cards = new List<Card>() { c85 };
            i86.Cards = new List<Card>() { c86 };
            i87.Cards = new List<Card>() { c87 };
            i88.Cards = new List<Card>() { c88 };
            i89.Cards = new List<Card>() { c89 };
            i90.Cards = new List<Card>() { c90 };
            i91.Cards = new List<Card>() { c91 };
            i92.Cards = new List<Card>() { c92 };
            i93.Cards = new List<Card>() { c93 };
            i94.Cards = new List<Card>() { c94 };
            i95.Cards = new List<Card>() { c95 };
            i96.Cards = new List<Card>() { c96 };
            i97.Cards = new List<Card>() { c97 };
            i98.Cards = new List<Card>() { c98 };
            i99.Cards = new List<Card>() { c99 };
            i100.Cards = new List<Card>() { c100 };
            i101.Cards = new List<Card>() { c101 };
            i102.Cards = new List<Card>() { c102 };
            i103.Cards = new List<Card>() { c103 };
            i104.Cards = new List<Card>() { c104 };
            i105.Cards = new List<Card>() { c105 };
            i106.Cards = new List<Card>() { c106 };
            i107.Cards = new List<Card>() { c107 };
            i108.Cards = new List<Card>() { c108 };
            i109.Cards = new List<Card>() { c109 };
            i110.Cards = new List<Card>() { c110 };
            i111.Cards = new List<Card>() { c111 };
            i112.Cards = new List<Card>() { c112 };
            i113.Cards = new List<Card>() { c113 };
            i114.Cards = new List<Card>() { c114 };
            i115.Cards = new List<Card>() { c115 };
            i116.Cards = new List<Card>() { c116 };
            i117.Cards = new List<Card>() { c117 };
            i118.Cards = new List<Card>() { c118 };
            i119.Cards = new List<Card>() { c119 };
            i120.Cards = new List<Card>() { c120 };
            i121.Cards = new List<Card>() { c121 };
            i122.Cards = new List<Card>() { c122 };
            i123.Cards = new List<Card>() { c123 };
            i124.Cards = new List<Card>() { c124 };
            i125.Cards = new List<Card>() { c125 };
            i126.Cards = new List<Card>() { c126 };
            i127.Cards = new List<Card>() { c127 };
            i128.Cards = new List<Card>() { c128 };
            i129.Cards = new List<Card>() { c129 };
            i130.Cards = new List<Card>() { c130 };
            i131.Cards = new List<Card>() { c131 };
            i132.Cards = new List<Card>() { c132 };
            i133.Cards = new List<Card>() { c133 };
            i134.Cards = new List<Card>() { c134 };
            i135.Cards = new List<Card>() { c135 };
            i136.Cards = new List<Card>() { c136 };
            i137.Cards = new List<Card>() { c137 };
            i138.Cards = new List<Card>() { c138 };
            i139.Cards = new List<Card>() { c139 };
            i140.Cards = new List<Card>() { c140 };
            i141.Cards = new List<Card>() { c141 };
            i142.Cards = new List<Card>() { c142 };
            i143.Cards = new List<Card>() { c143 };
            i144.Cards = new List<Card>() { c144 };
            i145.Cards = new List<Card>() { c145 };
            i146.Cards = new List<Card>() { c146 };
            i147.Cards = new List<Card>() { c147 };
            i148.Cards = new List<Card>() { c148 };
            i149.Cards = new List<Card>() { c149 };
            i150.Cards = new List<Card>() { c150 };
            i151.Cards = new List<Card>() { c151 };

            //var bugs     = new List<Card>() { c10, c11, c12, c13, c14, c15, c46, c47, c48, c49, c123, c127 };
            //var dragons  = new List<Card>() { c147, c148, c149 };
            //var electric = new List<Card>() { c25, c26, c81, c82, c100, c101, c125, c135, c145 };
            //var fight    = new List<Card>() { c56, c57, c62, c66, c67, c68, c106, c107 };
            //var fire     = new List<Card>() { c4, c5, c6, c37, c38, c58, c59, c77, c78, c126, c136, c146 };
            //var flying   = new List<Card>() { c6, c12, c16, c17, c18, c21, c22, c41, c42, c83, c84, c85, c123, c130, c142, c144, c145, c146, c149 };
            //var ghost    = new List<Card>() { c92, c93, c94 };
            //var grass    = new List<Card>() { c1, c2, c3, c43, c44, c45, c46, c47, c69, c70, c71, c102, c103, c114 };
            //var ground   = new List<Card>() { c27, c28, c31, c34, c50, c51, c74, c75, c76, c95, c104, c105, c111, c112 };
            //var ice      = new List<Card>() { c87, c91, c124, c131, c144 };
            //var normal   = new List<Card>() { c16, c17, c18, c19, c20, c21, c22,c35,c36, c39, c40, c52, c53, c83, c84, c85, c108, c113, c115, c128, c132, c133, c137, c143 };
            //var poison   = new List<Card>() { c1, c2, c3, c13, c14, c15, c23, c24, c29, c30, c31, c32, c33, c34, c41, c42, c43, c44, c45, c48, c49, c69, c70, c71, c72, c73, c88, c89, c92, c93, c94, c109, c110 };
            //var psychic  = new List<Card>() { c63, c64, c65, c79, c65, c79, c80, c96, c97, c102, c103, c121, c122, c124, c150, c151 };
            //var rock     = new List<Card>() { c74, c75, c76, c95, c111, c112, c138, c139, c140, c141, c142 };
            //var water    = new List<Card>() { c7, c8, c9, c54, c55, c60, c61, c62, c72, c73, c79, c80, c86, c87, c90, c91, c98, c99, c116, c117, c118, c119, c120, c121, c129, c130, c131, c134, c138, c139, c140, c141 };

            bug1.Cards = new List<Card>() { c10, c11, c12, c13, c14, c15, c46, c47, c48, c49, c123, c127 };
            drg2.Cards = new List<Card>() { c147, c148, c149 };
            elc3.Cards = new List<Card>() { c25, c26, c81, c82, c100, c101, c125, c135, c145 };
            fgh4.Cards = new List<Card>() { c56, c57, c62, c66, c67, c68, c106, c107 };
            fr5.Cards = new List<Card>() { c4, c5, c6, c37, c38, c58, c59, c77, c78, c126, c136, c146 };
            fly6.Cards = new List<Card>() { c6, c12, c16, c17, c18, c21, c22, c41, c42, c83, c84, c85, c123, c130, c142, c144, c145, c146, c149 };
            gh7.Cards = new List<Card>() { c92, c93, c94 };
            gras8.Cards = new List<Card>() { c1, c2, c3, c43, c44, c45, c46, c47, c69, c70, c71, c102, c103, c114 };
            grd9.Cards = new List<Card>() { c27, c28, c31, c34, c50, c51, c74, c75, c76, c95, c104, c105, c111, c112 };
            ice10.Cards = new List<Card>() { c87, c91, c124, c131, c144 };
            norm11.Cards = new List<Card>() { c16, c17, c18, c19, c20, c21, c22, c35, c36, c39, c40, c52, c53, c83, c84, c85, c108, c113, c115, c128, c132, c133, c137, c143 };
            psn12.Cards = new List<Card>() { c1, c2, c3, c13, c14, c15, c23, c24, c29, c30, c31, c32, c33, c34, c41, c42, c43, c44, c45, c48, c49, c69, c70, c71, c72, c73, c88, c89, c92, c93, c94, c109, c110 };
            psy13.Cards = new List<Card>() { c63, c64, c65, c79, c65, c79, c80, c96, c97, c102, c103, c121, c122, c124, c150, c151 };
            roc14.Cards = new List<Card>() { c74, c75, c76, c95, c111, c112, c138, c139, c140, c141, c142 };
            wat15.Cards = new List<Card>() { c7, c8, c9, c54, c55, c60, c61, c62, c72, c73, c79, c80, c86, c87, c90, c91, c98, c99, c116, c117, c118, c119, c120, c121, c129, c130, c131, c134, c138, c139, c140, c141 };


            c1.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c2.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c3.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c4.PokemonTypes = new List<PokemonType>() { fr5 };
            c5.PokemonTypes = new List<PokemonType>() { fr5 };
            c6.PokemonTypes = new List<PokemonType>() { fr5, fly6 };
            c7.PokemonTypes = new List<PokemonType>() { wat15 };
            c8.PokemonTypes = new List<PokemonType>() { wat15 };
            c9.PokemonTypes = new List<PokemonType>() { wat15 };
            c10.PokemonTypes = new List<PokemonType>() { bug1 };
            c11.PokemonTypes = new List<PokemonType>() { bug1 };
            c12.PokemonTypes = new List<PokemonType>() { bug1, fly6 };
            c13.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
            c14.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
            c15.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
            c16.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
            c17.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
            c18.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
            c19.PokemonTypes = new List<PokemonType>() { norm11 };
            c20.PokemonTypes = new List<PokemonType>() { norm11 };
            c21.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
            c22.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
            c23.PokemonTypes = new List<PokemonType>() { psn12 };
            c24.PokemonTypes = new List<PokemonType>() { psn12 };
            c25.PokemonTypes = new List<PokemonType>() { elc3 };
            c26.PokemonTypes = new List<PokemonType>() { elc3 };
            c27.PokemonTypes = new List<PokemonType>() { grd9 };
            c28.PokemonTypes = new List<PokemonType>() { grd9 };
            c29.PokemonTypes = new List<PokemonType>() { psn12 };
            c30.PokemonTypes = new List<PokemonType>() { psn12 };
            c31.PokemonTypes = new List<PokemonType>() { psn12, grd9 };
            c32.PokemonTypes = new List<PokemonType>() { psn12 };
            c33.PokemonTypes = new List<PokemonType>() { psn12 };
            c34.PokemonTypes = new List<PokemonType>() { psn12, grd9 };
            c35.PokemonTypes = new List<PokemonType>() { norm11 };
            c36.PokemonTypes = new List<PokemonType>() { norm11 };
            c37.PokemonTypes = new List<PokemonType>() { fr5 };
            c38.PokemonTypes = new List<PokemonType>() { fr5 };
            c39.PokemonTypes = new List<PokemonType>() { norm11 };
            c40.PokemonTypes = new List<PokemonType>() { norm11 };
            c41.PokemonTypes = new List<PokemonType>() { psn12, fly6 };
            c42.PokemonTypes = new List<PokemonType>() { psn12, fly6 };
            c43.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c44.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c45.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c46.PokemonTypes = new List<PokemonType>() { bug1, gras8 };
            c47.PokemonTypes = new List<PokemonType>() { bug1, gras8 };
            c48.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
            c49.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
            c50.PokemonTypes = new List<PokemonType>() { grd9 };
            c51.PokemonTypes = new List<PokemonType>() { grd9 };
            c52.PokemonTypes = new List<PokemonType>() { norm11 };
            c53.PokemonTypes = new List<PokemonType>() { norm11 };
            c54.PokemonTypes = new List<PokemonType>() { wat15 };
            c55.PokemonTypes = new List<PokemonType>() { wat15 };
            c56.PokemonTypes = new List<PokemonType>() { fgh4 };
            c57.PokemonTypes = new List<PokemonType>() { fgh4 };
            c58.PokemonTypes = new List<PokemonType>() { fr5 };
            c59.PokemonTypes = new List<PokemonType>() { fr5 };
            c60.PokemonTypes = new List<PokemonType>() { wat15 };
            c61.PokemonTypes = new List<PokemonType>() { wat15 };
            c62.PokemonTypes = new List<PokemonType>() { wat15, fgh4 };
            c63.PokemonTypes = new List<PokemonType>() { psy13 };
            c64.PokemonTypes = new List<PokemonType>() { psy13 };
            c65.PokemonTypes = new List<PokemonType>() { psy13 };
            c66.PokemonTypes = new List<PokemonType>() { fgh4 };
            c67.PokemonTypes = new List<PokemonType>() { fgh4 };
            c68.PokemonTypes = new List<PokemonType>() { fgh4 };
            c69.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c70.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c71.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
            c72.PokemonTypes = new List<PokemonType>() { wat15, psn12 };
            c73.PokemonTypes = new List<PokemonType>() { wat15, psn12 };
            c74.PokemonTypes = new List<PokemonType>() { roc14, grd9 };
            c75.PokemonTypes = new List<PokemonType>() { roc14, grd9 };
            c76.PokemonTypes = new List<PokemonType>() { roc14, grd9 };
            c77.PokemonTypes = new List<PokemonType>() { fr5 };
            c78.PokemonTypes = new List<PokemonType>() { fr5 };
            c79.PokemonTypes = new List<PokemonType>() { wat15, psy13 };
            c80.PokemonTypes = new List<PokemonType>() { wat15, psy13 };
            c81.PokemonTypes = new List<PokemonType>() { elc3 };
            c82.PokemonTypes = new List<PokemonType>() { elc3 };
            c83.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
            c84.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
            c85.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
            c86.PokemonTypes = new List<PokemonType>() { wat15 };
            c87.PokemonTypes = new List<PokemonType>() { wat15, ice10 };
            c88.PokemonTypes = new List<PokemonType>() { psn12 };
            c89.PokemonTypes = new List<PokemonType>() { psn12 };
            c90.PokemonTypes = new List<PokemonType>() { wat15 };
            c91.PokemonTypes = new List<PokemonType>() { wat15, ice10 };
            c92.PokemonTypes = new List<PokemonType>() { gh7, psn12 };
            c93.PokemonTypes = new List<PokemonType>() { gh7, psn12 };
            c94.PokemonTypes = new List<PokemonType>() { gh7, psn12 };
            c95.PokemonTypes = new List<PokemonType>() { roc14, grd9 };
            c96.PokemonTypes = new List<PokemonType>() { psy13 };
            c97.PokemonTypes = new List<PokemonType>() { psy13 };
            c98.PokemonTypes = new List<PokemonType>() { wat15 };
            c99.PokemonTypes = new List<PokemonType>() { wat15 };
            c100.PokemonTypes = new List<PokemonType>() { elc3 };
            c101.PokemonTypes = new List<PokemonType>() { elc3 };
            c102.PokemonTypes = new List<PokemonType>() { gras8, psy13 };
            c103.PokemonTypes = new List<PokemonType>() { gras8, psy13 };
            c104.PokemonTypes = new List<PokemonType>() { grd9 };
            c105.PokemonTypes = new List<PokemonType>() { grd9 };
            c106.PokemonTypes = new List<PokemonType>() { fgh4 };
            c107.PokemonTypes = new List<PokemonType>() { fgh4 };
            c108.PokemonTypes = new List<PokemonType>() { norm11 };
            c109.PokemonTypes = new List<PokemonType>() { psn12 };
            c110.PokemonTypes = new List<PokemonType>() { psn12 };
            c111.PokemonTypes = new List<PokemonType>() { grd9, roc14 };
            c112.PokemonTypes = new List<PokemonType>() { grd9, roc14 };
            c113.PokemonTypes = new List<PokemonType>() { norm11 };
            c114.PokemonTypes = new List<PokemonType>() { gras8 };
            c115.PokemonTypes = new List<PokemonType>() { norm11 };
            c116.PokemonTypes = new List<PokemonType>() { wat15 };
            c117.PokemonTypes = new List<PokemonType>() { wat15 };
            c118.PokemonTypes = new List<PokemonType>() { wat15 };
            c119.PokemonTypes = new List<PokemonType>() { wat15 };
            c120.PokemonTypes = new List<PokemonType>() { wat15 };
            c121.PokemonTypes = new List<PokemonType>() { wat15, psy13 };
            c122.PokemonTypes = new List<PokemonType>() { psy13 };
            c123.PokemonTypes = new List<PokemonType>() { bug1, fly6 };
            c124.PokemonTypes = new List<PokemonType>() { ice10, psy13 };
            c125.PokemonTypes = new List<PokemonType>() { elc3 };
            c126.PokemonTypes = new List<PokemonType>() { fr5 };
            c127.PokemonTypes = new List<PokemonType>() { bug1 };
            c128.PokemonTypes = new List<PokemonType>() { norm11 };
            c129.PokemonTypes = new List<PokemonType>() { wat15 };
            c130.PokemonTypes = new List<PokemonType>() { wat15, fly6 };
            c131.PokemonTypes = new List<PokemonType>() { wat15, ice10 };
            c132.PokemonTypes = new List<PokemonType>() { norm11 };
            c133.PokemonTypes = new List<PokemonType>() { norm11 };
            c134.PokemonTypes = new List<PokemonType>() { wat15 };
            c135.PokemonTypes = new List<PokemonType>() { elc3 };
            c136.PokemonTypes = new List<PokemonType>() { fr5 };
            c137.PokemonTypes = new List<PokemonType>() { norm11 };
            c138.PokemonTypes = new List<PokemonType>() { roc14, wat15 };
            c139.PokemonTypes = new List<PokemonType>() { roc14, wat15 };
            c140.PokemonTypes = new List<PokemonType>() { roc14, wat15 };
            c141.PokemonTypes = new List<PokemonType>() { roc14, wat15 };
            c142.PokemonTypes = new List<PokemonType>() { roc14, fly6 };
            c143.PokemonTypes = new List<PokemonType>() { norm11 };
            c144.PokemonTypes = new List<PokemonType>() { ice10, fly6 };
            c145.PokemonTypes = new List<PokemonType>() { elc3, fly6 };
            c146.PokemonTypes = new List<PokemonType>() { fr5, fly6 };
            c147.PokemonTypes = new List<PokemonType>() { drg2 };
            c148.PokemonTypes = new List<PokemonType>() { drg2 };
            c149.PokemonTypes = new List<PokemonType>() { drg2, fly6 };
            c150.PokemonTypes = new List<PokemonType>() { psy13 };
            c151.PokemonTypes = new List<PokemonType>() { psy13 };

            var cards = new List<Card>() {
                 c1, c2, c3, c4, c5, c6, c7, c8, c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23,c24,c25,c26,c27,c28,c29,c30,
                 c31,c32,c33,c34,c35,c36,c37,c38,c39,c40,c41,c42,c43,c44,c45,c46,c47,c48,c49,c50,c51,c52,c53,c54,c55,c56,c57,c58,c59,c60,
                 c61,c62,c63,c64,c65,c66,c67,c68,c69,c70,c71,c72,c73,c74,c75,c76,c77,c78,c79,c80,c81,c82,c83,c84,c85,c86,c87,c88,c89,c90,
                 c91,c92,c93,c94,c95,c96,c97,c98,c99,c100,c101,c102,c103,c104,c105,c106,c107,c108,c109,c110,c111,c112,c113,c114,c115,c116,
                 c117,c118,c119,c120,c121,c122,c123,c124,c125,c126,c127,c128,c129,c130,c131,c132,c133,c134,c135,c136,c137,c138,c139,c140,c141,
                 c142,c143,c144,c145,c146,c147,c148,c149,c150,c151
            };

            var pokemonTypes = new List<PokemonType>() {
                bug1,drg2,elc3,fgh4,fr5,fly6 ,gh7 ,gras8,
                grd9 ,ice10,norm11,psn12,psy13,roc14,wat15
            };

            var images = new List<Image>() {
                i1, i2, i3, i4, i5, i6, i7, i8, i9,i10,i11,i12,i13,i14,i15,i16,i17,i18,i19,i20,i21,i22,i23,i24,i25,i26,i27,i28,i29,i30,
                i31,i32,i33,i34,i35,i36,i37,i38,i39,i40,i41,i42,i43,i44,i45,i46,i47,i48,i49,i50,i51,i52,i53,i54,i55,i56,i57,i58,i59,i60,
                i61,i62,i63,i64,i65,i66,i67,i68,i69,i70,i71,i72,i73,i74,i75,i76,i77,i78,i79,i80,i81,i82,i83,i84,i85,i86,i87,i88,i89,i90,
                i91,i92,i93,i94,i95,i96,i97,i98,i99,i100,i101,i102,i103,i104,i105,i106,i107,i108,i109,i110,i111,i112,i113,i114,i115,i116,
                i117,i118,i119,i120,i121,i122,i123,i124,i125,i126,i127,i128,i129,i130,i131,i132,i133,i134,i135,i136,i137,i138,i139,i140,i141,
                i142,i143,i144,i145,i146,i147,i148,i149,i150,i151
            };

            //================================= Common Cards  ================================
            for (int i = 1; i < 50; i++)
            {
                Card comn1 = new Card() { pkdxNum = 1, Name = "Bulbasaur", Description = "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.", SerialNumber = i + 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, Market=false };
                Card comn4 = new Card() { pkdxNum = 4, Name = "Charmander", Description = "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.", SerialNumber = i + 1, Attack = 3, Defence = 4, Rarity = Rarity.Common, Market = false };
                Card comn7 = new Card() { pkdxNum = 7, Name = "Squirtle", Description = "When it retracts its long neck into its shell, it squirts out water with vigorous force.", SerialNumber = i + 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, Market = false };
                Card comn10 = new Card() { pkdxNum = 10, Name = "Caterpie", Description = "For protection, it releases a horrible stench from the antenna on its head to drive away enemies.", SerialNumber = i + 1, Attack = 3, Defence = 2, Rarity = Rarity.Common, Market = false };
                Card comn13 = new Card() { pkdxNum = 13, Name = "Weedle", Description = "Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves.", SerialNumber = i + 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, Market = false };
                Card comn16 = new Card() { pkdxNum = 16, Name = "Pidgey", Description = "Very docile. If attacked, it will often kick up sand to protect itself rather than fight back.", SerialNumber = i + 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, Market = false };
                Card comn19 = new Card() { pkdxNum = 19, Name = "Rattata", Description = "Will chew on anything with its fangs. If you see one, you can be certain that 40 more live in the area.", SerialNumber = i + 1, Attack = 2, Defence = 4, Rarity = Rarity.Common, Market = false };
                Card comn21 = new Card() { pkdxNum = 21, Name = "Spearow", Description = "Inept at flying high. However, it can fly around very fast to protect its territory.", SerialNumber = i + 1, Attack = 3, Defence = 4, Rarity = Rarity.Common, Market = false };
                Card comn23 = new Card() { pkdxNum = 23, Name = "Ekans", Description = "The older it gets, the longer it grows. At night, it wraps its long body around tree branches to rest.", SerialNumber = i + 1, Attack = 6, Defence = 5, Rarity = Rarity.Common, Market = false };
                Card comn25 = new Card() { pkdxNum = 25, Name = "Pikachu", Description = "Pikachu that can generate powerful electricity have cheek sacs that are extra soft and super stretchy.", SerialNumber = i + 1, Attack = 4, Defence = 3, Rarity = Rarity.Common, Market = false };
                Card comn27 = new Card() { pkdxNum = 27, Name = "Sandshrew", Description = "It loves to bathe in the grit of dry, sandy areas. By sand bathing, the Pokémon rids itself of dirt and moisture clinging to its body.", SerialNumber = i + 1, Attack = 5, Defence = 5, Rarity = Rarity.Common, Market = false };
                Card comn29 = new Card() { pkdxNum = 29, Name = "Nidoran", Description = "Females are more sensitive to smells than males. While foraging, they’ll use their whiskers to check wind direction and stay downwind of predators.", SerialNumber = i + 1, Attack = 3, Defence = 4, Rarity = Rarity.Common, Market = false };
                Card comn32 = new Card() { pkdxNum = 32, Name = "Nidoran", Description = "The horn on a male Nidoran’s forehead contains a powerful poison. This is a very cautious Pokémon, always straining its large ears.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn35 = new Card() { pkdxNum = 35, Name = "Clefairy", Description = "It is said that happiness will come to those who see a gathering of Clefairy dancing under a full moon.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn37 = new Card() { pkdxNum = 37, Name = "Vulpix", Description = "While young, it has six gorgeous tails. When it grows, several new tails are sprouted.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn41 = new Card() { pkdxNum = 41, Name = "Zubat", Description = "It emits ultrasonic waves from its mouth to check its surroundings. Even in tight caves, Zubat flies around with skill.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn43 = new Card() { pkdxNum = 43, Name = "Oddish", Description = "If exposed to moonlight, it starts to move. It roams far and wide at night to scatter its seeds.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn46 = new Card() { pkdxNum = 46, Name = "Paras", Description = "Burrows under the ground to gnaw on tree roots. The mushrooms on its back absorb most of the nutrition.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn48 = new Card() { pkdxNum = 48, Name = "Venonat", Description = "Its large eyes act as radar. In a bright place, you can see that they are clusters of many tiny eyes.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn50 = new Card() { pkdxNum = 50, Name = "Digglett", Description = "If a Diglett digs through a field, it leaves the soil perfectly tilled and ideal for planting crops.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn52 = new Card() { pkdxNum = 52, Name = "Meowth", Description = "It loves to collect shiny things. If it’s in a good mood, it might even let its Trainer have a look at its hoard of treasures.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn54 = new Card() { pkdxNum = 54, Name = "Psyduck", Description = "Psyduck is constantly beset by headaches. If the Pokémon lets its strange power erupt, apparently the pain subsides for a while.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn56 = new Card() { pkdxNum = 56, Name = "Mankey", Description = "An agile Pokémon that lives in trees. It angers easily and will not hesitate to attack anything.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn58 = new Card() { pkdxNum = 58, Name = "Growlithe", Description = "It has a brave and trustworthy nature. It fearlessly stands up to bigger and stronger foes.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn60 = new Card() { pkdxNum = 60, Name = "Poliwag", Description = "For Poliwag, swimming is easier than walking. The swirl pattern on its belly is actually part of the Pokémon’s innards showing through the skin.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn63 = new Card() { pkdxNum = 63, Name = "Abra", Description = "This Pokémon uses its psychic powers while it sleeps. The contents of Abra’s dreams affect the powers that the Pokémon wields.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn66 = new Card() { pkdxNum = 66, Name = "Machop", Description = "Its whole body is composed of muscles. Even though it’s the size of a human child, it can hurl 100 grown-ups.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn69 = new Card() { pkdxNum = 69, Name = "Bellsprout", Description = "Prefers hot and humid places. It ensnares tiny bugs with its vines and devours them.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn72 = new Card() { pkdxNum = 72, Name = "Tentacool", Description = "Tentacool is not a particularly strong swimmer. It drifts across the surface of shallow seas as it searches for prey.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn74 = new Card() { pkdxNum = 74, Name = "Geodude", Description = "Commonly found near mountain trails and the like. If you step on one by accident, it gets angry.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn79 = new Card() { pkdxNum = 79, Name = "Slowpoke", Description = "Slow-witted and oblivious, this Pokémon won’t feel any pain if its tail gets eaten. It won’t notice when its tail grows back, either.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn81 = new Card() { pkdxNum = 81, Name = "Magnemite", Description = "At times, Magnemite runs out of electricity and ends up on the ground. If you give batteries to a grounded Magnemite, it’ll start moving again.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn83 = new Card() { pkdxNum = 83, Name = "Farfetch'd", Description = "The stalk this Pokémon carries in its wings serves as a sword to cut down opponents. In a dire situation, the stalk can also serve as food.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn84 = new Card() { pkdxNum = 84, Name = "Doduo", Description = "Its short wings make flying difficult. Instead, this Pokémon runs at high speed on developed legs.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn86 = new Card() { pkdxNum = 86, Name = "Seel", Description = "Loves freezing-cold conditions. Relishes swimming in a frigid climate of around 14 degrees Fahrenheit.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn88 = new Card() { pkdxNum = 88, Name = "Grimer", Description = "Made of congealed sludge. It smells too putrid to touch. Even weeds won’t grow in its path.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn90 = new Card() { pkdxNum = 90, Name = "Shellder", Description = "It swims facing backward by opening and closing its two-piece shell. It is surprisingly fast.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn92 = new Card() { pkdxNum = 92, Name = "Gastly", Description = "Born from gases, anyone would faint if engulfed by its gaseous body, which contains poison.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn98 = new Card() { pkdxNum = 98, Name = "Krabby", Description = "It can be found near the sea. The large pincers grow back if they are torn out of their sockets.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn100 = new Card() { pkdxNum = 100, Name = "Voltrob", Description = "It is said to camouflage itself as a Poké Ball. It will self-destruct with very little stimulus.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn102 = new Card() { pkdxNum = 102, Name = "Exeggcute", Description = "Though it may look like it’s just a bunch of eggs, it’s a proper Pokémon. Exeggcute communicates with others of its kind via telepathy, apparently.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn104 = new Card() { pkdxNum = 104, Name = "Cubone", Description = "When the memory of its departed mother brings it to tears, its cries echo mournfully within the skull it wears on its head.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn106 = new Card() { pkdxNum = 106, Name = "Hitmonlee", Description = "This amazing Pokémon has an awesome sense of balance. It can kick in succession from any position.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn107 = new Card() { pkdxNum = 107, Name = "Hitmonchan", Description = "Its punches slice the air. They are launched at such high speed, even a slight graze could cause a burn.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn109 = new Card() { pkdxNum = 109, Name = "Koffing", Description = "Its body is full of poisonous gas. It floats into garbage dumps, seeking out the fumes of raw, rotting trash.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn111 = new Card() { pkdxNum = 111, Name = "Rhyhorn", Description = "Strong, but not too bright, this Pokémon can shatter even a skyscraper with its charging tackles", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn116 = new Card() { pkdxNum = 116, Name = "Horsea", Description = "Horsea makes its home in oceans with gentle currents. If this Pokémon is under attack, it spits out pitch-black ink and escapes.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn118 = new Card() { pkdxNum = 118, Name = "Goldeen", Description = "Its dorsal, pectoral, and tail fins wave elegantly in water. That is why it is known as the Water Dancer.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn120 = new Card() { pkdxNum = 120, Name = "Staryu", Description = "If you visit a beach at the end of summer, you’ll be able to see groups of Staryu lighting up in a steady rhythm.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn129 = new Card() { pkdxNum = 129, Name = "Magikarp", Description = "It is virtually worthless in terms of both power and speed. It is the most weak and pathetic Pokémon in the world.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };
                Card comn133 = new Card() { pkdxNum = 133, Name = "Eevee", Description = "It has the ability to alter the composition of its body to suit its surrounding environment.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common, Market = false };

                i1.Cards.Add(comn1);
                i4.Cards.Add(comn4);
                i7.Cards.Add(comn7);
                i10.Cards.Add(comn10);
                i13.Cards.Add(comn13);
                i16.Cards.Add(comn16);
                i19.Cards.Add(comn19);
                i21.Cards.Add(comn21);
                i23.Cards.Add(comn23);
                i25.Cards.Add(comn25);
                i27.Cards.Add(comn27);
                i29.Cards.Add(comn29);
                i32.Cards.Add(comn32);
                i35.Cards.Add(comn35);
                i37.Cards.Add(comn37);
                i41.Cards.Add(comn41);
                i43.Cards.Add(comn43);
                i46.Cards.Add(comn46);
                i48.Cards.Add(comn48);
                i50.Cards.Add(comn50);
                i52.Cards.Add(comn52);
                i54.Cards.Add(comn54);
                i56.Cards.Add(comn56);
                i58.Cards.Add(comn58);
                i60.Cards.Add(comn60);
                i63.Cards.Add(comn63);
                i66.Cards.Add(comn66);
                i69.Cards.Add(comn69);
                i72.Cards.Add(comn72);
                i74.Cards.Add(comn74);
                i79.Cards.Add(comn79);
                i81.Cards.Add(comn81);
                i83.Cards.Add(comn83);
                i84.Cards.Add(comn84);
                i86.Cards.Add(comn86);
                i88.Cards.Add(comn88);
                i90.Cards.Add(comn90);
                i92.Cards.Add(comn92);
                i98.Cards.Add(comn98);
                i100.Cards.Add(comn100);
                i102.Cards.Add(comn102);
                i104.Cards.Add(comn104);
                i106.Cards.Add(comn106);
                i107.Cards.Add(comn107);
                i109.Cards.Add(comn109);
                i111.Cards.Add(comn111);
                i116.Cards.Add(comn116);
                i118.Cards.Add(comn118);
                i120.Cards.Add(comn120);
                i129.Cards.Add(comn129);
                i133.Cards.Add(comn133);


                bug1.Cards = new List<Card>() { comn10, comn13, comn46, comn48 };
                elc3.Cards = new List<Card>() { comn25, comn81, comn100 };
                fgh4.Cards = new List<Card>() { comn56, comn66, comn106, comn107 };
                fr5.Cards = new List<Card>() { comn4, comn37, comn58 };
                fly6.Cards = new List<Card>() { comn21, comn41, comn83, comn84 };
                gh7.Cards = new List<Card>() { comn92 };
                gras8.Cards = new List<Card>() { comn1, comn43, comn46, comn69, comn102 };
                grd9.Cards = new List<Card>() { comn27, comn50, comn74, comn104, comn111 };
                norm11.Cards = new List<Card>() { comn16, comn19, comn21, comn35, comn52, comn83, comn84, comn133 };
                psn12.Cards = new List<Card>() { comn1, comn13, comn23, comn29, comn32, comn41, comn43, comn48, comn69, comn72, comn88, comn92, comn109 };
                psy13.Cards = new List<Card>() { comn63, comn79, comn79, comn102 };
                roc14.Cards = new List<Card>() { comn74, comn111 };
                wat15.Cards = new List<Card>() { comn7, comn54, comn60, comn72, comn79, comn86, comn90, comn98, comn116, comn118, comn120, comn129 };

                comn1.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                comn4.PokemonTypes = new List<PokemonType>() { fr5 };
                comn7.PokemonTypes = new List<PokemonType>() { wat15 };
                comn10.PokemonTypes = new List<PokemonType>() { bug1 };
                comn13.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
                comn16.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
                comn19.PokemonTypes = new List<PokemonType>() { norm11 };
                comn21.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
                comn23.PokemonTypes = new List<PokemonType>() { psn12 };
                comn25.PokemonTypes = new List<PokemonType>() { elc3 };
                comn27.PokemonTypes = new List<PokemonType>() { grd9 };
                comn29.PokemonTypes = new List<PokemonType>() { psn12 };
                comn32.PokemonTypes = new List<PokemonType>() { psn12 };
                comn35.PokemonTypes = new List<PokemonType>() { norm11 };
                comn37.PokemonTypes = new List<PokemonType>() { fr5 };
                comn41.PokemonTypes = new List<PokemonType>() { psn12, fly6 };
                comn43.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                comn46.PokemonTypes = new List<PokemonType>() { bug1, gras8 };
                comn48.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
                comn50.PokemonTypes = new List<PokemonType>() { grd9 };
                comn52.PokemonTypes = new List<PokemonType>() { norm11 };
                comn54.PokemonTypes = new List<PokemonType>() { wat15 };
                comn56.PokemonTypes = new List<PokemonType>() { fgh4 };
                comn58.PokemonTypes = new List<PokemonType>() { fr5 };
                comn60.PokemonTypes = new List<PokemonType>() { wat15 };
                comn63.PokemonTypes = new List<PokemonType>() { psy13 };
                comn66.PokemonTypes = new List<PokemonType>() { fgh4 };
                comn69.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                comn72.PokemonTypes = new List<PokemonType>() { wat15, psn12 };
                comn74.PokemonTypes = new List<PokemonType>() { roc14, grd9 };
                comn79.PokemonTypes = new List<PokemonType>() { wat15, psy13 };
                comn81.PokemonTypes = new List<PokemonType>() { elc3 };
                comn83.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
                comn84.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
                comn86.PokemonTypes = new List<PokemonType>() { wat15 };
                comn88.PokemonTypes = new List<PokemonType>() { psn12 };
                comn90.PokemonTypes = new List<PokemonType>() { wat15 };
                comn92.PokemonTypes = new List<PokemonType>() { gh7, psn12 };
                comn98.PokemonTypes = new List<PokemonType>() { wat15 };
                comn100.PokemonTypes = new List<PokemonType>() { elc3 };
                comn102.PokemonTypes = new List<PokemonType>() { gras8, psy13 };
                comn104.PokemonTypes = new List<PokemonType>() { grd9 };
                comn106.PokemonTypes = new List<PokemonType>() { fgh4 };
                comn107.PokemonTypes = new List<PokemonType>() { fgh4 };
                comn109.PokemonTypes = new List<PokemonType>() { psn12 };
                comn111.PokemonTypes = new List<PokemonType>() { grd9, roc14 };
                comn116.PokemonTypes = new List<PokemonType>() { wat15 };
                comn118.PokemonTypes = new List<PokemonType>() { wat15 };
                comn120.PokemonTypes = new List<PokemonType>() { wat15 };
                comn129.PokemonTypes = new List<PokemonType>() { wat15 };
                comn133.PokemonTypes = new List<PokemonType>() { norm11 };


                cards.Add(comn1);
                cards.Add(comn4);
                cards.Add(comn7);
                cards.Add(comn7);
                cards.Add(comn10);
                cards.Add(comn13);
                cards.Add(comn16);
                cards.Add(comn19);
                cards.Add(comn21);
                cards.Add(comn23);
                cards.Add(comn25);
                cards.Add(comn27);
                cards.Add(comn29);
                cards.Add(comn32);
                cards.Add(comn35);
                cards.Add(comn37);
                cards.Add(comn41);
                cards.Add(comn43);
                cards.Add(comn46);
                cards.Add(comn48);
                cards.Add(comn50);
                cards.Add(comn52);
                cards.Add(comn54);
                cards.Add(comn56);
                cards.Add(comn58);
                cards.Add(comn60);
                cards.Add(comn63);
                cards.Add(comn66);
                cards.Add(comn69);
                cards.Add(comn72);
                cards.Add(comn74);
                cards.Add(comn79);
                cards.Add(comn81);
                cards.Add(comn83);
                cards.Add(comn84);
                cards.Add(comn86);
                cards.Add(comn88);
                cards.Add(comn90);
                cards.Add(comn92);
                cards.Add(comn98);
                cards.Add(comn100);
                cards.Add(comn102);
                cards.Add(comn104);
                cards.Add(comn106);
                cards.Add(comn107);
                cards.Add(comn109);
                cards.Add(comn111);
                cards.Add(comn116);
                cards.Add(comn118);
                cards.Add(comn120);
                cards.Add(comn129);
                cards.Add(comn133);
            }

            //================================= Rare Cards  ================================
            for (int i = 1; i < 25; i++)
            {

                Card rare2 = new Card() { pkdxNum = 2, Name = "Ivysaur", Description = "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.", SerialNumber = i + 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = false };
                Card rare5 = new Card() { pkdxNum = 5, Name = "Charmeleon", Description = "It has a barbaric nature. In battle, it whips its fiery tail around and slashes away with sharp claws.", SerialNumber = i + 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = false };
                Card rare8 = new Card() { pkdxNum = 8, Name = "Wartortle", Description = "It is recognized as a symbol of longevity. If its shell has algae on it, that Wartortle is very old.", SerialNumber = i + 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = false };
                Card rare11 = new Card() { pkdxNum = 11, Name = "Metapod", Description = "It is waiting for the moment to evolve. At this stage, it can only harden, so it remains motionless to avoid attack.", SerialNumber = i + 1, Attack = 3, Defence = 2, Rarity = Rarity.Rare, Market = false };
                Card rare14 = new Card() { pkdxNum = 14, Name = "Kakuna", Description = "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy.", SerialNumber = i + 1, Attack = 3, Defence = 2, Rarity = Rarity.Rare, Market = false };
                Card rare17 = new Card() { pkdxNum = 17, Name = "Pidgeotto", Description = "This Pokémon is full of vitality. It constantly flies around its large territory in search of prey.", SerialNumber = i + 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = false };
                Card rare20 = new Card() { pkdxNum = 20, Name = "Raticate", Description = "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.", SerialNumber = i + 1, Attack = 4, Defence = 5, Rarity = Rarity.Rare, Market = false };
                Card rare22 = new Card() { pkdxNum = 22, Name = "Fearow", Description = "A Pokémon that dates back many years. If it senses danger, it flies high and away, instantly.", SerialNumber = i + 1, Attack = 4, Defence = 6, Rarity = Rarity.Rare, Market = false };
                Card rare24 = new Card() { pkdxNum = 24, Name = "Arbok", Description = "The frightening patterns on its belly have been studied. Six variations have been confirmed.", SerialNumber = i + 1, Attack = 6, Defence = 5, Rarity = Rarity.Rare, Market = false };
                Card rare26 = new Card() { pkdxNum = 26, Name = "Raichu", Description = "Its long tail serves as a ground to protect itself from its own high-voltage power.", SerialNumber = i + 1, Attack = 6, Defence = 4, Rarity = Rarity.Rare, Market = false };
                Card rare28 = new Card() { pkdxNum = 28, Name = "Sandslash", Description = "The drier the area Sandslash lives in, the harder and smoother the Pokémon’s spikes will feel when touched.", SerialNumber = i + 1, Attack = 6, Defence = 7, Rarity = Rarity.Rare, Market = false };
                Card rare30 = new Card() { pkdxNum = 30, Name = "Nidorina", Description = "The horn on its head has atrophied. It’s thought that this happens so Nidorina’s children won’t get poked while their mother is feeding them.", SerialNumber = i + 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare, Market = false };
                Card rare33 = new Card() { pkdxNum = 33, Name = "Nidorino", Description = "With a horn that’s harder than diamond, this Pokémon goes around shattering boulders as it searches for a moon stone.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare36 = new Card() { pkdxNum = 36, Name = "Clefable", Description = "A timid fairy Pokémon that is rarely seen, it will run and hide the moment it senses people.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare38 = new Card() { pkdxNum = 38, Name = "Ninetales", Description = "It is said to live 1,000 years, and each of its tails is loaded with supernatural powers.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare39 = new Card() { pkdxNum = 39, Name = "Jigglypuff", Description = "Jigglypuff has top-notch lung capacity, even by comparison to other Pokémon. It won’t stop singing its lullabies until its foes fall asleep.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare42 = new Card() { pkdxNum = 42, Name = "Golbat", Description = "It loves to drink other creatures’ blood. It’s said that if it finds others of its kind going hungry, it sometimes shares the blood it’s gathered.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare44 = new Card() { pkdxNum = 44, Name = "Gloom", Description = "Its pistils exude an incredibly foul odor. The horrid stench can cause fainting at a distance of 1.25 miles.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare47 = new Card() { pkdxNum = 47, Name = "Rarasect", Description = "The bug host is drained of energy by the mushroom on its back. The mushroom appears to do all the thinking.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare49 = new Card() { pkdxNum = 49, Name = "Venomoth", Description = "The powdery scales on its wings are hard to remove from skin. They also contain poison that leaks out on contact.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare51 = new Card() { pkdxNum = 51, Name = "Dugtrio", Description = "A team of Diglett triplets. It triggers huge earthquakes by burrowing 60 miles underground.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare53 = new Card() { pkdxNum = 53, Name = "Persian", Description = "Getting this prideful Pokémon to warm up to you takes a lot of effort, and it will claw at you the moment it gets annoyed.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare57 = new Card() { pkdxNum = 57, Name = "Primeape", Description = "It stops being angry only when nobody else is around. To view this moment is very difficult.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare61 = new Card() { pkdxNum = 61, Name = "Poliwhirl", Description = "Staring at the swirl on its belly causes drowsiness. This trait of Poliwhirl’s has been used in place of lullabies to get children to go to sleep.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare64 = new Card() { pkdxNum = 64, Name = "Kadabra", Description = "Using its psychic power, Kadabra levitates as it sleeps. It uses its springy tail as a pillow.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare67 = new Card() { pkdxNum = 67, Name = "Machoke", Description = "Its muscular body is so powerful, it must wear a power-save belt to be able to regulate its motions.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare70 = new Card() { pkdxNum = 70, Name = "Weepinbell", Description = "When hungry, it swallows anything that moves. Its hapless prey is dissolved by strong acids.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare73 = new Card() { pkdxNum = 73, Name = "Tentacruel", Description = "When the red orbs on Tentacruel’s head glow brightly, watch out. The Pokémon is about to fire off a burst of ultrasonic waves.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare75 = new Card() { pkdxNum = 75, Name = "Graveler", Description = "Often seen rolling down mountain trails. Obstacles are just things to roll straight over, not avoid.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
                Card rare77 = new Card() { pkdxNum = 77, Name = "Ponyta", Description = "It can’t run properly when it’s newly born. As it races around with others of its kind, its legs grow stronger.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
                Card rare80 = new Card() { pkdxNum = 80, Name = "Slowbro", Description = "Slowpoke became Slowbro when a Shellder bit on to its tail. Sweet flavors seeping from the tail make the Shellder feel as if its life is a dream.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare85 = new Card() { pkdxNum = 85, Name = "Dodrio", Description = "One of Doduo’s two heads splits to form a unique species. It runs close to 40 mph in prairies.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare87 = new Card() { pkdxNum = 87, Name = "Dewgong", Description = "Its entire body is a snowy white. Unharmed by even intense cold, it swims powerfully in icy waters.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare89 = new Card() { pkdxNum = 89, Name = "Muk", Description = "Smells so awful, it can cause fainting. Through degeneration of its nose, it lost its sense of smell.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare96 = new Card() { pkdxNum = 96, Name = "Drowzee", Description = "If you sleep by it all the time, it will sometimes show you dreams it had eaten in the past.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare97 = new Card() { pkdxNum = 97, Name = "Hypno", Description = "Avoid eye contact if you come across one. It will try to put you to sleep by using its pendulum.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
                Card rare99 = new Card() { pkdxNum = 99, Name = "Kingler", Description = "Its large and hard pincer has 10,000-horsepower strength. However, being so big, it is unwieldy to move.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare101 = new Card() { pkdxNum = 101, Name = "Electrode", Description = "Stores electrical energy inside its body. Even the slightest shock could trigger a huge explosion.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare103 = new Card() { pkdxNum = 103, Name = "Exeggutor", Description = "Each of Exeggutor’s three heads is thinking different thoughts. The three don’t seem to be very interested in one another.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare108 = new Card() { pkdxNum = 108, Name = "Lickitung", Description = "If this Pokémon’s sticky saliva gets on you and you don’t clean it off, an intense itch will set in. The itch won’t go away, either.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare110 = new Card() { pkdxNum = 110, Name = "Weezing", Description = "It mixes gases between its two bodies. It’s said that these Pokémon were seen all over the Galar region back in the day.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare112 = new Card() { pkdxNum = 112, Name = "Rhydon", Description = "It begins walking on its hind legs after evolution. It can punch holes through boulders with its horn.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare113 = new Card() { pkdxNum = 113, Name = "Chansey", Description = "The egg Chansey carries is not only delicious but also packed with nutrition. It’s used as a high-class cooking ingredient.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare114 = new Card() { pkdxNum = 114, Name = "Tangela", Description = "Hidden beneath a tangle of vines that grows nonstop even if the vines are torn off, this Pokémon’s true appearance remains a mystery.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare119 = new Card() { pkdxNum = 119, Name = "Seaking", Description = "In autumn, its body becomes more fatty in preparing to propose to a mate. It takes on beautiful colors.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare121 = new Card() { pkdxNum = 121, Name = "Starmie", Description = "This Pokémon has an organ known as its core. The organ glows in seven colors when Starmie is unleashing its potent psychic powers.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare123 = new Card() { pkdxNum = 123, Name = "Scyther", Description = "As Scyther fights more and more battles, its scythes become sharper and sharper. With a single slice, Scyther can fell a massive tree.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare125 = new Card() { pkdxNum = 125, Name = "Electabuzz", Description = "Many power plants keep Ground-type Pokémon around as a defense against Electabuzz that come seeking electricity.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare126 = new Card() { pkdxNum = 126, Name = "Magmar", Description = "Magmar dispatches its prey with fire. But it regrets this habit once it realizes that it has burned its intended prey to a charred crisp.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare127 = new Card() { pkdxNum = 127, Name = "Pinsir", Description = "These Pokémon judge one another based on pincers. Thicker, more impressive pincers make for more popularity with the opposite gender.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare128 = new Card() { pkdxNum = 128, Name = "Tauros", Description = "When Tauros begins whipping itself with its tails, it’s a warning that the Pokémon is about to charge with astounding speed.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare131 = new Card() { pkdxNum = 131, Name = "Lapras", Description = "A smart and kindhearted Pokémon, it glides across the surface of the sea while its beautiful song echoes around it.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare132 = new Card() { pkdxNum = 132, Name = "Ditto", Description = "It can reconstitute its entire cellular structure to change into what it sees, but it returns to normal when it relaxes.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare138 = new Card() { pkdxNum = 138, Name = "Omanyte", Description = "Because some Omanyte manage to escape after being restored or are released into the wild by people, this species is becoming a problem.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare140 = new Card() { pkdxNum = 140, Name = "Kabuto", Description = "This species is almost entirely extinct. Kabuto molt every three days, making their shells harder and harder.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare143 = new Card() { pkdxNum = 143, Name = "Snorlax", Description = "It is not satisfied unless it eats over 880 pounds of food every day. When it is done eating, it goes promptly to sleep.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };
                Card rare147 = new Card() { pkdxNum = 147, Name = "Dratini", Description = "Dratini dwells near bodies of rapidly flowing water, such as the plunge pools of waterfalls. As it grows, Dratini will shed its skin many times.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare, Market = false };

                i2.Cards.Add(rare2);
                i5.Cards.Add(rare5);
                i8.Cards.Add(rare8);
                i11.Cards.Add(rare11);
                i14.Cards.Add(rare14);
                i17.Cards.Add(rare17);
                i20.Cards.Add(rare20);
                i22.Cards.Add(rare22);
                i24.Cards.Add(rare24);
                i26.Cards.Add(rare26);
                i28.Cards.Add(rare28);
                i30.Cards.Add(rare30);
                i33.Cards.Add(rare33);
                i36.Cards.Add(rare36);
                i38.Cards.Add(rare38);
                i39.Cards.Add(rare39);
                i42.Cards.Add(rare42);
                i44.Cards.Add(rare44);
                i47.Cards.Add(rare47);
                i49.Cards.Add(rare49);
                i51.Cards.Add(rare51);
                i53.Cards.Add(rare53);
                i57.Cards.Add(rare57);
                i61.Cards.Add(rare61);
                i64.Cards.Add(rare64);
                i67.Cards.Add(rare67);
                i70.Cards.Add(rare70);
                i73.Cards.Add(rare73);
                i75.Cards.Add(rare75);
                i77.Cards.Add(rare77);
                i80.Cards.Add(rare80);
                i85.Cards.Add(rare85);
                i87.Cards.Add(rare87);
                i89.Cards.Add(rare89);
                i96.Cards.Add(rare96);
                i97.Cards.Add(rare97);
                i99.Cards.Add(rare99);
                i101.Cards.Add(rare101);
                i103.Cards.Add(rare103);
                i108.Cards.Add(rare108);
                i110.Cards.Add(rare110);
                i112.Cards.Add(rare112);
                i113.Cards.Add(rare113);
                i114.Cards.Add(rare114);
                i119.Cards.Add(rare119);
                i121.Cards.Add(rare121);
                i123.Cards.Add(rare123);
                i125.Cards.Add(rare125);
                i126.Cards.Add(rare126);
                i127.Cards.Add(rare127);
                i128.Cards.Add(rare128);
                i131.Cards.Add(rare131);
                i132.Cards.Add(rare132);
                i138.Cards.Add(rare138);
                i140.Cards.Add(rare140);
                i143.Cards.Add(rare143);
                i147.Cards.Add(rare147);

                bug1.Cards = new List<Card>() { rare11, rare14, rare47, rare49, rare123, rare127 };
                drg2.Cards = new List<Card>() { rare147, };
                elc3.Cards = new List<Card>() { rare26, rare101, rare125 };
                fgh4.Cards = new List<Card>() { rare57, rare67 };
                fr5.Cards = new List<Card>() { rare5, rare38, rare77, rare126 };
                fly6.Cards = new List<Card>() { rare17, rare22, rare42, rare85, rare123 };
                gras8.Cards = new List<Card>() { rare2, rare44, rare47, rare70, rare103, rare114 };
                grd9.Cards = new List<Card>() { rare28, rare51, rare75, rare112 };
                ice10.Cards = new List<Card>() { rare87, rare131 };
                norm11.Cards = new List<Card>() { rare17, rare20, rare22, rare36, rare39, rare53, rare85, rare108, rare113, rare128, rare132, rare143 };
                psn12.Cards = new List<Card>() { rare2, rare14, rare24, rare30, rare33, rare42, rare44, rare49, rare70, rare73, rare89, rare110 };
                psy13.Cards = new List<Card>() { rare64, rare80, rare96, rare97, rare103, rare121 };
                roc14.Cards = new List<Card>() { rare75, rare112, rare138, rare140 };
                wat15.Cards = new List<Card>() { rare8, rare61, rare73, rare80, rare87, rare99, rare119, rare121, rare131, rare138, rare140 };

                rare2.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                rare5.PokemonTypes = new List<PokemonType>() { fr5 };
                rare8.PokemonTypes = new List<PokemonType>() { wat15 };
                rare11.PokemonTypes = new List<PokemonType>() { bug1 };
                rare14.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
                rare17.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
                rare20.PokemonTypes = new List<PokemonType>() { norm11 };
                rare22.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
                rare24.PokemonTypes = new List<PokemonType>() { psn12 };
                rare26.PokemonTypes = new List<PokemonType>() { elc3 };
                rare28.PokemonTypes = new List<PokemonType>() { grd9 };
                rare30.PokemonTypes = new List<PokemonType>() { psn12 };
                rare33.PokemonTypes = new List<PokemonType>() { psn12 };
                rare36.PokemonTypes = new List<PokemonType>() { norm11 };
                rare38.PokemonTypes = new List<PokemonType>() { fr5 };
                rare39.PokemonTypes = new List<PokemonType>() { norm11 };
                rare42.PokemonTypes = new List<PokemonType>() { psn12, fly6 };
                rare44.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                rare47.PokemonTypes = new List<PokemonType>() { bug1, gras8 };
                rare49.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
                rare51.PokemonTypes = new List<PokemonType>() { grd9 };
                rare53.PokemonTypes = new List<PokemonType>() { norm11 };
                rare57.PokemonTypes = new List<PokemonType>() { fgh4 };
                rare61.PokemonTypes = new List<PokemonType>() { wat15 };
                rare64.PokemonTypes = new List<PokemonType>() { psy13 };
                rare67.PokemonTypes = new List<PokemonType>() { fgh4 };
                rare70.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                rare73.PokemonTypes = new List<PokemonType>() { wat15, psn12 };
                rare75.PokemonTypes = new List<PokemonType>() { roc14, grd9 };
                rare77.PokemonTypes = new List<PokemonType>() { fr5 };
                rare80.PokemonTypes = new List<PokemonType>() { wat15, psy13 };
                rare85.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
                rare87.PokemonTypes = new List<PokemonType>() { wat15, ice10 };
                rare89.PokemonTypes = new List<PokemonType>() { psn12 };
                rare96.PokemonTypes = new List<PokemonType>() { psy13 };
                rare97.PokemonTypes = new List<PokemonType>() { psy13 };
                rare99.PokemonTypes = new List<PokemonType>() { wat15 };
                rare101.PokemonTypes = new List<PokemonType>() { elc3 };
                rare103.PokemonTypes = new List<PokemonType>() { gras8, psy13 };
                rare108.PokemonTypes = new List<PokemonType>() { norm11 };
                rare110.PokemonTypes = new List<PokemonType>() { psn12 };
                rare112.PokemonTypes = new List<PokemonType>() { grd9, roc14 };
                rare113.PokemonTypes = new List<PokemonType>() { norm11 };
                rare114.PokemonTypes = new List<PokemonType>() { gras8 };
                rare119.PokemonTypes = new List<PokemonType>() { wat15 };
                rare121.PokemonTypes = new List<PokemonType>() { wat15, psy13 };
                rare123.PokemonTypes = new List<PokemonType>() { bug1, fly6 };
                rare125.PokemonTypes = new List<PokemonType>() { elc3 };
                rare126.PokemonTypes = new List<PokemonType>() { fr5 };
                rare127.PokemonTypes = new List<PokemonType>() { bug1 };
                rare128.PokemonTypes = new List<PokemonType>() { norm11 };
                rare131.PokemonTypes = new List<PokemonType>() { wat15, ice10 };
                rare132.PokemonTypes = new List<PokemonType>() { norm11 };
                rare138.PokemonTypes = new List<PokemonType>() { roc14, wat15 };
                rare140.PokemonTypes = new List<PokemonType>() { roc14, wat15 };
                rare143.PokemonTypes = new List<PokemonType>() { norm11 };
                rare147.PokemonTypes = new List<PokemonType>() { drg2 };

                cards.Add(rare2);
                cards.Add(rare5);
                cards.Add(rare8);
                cards.Add(rare11);
                cards.Add(rare14);
                cards.Add(rare17);
                cards.Add(rare20);
                cards.Add(rare22);
                cards.Add(rare24);
                cards.Add(rare26);
                cards.Add(rare28);
                cards.Add(rare30);
                cards.Add(rare33);
                cards.Add(rare36);
                cards.Add(rare38);
                cards.Add(rare39);
                cards.Add(rare42);
                cards.Add(rare44);
                cards.Add(rare47);
                cards.Add(rare49);
                cards.Add(rare51);
                cards.Add(rare53);
                cards.Add(rare57);
                cards.Add(rare61);
                cards.Add(rare64);
                cards.Add(rare67);
                cards.Add(rare70);
                cards.Add(rare73);
                cards.Add(rare75);
                cards.Add(rare77);
                cards.Add(rare80);
                cards.Add(rare85);
                cards.Add(rare87);
                cards.Add(rare89);
                cards.Add(rare96);
                cards.Add(rare97);
                cards.Add(rare99);
                cards.Add(rare101);
                cards.Add(rare103);
                cards.Add(rare108);
                cards.Add(rare110);
                cards.Add(rare112);
                cards.Add(rare113);
                cards.Add(rare114);
                cards.Add(rare119);
                cards.Add(rare121);
                cards.Add(rare123);
                cards.Add(rare125);
                cards.Add(rare126);
                cards.Add(rare127);
                cards.Add(rare128);
                cards.Add(rare131);
                cards.Add(rare132);
                cards.Add(rare138);
                cards.Add(rare140);
                cards.Add(rare143);
                cards.Add(rare147);
            }

            //================================= Epic Cards  ================================
            for (int i = 1; i < 10; i++)
            {

                Card Epic3 = new Card() { pkdxNum = 3, Name = "Venusaur", Description = "Its plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", SerialNumber = i + 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, Market = false };
                Card Epic6 = new Card() { pkdxNum = 6, Name = "Charizard", Description = "It spits fire that is hot enough to melt boulders. It may cause forest fires by blowing flames.", SerialNumber = i + 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, Market = false };
                Card Epic9 = new Card() { pkdxNum = 9, Name = "Blastoise", Description = "It crushes its foe under its heavy body to cause fainting. In a pinch, it will withdraw inside its shell.", SerialNumber = i + 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, Market = false };
                Card Epic12 = new Card() { pkdxNum = 12, Name = "Butterfree", Description = "In battle, it flaps its wings at great speed to release highly toxic dust into the air.", SerialNumber = i + 1, Attack = 4, Defence = 3, Rarity = Rarity.Epic, Market = false };
                Card Epic15 = new Card() { pkdxNum = 15, Name = "Beedrill", Description = "It has three poisonous stingers on its forelegs and its tail. They are used to jab its enemy repeatedly.", SerialNumber = i + 1, Attack = 4, Defence = 6, Rarity = Rarity.Epic, Market = false };
                Card Epic18 = new Card() { pkdxNum = 18, Name = "Pidgeot", Description = "This Pokémon flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons.", SerialNumber = i + 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, Market = false };
                Card Epic31 = new Card() { pkdxNum = 31, Name = "Nidoqueen", Description = "Nidoqueen is better at defense than offense. With scales like armor, this Pokémon will shield its children from any kind of attack.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic34 = new Card() { pkdxNum = 34, Name = "Nidoking", Description = "When it goes on a rampage, it’s impossible to control. But in the presence of a Nidoqueen it’s lived with for a long time, Nidoking calms down.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic40 = new Card() { pkdxNum = 40, Name = "Wigglytuff", Description = "The more air it takes in, the more it inflates. If opponents catch it in a bad mood, it will inflate itself to an enormous size to intimidate them.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic45 = new Card() { pkdxNum = 45, Name = "Vileplume", Description = "It has the world’s largest petals. With every step, the petals shake out heavy clouds of toxic pollen.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic55 = new Card() { pkdxNum = 55, Name = "Golduck", Description = "This Pokémon lives in gently flowing rivers. It paddles through the water with its long limbs, putting its graceful swimming skills on display.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic59 = new Card() { pkdxNum = 59, Name = "Arcanine", Description = "The sight of it running over 6,200 miles in a single day and night has captivated many people.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic62 = new Card() { pkdxNum = 62, Name = "Poliwrath", Description = "Its body is solid muscle. When swimming through cold seas, Poliwrath uses its impressive arms to smash through drift ice and plow forward.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic65 = new Card() { pkdxNum = 65, Name = "Alakazam", Description = "It has an incredibly high level of intelligence. Some say that Alakazam remembers everything that ever happens to it, from birth till death.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic68 = new Card() { pkdxNum = 68, Name = "Machamp", Description = "It quickly swings its four arms to rock its opponents with ceaseless punches and chops from all angles.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic71 = new Card() { pkdxNum = 71, Name = "Victreebel", Description = "Lures prey with the sweet aroma of honey. Swallowed whole, the prey is dissolved in a day, bones and all.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic76 = new Card() { pkdxNum = 76, Name = "Golem", Description = "Once it sheds its skin, its body turns tender and whitish. Its hide hardens when it’s exposed to air.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic78 = new Card() { pkdxNum = 78, Name = "Rapidash", Description = "This Pokémon can be seen galloping through fields at speeds of up to 150 mph, its fiery mane fluttering in the wind.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic82 = new Card() { pkdxNum = 82, Name = "Magneton", Description = "This Pokémon is three Magnemite that have linked together. Magneton sends out powerful radio waves to study its surroundings.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic91 = new Card() { pkdxNum = 91, Name = "Cloyster", Description = "Its shell is extremely hard. It cannot be shattered, even with a bomb. The shell opens only when it is attacking.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic93 = new Card() { pkdxNum = 93, Name = "Haunter", Description = "Its tongue is made of gas. If licked, its victim starts shaking constantly until death eventually comes.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic95 = new Card() { pkdxNum = 95, Name = "Onix", Description = "As it digs through the ground, it absorbs many hard objects. This is what makes its body so solid.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic105 = new Card() { pkdxNum = 105, Name = "Marowak", Description = "This Pokémon overcame its sorrow to evolve a sturdy new body. Marowak faces its opponents bravely, using a bone as a weapon.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic115 = new Card() { pkdxNum = 115, Name = "Kangaskhan", Description = "Although it’s carrying its baby in a pouch on its belly, Kangaskhan is swift on its feet. It intimidates its opponents with quick jabs.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic117 = new Card() { pkdxNum = 117, Name = "Seadra", Description = "It’s the males that raise the offspring. While Seadra are raising young, the spines on their backs secrete thicker and stronger poison.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic122 = new Card() { pkdxNum = 122, Name = "Mr.Mime", Description = "The broadness of its hands may be no coincidence—many scientists believe its palms became enlarged specifically for pantomiming.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic124 = new Card() { pkdxNum = 124, Name = "Jynx", Description = "In certain parts of Galar, Jynx was once feared and worshiped as the Queen of Ice.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic134 = new Card() { pkdxNum = 134, Name = "Vaporeon", Description = "When Vaporeon’s fins begin to vibrate, it is a sign that rain will come within a few hours.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic135 = new Card() { pkdxNum = 135, Name = "Jolteon", Description = "If it is angered or startled, the fur all over its body bristles like sharp needles that pierce foes.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic136 = new Card() { pkdxNum = 136, Name = "Flareon", Description = "Once it has stored up enough heat, this Pokémon’s body temperature can reach up to 1,700 degrees Fahrenheit.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic137 = new Card() { pkdxNum = 137, Name = "Porygon", Description = "State-of-the-art technology was used to create Porygon. It was the first artificial Pokémon to be created via computer programming.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic139 = new Card() { pkdxNum = 139, Name = "Omastar", Description = "Weighed down by a large and heavy shell, Omastar couldn’t move very fast. Some say it went extinct because it was unable to catch food.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic141 = new Card() { pkdxNum = 141, Name = "Kabutops", Description = "Kabutops slices its prey apart and sucks out the fluids. The discarded body parts become food for other Pokémon.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic142 = new Card() { pkdxNum = 142, Name = "Aerodactyl", Description = "This is a ferocious Pokémon from ancient times. Apparently even modern technology is incapable of producing a perfectly restored specimen.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };
                Card Epic148 = new Card() { pkdxNum = 148, Name = "Dragonair", Description = "This Pokémon lives in pristine oceans and lakes. It can control the weather, and it uses this power to fly into the sky, riding on the wind.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic, Market = false };

                i3.Cards.Add(Epic3);
                i6.Cards.Add(Epic6);
                i9.Cards.Add(Epic9);
                i12.Cards.Add(Epic12);
                i15.Cards.Add(Epic15);
                i18.Cards.Add(Epic18);
                i31.Cards.Add(Epic31);
                i34.Cards.Add(Epic34);
                i40.Cards.Add(Epic40);
                i45.Cards.Add(Epic45);
                i55.Cards.Add(Epic55);
                i59.Cards.Add(Epic59);
                i62.Cards.Add(Epic62);
                i65.Cards.Add(Epic65);
                i68.Cards.Add(Epic68);
                i71.Cards.Add(Epic71);
                i76.Cards.Add(Epic76);
                i78.Cards.Add(Epic78);
                i82.Cards.Add(Epic82);
                i91.Cards.Add(Epic91);
                i93.Cards.Add(Epic93);
                i95.Cards.Add(Epic95);
                i105.Cards.Add(Epic105);
                i115.Cards.Add(Epic115);
                i117.Cards.Add(Epic117);
                i122.Cards.Add(Epic122);
                i124.Cards.Add(Epic124);
                i134.Cards.Add(Epic134);
                i135.Cards.Add(Epic135);
                i136.Cards.Add(Epic136);
                i137.Cards.Add(Epic137);
                i139.Cards.Add(Epic139);
                i141.Cards.Add(Epic141);
                i142.Cards.Add(Epic142);
                i148.Cards.Add(Epic148);

                bug1.Cards = new List<Card>() { Epic12, Epic15 };
                drg2.Cards = new List<Card>() { Epic148 };
                elc3.Cards = new List<Card>() { Epic82, Epic135 };
                fgh4.Cards = new List<Card>() { Epic62, Epic68 };
                fr5.Cards = new List<Card>() { Epic6, Epic59, Epic78, Epic136 };
                fly6.Cards = new List<Card>() { Epic6, Epic12, Epic18, Epic142 };
                gh7.Cards = new List<Card>() { Epic93 };
                gras8.Cards = new List<Card>() { Epic3, Epic45, Epic71 };
                grd9.Cards = new List<Card>() { Epic31, Epic34, Epic76, Epic95, Epic105 };
                ice10.Cards = new List<Card>() { Epic91, Epic124 };
                norm11.Cards = new List<Card>() { Epic18, Epic40, Epic115, Epic137 };
                psn12.Cards = new List<Card>() { Epic3, Epic15, Epic31, Epic34, Epic45, Epic71, Epic93 };
                psy13.Cards = new List<Card>() { Epic65, Epic65, Epic122, Epic124 };
                roc14.Cards = new List<Card>() { Epic76, Epic95, Epic139, Epic141, Epic142 };
                wat15.Cards = new List<Card>() { Epic9, Epic55, Epic62, Epic91, Epic117, Epic134, Epic139, Epic141 };

                Epic3.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                Epic6.PokemonTypes = new List<PokemonType>() { fr5, fly6 };
                Epic9.PokemonTypes = new List<PokemonType>() { wat15 };
                Epic12.PokemonTypes = new List<PokemonType>() { bug1, fly6 };
                Epic15.PokemonTypes = new List<PokemonType>() { bug1, psn12 };
                Epic18.PokemonTypes = new List<PokemonType>() { norm11, fly6 };
                Epic31.PokemonTypes = new List<PokemonType>() { psn12, grd9 };
                Epic34.PokemonTypes = new List<PokemonType>() { psn12, grd9 };
                Epic40.PokemonTypes = new List<PokemonType>() { norm11 };
                Epic45.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                Epic55.PokemonTypes = new List<PokemonType>() { wat15 };
                Epic59.PokemonTypes = new List<PokemonType>() { fr5 };
                Epic62.PokemonTypes = new List<PokemonType>() { wat15, fgh4 };
                Epic65.PokemonTypes = new List<PokemonType>() { psy13 };
                Epic68.PokemonTypes = new List<PokemonType>() { fgh4 };
                Epic71.PokemonTypes = new List<PokemonType>() { gras8, psn12 };
                Epic76.PokemonTypes = new List<PokemonType>() { roc14, grd9 };
                Epic78.PokemonTypes = new List<PokemonType>() { fr5 };
                Epic82.PokemonTypes = new List<PokemonType>() { elc3 };
                Epic91.PokemonTypes = new List<PokemonType>() { wat15, ice10 };
                Epic93.PokemonTypes = new List<PokemonType>() { gh7, psn12 };
                Epic95.PokemonTypes = new List<PokemonType>() { roc14, grd9 };
                Epic105.PokemonTypes = new List<PokemonType>() { grd9 };
                Epic115.PokemonTypes = new List<PokemonType>() { norm11 };
                Epic117.PokemonTypes = new List<PokemonType>() { wat15 };
                Epic122.PokemonTypes = new List<PokemonType>() { psy13 };
                Epic124.PokemonTypes = new List<PokemonType>() { ice10, psy13 };
                Epic134.PokemonTypes = new List<PokemonType>() { wat15 };
                Epic135.PokemonTypes = new List<PokemonType>() { elc3 };
                Epic136.PokemonTypes = new List<PokemonType>() { fr5 };
                Epic137.PokemonTypes = new List<PokemonType>() { norm11 };
                Epic139.PokemonTypes = new List<PokemonType>() { roc14, wat15 };
                Epic141.PokemonTypes = new List<PokemonType>() { roc14, wat15 };
                Epic142.PokemonTypes = new List<PokemonType>() { roc14, fly6 };
                Epic148.PokemonTypes = new List<PokemonType>() { drg2 };

                cards.Add(Epic3);
                cards.Add(Epic6);
                cards.Add(Epic9);
                cards.Add(Epic12);
                cards.Add(Epic15);
                cards.Add(Epic18);
                cards.Add(Epic31);
                cards.Add(Epic34);
                cards.Add(Epic40);
                cards.Add(Epic45);
                cards.Add(Epic55);
                cards.Add(Epic59);
                cards.Add(Epic62);
                cards.Add(Epic65);
                cards.Add(Epic68);
                cards.Add(Epic71);
                cards.Add(Epic76);
                cards.Add(Epic78);
                cards.Add(Epic82);
                cards.Add(Epic91);
                cards.Add(Epic93);
                cards.Add(Epic95);
                cards.Add(Epic105);
                cards.Add(Epic115);
                cards.Add(Epic117);
                cards.Add(Epic122);
                cards.Add(Epic124);
                cards.Add(Epic134);
                cards.Add(Epic135);
                cards.Add(Epic136);
                cards.Add(Epic137);
                cards.Add(Epic139);
                cards.Add(Epic141);
                cards.Add(Epic142);
                cards.Add(Epic148);

            }

            //================================= Legendary Cards  ================================
            for (int i = 1; i < 5; i++)
            {
                Card lege94 = new Card() { pkdxNum = 94, Name = "Gengar", Description = "On the night of a full moon, if shadows move on their own and laugh, it must be Gengar’s doing.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market=false };
                Card lege130 = new Card() { pkdxNum = 130, Name = "Gyarados", Description = "It has an extremely aggressive nature. The Hyper Beam it shoots from its mouth totally incinerates all targets.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = false };
                Card lege144 = new Card() { pkdxNum = 144, Name = "Articuno", Description = "It’s said that this Pokémon’s beautiful blue wings are made of ice. Articuno flies over snowy mountains, its long tail fluttering along behind it.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = false };
                Card lege145 = new Card() { pkdxNum = 145, Name = "Zapdos", Description = "This Pokémon has complete control over electricity. There are tales of Zapdos nesting in the dark depths of pitch-black thunderclouds.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = false };
                Card lege146 = new Card() { pkdxNum = 146, Name = "Moltres", Description = "It’s one of the legendary bird Pokémon. When Moltres flaps its flaming wings, they glimmer with a dazzling red glow.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = false };
                Card lege149 = new Card() { pkdxNum = 149, Name = "Dragonite", Description = "It’s a kindhearted Pokémon. If it spots a drowning person or Pokémon, Dragonite simply must help them.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = false };
                Card lege150 = new Card() { pkdxNum = 150, Name = "Mewtwo", Description = "Its DNA is almost the same as Mew’s. However, its size and disposition are vastly different.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = false };
                Card lege151 = new Card() { pkdxNum = 151, Name = "Mew", Description = "When viewed through a microscope, this Pokémon’s short, fine, delicate hair can be seen.", SerialNumber = i + 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary, Market = false };

                i94.Cards.Add(lege94);
                i130.Cards.Add(lege130);
                i144.Cards.Add(lege144);
                i145.Cards.Add(lege145);
                i146.Cards.Add(lege146);
                i149.Cards.Add(lege149);
                i150.Cards.Add(lege150);
                i151.Cards.Add(lege151);

                drg2.Cards = new List<Card>() { lege149 };
                elc3.Cards = new List<Card>() { lege145 };
                fr5.Cards = new List<Card>() { lege146 };
                fly6.Cards = new List<Card>() { lege130, lege144, lege145, lege146, lege149 };
                gh7.Cards = new List<Card>() { lege94 };
                ice10.Cards = new List<Card>() { lege144 };
                psn12.Cards = new List<Card>() { lege94 };
                psy13.Cards = new List<Card>() { lege150, lege151 };
                wat15.Cards = new List<Card>() { lege130 };

                lege94.PokemonTypes = new List<PokemonType>() { gh7, psn12 };
                lege130.PokemonTypes = new List<PokemonType>() { wat15, fly6 };
                lege144.PokemonTypes = new List<PokemonType>() { ice10, fly6 };
                lege145.PokemonTypes = new List<PokemonType>() { elc3, fly6 };
                lege146.PokemonTypes = new List<PokemonType>() { fr5, fly6 };
                lege149.PokemonTypes = new List<PokemonType>() { drg2, fly6 };
                lege150.PokemonTypes = new List<PokemonType>() { psy13 };
                lege151.PokemonTypes = new List<PokemonType>() { psy13 };

                cards.Add(lege94);
                cards.Add(lege130);
                cards.Add(lege144);
                cards.Add(lege145);
                cards.Add(lege146);
                cards.Add(lege149);
                cards.Add(lege150);
                cards.Add(lege151);

            }


            //Database sales
            Sales s1 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 700) };
            Sales s2 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 600) };
            Sales s3 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 500) };
            Sales s4 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 400) };
            Sales s5 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 300) };
            Sales s6 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 200) };
            Sales s7 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 830) };
            Sales s8 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 820) };
            Sales s9 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 810) };
            Sales s10 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 500) };

            Sales s11 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 801) };
            Sales s12 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 802) };
            Sales s13 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 803) };
            Sales s14 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 704) };
            Sales s15 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 805) };
            Sales s16 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 806) };
            Sales s17 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 807) };
            Sales s18 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 808) };
            Sales s19 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 809) };
            Sales s20 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 810) };

            Sales s21 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 820) };
            Sales s22 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 830) };
            Sales s23 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 840) };
            Sales s24 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 850) };
            Sales s25 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 860) };
            Sales s26 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 870) };
            Sales s27 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 880) };
            Sales s28 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 890) };
            Sales s29 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 899) };
            Sales s30 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };

            Sales s31 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 821) };
            Sales s32 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 832) };
            Sales s33 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 843) };
            Sales s34 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 854) };
            Sales s35 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 865) };
            Sales s36 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 876) };
            Sales s37 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 887) };
            Sales s38 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 898) };
            Sales s39 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 890) };
            Sales s40 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 811) };

            Sales s41 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 822) };
            Sales s42 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 833) };
            Sales s43 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 844) };
            Sales s44 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 855) };
            Sales s45 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 866) };
            Sales s46 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 877) };
            Sales s47 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 888) };
            Sales s48 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 899) };
            Sales s49 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 898) };
            Sales s50 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 897) };

            Sales s51 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 122) };
            Sales s52 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 233) };
            Sales s53 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 344) };
            Sales s54 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 455) };
            Sales s55 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 566) };
            Sales s56 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 677) };
            Sales s57 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 788) };
            Sales s58 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 899) };
            Sales s59 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 198) };
            Sales s60 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 197) };
                   
            Sales s61 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 322) };
            Sales s62 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 333) };
            Sales s63 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 344) };
            Sales s64 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 355) };
            Sales s65 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 366) };
            Sales s66 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 377) };
            Sales s67 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 388) };
            Sales s68 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 399) };
            Sales s69 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 398) };
            Sales s70 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 397) };

            Sales s71 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s72 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s73 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s74 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s75 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s76 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s77 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s78 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s79 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };
            Sales s80 = new Sales() { PokemonName = "Mew", Price = new Random().Next(1, 800) };


            var sales = new List<Sales>()
            {
                s1,s2,s3,s5,s6,s7,s8,s9,s10,
                s11,s12,s13,s14,s15,s16,s17,s18,s19,s20,
                s21,s22,s23,s24,s25,s26,s27,s28,s29,s30,
                s31,s32,s33,s34,s35,s36,s37,s38,s39,s40,
                s41,s42,s43,s44,s45,s46,s47,s48,s49,s50,
                s51,s52,s53,s54,s55,s56,s57,s58,s59,s60,
                s61,s62,s63,s64,s65,s66,s67,s68,s69,s70,
                s71,s72,s73,s74,s75,s76,s77,s78,s79,s80 
            };




            context.Sales.AddRange(sales);
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

                admn1 = new ApplicationUser()
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    Balance = 10000,
                    PasswordHash = passwordHash.HashPassword("Admin1234!")
                };
              
                userManager.Create(admn1);
                userManager.AddToRole(admn1.Id, "Admin");

            }

            if (!context.Users.Any(u => u.UserName == "Adam@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(store);

                var passwordHash = new PasswordHasher();

                us1 = new ApplicationUser()
                {
                    UserName = "Adam@gmail.com",
                    Email = "Adam@gmail.com",
                    Balance = 10000,
                    PasswordHash = passwordHash.HashPassword("Adam1234!")
                };

                c1.User = us1;
                c2.User = us1;
                c3.User = us1;
                c4.User = us1;
                c5.User = us1;
                c6.User = us1;
                c7.User = us1;
                c8.User = us1;
                c9.User = us1;
                c10.User = us1;
                c11.User = us1;
                c12.User = us1;
                c13.User = us1;
                c14.User = us1;
                c15.User = us1;
                c16.User = us1;
                c17.User = us1;
                c18.User = us1;
                c19.User = us1;
                c20.User = us1;
                c21.User = us1;
                c22.User = us1;
                c23.User = us1;
                c24.User = us1;
                c25.User = us1;
                c26.User = us1;
                c27.User = us1;
                c28.User = us1;
                c29.User = us1;
                c30.User = us1;
                c151.User = us1;

                userManager.Create(us1);
                userManager.AddToRole(us1.Id, "Customer");


            }

            if (!context.Users.Any(u => u.UserName == "Nikolas@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(store);

                var passwordHash = new PasswordHasher();

                us2 = new ApplicationUser()
                {
                    UserName = "Nikolas@gmail.com",
                    Email = "Nikolas@gmail.com",
                    Balance = 10000,
                    PasswordHash = passwordHash.HashPassword("Nikolas1234!")
                };

                c31.User = us2;
                c32.User = us2;
                c33.User = us2;
                c34.User = us2;
                c35.User = us2;
                c36.User = us2;
                c37.User = us2;
                c38.User = us2;
                c39.User = us2;
                c40.User = us2;
                c41.User = us2;
                c42.User = us2;
                c43.User = us2;
                c44.User = us2;
                c45.User = us2;
                c46.User = us2;
                c47.User = us2;
                c48.User = us2;
                c49.User = us2;
                c50.User = us2;
                c51.User = us2;
                c52.User = us2;
                c53.User = us2;
                c54.User = us2;
                c55.User = us2;
                c56.User = us2;
                c57.User = us2;
                c58.User = us2;
                c59.User = us2;
                c60.User = us2;

                userManager.Create(us2);
                userManager.AddToRole(us2.Id, "Customer");


            }

            if (!context.Users.Any(u => u.UserName == "Kwstas@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(store);

                var passwordHash = new PasswordHasher();

                us3 = new ApplicationUser()
                {
                    UserName = "Kwstas@gmail.com",
                    Email = "Kwstas@gmail.com",
                    Balance = 10000,
                    PasswordHash = passwordHash.HashPassword("Kwstas1234!")
                };

                c61.User = us3;
                c62.User = us3;
                c63.User = us3;
                c64.User = us3;
                c65.User = us3;
                c66.User = us3;
                c67.User = us3;
                c68.User = us3;
                c69.User = us3;
                c70.User = us3;
                c71.User = us3;
                c72.User = us3;
                c73.User = us3;
                c74.User = us3;
                c75.User = us3;
                c76.User = us3;
                c77.User = us3;
                c78.User = us3;
                c79.User = us3;
                c80.User = us3;
                c81.User = us3;
                c82.User = us3;
                c83.User = us3;
                c84.User = us3;
                c85.User = us3;
                c86.User = us3;
                c87.User = us3;
                c88.User = us3;
                c89.User = us3;
                c90.User = us3;

                userManager.Create(us3);
                userManager.AddToRole(us3.Id, "Customer");


            }

            if (!context.Users.Any(u => u.UserName == "Spuros@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(store);

                var passwordHash = new PasswordHasher();

                us4 = new ApplicationUser()
                {
                    UserName = "Spuros@gmail.com",
                    Email = "Spuros@gmail.com",
                    Balance = 10000,
                    PasswordHash = passwordHash.HashPassword("Spuros1234!")
                };

                c91.User = us4;
                c92.User = us4;
                c93.User = us4;
                c94.User = us4;
                c95.User = us4;
                c96.User = us4;
                c97.User = us4;
                c98.User = us4;
                c99.User = us4;
                c100.User = us4;
                c101.User = us4;
                c102.User = us4;
                c103.User = us4;
                c104.User = us4;
                c105.User = us4;
                c106.User = us4;
                c107.User = us4;
                c108.User = us4;
                c109.User = us4;
                c110.User = us4;
                c111.User = us4;
                c112.User = us4;
                c113.User = us4;
                c114.User = us4;
                c115.User = us4;
                c116.User = us4;
                c117.User = us4;
                c118.User = us4;
                c119.User = us4;
                c120.User = us4;

                userManager.Create(us4);
                userManager.AddToRole(us4.Id, "Customer");


            }

            if (!context.Users.Any(u => u.UserName == "Mpampis@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(store);

                var passwordHash = new PasswordHasher();

                us5 = new ApplicationUser()
                {
                    UserName = "Mpampis@gmail.com",
                    Email = "Mpampis@gmail.com",
                    Balance = 10000,
                    PasswordHash = passwordHash.HashPassword("Mpampis1234!")
                };

                c121.User = us5;
                c122.User = us5;
                c123.User = us5;
                c124.User = us5;
                c125.User = us5;
                c126.User = us5;
                c127.User = us5;
                c128.User = us5;
                c129.User = us5;
                c130.User = us5;
                c131.User = us5;
                c132.User = us5;
                c133.User = us5;
                c134.User = us5;
                c135.User = us5;
                c136.User = us5;
                c137.User = us5;
                c138.User = us5;
                c139.User = us5;
                c140.User = us5;
                c141.User = us5;
                c142.User = us5;
                c143.User = us5;
                c144.User = us5;
                c145.User = us5;
                c146.User = us5;
                c147.User = us5;
                c148.User = us5;
                c149.User = us5;
                c150.User = us5;

                userManager.Create(us5);
                userManager.AddToRole(us5.Id, "Customer");


            }

            if (!context.Users.Any(u => u.UserName == "Test1@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(store);

                var passwordHash = new PasswordHasher();

                test1 = new ApplicationUser()
                {
                    UserName = "Test1@gmail.com",
                    Email = "Test1@gmail.com",
                    Balance = 100000,
                    PasswordHash = passwordHash.HashPassword("Test1234!")
                };

                userManager.Create(test1);
                userManager.AddToRole(test1.Id, "Customer");


            }


            context.SaveChanges();

        }
    }
}

