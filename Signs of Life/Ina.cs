using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Signs_of_Life
{
    class Ina : Person
    {

        public Ina(string n,Clue c,string d) : base(n, c, d)
        {
            Name = "Mysterious girl";
            d = "A purple haired girl with a strange floating orange ring behind her stands at the center of the bubble of the city. She seems to have small angel wings either coming out of or just floating around her hips along with an unsettling aura that we are only seeing a portion of her true body.";
        }


        public override void TestWorking(Game g)
        {
            WriteLine("Walking up to the girl I feel an erie presence wash over me as...");
            g.StoryComplete = true;
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press a key to continue...");
            ReadKey(true);
        }
    }
}
