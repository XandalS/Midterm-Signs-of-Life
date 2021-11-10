using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Signs_of_Life
{
    class Game
    {
        //Var
        public string Input;
        public bool StoryComplete;
        public Location Place;
        public List <Location> Map =new List<Location>();
        public bool GUnlocked = false;
        public bool Clied = false;
        public Player Ame;
        //Construct
        public Game()
        {
            Title = "Signs of Life";
            StoryComplete = false;
            Player Ame = new Player();
            this.Ame = Ame;
            LoadMap();
            StoryBegin();
            while (StoryComplete == false)
            {
                
                Clear();
                Place.DisplayDescription();
                WriteLine("What would you like to do?");
                Place.PeopleDescriptions(this);
                WriteLine();
                WriteLine();
                WriteLine();
                WriteLine();
                WriteLine("Inputs: Move, Search, Clue");
                Input = ReadLine().ToLower();
                switch (Input)
                {
                    case "search":
                        Investigate();
                        break;
                    case "move":
                        Move();
                        break;
                    case "clue":
                        Clue();
                        break;
                }
            }
            Clear();
            WriteLine("Congrats You beat the game.");
            if (GUnlocked == true)
            {
                WriteLine("And I made friends with the girl! Her name is Ina. Ina, Gura, Calli, Kiara, and I all got invited by the business man Calli went to see to become idols. We are now part of Hololive's EN branch generation 1 'Myth'!");
            }else if (Clied == true)
            {
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("I told you to stay out of the city, this is what you get for disobeying the reaper.");
            }
            else
            {
                WriteLine("But the girl didnt find you alone enough to stop her. Nah I wasnt there in this timeline, I'm still alive after all~");
            }
        }
        //Method
        public void Clue()
        {
            WriteLine("I have knowledge of:");
            //Make the clues show up from the player character
            foreach (string c in Ame.Clues)
            {
                WriteLine(c);
            }
            ReadKey(true);
        }
        public void Move()
        {
            Location Guide;
            string Direction;
            Guide = Place;
            int i = 0;
            Clear();
            WriteLine("Where do you want to go?");
            foreach (Location N in Place.Direction)
            {
                if (Place.CName == "Beach Docks")
                {
                    SubCheck();
                }
                if (N.CName == "Doesnt exist")
                {

                }
                else
                {
                    ForegroundColor = ConsoleColor.Gray;
                    Write($"{N.CName} is in the ");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine(N.DName[i]);
                    ForegroundColor = ConsoleColor.Gray;
                }
                i++;
            }
            Direction = ReadLine().ToLower();
            switch (Direction)
            {
                case "north":
                    Guide = Place.Direction[0];
                    if (Place.Direction[0].CName == "Doesnt exist")
                    {
                        WriteLine("Well I guess I can look around here more.");
                        Place.DisplayDescription();
                    }
                    else
                    {
                        Place = Guide;
                        WriteLine("Wonder what I will find over here.");
                        Place.ChangeTitle(Place.CName);
                        Place.DisplayDescription();
                    }
                    break;
                case "west":
                    Guide = Place.Direction[2];
                    if (Place.Direction[2].CName == "Doesnt exist")
                    {
                        WriteLine("Well I guess I can look around here more.");
                        Place.DisplayDescription();
                    }
                    else
                    {
                        Place = Guide;
                        WriteLine("Wonder what I will find over here.");
                        Place.ChangeTitle(Place.CName);
                        Place.DisplayDescription();
                    }
                    break;
                case "east":
                    Guide = Place.Direction[1];

                    if (Place.Direction[1].CName == "Doesnt exist")
                    {
                        WriteLine("Well I guess I can look around here more.");
                        Place.ChangeTitle(Place.CName);
                        Place.DisplayDescription();
                    }
                    else if (Place.Direction[1].CName == "The inner city")
                    {
                        Clied = true;
                        WriteLine("Ignoring the reapers warnings I walked towards the city and found-");
                        WriteLine("SHING");
                        ReadKey(true);
                        StoryComplete = true;
                    }
                    else
                    {
                        Place = Guide;
                        WriteLine("Wonder what I will find over here.");
                        Place.ChangeTitle(Place.CName);
                        Place.DisplayDescription();
                    }
                    break;
                case "south":
                    Guide = Place.Direction[3];
                    if (Place.Direction[3].CName == "Doesnt exist")
                    {
                        WriteLine("Well I guess I can look around here more.");
                        Place.ChangeTitle(Place.CName);
                        Place.DisplayDescription();
                    }
                    else
                    {
                        Place = Guide;
                        WriteLine("Wonder what I will find over here.");
                        Place.ChangeTitle(Place.CName);
                        Place.DisplayDescription();
                    }
                    break;
            }
            //Change the area of where the player is into something new
            Place.SetLocation(Direction, Guide);
            if (Guide != Place)
            {
                Place = Guide;
                WriteLine("Wonder what I will find over here.");
                Place.DisplayDescription();
            }
            else
            {
                WriteLine("Well I guess I can look around here more.");
                Place.DisplayDescription();
            }

        }
        public void Investigate()
        {
            int index = 0;
            int r;
            foreach (Person p in Place.Collective)
            {
                if(p.Name == "Gura")
                {
                    if(GUnlocked == true)
                    {
                        WriteLine($"Type {index} to speak to {p.Name}");
                        index++;
                    }
                    else
                    {
                        index++;
                    }

                }
                else
                {
                    WriteLine($"Type {index} to speak to {p.Name}");
                    index++;
                }

                
            }
            try
            {
                r = Convert.ToInt32(ReadLine());
                Place.Collective[r].Investigated(this);
            }
            catch (SystemException)
            {
               
            }
            
        }

        public void LoadMap()
        {
            Clue no = new Clue("no", "no");
            Location location0 = new Location("Doesnt exist", "You shouldnt be here... how are you here?");
            Location location1 = new Location("Beach Docks","A small dock above the beach of Holosville. Its quite quant here.");
            Checking subCheck = new Checking("SubKey", false, true);
            Gura G1 = new Gura("Gura", no, "She is standing on the docks seemingly waiting for me.");
            location1.Collective.Add(G1);
            Clue SubKey = new Clue("SubKey", "Its the key that is used to get into the submarine.");
            Scuba_Man scuba = new Scuba_Man("Sub Man", SubKey, "Just a kindly old man sitting by the docks. I called him beforehand to ask for use of his sub, after all if any clues exist they may be bellow the sea.");
            Checking gUnlocked = new Checking("Gura", false, true);
            location1.Collective.Add(scuba);
            location1.Conditions.Add(gUnlocked);
            location1.Conditions.Add(subCheck);
            location1.ConditionCheck(G1, GUnlocked);
            Location location2 = new Location("Bellow the Docks", "The water flows above the craft as I sit here... I bet bubba would like it in here.");
            Location location3 = new Location("Coral Docks", "The docks are in the distance, the coral bellow my craft tells me that this isnt a good place to be.");
            Location location4 = new Location("Wall of Coral", "There is a wall of coral infront of me, I cant go to the South or to the West.");
            Location location5 = new Location("Holoville boardwalk Southermost point", "The boardwalk of Holoville stretches to the north, people walk up and down it without a care in the world.");
            Location location6 = new Location("Atlantis Diner", "A quaint looking diner that is styled after the legend of Atlantis. White collums rise against the walls with seafoam green and a royal blue.");
            Location location14 = new Location("Near Docks Beach", "The waves crash up and down on the sandy beaches here.");
            Location location15 = new Location("Southmost shore", "The docks are to your south, there is nothing but sand bellow the sub now.");
            Gura G2 = new Gura("Gura", no, "She is just walking on the bottom of the oceanbed like normal ground, maybe she is some type of Atlantian after all...");
            location15.Collective.Add(G2);
            location15.Conditions.Add(gUnlocked);
            location15.ConditionCheck(G2,GUnlocked);
            Location location16 = new Location("Coral Gap", "The Holosville coral reef stretches to either side of my sub.");
            Gura G3 = new Gura("Gura", no, "I can see her form still walking on the oceanfloor bellow me longer than any human ever could... though all she has been doing is walking. I wonder is this shark cant swim.");
            location16.Collective.Add(G3);
            location15.Conditions.Add(gUnlocked);
            location16.ConditionCheck(G3, GUnlocked);
            Location location17 = new Location("Coral Canyon", "The reef begins to close in as the waters deepen, it is difficult to move foreward in the sub.");
            Gura G4 = new Gura("Gura", no, "I just watched her jump about 30 feet up in the water with ease, her back tail must really be useful... and more real than I thought. She is currently waiting for me in a small hole in the coral.");
            location17.Collective.Add(G4);
            location17.Conditions.Add(gUnlocked);
            location17.ConditionCheck(G4, GUnlocked);
            Location location18 = new Location("Trench of Coral", "The deepest part of the reef, Its harder to move down here than before.");
            Gura G5 = new Gura("Gura", no, "She is walking through the coral with ease before jumping without fear into the deep darkness of the trench.");
            location18.Collective.Add(G5);
            location18.Conditions.Add(gUnlocked);
            location18.ConditionCheck(G5, GUnlocked);
            Location location19 = new Location("Holoville Gift shop entrance", "A weird gift shop with some strange statue of a white haired girl in the window.");
            Location location20 = new Location("Holoville Gift shop", "The whole shop is decorated with this weird girl with white hair, I think it originally was a shark shop based on the shark hung from the ceiling.");
            Location location28 = new Location("Populated beach", "There are actually people here, its pretty close to the entrance to town so it makes sense that people flock from there.");
            Location location29 = new Location("Populated shore", "Hehe I wonder how many people I could scare if I put a shark fin on top of the sub here.");
            Clue IslandL = new Clue("Island Location", "The strange girl named Gura seemed to know where the island, I am going to follow her to it.");
            Gura SHG = new Gura("White haired Girl", IslandL, "There is a white haired girl floating on the surface of the water with her back up. She seems to be dead.");
            location28.Collective.Add(SHG);
            Location location30 = new Location("Coral Gap Wall", "The coral reef of Holosville rises high here. The sub will have difficulty moving from here.");
            Location location31 = new Location("Against the coral wall", "The wall of coral is pretty strong here, I dont think I can break through this. Gonna need to find a way around.");
            Location location32 = new Location("Trench bubble", "A massive bubble of air lays infront of me. I dont know what is going on here but I am going to have to abandon my sub to go further.");
            Gura G6 = new Gura("Gura", no, "My doubts in the shark girl are starting to fade as I go further and further in with her. Especially with what lies before me...");
            location32.Collective.Add(G6);
            location32.ConditionCheck(G6, GUnlocked);
            Location location33 = new Location("The town on the island of Ninomae", "A very rough and earie aura lays in the air... something seriously happened here, but what?");
            Gura G7 = new Gura("Gura", no, "She is standing next to me... she must not have truely been in here either with how off disturbed by the air in here is to her, though I am not one to talk.");
            location33.Collective.Add(G7);
            Ina ina = new Ina("Mysterious girl",no, "A purple haired girl with a strange floating orange ring behind her stands at the center of the bubble of the city. She seems to have small angel wings either coming out of or just floating around her hips along with an unsettling aura that we are only seeing a portion of her true body.");
            location33.Collective.Add(ina);
            location33.ConditionCheck(G7, GUnlocked);
            Location location34 = new Location("Boardwalk scuba", "Of course there is a scuba shop here, would be a major tourist attraction if more people came here.");
            Clue GuraL = new Clue("Strange girl's location", "Acording to Kiara's instructions there is a white haired girl acting like a dead swimmer to scare passeres by on the beach. She may know what happened to the island or better be able to show me.");
            Kiara kiara = new Kiara("Kiara", GuraL, "Kiara is standing on the boardwalk holding a KFP sign, apparently even the CEO of a food chain has to do sign twirling every once in a while");
            location34.Collective.Add(kiara);
            Location location35 = new Location("Scuba shop", "A heavy smell of dust wafts around me with the air almost becoming suffocating. No one probably visits here often.");
            Location location43 = new Location("Town boardwalk", "The town's beach entrance, I would love to go deeper into it and see what investigations I can find but I have to focus on the current task at hand");
            Location location44 = new Location("Beach of Holosville", "The view from here is quite sceanic, an ocean to the front of me.");
            Location location45 = new Location("Shore of Holosville", "The water splashes and washes over shore here, the view isnt quite as sceanic underwater but it still is nice.");
            Location location46 = new Location("Coral Reef", "The rough reefs are scratching against the bottom of the sub, I really shouldnt be here.");
            Location location47 = new Location("My underwater house", "A small hole in the coral, I shall name this place mine. Soon I will come back to build an underwater research center for developing more potent versions of my Watson Concoction!!");
            Location location48 = new Location("Coral Reef", "A rough section of water where the coral grows high, if Im not careful I may puncture the sub!");
            Location location49 = new Location("Streets of Holosville", "The entrance to the inner city, it looks big and bustling here. Calli said not to go in there but she cant tell me what to do, she is only an apprentice reaper after all.");
            Location location57 = new Location("KFP Boardwalk", "The new KFP establishment, the smell of fried chi- I mean pheonix keeps wafting out smelling super good. I am half tempted to go in and order some.");
            Location location58 = new Location("Littered Beach", "This section of the beach has seen better days, its full of KFP boxes and bags. If I had more time I would stay and try to help clean but I need to finish my investigation first.");
            Location location59 = new Location("Littered Ocean", "The liter drifts along the surface of the water, I sigh thinking on how many browny points I could earn with Mother Nature if I were to clean all this up.");
            Location location60 = new Location("Clean basin", "A small clean part of the ocean. The litter hasn't made its way out this far yet.");
            Location location61 = new Location("Coral Reef", "Rough patches of water with some coral sprinkled about, its difficult to move here.");
            Location location62 = new Location("KFP", "The smell of fried pheonix is everywhere here. I desperately want to get some food but need to stay on track for the investigation, though strangely enough there is a small shark like creature here that seems to be eating an entire bucket of pheonix wings by itself...");
            Location location63 = new Location("The inner city", "You shouldnt be here");
            Map.Add(location0);
            SettingLocation(location1,location14,location2,location5,location0);
            Map.Add(location1);
            SettingLocation(location2, location15, location3, location1, location0);
            Map.Add(location2);
            SettingLocation(location3, location16, location4, location2, location0);
            Map.Add(location3);
            SettingLocation(location4, location17, location0, location3, location0);
            Map.Add(location4);
            SettingLocation(location5, location19, location1, location6, location0);
            Map.Add(location5);
            SettingLocation(location6, location0, location5, location0, location0);
            Map.Add(location6);
            SettingLocation(location14, location28, location0, location19, location1);
            Map.Add(location14);
            SettingLocation(location15, location29, location16, location0, location2);
            Map.Add(location15);
            SettingLocation(location16, location30, location17, location15, location3);
            Map.Add(location16);
            SettingLocation(location17, location31, location18, location16, location4);
            Map.Add(location17);
            SettingLocation(location18, location32, location0, location17, location0);
            Map.Add(location18);
            SettingLocation(location19, location34, location14, location20, location5);
            Map.Add(location19);
            SettingLocation(location20, location0, location19, location0, location0);
            Map.Add(location20);
            SettingLocation(location28, location44, location0, location34, location14);
            Map.Add(location28);
            SettingLocation(location29, location45, location30, location0, location15);
            Map.Add(location29);
            SettingLocation(location30, location46, location31, location29, location16);
            Map.Add(location30);
            SettingLocation(location31, location47, location32, location30, location17);
            Map.Add(location31);
            SettingLocation(location32, location48, location33, location31, location18);
            Map.Add(location32);
            SettingLocation(location33, location0, location0, location0, location0);
            Map.Add(location33);
            SettingLocation(location34, location43, location28, location35, location19);
            Map.Add(location34);
            SettingLocation(location35, location0, location35, location0, location0);
            Map.Add(location35);
            SettingLocation(location43, location57, location44, location49, location34);
            Map.Add(location43);
            SettingLocation(location44, location58, location0, location43, location28);
            Map.Add(location44);
            SettingLocation(location45, location59, location46, location0, location29);
            Map.Add(location45);
            SettingLocation(location46, location60, location47, location45, location30);
            Map.Add(location46);
            SettingLocation(location47, location61, location48, location46, location31);
            Map.Add(location47);
            SettingLocation(location48, location0, location0, location47, location32);
            Map.Add(location48);
            SettingLocation(location49, location0, location43, location63, location0);
            Map.Add(location49);
            SettingLocation(location57, location0, location58, location62, location43);
            Map.Add(location57);
            SettingLocation(location58, location0, location0, location57, location44);
            Map.Add(location58);
            SettingLocation(location59, location0, location60, location0, location45);
            Map.Add(location59);
            SettingLocation(location60, location0, location61, location59, location46);
            Map.Add(location60);
            SettingLocation(location61, location0, location0, location60, location47);
            Map.Add(location61);
            SettingLocation(location62, location0, location57, location0, location0);
            Map.Add(location62);
            Place = location1;
            Place.ChangeTitle(Place.CName);
        }
        public void SettingLocation(Location l, Location n, Location w, Location e, Location s) 
        {
            l.SetLocation(n,e,w,s);
        }
        public void StoryBegin()
        {
            WriteLine("I was contacted one week ago about a missing island, the origin of which seemed paranormal.");
            WriteLine(" Being a lady who is particularly good with paranormal going happenings I took the case.");
            WriteLine(" I had only started leaving for the town whos port was once connected to the island when a familiar face greeted me.");
            WriteLine(" Standing there in her dark shroud with her pink hair glistening in the wind was an old friend that never could quite catch me, the reapers apprentice Calliope Mori.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ForegroundColor = ConsoleColor.DarkRed;
            ReadKey(true);
            WriteLine("Watson, I wish I could say that this was the time I could finally catch you-");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("To which you would be wrong.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("... But I have other things here that are happening. I am meeting with a business man about some other jobs and am warning you to stay out of the city unless you want it to be your time.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Okay, My focus was more on the boardwalk and the ocean anyway. May even get some KFP. If you want some then I would be happy to share, Kiara may even give me a discount if your there.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("H-Hey now! D-dont you dare think you can butter me up with food and actually being good for once!");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("With that the reaper just blushed as she walked off towards the city of Holosville leaving me to my investigation. What had been going on here, why did an entire island go missing and what was this feeling I was getting that things were about to become a lot more interesting?");
            WriteLine("Press any key to continue.");
            ReadKey(true);
            Clear();
        }

        public void SubCheck()
        {
            if (Ame.Clues.Contains("SubKey"))
            {
                Place.Direction[2] = Map[2];
            }
            else
            {
                Place.Direction[2] = Map[0];
            }
        }
    }
}
