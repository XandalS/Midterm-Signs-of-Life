using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Signs_of_Life
{
    class Scuba_Man : Person
    {
        string name;
        string description;
        Clue clue;
        public bool KeyGiven;
        public Scuba_Man(string n, Clue c,string d) : base(n, c, d)
        {
            name = n;
            clue = c;
            description = d;
        }

        public override void TestWorking(Game g)
        {
            if (KeyGiven == false)
            {
                g.Ame.Clues.Add(clue.Name);
                WriteLine("Here is the key to my sub Detective.");
                ReadKey(true);
                KeyGiven = true;
            }
            else
            {
                WriteLine("You already got my key Detective.");
                ReadKey(true);
            }
        }
    }
}
