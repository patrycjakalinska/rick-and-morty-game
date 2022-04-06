using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace gra
{
    class SnakePlanet
    {
        private string[,] maze = new string[27,27];

        
        private void fillUpEdges()
        {
           

            
            for (int z = 0; z < 26; z++)
            {
                for (int j = 0; j < 26; j++)
                {
                    maze[z, j] = " ";
                }
            }
            
            
            for (int y = 0; y < 26; y++)
            {
                maze[y, 0] = "U";
                maze[y, 26] = "U";
            }

            for (int j = 1; j < 26; j++)
            {
                maze[0, j] = "U";
                maze[26, j] = "U";
            }

            var n1 = new List<int>() { 12 };
            var n3 = new List<int>() { 2, 4, 6, 12, 24 };
            var n5 = new List<int>() { 2, 14, 22, 24 };
            var n7 = new List<int>() { 2, 8, 18, 22, 24 };
            var n9 = new List<int>() { 2, 8, 10, 12, 16, 18, 20, 22 };
            var n11 = new List<int>() { 2, 10, 12, 16, 18, 20, 22, 24 };
            var n13 = new List<int>() { 12, 18, 20, 22, 24 };
            var n15 = new List<int>() { 6, 10, 12, 20, 22 };
            var n17 = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 20 };
            var n19 = new List<int>() { 2, 4, 8, 10, 12, 14, 24 };
            var n21 = new List<int>() { 2, 12, 14, 16, 20, 22, 24 };
            var n23 = new List<int>() { 2, 6, 12, 14, 16, 18, 20, 22, 24 };
            var n25 = new List<int>() { 4, 12, 14, 20 };

            List<List<int>> myList = new List<List<int>>() { n1, n3, n5, n7, n9, n11, n13, n15, n17, n19, n21, n23, n25 };

            int c = 1;
            foreach (List<int> subList in myList)
            {

                foreach (int item in subList)
                {
                    maze[c, item] = "U";
                }
                c = c + 2;
            }

            var c1 = new List<int>() {14 };
            var c3 = new List<int>() {6,8,12,14,22 };
            var c5 = new List<int>() {4,6,8,10,12,14,20,22 };
            var c7 = new List<int>() {2,4,6,10,12,14,20,22,24 };
            var c9 = new List<int>() { 2,4,6,12,14,20,22,24};
            var c11 = new List<int>() { 4,6,22};
            var c13 = new List<int>() {6,8,10,14 };
            var c15 = new List<int>() {2,4,6,8,12,14,16 };
            var c17 = new List<int>() {2,4,6,14,16,18,20,24 };
            var c19 = new List<int>() { 2,4,6,16,18,20};
            var c21 = new List<int>() {2,4,18 };
            var c23 = new List<int>() {2,14,16,18,24 };
            var c25 = new List<int>() {8 };

            List<List<int>> myList2 = new List<List<int>>() { c1,c3,c5,c7,c9,c11,c13,c15,c17,c19,c21,c23,c25 };

            int d = 1;
            foreach (List<int> subList2 in myList2)
            {

                foreach (int item in subList2)
                {
                    maze[item, d] = "U";
                }
                d = d + 2;
            }


            maze[23, 7] = "+";
        }
        

        private void layout()
        {
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine(",-----------------------------.----------------------------------.");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[1,1] + "    " + maze[1,3]+"    " + maze[1,5]+"     " + maze[1,7] + "    " + maze[1,9] + "    " + maze[1,11] + " | "+ maze[1,13] + "    " + maze[1,15] + "    " + maze[1,17] + "    " + maze[1, 19] + "    " + maze[1, 21] + "    " + maze[1, 23] + "    " + maze[1, 25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    .    .    ,---------     |     ------------------------.    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| "+maze[3, 1]+"  | " + maze[3, 3] + "  | " + maze[3, 5] + "  |  " + maze[3, 7] + "    " + maze[3, 9] + "    " + maze[3, 11] + " | " + maze[3, 13] + "    " + maze[3, 15] + "    " + maze[3, 17] + "    " + maze[3, 19] + "    " + maze[3, 21] + "    " + maze[3, 23] + "  | " + maze[3, 25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    |    `----'--------------'    ,-------------------.    |    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[5, 1] + "  | " + maze[5,3] + "    " + maze[5,5] + "     " + maze[5,7] + "    " + maze[5,9] + "    " + maze[5,11] + "   " + maze[5,13] + "  | " + maze[5,15] + "    " + maze[5,17] + "    " + maze[5,19] + "    " + maze[5,21] + "  | " + maze[5,23] + "  | " + maze[5,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    :--------------.--------------'----,---------:    |    |    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[7, 1] + "  | " + maze[7, 3] + "    " + maze[7,5] + "    " + maze[7, 7] + "  | " + maze[7, 9] + "     " + maze[7, 11] + "   " + maze[7,13] + "    " + maze[7,15] + "    " + maze[7,17] + "  | " + maze[7,19] + "    " + maze[7,21] + "  | " + maze[7,23] + "  | " + maze[7,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    :---------     |    .    ,---------.    |    .    |    `----:");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[9, 1] + "  | " + maze[9, 3] + "    " + maze[9,5] + "    " + maze[9, 7] + "  | " + maze[9,9] + "  |  " + maze[9,11] + " | " + maze[9,13] + "    " + maze[9,15] + "  | " + maze[9,17] + "  | " + maze[9,19] + "  | " + maze[9,21] + "  | "+maze[9,23]+"    " + maze[9,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    |     ---------'    |    :----     |    |    |    |    .    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[11, 1] + "  | " + maze[11, 3] + "    " + maze[11, 5] + "    " + maze[11, 7] + "    " + maze[11,9] + "  |  " + maze[11,11] + " | " + maze[11,13] + "    " + maze[11,15] + "  | " + maze[11,17] + "  | " + maze[11,19] + "  | " + maze[11,21] + "  | " + maze[11,23] + "  | " + maze[11,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    `-------------------'    |     ----'    |    |    |    |    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[13, 1] + "    " + maze[13, 3] + "    " + maze[13, 5] + "    " + maze[13, 7] + "    " + maze[13, 9] + "     " + maze[13,11] + " | " + maze[13,13] + "    " + maze[13,15] + "    " + maze[13,17] + "  | " + maze[13,19] + "  | " + maze[13,21] + "  | " + maze[13,23] + "  | " + maze[13,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine(":--------------.---------.    :--------------'    |    :----'    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[15,1] + "    " + maze[15,3] + "    " + maze[15,5] + "  | " + maze[15,7] + "    " + maze[15,9] + "  | " + maze[15, 11] + "  | " + maze[15, 13] + "    " + maze[15,15] + "    " + maze[15,17] + "    " + maze[15,19] + "  | " + maze[15,21] + "  | " + maze[15, 23] + "    " + maze[15, 25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    .    .    |    .    |    |    ,--------------:    `----     |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[17,1] + "  | " + maze[17, 3] + "  | " + maze[17,5] + "  | "+ maze[17,7] +"  | " + maze[17,9] + "  | " + maze[17,11] + "  | " + maze[17,13] + "  | " + maze[17,15] + "    " + maze[17,17] + "    " + maze[17,19] + "  | " + maze[17,21] + "    " + maze[17,23] + "    " + maze[17,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    |    |    '    |    |    |    |     ---------'---------.    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[19,1] + "  | " + maze[19,3] + "  | " + maze[19, 5] + "    " + maze[19,7] + "  | " + maze[19,9] + "  | " + maze[19,11] + "  | " + maze[19,13] + "  | " + maze[19,15] + "    " + maze[19,17] + "    " + maze[19,19] + "    " + maze[19,21] + "    " + maze[19,23] + "  | " + maze[19,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    |    `---------'----'    |    |    ,---------.    .    |    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[21,1] + "  | " + maze[21, 3] + "    " + maze[21, 5] + "    " + maze[21,7] + "    " + maze[21,9] + "    " + maze[21,11] + "  | " + maze[21,13] + "  | " + maze[21,15] + "  | " + maze[21,17] + "    " + maze[21,19] + "  | " + maze[21,21] + "  | " + maze[21,23] + "  | " + maze[21,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    :---------.--------------:    |    |    .    |    |    |    |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[23,1] + "  | " + maze[23, 3] + "    " + maze[23,5] + "  | " + maze[23,7] + "    " + maze[23,9] + "    " + maze[23, 11] + "  | " + maze[23,13] + "  | " + maze[23,15] + "  | " + maze[23,17] + "  | " + maze[23,19] + "  | " + maze[23,21] + "  | " + maze[23,23] + "  | " + maze[23,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("|    '    .    `---------     |    |    `----'    |    `----'    | ");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("| " + maze[25,1] + "    " + maze[25, 3] + "  | " + maze[25, 5] + "    " + maze[25,7] + "    " + maze[25,9] + "    " + maze[25,11] + "  | " + maze[25,13] + "  | " + maze[25,15] + "    " + maze[25,17] + "    " + maze[25,19] + "  | " + maze[25,21] + "    " + maze[25,23] + "    " + maze[25,25] + "  |");
            Console.SetCursorPosition((Console.WindowWidth - 66) / 2, Console.CursorTop);
            Console.WriteLine("`---------'-------------------'    `--------------'--------------'");

            /*,-----------------------------.----------------------------------.
            |                             |                                  |
            |    .    .    ,---------     |     ------------------------.    |
            |    |    |    |              |                             |    |
            |    |    `----"--------------'    ,-------------------.    |    |    
            |    |                             |                   |    |    |
            |    :--------------.--------------"----     ,---------:    |    |    
            |    |              |                        |         |    |    |
            |    :---------     |    .    ,---------.    |    .    |    `----:    
            |    |              |    |    |         |    |    |    |         |
            |    |     ---------'    |    :----     |    |    |    |    .    |    
            |    |                   |    |         |    |    |    |    |    |
            |    `-------------------'    |     ----'    |    |    |    |    |
            |                             |              |    |    |    |    |
            :--------------.---------.    :--------------'    |    :----'    |
            |              |         |    |                   |    |         |
            |    .    .    |    .    |    |    ,--------------:    `----     |
            |    |    |    |    |    |    |    |              |              |
            |    |    |    "    |    |    |    |     ---------"---------.    |
            |    |    |         |    |    |    |                        |    |
            |    |    `---------"----'    |    |    ,---------.    .    |    |    
            |    |                        |    |    |         |    |    |    |
            |    :---------.--------------:    |    |    .    |    |    |    |
            |    |         | X            |    |    |    |    |    |    |    |
            |    "    .    `---------     |    |    `----'    |    `----'    |    
            |         |                   |    |              |              |
            `---------"-------------------'    `--------------"--------------'*/
            
            
            



        }

        public bool rungame()
        {
            fillUpEdges();
            int x = 25;
            int y = 13;
            maze[x, y] = "x";
            string temp = " ";
            while (temp != "+")
            {
                
                Console.Clear();
                layout();
                var ch = Console.ReadKey(false).Key;
                
                switch (ch)
                {
                    case ConsoleKey.UpArrow:
                        if (maze[x - 1, y] != "U")
                        {
                            
                            maze[x, y] = " ";
                            temp = maze[x - 2, y];
                            x =x-2;
                            maze[x,y] = "x";
                            continue;
                        }
                        else continue;
                    case ConsoleKey.DownArrow:
                        if (maze[x + 1, y] != "U")
                        {
                            
                            maze[x, y] = " ";
                            temp = maze[x + 2, y];
                            x =x+2;
                            maze[x, y] = "x";
                            
                            continue;
                        }
                        else continue;
                    case ConsoleKey.LeftArrow:
                        if (maze[x, y - 1] != "U")
                        {
                            
                            maze[x, y] = " ";
                            temp = maze[x, y - 2];
                            y =y-2;
                            maze[x, y] = "x";
                           
                            continue;
                        }
                        else continue;
                    case ConsoleKey.RightArrow:
                        if (maze[x, y + 1] != "U")
                        {
                            

                            maze[x, y] = " ";
                            temp = maze[x, y + 2];
                            y =y+2;
                            maze[x, y] = "x";
                            
                            continue;
                        }
                        else continue;
                    default:
                        continue;
                }
            }
            return true;
        }

        public bool gameMaze()
        {
            
            sIntroduction();
            if (rungame() == true)
            {
                Console.Clear();
                WinCongrats();
                return true;
            }
            else
            {
                string s = "u loser";
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                Console.WriteLine(s);
                Thread.Sleep(1500);
                return false;
            }
        }


        public void sIntroduction()
        {
            Console.Clear();
            Console.WriteLine("\n");
            string z = "Welcome to the sssssnake planet. We need you to passss our maze 'cause we are not able to do this ourselvesss. At least you don't need to stick weird seed all the way up your a.........";
            Console.SetCursorPosition((Console.WindowWidth - z.Length) / 2, Console.CursorTop);
            Console.WriteLine(z);
            Thread.Sleep(100);
            z = "Pressss [ ENTER ] to start our 20s journey, in and out";
            Console.SetCursorPosition((Console.WindowWidth - z.Length) / 2, Console.CursorTop);
            Console.WriteLine(z);
            Thread.Sleep(100);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            Console.Clear();
        }

        public void WinCongrats()
        {
            string s = "That wassss a hard one but you got it! We, the sssssnakessss of planet C-345FG, as a reward will deliver to you ssssome really sssstuning weaponssss that will help you at The Citadel!";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(100);
            s = "We are on your sssside";
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

    }
}
