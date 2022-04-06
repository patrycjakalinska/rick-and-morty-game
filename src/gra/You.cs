using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace gra
{
    class You
    {
        public string Name { get; set; }
        public int Age {
            get { return age; }
            set
            {
                if (value > 0) age = value;
                else
                {
                    Console.WriteLine("Are you dumb or just wanna die? We set your age to 13, dummy");
                    age = 13;
                }
            }
        }
        public int HP { get { return hp; } set { hp = hp + value; } }
        public List<string> EQ { get { return eq; } }

        private Random rnd = new Random();
        private int hp;
        private int age;
        private string name;
        private List<string> eq;
        private List<string> eqWannabe = new List<string>() { "Doran's blade", "Doran's shield", "The Flaming Poisoning Raging Sword", "Lifebender", "Typhoon Plasma Rifle","Supernova Laser Blaster","Penetrator","Redemmption","Curse of the Lost","Toothpick","Stick","Pan","Algebra Book","Leg" };

        
        public You()
        {
            name = "Morty";
            hp = 100;
            age = 13;
            eq = new List<string>();
        }

        public void viewEQ()
        {

            //ladny napis to twoje eq i statystyki
            //tutaj ladny duzy napis twoje hp
            var ar = new[]
            {
                @"__________________________________________________",//50
                @"| |                                            | |",
                @"| |                Your HP: "+hp+"                | |",//44
                @"__|____________________________________________|__",




            };

            foreach (string line in ar)
            {
                Console.SetCursorPosition((Console.WindowWidth - 60) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(50);
            }
                var arr = new[]
            {
                @"____________________________________________________________________________________________________",//100
                @"|                                                                                                   |"
            };
            Console.SetCursorPosition((Console.WindowWidth - 115) / 2, Console.CursorTop);
            Console.WriteLine(arr[0]);
            Thread.Sleep(50);

            for(int i = 0; i < eq.Count; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - 115) / 2, Console.CursorTop);
                Console.WriteLine(arr[1]);
                Thread.Sleep(50);

                int x = 0;
                string s = "";
                for(int j = 0; j < (98-eq[i].Length)/2; j++)
                {
                    s = s + " ";
                    x++;
                }
                s = s + eq[i];
                for (int y = 0; y < x; y++) s = s + " ";

                Console.SetCursorPosition((Console.WindowWidth - 115) / 2, Console.CursorTop);
                Console.WriteLine(s);
                Thread.Sleep(50);

                Console.SetCursorPosition((Console.WindowWidth - 115) / 2, Console.CursorTop);
                Console.WriteLine(arr[1]);
                Thread.Sleep(50);

                Console.SetCursorPosition((Console.WindowWidth - 115) / 2, Console.CursorTop);
                Console.WriteLine(arr[0]);
                Thread.Sleep(50);
            }
            Console.WriteLine("\n\n\n");
            string z = "[ ENTER ]";
            Console.SetCursorPosition((Console.WindowWidth - z.Length) / 2, Console.CursorTop);
            Console.WriteLine(z);
            Thread.Sleep(100);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            Console.Clear();

        }


        public void changeHP(int x)
        {
            hp = hp + x;
        }

        public bool takeDamage(int x)
        {
            if ((hp - x) > 0)
            {
                hp = hp - x;
                return false;
            }
            else
            {
                hp = 0;
                return true;
            }
        }

        public void progress()
        {
            changeHP(rnd.Next(10,100));
            eq.Add(eqWannabe[rnd.Next(0, eqWannabe.Count)]);
            eq.Add(eqWannabe[rnd.Next(0, eqWannabe.Count)]);

        }

        public int usePower(string x)
        {
            int damage = rnd.Next(50, 150);
            string s = "You use " +x+ " and hit Morty for " + damage + "!";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            System.Threading.Thread.Sleep(3000);
            return damage;
        }
        


        
    }
}
