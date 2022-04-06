using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace gra
{
    class Citadel
    {
        private int maxHP;
        private int mortMaxHP;
        EvilMorty mort = new EvilMorty();
        You character;
        private bool win = false;
        public bool lose = false;
        private int temp1;
        private int temp2;
        public Citadel(ref You character)
        {   
            this.character = character;
        }
        
        public void showProgress()
        {
            Console.Clear();
            var arr1 = new[]
            {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|█████                                            |",
                @"|█████                                            |",
                @"___________________________________________________",
            };
            var arr2 = new[]
            {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|██████████                                       |",
                @"|██████████                                       |",
                @"___________________________________________________",
            };
            var arr3 = new[]
            {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|███████████████                                  |",
                @"|███████████████                                  |",
                @"___________________________________________________",
            };
            var arr4 = new[]
            {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|████████████████████                             |",
                @"|████████████████████                             |",
                @"___________________________________________________",
            };
            var arr5 = new[]
             {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|█████████████████████████                        |",
                @"|█████████████████████████                        |",
                @"___________________________________________________",
            };
            var arr6 = new[]
             {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|██████████████████████████████                   |",
                @"|██████████████████████████████                   |",
                @"___________________________________________________",
            };
            var arr7 = new[]
             {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|███████████████████████████████████              |",
                @"|███████████████████████████████████              |",
                @"___________________________________________________",
            };
            var arr8 = new[]
              {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|████████████████████████████████████████         |",
                @"|████████████████████████████████████████         |",
                @"___________________________________________________",
            };
            var arr9 = new[]
              {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|█████████████████████████████████████████████    |",
                @"|█████████████████████████████████████████████    |",
                @"___________________________________________________",
            };
            var arr10 = new[]
              {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|█████████████████████████████████████████████████|",
                @"|█████████████████████████████████████████████████|",
                @"___________________________________________________",
            };

            var arrDED = new[]
            {
                @"       _   _ ____ _  _ ____    _  _ ___            ",
                @"        \_/  |  | |  | |__/    |__| |__]           ",
                @"         |   |__| |__| |  \    |  | |              ",
                @"                                                   ",
                @"___________________________________________________",
                @"|                                                 |",
                @"|                                                 |",
                @"___________________________________________________",
            };

            if (character.HP > 0.9 * maxHP)
            {
                foreach (string line in arr10)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else if (character.HP > 0.8 * maxHP)
            {
                foreach (string line in arr9)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else if (character.HP > 0.7 * maxHP)
            {
                foreach (string line in arr8)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else if (character.HP > 0.6 * maxHP)
            {
                foreach (string line in arr7)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else if (character.HP > 0.5 * maxHP)
            {
                foreach (string line in arr6)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else if (character.HP > 0.4 * maxHP)
            {
                foreach (string line in arr5)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else if (character.HP > 0.3 * maxHP)
            {
                foreach (string line in arr4)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
/*                    Thread.Sleep(160);
*/                }
            }
            else if (character.HP > 0.2 * maxHP)
            {
                foreach (string line in arr4)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
/*                    Thread.Sleep(160);
*/                }
            }
            else if (character.HP > 0.1 * maxHP)
            {
                foreach (string line in arr2)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else if (character.HP > 0)
            {
                foreach (string line in arr1)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else
            {
                foreach (string line in arrDED)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
                
            }

            var ar = new[]
            {
                @"   _  _ ____ ____ ___ _   _ . ____    _  _ ___     ",
                @"   |\/| |  | |__/  |   \_/  ' [__     |__| |__]    ",
                @"   |  | |__| |  \  |    |     ___]    |  | |       ",
                @"",
                @"___________________________________________________",
            };

            var ar1 = new[]
            {
                @"|█████                                            |",
                @"|█████                                            |",
                @"___________________________________________________",
            };
            var ar2 = new[]
            {
                @"|██████████                                       |",
                @"|██████████                                       |",
                @"___________________________________________________",
            };
            var ar3 = new[]
            {
                @"|███████████████                                  |",
                @"|███████████████                                  |",
                @"___________________________________________________",
            };
            var ar4 = new[]
            {
                @"|████████████████████                             |",
                @"|████████████████████                             |",
                @"___________________________________________________",
            };
            var ar5 = new[]
             {
                @"|█████████████████████████                        |",
                @"|█████████████████████████                        |",
                @"___________________________________________________",
            };
            var ar6 = new[]
             {
                @"|██████████████████████████████                    |",
                @"|██████████████████████████████                    |",
                @"____________________________________________________",
            };
            var ar7 = new[]
             {
                @"|███████████████████████████████████               |",
                @"|███████████████████████████████████               |",
                @"____________________________________________________",
            };
            var ar8 = new[]
              {
                @"|████████████████████████████████████████          |",
                @"|████████████████████████████████████████          |",
                @"____________________________________________________",
            };
            var ar9 = new[]
              {
                @"|█████████████████████████████████████████████     |",
                @"|█████████████████████████████████████████████     |",
                @"____________________________________________________",
            };
            var ar10 = new[]
              {
                @"|██████████████████████████████████████████████████|",
                @"|██████████████████████████████████████████████████|",
                @"____________________________________________________",
            };
            var arDED = new[]
            {
                @"|                                                 |",
                @"|                                                 |",
                @"___________________________________________________",
            };
            if (mort.EvilHp > 0.9 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
                foreach (string line in ar10)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0.8 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
                foreach (string line in ar9)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                  /*  Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0.7 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                  /*  Thread.Sleep(160);*/
                }
                foreach (string line in ar8)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0.6 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
                foreach (string line in ar7)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0.5 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
                foreach (string line in ar6)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0.4 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
                foreach (string line in ar5)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0.3 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                    /*Thread.Sleep(160);*/
                }
                foreach (string line in ar4)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                  /*  Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0.2 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }
                foreach (string line in ar3)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                  /*  Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0.1 * mortMaxHP)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }
                foreach (string line in ar2)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                  /*  Thread.Sleep(160);*/
                }
            }
            else if (mort.EvilHp > 0)
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                  /*  Thread.Sleep(160);*/
                }
                foreach (string line in ar1)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }
            }
            else
            {
                foreach (string line in ar)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }
                foreach (string line in arDED)
                {
                    Console.SetCursorPosition(175, Console.CursorTop);
                    Console.WriteLine(line);
                   /* Thread.Sleep(160);*/
                }

            }

        }

        public void introduction()
        {
            maxHP = character.HP;
            mortMaxHP = 500;

            var intro = new[]
            {
                @"Prepare to fight, I'm counting on you Morty",
                @",",
                @",",
                @",",
            };
            foreach (string line in intro)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(500);
            }
            Thread.Sleep(1000);
        }

        public bool game()
        {
            introduction();
            while (win != true)
            {
                
                if (lose == true) return false;
                else fightMenu();
                
            }
            
            return true;
        }

        private void fightMenu()
        {

            showProgress();
            var arr = new[]
            {
                @"What do you want to use?",
                @"________________________________________",
                @"",
            };
            foreach (string line in arr)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(50);
            }
            
            for (int i = 0; i < character.EQ.Count; i++)
            {
                string s = "[ " + (i + 1) + " ] " + character.EQ[i];
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                Console.WriteLine(s);
                Console.WriteLine("\n");
                Thread.Sleep(50);
                s = " ";
            }
            choiceWeapon();
        }

        private int getChoi()
        {
            int choi = character.EQ.Count + 1;

            do
            {
                try
                {
                    choi = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                }

            } while (choi > character.EQ.Count);
            return choi;
        }

        private void choiceWeapon()
        {
            int choi = getChoi();

            
            temp1 = character.usePower(character.EQ[choi - 1]);
            win = mort.takeDamage(temp1);
            temp1 = 0;

            
            temp2 = mort.usePower();
            lose = character.takeDamage(temp2);
            temp2 = 0;

            showProgress();
        }
    }
}
