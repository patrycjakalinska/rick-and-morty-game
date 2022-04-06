using System;
using System.Collections.Generic;
using System.Text;

namespace gra
{
    class EvilMorty
    {
        public string EvilName { get; }
        public int EvilHp { get { return evilhp; } }
        public Dictionary<string, int> Kkills { get; }


        static Random rnd = new Random();
        private int evilhp;
        private string evilname;
        private Dictionary<string, int> skills = new Dictionary<string, int>();
        public static List<string> powers = new List<string>() { "Headbutt", "Jaw Stab", "Split Punch", "Fireball", "Oracle Chain", "Crab Bullet", "Stabbing Blizzard", "Venom Chain","Illumination","Shadow Slash","Bountiful Harvest","Crowstorm","Last Breath",};

        public EvilMorty()
        {
            evilname = "Evil Morty";
            evilhp = 500;
        }

        public bool takeDamage(int x)
        {
            if ((evilhp - x) > 0)
            {
                this.evilhp -= x;
                return false;
            }
            else
            {
                evilhp = 0;
                return true;
            }
        }

        public int usePower()
        {
            int damage = rnd.Next(10, 100);
            string s = "Evil Morty use " + powers[rnd.Next(0, powers.Count)] + " and hits you for " + damage + "!";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            System.Threading.Thread.Sleep(3000);
            return damage;
        }

    }
}


