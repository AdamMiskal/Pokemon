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
            Card c1 = new Card() { Name = "Bulbasaur", Description = "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.", SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common };
            Card c2 = new Card() { Name = "Ivysaur", Description = "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c3 = new Card() { Name = "Venusaur", Description = "Its plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic };
            Card c4 = new Card() { Name = "Charmander", Description = "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.", SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common };
            Card c5 = new Card() { Name = "Charmeleon", Description = "It has a barbaric nature. In battle, it whips its fiery tail around and slashes away with sharp claws.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c6 = new Card() { Name = "Charizard", Description = "It spits fire that is hot enough to melt boulders. It may cause forest fires by blowing flames.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic };
            Card c7 = new Card() { Name = "Squirtl", Description = "When it retracts its long neck into its shell, it squirts out water with vigorous force.", SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common, };
            Card c8 = new Card() { Name = "Wartortle", Description = "It is recognized as a symbol of longevity. If its shell has algae on it, that Wartortle is very old.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c9 = new Card() { Name = "Blastoise", Description = "It crushes its foe under its heavy body to cause fainting. In a pinch, it will withdraw inside its shell.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic, };
            Card c10 = new Card() { Name = "Caterpie", Description = "For protection, it releases a horrible stench from the antenna on its head to drive away enemies.", SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Common };
            Card c11 = new Card() { Name = "Metapod", Description = "It is waiting for the moment to evolve. At this stage, it can only harden, so it remains motionless to avoid attack.", SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Rare };
            Card c12 = new Card() { Name = "Butterfree", Description = "In battle, it flaps its wings at great speed to release highly toxic dust into the air.", SerialNumber = 1, Attack = 4, Defence = 3, Rarity = Rarity.Epic };
            Card c13 = new Card() { Name = "Weedle", Description = "Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves.", SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common };
            Card c14 = new Card() { Name = "Kakuna", Description = "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy.", SerialNumber = 1, Attack = 3, Defence = 2, Rarity = Rarity.Rare, };
            Card c15 = new Card() { Name = "Beedrill", Description = "It has three poisonous stingers on its forelegs and its tail. They are used to jab its enemy repeatedly.", SerialNumber = 1, Attack = 4, Defence = 6, Rarity = Rarity.Epic };
            Card c16 = new Card() { Name = "Pidgey", Description = "Very docile. If attacked, it will often kick up sand to protect itself rather than fight back.", SerialNumber = 1, Attack = 3, Defence = 3, Rarity = Rarity.Common };
            Card c17 = new Card() { Name = "Pidgeotto", Description = "This Pokémon is full of vitality. It constantly flies around its large territory in search of prey.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c18 = new Card() { Name = "Pidgeot", Description = "This Pokémon flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Epic };
            Card c19 = new Card() { Name = "Rattata", Description = "Will chew on anything with its fangs. If you see one, you can be certain that 40 more live in the area.", SerialNumber = 1, Attack = 2, Defence = 4, Rarity = Rarity.Common };
            Card c20 = new Card() { Name = "Raticate", Description = "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.", SerialNumber = 1, Attack = 4, Defence = 5, Rarity = Rarity.Rare };
            Card c21 = new Card() { Name = "Spearow", Description = "Inept at flying high. However, it can fly around very fast to protect its territory.", SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common };
            Card c22 = new Card() { Name = "Fearow", Description = "A Pokémon that dates back many years. If it senses danger, it flies high and away, instantly.", SerialNumber = 1, Attack = 4, Defence = 6, Rarity = Rarity.Rare, };
            Card c23 = new Card() { Name = "Ekans", Description = "The older it gets, the longer it grows. At night, it wraps its long body around tree branches to rest.", SerialNumber = 1, Attack = 6, Defence = 5, Rarity = Rarity.Common };
            Card c24 = new Card() { Name = "Arbok", Description = "The frightening patterns on its belly have been studied. Six variations have been confirmed.", SerialNumber = 1, Attack = 6, Defence = 5, Rarity = Rarity.Rare };
            Card c25 = new Card() { Name = "Pikachu", Description = "Pikachu that can generate powerful electricity have cheek sacs that are extra soft and super stretchy.", SerialNumber = 1, Attack = 4, Defence = 3, Rarity = Rarity.Common };
            Card c26 = new Card() { Name = "Raichu", Description = "Its long tail serves as a ground to protect itself from its own high-voltage power.", SerialNumber = 1, Attack = 6, Defence = 4, Rarity = Rarity.Rare };
            Card c27 = new Card() { Name = "Sandshrew", Description = "It loves to bathe in the grit of dry, sandy areas. By sand bathing, the Pokémon rids itself of dirt and moisture clinging to its body.", SerialNumber = 1, Attack = 5, Defence = 5, Rarity = Rarity.Common };
            Card c28 = new Card() { Name = "Sandslash", Description = "The drier the area Sandslash lives in, the harder and smoother the Pokémon’s spikes will feel when touched.", SerialNumber = 1, Attack = 6, Defence = 7, Rarity = Rarity.Rare };
            Card c29 = new Card() { Name = "Nidoran", Description = "Females are more sensitive to smells than males. While foraging, they’ll use their whiskers to check wind direction and stay downwind of predators.", SerialNumber = 1, Attack = 3, Defence = 4, Rarity = Rarity.Common };
            Card c30 = new Card() { Name = "Nidorina", Description = "The horn on its head has atrophied. It’s thought that this happens so Nidorina’s children won’t get poked while their mother is feeding them.", SerialNumber = 1, Attack = 4, Defence = 4, Rarity = Rarity.Rare };
            Card c31 = new Card() { Name = "Nidoqueen", Description = "Nidoqueen is better at defense than offense. With scales like armor, this Pokémon will shield its children from any kind of attack.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c32 = new Card() { Name = "Nidoran", Description = "The horn on a male Nidoran’s forehead contains a powerful poison. This is a very cautious Pokémon, always straining its large ears.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c33 = new Card() { Name = "Nidorino", Description = "With a horn that’s harder than diamond, this Pokémon goes around shattering boulders as it searches for a moon stone.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c34 = new Card() { Name = "Nidoking", Description = "When it goes on a rampage, it’s impossible to control. But in the presence of a Nidoqueen it’s lived with for a long time, Nidoking calms down.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c35 = new Card() { Name = "Clefairy", Description = "It is said that happiness will come to those who see a gathering of Clefairy dancing under a full moon.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c36 = new Card() { Name = "Clefable", Description = "A timid fairy Pokémon that is rarely seen, it will run and hide the moment it senses people.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c37 = new Card() { Name = "Vulpix", Description = "While young, it has six gorgeous tails. When it grows, several new tails are sprouted.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c38 = new Card() { Name = "Ninetales", Description = "It is said to live 1,000 years, and each of its tails is loaded with supernatural powers.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c39 = new Card() { Name = "Jigglypuff", Description = "Jigglypuff has top-notch lung capacity, even by comparison to other Pokémon. It won’t stop singing its lullabies until its foes fall asleep.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c40 = new Card() { Name = "Wigglytuff", Description = "The more air it takes in, the more it inflates. If opponents catch it in a bad mood, it will inflate itself to an enormous size to intimidate them.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c41 = new Card() { Name = "Zubat", Description = "It emits ultrasonic waves from its mouth to check its surroundings. Even in tight caves, Zubat flies around with skill.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c42 = new Card() { Name = "Golbat", Description = "It loves to drink other creatures’ blood. It’s said that if it finds others of its kind going hungry, it sometimes shares the blood it’s gathered.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c43 = new Card() { Name = "Oddish", Description = "If exposed to moonlight, it starts to move. It roams far and wide at night to scatter its seeds.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c44 = new Card() { Name = "Gloom", Description = "Its pistils exude an incredibly foul odor. The horrid stench can cause fainting at a distance of 1.25 miles.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c45 = new Card() { Name = "Vileplume", Description = "It has the world’s largest petals. With every step, the petals shake out heavy clouds of toxic pollen.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c46 = new Card() { Name = "Paras", Description = "Burrows under the ground to gnaw on tree roots. The mushrooms on its back absorb most of the nutrition.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c47 = new Card() { Name = "Rarasect", Description = "The bug host is drained of energy by the mushroom on its back. The mushroom appears to do all the thinking.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c48 = new Card() { Name = "Venonat", Description = "Its large eyes act as radar. In a bright place, you can see that they are clusters of many tiny eyes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c49 = new Card() { Name = "Venomoth", Description = "The powdery scales on its wings are hard to remove from skin. They also contain poison that leaks out on contact.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c50 = new Card() { Name = "Digglett", Description = "If a Diglett digs through a field, it leaves the soil perfectly tilled and ideal for planting crops.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c51 = new Card() { Name = "Dugtrio", Description = "A team of Diglett triplets. It triggers huge earthquakes by burrowing 60 miles underground.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c52 = new Card() { Name = "Meowth", Description = "It loves to collect shiny things. If it’s in a good mood, it might even let its Trainer have a look at its hoard of treasures.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c53 = new Card() { Name = "Persian", Description = "Getting this prideful Pokémon to warm up to you takes a lot of effort, and it will claw at you the moment it gets annoyed.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c54 = new Card() { Name = "Psyduck", Description = "Psyduck is constantly beset by headaches. If the Pokémon lets its strange power erupt, apparently the pain subsides for a while.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c55 = new Card() { Name = "Golduck", Description = "This Pokémon lives in gently flowing rivers. It paddles through the water with its long limbs, putting its graceful swimming skills on display.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c56 = new Card() { Name = "Mankey", Description = "An agile Pokémon that lives in trees. It angers easily and will not hesitate to attack anything.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c57 = new Card() { Name = "Primeape", Description = "It stops being angry only when nobody else is around. To view this moment is very difficult.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c58 = new Card() { Name = "Growlithe", Description = "It has a brave and trustworthy nature. It fearlessly stands up to bigger and stronger foes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c59 = new Card() { Name = "Arcanine", Description = "The sight of it running over 6,200 miles in a single day and night has captivated many people.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c60 = new Card() { Name = "Poliwag", Description = "For Poliwag, swimming is easier than walking. The swirl pattern on its belly is actually part of the Pokémon’s innards showing through the skin.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c61 = new Card() { Name = "Poliwhirl", Description = "Staring at the swirl on its belly causes drowsiness. This trait of Poliwhirl’s has been used in place of lullabies to get children to go to sleep.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c62 = new Card() { Name = "Poliwrath", Description = "Its body is solid muscle. When swimming through cold seas, Poliwrath uses its impressive arms to smash through drift ice and plow forward.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c63 = new Card() { Name = "Abra", Description = "This Pokémon uses its psychic powers while it sleeps. The contents of Abra’s dreams affect the powers that the Pokémon wields.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c64 = new Card() { Name = "Kadabra", Description = "Using its psychic power, Kadabra levitates as it sleeps. It uses its springy tail as a pillow.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c65 = new Card() { Name = "Alakazam", Description = "It has an incredibly high level of intelligence. Some say that Alakazam remembers everything that ever happens to it, from birth till death.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c66 = new Card() { Name = "Machop", Description = "Its whole body is composed of muscles. Even though it’s the size of a human child, it can hurl 100 grown-ups.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c67 = new Card() { Name = "Machoke", Description = "Its muscular body is so powerful, it must wear a power-save belt to be able to regulate its motions.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c68 = new Card() { Name = "Machamp", Description = "It quickly swings its four arms to rock its opponents with ceaseless punches and chops from all angles.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c69 = new Card() { Name = "Bellsprout", Description = "Prefers hot and humid places. It ensnares tiny bugs with its vines and devours them.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c70 = new Card() { Name = "Weepinbell", Description = "When hungry, it swallows anything that moves. Its hapless prey is dissolved by strong acids.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c71 = new Card() { Name = "Victreebel", Description = "Lures prey with the sweet aroma of honey. Swallowed whole, the prey is dissolved in a day, bones and all.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c72 = new Card() { Name = "Tentacool", Description = "Tentacool is not a particularly strong swimmer. It drifts across the surface of shallow seas as it searches for prey.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c73 = new Card() { Name = "Tentacruel", Description = "When the red orbs on Tentacruel’s head glow brightly, watch out. The Pokémon is about to fire off a burst of ultrasonic waves.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c74 = new Card() { Name = "Geodude", Description = "Commonly found near mountain trails and the like. If you step on one by accident, it gets angry.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c75 = new Card() { Name = "Graveler", Description = "Often seen rolling down mountain trails. Obstacles are just things to roll straight over, not avoid.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c76 = new Card() { Name = "Golem", Description = "Once it sheds its skin, its body turns tender and whitish. Its hide hardens when it’s exposed to air.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c77 = new Card() { Name = "Ponyta", Description = "It can’t run properly when it’s newly born. As it races around with others of its kind, its legs grow stronger.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c78 = new Card() { Name = "Rapidash", Description = "This Pokémon can be seen galloping through fields at speeds of up to 150 mph, its fiery mane fluttering in the wind.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c79 = new Card() { Name = "Slowpoke", Description = "Slow-witted and oblivious, this Pokémon won’t feel any pain if its tail gets eaten. It won’t notice when its tail grows back, either.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c80 = new Card() { Name = "Slowbro", Description = "Slowpoke became Slowbro when a Shellder bit on to its tail. Sweet flavors seeping from the tail make the Shellder feel as if its life is a dream.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c81 = new Card() { Name = "Magnemite", Description = "At times, Magnemite runs out of electricity and ends up on the ground. If you give batteries to a grounded Magnemite, it’ll start moving again.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c82 = new Card() { Name = "Magneton", Description = "This Pokémon is three Magnemite that have linked together. Magneton sends out powerful radio waves to study its surroundings.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c83 = new Card() { Name = "Farfetch'd", Description = "The stalk this Pokémon carries in its wings serves as a sword to cut down opponents. In a dire situation, the stalk can also serve as food.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c84 = new Card() { Name = "Doduo", Description = "Its short wings make flying difficult. Instead, this Pokémon runs at high speed on developed legs.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c85 = new Card() { Name = "Dodrio", Description = "One of Doduo’s two heads splits to form a unique species. It runs close to 40 mph in prairies.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c86 = new Card() { Name = "Seel", Description = "Loves freezing-cold conditions. Relishes swimming in a frigid climate of around 14 degrees Fahrenheit.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c87 = new Card() { Name = "Dewgong", Description = "Its entire body is a snowy white. Unharmed by even intense cold, it swims powerfully in icy waters.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c88 = new Card() { Name = "Grimer", Description = "Made of congealed sludge. It smells too putrid to touch. Even weeds won’t grow in its path.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c89 = new Card() { Name = "Muk", Description = "Smells so awful, it can cause fainting. Through degeneration of its nose, it lost its sense of smell.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c90 = new Card() { Name = "Shellder", Description = "It swims facing backward by opening and closing its two-piece shell. It is surprisingly fast.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c91 = new Card() { Name = "Cloyster", Description = "Its shell is extremely hard. It cannot be shattered, even with a bomb. The shell opens only when it is attacking.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c92 = new Card() { Name = "Gastly", Description = "Born from gases, anyone would faint if engulfed by its gaseous body, which contains poison.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c93 = new Card() { Name = "Haunter", Description = "Its tongue is made of gas. If licked, its victim starts shaking constantly until death eventually comes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c94 = new Card() { Name = "Gengar", Description = "On the night of a full moon, if shadows move on their own and laugh, it must be Gengar’s doing.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary };
            Card c95 = new Card() { Name = "Onix", Description = "As it digs through the ground, it absorbs many hard objects. This is what makes its body so solid.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c96 = new Card() { Name = "Drowzee", Description = "If you sleep by it all the time, it will sometimes show you dreams it had eaten in the past.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c97 = new Card() { Name = "Hypno", Description = "Avoid eye contact if you come across one. It will try to put you to sleep by using its pendulum.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c98 = new Card() { Name = "Krabby", Description = "It can be found near the sea. The large pincers grow back if they are torn out of their sockets.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c99 = new Card() { Name = "Kingler", Description = "Its large and hard pincer has 10,000-horsepower strength. However, being so big, it is unwieldy to move.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c100 = new Card() { Name = "Voltrob", Description = "It is said to camouflage itself as a Poké Ball. It will self-destruct with very little stimulus.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c101 = new Card() { Name = "Electrode", Description = "Stores electrical energy inside its body. Even the slightest shock could trigger a huge explosion.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c102 = new Card() { Name = "Exeggcute", Description = "Though it may look like it’s just a bunch of eggs, it’s a proper Pokémon. Exeggcute communicates with others of its kind via telepathy, apparently.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c103 = new Card() { Name = "Exeggutor", Description = "Each of Exeggutor’s three heads is thinking different thoughts. The three don’t seem to be very interested in one another.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c104 = new Card() { Name = "Cubone", Description = "When the memory of its departed mother brings it to tears, its cries echo mournfully within the skull it wears on its head.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c105 = new Card() { Name = "Marowak", Description = "This Pokémon overcame its sorrow to evolve a sturdy new body. Marowak faces its opponents bravely, using a bone as a weapon.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c106 = new Card() { Name = "Hitmonlee", Description = "This amazing Pokémon has an awesome sense of balance. It can kick in succession from any position.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c107 = new Card() { Name = "Hitmonchan", Description = "Its punches slice the air. They are launched at such high speed, even a slight graze could cause a burn.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c108 = new Card() { Name = "Lickitung", Description = "If this Pokémon’s sticky saliva gets on you and you don’t clean it off, an intense itch will set in. The itch won’t go away, either.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c109 = new Card() { Name = "Koffing", Description = "Its body is full of poisonous gas. It floats into garbage dumps, seeking out the fumes of raw, rotting trash.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c110 = new Card() { Name = "Weezing", Description = "It mixes gases between its two bodies. It’s said that these Pokémon were seen all over the Galar region back in the day.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c111 = new Card() { Name = "Rhyhorn", Description = "Strong, but not too bright, this Pokémon can shatter even a skyscraper with its charging tackles", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c112 = new Card() { Name = "Rhydon", Description = "It begins walking on its hind legs after evolution. It can punch holes through boulders with its horn.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c113 = new Card() { Name = "Chansey", Description = "The egg Chansey carries is not only delicious but also packed with nutrition. It’s used as a high-class cooking ingredient.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c114 = new Card() { Name = "Tangela", Description = "Hidden beneath a tangle of vines that grows nonstop even if the vines are torn off, this Pokémon’s true appearance remains a mystery.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c115 = new Card() { Name = "Kangaskhan", Description = "Although it’s carrying its baby in a pouch on its belly, Kangaskhan is swift on its feet. It intimidates its opponents with quick jabs.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c116 = new Card() { Name = "Horsea", Description = "Horsea makes its home in oceans with gentle currents. If this Pokémon is under attack, it spits out pitch-black ink and escapes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c117 = new Card() { Name = "Seadra", Description = "It’s the males that raise the offspring. While Seadra are raising young, the spines on their backs secrete thicker and stronger poison.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c118 = new Card() { Name = "Goldeen", Description = "Its dorsal, pectoral, and tail fins wave elegantly in water. That is why it is known as the Water Dancer.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c119 = new Card() { Name = "Seaking", Description = "In autumn, its body becomes more fatty in preparing to propose to a mate. It takes on beautiful colors.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c120 = new Card() { Name = "Staryu", Description = "If you visit a beach at the end of summer, you’ll be able to see groups of Staryu lighting up in a steady rhythm.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c121 = new Card() { Name = "Starmie", Description = "This Pokémon has an organ known as its core. The organ glows in seven colors when Starmie is unleashing its potent psychic powers.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c122 = new Card() { Name = "Mr.Mime", Description = "The broadness of its hands may be no coincidence—many scientists believe its palms became enlarged specifically for pantomiming.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c123 = new Card() { Name = "Scyther", Description = "As Scyther fights more and more battles, its scythes become sharper and sharper. With a single slice, Scyther can fell a massive tree.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c124 = new Card() { Name = "Jynx", Description = "In certain parts of Galar, Jynx was once feared and worshiped as the Queen of Ice.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c125 = new Card() { Name = "Electabuzz", Description = "Many power plants keep Ground-type Pokémon around as a defense against Electabuzz that come seeking electricity.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c126 = new Card() { Name = "Magmar", Description = "Magmar dispatches its prey with fire. But it regrets this habit once it realizes that it has burned its intended prey to a charred crisp.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c127 = new Card() { Name = "Pinsir", Description = "These Pokémon judge one another based on pincers. Thicker, more impressive pincers make for more popularity with the opposite gender.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c128 = new Card() { Name = "Tauros", Description = "When Tauros begins whipping itself with its tails, it’s a warning that the Pokémon is about to charge with astounding speed.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c129 = new Card() { Name = "Magikarp", Description = "It is virtually worthless in terms of both power and speed. It is the most weak and pathetic Pokémon in the world.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c130 = new Card() { Name = "Gyarados", Description = "It has an extremely aggressive nature. The Hyper Beam it shoots from its mouth totally incinerates all targets.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary };
            Card c131 = new Card() { Name = "Lapras", Description = "A smart and kindhearted Pokémon, it glides across the surface of the sea while its beautiful song echoes around it.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c132 = new Card() { Name = "Ditto", Description = "It can reconstitute its entire cellular structure to change into what it sees, but it returns to normal when it relaxes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c133 = new Card() { Name = "Eevee", Description = "It has the ability to alter the composition of its body to suit its surrounding environment.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Common };
            Card c134 = new Card() { Name = "Vaporeon", Description = "When Vaporeon’s fins begin to vibrate, it is a sign that rain will come within a few hours.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c135 = new Card() { Name = "Jolteon", Description = "If it is angered or startled, the fur all over its body bristles like sharp needles that pierce foes.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c136 = new Card() { Name = "Flareon", Description = "Once it has stored up enough heat, this Pokémon’s body temperature can reach up to 1,700 degrees Fahrenheit.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c137 = new Card() { Name = "Porygon", Description = "State-of-the-art technology was used to create Porygon. It was the first artificial Pokémon to be created via computer programming.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c138 = new Card() { Name = "Omanyte", Description = "Because some Omanyte manage to escape after being restored or are released into the wild by people, this species is becoming a problem.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c139 = new Card() { Name = "Omastar", Description = "Weighed down by a large and heavy shell, Omastar couldn’t move very fast. Some say it went extinct because it was unable to catch food.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c140 = new Card() { Name = "Kabuto", Description = "This species is almost entirely extinct. Kabuto molt every three days, making their shells harder and harder.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c141 = new Card() { Name = "Kabutops", Description = "Kabutops slices its prey apart and sucks out the fluids. The discarded body parts become food for other Pokémon.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c142 = new Card() { Name = "Aerodactyl", Description = "This is a ferocious Pokémon from ancient times. Apparently even modern technology is incapable of producing a perfectly restored specimen.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c143 = new Card() { Name = "Snorlax", Description = "It is not satisfied unless it eats over 880 pounds of food every day. When it is done eating, it goes promptly to sleep.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c144 = new Card() { Name = "Articuno", Description = "It’s said that this Pokémon’s beautiful blue wings are made of ice. Articuno flies over snowy mountains, its long tail fluttering along behind it.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary };
            Card c145 = new Card() { Name = "Zapdos", Description = "This Pokémon has complete control over electricity. There are tales of Zapdos nesting in the dark depths of pitch-black thunderclouds.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary };
            Card c146 = new Card() { Name = "Moltres", Description = "It’s one of the legendary bird Pokémon. When Moltres flaps its flaming wings, they glimmer with a dazzling red glow.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary };
            Card c147 = new Card() { Name = "Dratini", Description = "Dratini dwells near bodies of rapidly flowing water, such as the plunge pools of waterfalls. As it grows, Dratini will shed its skin many times.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Rare };
            Card c148 = new Card() { Name = "Dragonair", Description = "This Pokémon lives in pristine oceans and lakes. It can control the weather, and it uses this power to fly into the sky, riding on the wind.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Epic };
            Card c149 = new Card() { Name = "Dragonite", Description = "It’s a kindhearted Pokémon. If it spots a drowning person or Pokémon, Dragonite simply must help them.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary };
            Card c150 = new Card() { Name = "Mewtwo", Description = "Its DNA is almost the same as Mew’s. However, its size and disposition are vastly different.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary };
            Card c151 = new Card() { Name = "Mew", Description = "When viewed through a microscope, this Pokémon’s short, fine, delicate hair can be seen.", SerialNumber = 1, Attack = new Random().Next(1, 10), Defence = new Random().Next(1, 10), Rarity = Rarity.Legendary };

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

            //c77.PokemonTypes = new List<PokemonType>() { roc14 };
            //c78.PokemonTypes = new List<PokemonType>() { roc14 };
            //c79.PokemonTypes = new List<PokemonType>() { roc14 };
            //c80.PokemonTypes = new List<PokemonType>() { roc14 };
            //c81.PokemonTypes = new List<PokemonType>() { roc14 };
            //c82.PokemonTypes = new List<PokemonType>() { roc14 };
            //c83.PokemonTypes = new List<PokemonType>() { roc14 };
            //c84.PokemonTypes = new List<PokemonType>() { roc14 };
            //c85.PokemonTypes = new List<PokemonType>() { roc14 };
            //c86.PokemonTypes = new List<PokemonType>() { roc14 };
            //c87.PokemonTypes = new List<PokemonType>() { roc14 };
            //c88.PokemonTypes = new List<PokemonType>() { roc14 };
            //c89.PokemonTypes = new List<PokemonType>() { roc14 };
            //c90.PokemonTypes = new List<PokemonType>() { roc14 };
            //c91.PokemonTypes = new List<PokemonType>() { roc14 };
            //c92.PokemonTypes = new List<PokemonType>() { roc14 };
            //c93.PokemonTypes = new List<PokemonType>() { roc14 };
            //c94.PokemonTypes = new List<PokemonType>() { roc14 };
            //c95.PokemonTypes = new List<PokemonType>() { roc14 };
            //c96.PokemonTypes = new List<PokemonType>() { roc14 };
            //c97.PokemonTypes = new List<PokemonType>() { roc14 };
            //c98.PokemonTypes = new List<PokemonType>() { roc14 };
            //c99.PokemonTypes = new List<PokemonType>() { roc14 };
            //c100.PokemonTypes = new List<PokemonType>() { roc14 };
            //c101.PokemonTypes = new List<PokemonType>() { roc14 };
            //c102.PokemonTypes = new List<PokemonType>() { roc14 };
            //c103.PokemonTypes = new List<PokemonType>() { roc14 };
            //c104.PokemonTypes = new List<PokemonType>() { roc14 };
            //c105.PokemonTypes = new List<PokemonType>() { roc14 };
            //c106.PokemonTypes = new List<PokemonType>() { roc14 };
            //c107.PokemonTypes = new List<PokemonType>() { roc14 };
            //c108.PokemonTypes = new List<PokemonType>() { roc14 };
            //c109.PokemonTypes = new List<PokemonType>() { roc14 };
            //c110.PokemonTypes = new List<PokemonType>() { roc14 };
            //c111.PokemonTypes = new List<PokemonType>() { roc14 };
            //c112.PokemonTypes = new List<PokemonType>() { roc14 };
            //c113.PokemonTypes = new List<PokemonType>() { roc14 };
            //c114.PokemonTypes = new List<PokemonType>() { roc14 };
            //c115.PokemonTypes = new List<PokemonType>() { roc14 };
            //c116.PokemonTypes = new List<PokemonType>() { roc14 };
            //c117.PokemonTypes = new List<PokemonType>() { roc14 };
            //c118.PokemonTypes = new List<PokemonType>() { roc14 };
            //c119.PokemonTypes = new List<PokemonType>() { roc14 };
            //c120.PokemonTypes = new List<PokemonType>() { roc14 };
            //c121.PokemonTypes = new List<PokemonType>() { roc14 };
            //c122.PokemonTypes = new List<PokemonType>() { roc14 };
            //c123.PokemonTypes = new List<PokemonType>() { roc14 };
            //c124.PokemonTypes = new List<PokemonType>() { roc14 };
            //c125.PokemonTypes = new List<PokemonType>() { roc14 };
            //c126.PokemonTypes = new List<PokemonType>() { roc14 };
            //c127.PokemonTypes = new List<PokemonType>() { roc14 };
            //c128.PokemonTypes = new List<PokemonType>() { roc14 };
            //c129.PokemonTypes = new List<PokemonType>() { roc14 };
            //c130.PokemonTypes = new List<PokemonType>() { roc14 };
            //c131.PokemonTypes = new List<PokemonType>() { roc14 };
            //c132.PokemonTypes = new List<PokemonType>() { roc14 };
            //c133.PokemonTypes = new List<PokemonType>() { roc14 };
            //c134.PokemonTypes = new List<PokemonType>() { roc14 };
            //c135.PokemonTypes = new List<PokemonType>() { roc14 };
            //c136.PokemonTypes = new List<PokemonType>() { roc14 };
            //c137.PokemonTypes = new List<PokemonType>() { roc14 };
            //c138.PokemonTypes = new List<PokemonType>() { roc14 };
            //c139.PokemonTypes = new List<PokemonType>() { roc14 };
            //c140.PokemonTypes = new List<PokemonType>() { roc14 };
            //c141.PokemonTypes = new List<PokemonType>() { roc14 };

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
                i117,i118,i119,i120,i121,i122,i123,i124,i125,i126,i127,i128,i129,i130,i31,i32,i33,i34,i35,i136,i137,i138,i139,i140,i141,
                i142,i143,i144,i145,i146,i147,i148,i149,i150,i151
            };



            //================================= Common Cards  ================================
            //for (int i = 0; i < 50; i++)
            //{
            //    //
            //}


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

