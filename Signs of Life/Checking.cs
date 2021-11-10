using System;
using System.Collections.Generic;
using System.Text;

namespace Signs_of_Life
{
    class Checking
    {
        public string Name;
        public bool condition;
        public bool CWant;

        public Checking(string n, bool c, bool w)
        {
            Name = n;
            condition = c;
            CWant = w;
        }

        public bool ClueCheck(string IName)
        {
            if (Name == IName)
            {
                condition = true;
            }
            else
            {
                condition = false;
            }
            return (condition);
        }
    }
}
