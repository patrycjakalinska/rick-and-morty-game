using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace gra
{
    class InterdimensionalCable
    {
        public bool TheEnd { get; private set; } = false;
        public bool Win { get; set; } = false;

        public List<Cables> Cables { get; private set; }

        private int guesspos = 0;
        private int count = 0;

        public InterdimensionalCable()
        {
            Cables = new List<Cables>();
            generateRanWord();
        }

        public bool makeGuess(Cables word)
        {
            if (Cables[guesspos] != word)
            {
                TheEnd = true;
                return false;
            }
            if (count == 15)
            {
                Win = true;
                TheEnd = true;
                return false;
            }
            else
            {
                //round over
                if (guesspos == Cables.Count - 1)
                {
                    guesspos = 0;
                    generateRanWord();
                    return false;

                }
                guesspos++;
                count++;

                return true;
            }
        }

        private void generateRanWord()
        {
            Random rnd = new Random();
            int rndWordAsInt = rnd.Next(0, 7);
            Cables rndWord = (Cables)rndWordAsInt;

            Cables.Add(rndWord);
        }

        public void displayCurrentLvl()
        {
            Console.Clear();
            foreach (Cables word in Cables)
            {
                Console.WriteLine("Round " + Cables.Count + " \n");
                Thread.Sleep(1000);

                switch (word)
                {
                    case gra.Cables.Eyeholes:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case gra.Cables.Gazorpazorp:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case gra.Cables.Meeseeks:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case gra.Cables.Schwifty:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case gra.Cables.Poopybutthole:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case gra.Cables.Morty:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case gra.Cables.Birdperson:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case gra.Cables.Squanchy:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                }

                Console.WriteLine(word);
                Thread.Sleep(1000);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine("Round " + Cables.Count + ": \n");


        }

        public void idIntroduction()
        {
            Console.Clear();
            //ladny napis interdimendional\ncable
            string s = "Hello! Welcome to the show how did I get there. I guarantee you will wonder how did he got there!";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(100);
            s = "No, but really, as a part of our show you will have to memorize some words I will show you on the screen and then write them down in the console";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(100);
            s = "Upper or lower case - it  doesn't matter. There will be 6 rounds of pure fun. As a reward I will ship to you some cool fight stuff, really lovely i promise!";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(100);
            s = "[ ENTER ]";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(100);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            Console.Clear();



        }

        public void idWinCongrats()
        {
            var arr = new[]
                        {
                             @"I'm Ants-In-My-Eyes Johnson, Here at Ants-in-My-Eyes Johnson's Electronics.",
                            @"I mean, there's so many ants in my eyes! And there's so many TVs, microwaves, radios I think, I can't-- I'm not 100% sure what we have here in stock, because I can't see anything. ",
                            @"Our prices, I hope, aren't too low! Check out this refrigerator! Only $200! What about this microwave? Only $100! That's fair!",
                            @"I'm Ants-in-My-Eyes Johnson! Everything's black, I can't see a thing! ",
                            @"And also I can't feel anything either-- did I mention that? But that's not as catchy as having ants in your eyes. So that always goes, you know, off by the wayside.",
                            @"I can't feel. It's a very rare disease. All my-- All my nerves, they don't allow for the sensation of touch. So I never know what's going on.",
                            @"Am I standing? Sitting? I don't know.",
                            @"",
                            @"",
                            @"",
                            @"",
                            @"So yeah you won, congrats and all, we'll ship your order soon!",
                            @"And yeah, press enter to exit, or whatever",
                        };
            foreach (string line in arr)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(200);
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            Console.Clear();
        }
    }
}
