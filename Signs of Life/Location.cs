using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Signs_of_Life
{
    class Location
    {
        public Location[] Direction = new Location[4];
        public List<Person> Collective = new List<Person>();
        public List<Checking> Conditions = new List<Checking>();
        private Location east;
        private Location west;
        private Location north;
        private Location south;
        private string Description;
        public string CName;
        public string[] DName = new string[4];
        public Location(string c,string d)
        {
            DName[0] = "North";
            DName[2] = "West";
            DName[1] = "East";
            DName[3] = "South";
            CName = c;
            Description = d;

        }
        public void SetLocation(Location n, Location e, Location w, Location s)
        {
            north = n;
            Direction[0] = north;
            east = e;
            Direction[1] = east;
            west = w;
            Direction[2] = west;
            south = s;
            Direction[3] = south;
        }


        
        public void DisplayDescription()
        {
            WriteLine(Description);
            foreach(Checking c in Conditions)
            {
                foreach(Person p in Collective)
                {
                    if (c.Name == p.Name)
                    {
                        if (c.condition == c.CWant)
                        p.InWorldDescription();
                    }
                }
                
                //Should be coded out ConditionCheck();
                
            }
            
        }

        public Location SetLocation(string Direct, Location Going)
        {
            switch (Direct)
            {
                case "north":
                    Going = north;
                    break;
                case "west":
                    Going = west;
                    break;
                case "east":
                    Going = east;
                    break;
                case "south":
                    Going = south;
                    break;
                default:
                    WriteLine($"Im not going to {Direct}");
                    break;
            }
            return (Going);
        }

        public void ConditionCheck(Location l,bool c,int d)
        {
            if (c == true)
            {
                this.Direction[d].CName = l.CName;
            }
            else
            {
                this.Direction[d].CName = "Doesnt exist";
            }
        }

        public void ConditionCheck(Person p,bool c)
        {

        }

        public void ChangeTitle(string name)
        {
            Title = ($"Signs of Life: {name}");
        }
        public void PeopleDescriptions(Game g)
        {
            foreach (Person p in g.Place.Collective)
            {
                if (p.Name == "Gura")
                {
                    if (g.GUnlocked == true)
                    {
                        p.InWorldDescription();
                    }
                }
                else
                {
                    p.InWorldDescription();
                }
            }
        }
    }
}