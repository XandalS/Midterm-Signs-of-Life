using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Signs_of_Life
{
    class Kiara : Person 
    {
        new string Name;
        public Clue kfp;
        string Des;
        public Kiara(string n, Clue c,string d) :base(n,c,d)
        {
            kfp = c;
            n = "Kiara";
            Name = n;
            kfp.Name = "Strange girl's location";
            kfp.Description = "Acording to Kiara's instructions there is a white haired girl acting like a dead swimmer to scare passeres by on the beach. She may know what happened to the island or better be able to show me.";
            Des = "Kiara is standing on the boardwalk holding a KFP sign, apparently even the CEO of a food chain has to do sign twirling every once in a while";
        }

        public override void TestWorking(Game g)
        {
            if (g.Ame.Clues.Contains("Strange girl's location"))
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("Your the best Ame!!");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
            }
            else
            {
                Clear();
                WriteLine("As I walk up to my old Pheonix friend she smiles before jumping at me.");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("Ki Kiri Kiiiii! Ame! Its so good to see you, what are you doing here~");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Hehe I could ask you the same thing Kiara.");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("Well KFP just set up a new building here so I decided to come help spread the word. Everyone in Holosville can now enjoy some Kiara Fried Pheonix!!");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Thats great to hear Kiara, though it seems like you dont have too many customers right now.");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("Well true but at the same time this isnt my shop, its the scuba shop. KFP is further down the boardwalk, for all the good it is doing it.");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("What do you mean by that?");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("Apparently this white haired girl is floating in the water near the beach scaring off everyone who comes near her. She isnt dead either, I tried to drag her body out of the water before she scared me nearly causing me to die again.");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("That sounds pretty rough, want me to go sort her out?");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("Oh yes yes please! She has been floating up and down the coast all day but I think she has settled near the more populated side of the beach! Thank you Ame!!");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("With that my feathered friend gave me a big hug before sending me on my way");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                ReadKey(true);
                ForegroundColor = ConsoleColor.DarkYellow;
                WriteLine("'INFO ON THE SILVER HAIRED GIRL' WAS ADDED TO THE CLUES");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press a key to continue...");
                g.Ame.Clues.Add("Strange girl's location");
                ReadKey(true);
            }
            
        }

    }
}
