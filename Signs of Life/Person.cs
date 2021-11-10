using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Signs_of_Life
{
    class Person
    {
        public string Name;
        Clue clue;
        string Description;
        


        public Person(string n, Clue c, string d)
        {
            Name = n;
            clue = c;
            Description = d;
        }

        public void InWorldDescription()
        {
            WriteLine(Description);
        }

        public void Investigated(Game g)
        {
            TestWorking(g);
        }
        public virtual void TestWorking(Game g)
        {

        }
    }
}
