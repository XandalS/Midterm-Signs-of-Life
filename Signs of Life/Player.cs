using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Signs_of_Life
{
    class Player
    {

        //Attributes
        public string FName = "Amelia";
        public string LName = "Watson";
        public List<string> Clues = new List<string>();
        //Construct

        public Player()
        {
            Greeting();
            Title = "Signs of Life: Ame's tutorial";
            Tutorial();
            FinishGreet();
        }


        //Method
        public void Greeting()
        {
            Write("Greetings world! My name is ");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{FName} {LName}!");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
            Clear();
            Write("I am currently on an investigation to find out what happened to the ");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("island of Ninomae.");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Press any key to continue.");
            ReadKey(true);
        }

        public void Tutorial()
        {
            string input;
            bool passed = false;
            Clear();

            while (passed == false)
            {
                Write("Lets get this investigation underway. To start it off type ");
                ForegroundColor = ConsoleColor.Green;
                Write("Move");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine(" to move around, lets try it.");
                input = ReadLine().ToLower();
                if (input == "move")
                {
                    WriteLine("Great job");
                    passed = true;
                }
                else
                {
                    Write("Come on. I said type ");
                    ForegroundColor = ConsoleColor.Green;
                    Write("Move");
                    ForegroundColor = ConsoleColor.Gray;
                    Write(", not ");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"{input}.");
                    ForegroundColor = ConsoleColor.Gray;
                }
                
            }
            TMove();
            
            
        }
        public void TMove()
        {
            string direction;
            bool c;
            c = false;
            Clear();
            WriteLine("Alright now that we have selected Move as what we wanna do is select a location to move.");
            ReadKey(true);
            WriteLine("Press any key to continue.");

            while (c == false)
            {
                Write("Enter in ");
                ForegroundColor = ConsoleColor.Green;
                Write("North, East, South, or West");
                ForegroundColor = ConsoleColor.Gray;
                WriteLine(" to go in those directions");
                direction = ReadLine().ToLower();
                switch (direction)
                {
                    case "east":
                        c = true;
                        Write($"Good job, we are going ");
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine($"{direction}!");
                        ForegroundColor = ConsoleColor.Gray;
                        WriteLine("Press any key to continue.");
                        ReadKey(true);
                        Clear();
                        break;
                    case "west":
                        c = true;
                        Write($"Good job, we are going ");
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine($"{direction}!");
                        ForegroundColor = ConsoleColor.Gray;
                        WriteLine("Press any key to continue.");
                        ReadKey(true);
                        Clear();
                        break;
                    case "north":
                        c = true;
                        Write($"Good job, we are going ");
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine($"{direction}!");
                        ForegroundColor = ConsoleColor.Gray;
                        WriteLine("Press any key to continue.");
                        ReadKey(true);
                        Clear();
                        break;
                    case "south":
                        c = true;
                        Write($"Good job, we are going ");
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine($"{direction}!");
                        ForegroundColor = ConsoleColor.Gray;
                        WriteLine("Press any key to continue.");
                        ReadKey(true);
                        Clear();
                        break;
                    default:
                        WriteLine("Oi, its time to get smart and choose a direction to go!");
                        WriteLine("Press any key to continue.");
                        ReadKey(true);
                        Clear();
                        break;
                }
            }
            WriteLine("This is the basic mode of transportation used to go searching for clues on this investigation");
            WriteLine("Press any key to continue.");
            ReadKey(true);
            TInvestigate();
        }

        public void TInvestigate()
        {
            string Inv;
            bool B;
            B = false;
            Clear();
            WriteLine("Now that we know how to go places lets learn what to do once we are there.");
            Write("If you ever think there is something worth investigating in a location just type ");
            ForegroundColor = ConsoleColor.Green;
            Write("Search");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(" and I will look into anything suspicious.");
            while (B == false)
            {
                Write("Lets try to ");
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Search.");
                ForegroundColor = ConsoleColor.Gray;
                Inv = ReadLine().ToLower();
                if (Inv == "search")
                {
                    Write("Good job! Oh and there was something suspicious here. Who put this ");
                    ForegroundColor = ConsoleColor.Blue;
                    Write("'Detective's Apprentice'");
                    ForegroundColor = ConsoleColor.Gray;
                    WriteLine(" badge here?");
                    WriteLine("Oh well. Guess its yours now.");
                    WriteLine("Press any key to continue.");
                    ReadKey(true);
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("DETECTIVE'S APPRENTICE BADGE WAS ADDED TO YOUR CLUES");
                    ForegroundColor = ConsoleColor.Gray;
                    Clues.Add("Detective's Apprentice Badge");
                    WriteLine("Press any key to continue.");
                    ReadKey(true);
                    Write("Oh yea thats right! If at any time you want to see your clues. Just type ");
                    ForegroundColor = ConsoleColor.Green;
                    Write("Clue");
                    ForegroundColor = ConsoleColor.Gray;
                    WriteLine(" in and I will tell you all the clues we have uncovered.");
                    WriteLine("Press any key to continue.");
                    ReadKey(true);
                    B = true;
                    Clear();
                }
            }
            

        }

        public void FinishGreet()
        {
            WriteLine("Alright now that you know how to look for clues I think we should actually get started on the actual investigation.");
            WriteLine("Let me start at the beginning of the data that I know.");
            WriteLine("Press any key to continue.");
            ReadKey(true);
        }
        // Main game Actions
        public void GettingClues(string c)
        {
            Clues.Add(c);
            ForegroundColor = ConsoleColor.Blue;
            Write(c);
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(" has been added to the clues");
        }

        public void DisplayClues()
        {
            foreach (string DClue in Clues)
            {
                Console.WriteLine(DClue);
            }
            Console.WriteLine("This is currently all I know for this case. *Hic*");
        }
    }
}
