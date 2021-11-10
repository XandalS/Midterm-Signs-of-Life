using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Signs_of_Life
{
    class Gura:Person
    {
        new string Name;
        Clue IslandLocation;
        string Description;


        public Gura(string n, Clue c,string d) : base(n, c, d)
        {
            Name = n;
            IslandLocation = c;
            Description = d;
        }
        public override void TestWorking(Game g)
        {
            if (!g.GUnlocked)
            {
                MeetingGura();
                g.GUnlocked = true;
            }
            else
            {
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Come on, lets move stinky!!");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine("Press any key to continue.");
                ReadKey(true);
            }
           
        }
        public void Beachtroduction()
        {
            Name = "Gura";
        }
        public void MeetingGura()
        {
            Clear();
            WriteLine("Walking up to the facedown girl in the ocean I sigh looking at her before lifting up my foot and stomping her head into the sand.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            WriteLine("The girl flailes around against the sand clearly not expecting me to do something so harsh all of a sudden. Lifting up my foot I just stare down at her as she lifts herself up out of the water and begins yelling at me.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("WHAT THE HECK WAS THAT! You see a girl laying face down in the water, most likely dead, and your first instict is to stomp her head into the sand?!?");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Its not in very good taste to be pretending to be a dead body at a beach. I could take you in for that, I am a cop after all.(Heh I am such a lier.)");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("What the heck?!? Aw dang it, didnt think the cops would come so soon. Can I atleast get my friend from that fried bird resturant first?");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Tell you what, your not actually what I came here for so I am gonna cut you a deal. You lead me to the remains of that island that sank not too long ago and I will forget this all happened, okay?");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("The girl seemed to actually be thinking about this like it was an actual choice. Her shark like tail, which was a surprise to note that she had, swayed as she considered the no other options she had.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Cyan;
            Write("Okay! I'll do it! ");
            ForegroundColor = ConsoleColor.Gray;
            Write("The girl replied as she got to her feet showing off her deep blue hoodie with shark jaws motif. ");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("By the way my name is Gwar Gura. You can just call me Gura to make it easier. I am a shark from Atlantis incase you didnt know so I am rather adept at swimming and being underwater.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Nice to meet you Gura. My name is Amelia Watson. Pleasure to be working with you");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Alright Watson, I will meet you at the docks so you best finish up anything you wanna do and go over there before I get bored.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("With that the 'shark girl' ran off towards the docks to the south leaving me alone on the beach.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
        }
    }
}
