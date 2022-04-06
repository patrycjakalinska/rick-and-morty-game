using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Media;

namespace gra
{
    class CromulonD

    {

        private int points = 0;


        private void introduction()
        {
            Console.Clear();
            var arr = new[]
            {
                @"_____________________________________________________________________________________",
                @"Terry: The view here is the same as yours, Jim. A giant head has entered Earth’s gravity, triggering climate change and natural disasters we thought were impossible for at least another eight years.",
                @"Jim: (in news studio) Let’s not make this political, Terry. Do we know what this giant head wants?",
                @"Giant Head: SHOW ME WHAT YOU GOT.",
                @"Terry: Jim, you heard he said, Show me what you got ",
                @"Giant Head: SHOW ME WHAT YOU GOT. I WANT TO SEE WHAT YOU GOT.",
                @"_____________________________________________________________________________________",
                @".",
                @".",
                @".",
                @"You've been challanged to save the Earth by singing a song in Intergalactic Song Contest",
                @"",
                @"But of course you are not a singer and I'm not a programmer so basically it will be a abcd quiz",
                @"",
                @"Song : Get Schwifty",
                @"",
                @"(You need to know this one, it's almost as crucial as Pickle Rick, ok?)",
                @"",
                @"Get 8 points out of 10 to pass and get some cool stuff to win final battle with Evil Morty!",
                @"",
                @"",
                @"",
                @"[ ENTER ]",
            };
            foreach (string line in arr)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(200);
            }

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();

        }


        private void congratsWin()
        {
            Console.Clear();
            var poi = new[]
            {
                 @"_   _ ____ _  _ ____    ___  ____ _ _  _ ___ ____ ",
                 @" \_/  |  | |  | |__/    |__] |  | | |\ |  |  [__,",
                 @"  |   |__| |__| |  \    |    |__| | | \|  |  ___]",
                 @"",
            };
            string x = points + " out of 10";
            var arr2 = new[]
            {

                 @"                                                          ...                                                                            ",
                 @"                                              (#/,..................(#,                                                                  ",
                 @"                                        .&*......,................,......,%/                                                             ",
                 @"                                     .%..,,,,.......,............,.....,.......%/                                                        ",
                 @"                                   &...,,...........//((((((((//*,,,,,,,,,,,,......%                                                     ",
                 @"                                 #..,,,,...*(,...............................,........#*                                                 ",
                 @"                               **.,,,,,..........,,,******///*,,,,,,,,,,,,,,,,,,,,,,,,,,,#,                                              ",
                 @"                              #..,,,,,.....,//,,,......................,,,,,,,,,,,,,,........,#%.                                        ",
                 @"                            @...,,,,,,.,(,...........,.,...,.......................................&                                     ",
                 @"                          /,..,,/.,,,,.......,. .(%@@@@&(,...............,,.,,...............        *,                                  ",
                 @"                        /,..,,,,.,,,,,.,./(,.........................,*/(#%%%%#(##(/,....................,/                              ",
                 @"                      ./..,,,,,,.*,,,,%.........../(((##((((#(#((/*.........................,*//(((/**.  .&(                             ",
                 @"                     %..,,,,,,*.*,,,,&....((,,,,,,,...........,,,,,,,,,,,,,******,,,,,,,,,,,,,,,.........#.                              ",
                 @"                    (.,,,,,,(...,*,,,,..........(.         ,%/........................,%/        (*...,..%*                              ",
                 @"                  .*.,,,/*,......./,,......../                  .#...,.............%                ./....%.                             ",
                 @"                 /.,,,,,(,,,,,,*..,......./                       #............/.                    /...#/                              ",
                 @"                 %.,,,,,,,,,,,,,,*...,..../                          (........,.                       (...@.                            ",
                 @"                /.,,,,,,,,,,,,,.,,.......*               **           /.......,              ,(*        /..#/                            ",
                 @"                (.,,,,,,,,,,,,,...,....../                            %....,.,.                         %.. &,                           ",
                 @"               #..,,,,,,,,,,,,...........*                            /.......&                         @...%*                           ",
                 @"               &.,,,,,,,,,,,,/..,........./                          &..,......(                        *.../(                           ",
                 @"               #.,,,,,,,,,,,,/............/                         #.....,,..../                      %...,,#,                          ",
                 @"               /.,,,,,/,,,,,,/.............*.                      /....... &....(                   .(...,*.&,                          ",
                 @"               ,.,,,,,/.,/,,,,*........,.....,%                 ,*...........*.,...,/             .%......,,.@*                          ",
                 @"               *.,,,,*../,,,,,*..................../&&&#*.,/%%....,........../.........................,..,,,#/                          ",
                 @"               &.,,/...,,,,,,,,,*.............,..,.,.........,................(...........................,,,(/                          ",
                 @"               /./.....,*,,,,,,,,/...,...,..............,.........,....,...... #..............,..........,,,,##                          ",
                 @"               #.....,..,*,,,,,,,,,*,....,...........,..............,.,...........,..............,.......,,,,##                          ",
                 @"               (...,,.......,,,,,,,,,,,/,........,.....,...........,..,.,.......#.........,...,.......,.,..,,#/                          ",
                 @"                *,.,,,,,/,...,,,,,,,,,,,,,,,,,............................,,,..**.........,.......,...,,...,,%/                          ",
                 @"                 #.,,,,,,,,/,,,,,,,,,,,,,,,,,,,,,,,................................................,,,,...,,.&*                          ",
                 @"                 /..,,,,,,,,/,,,,,,,,,,,,,,,,,,,,.............,..................................,,,,,,,,,,,*%,                          ",
                 @"                  %..,,,,,,,,/,,,,,,,,,,,,,,,,,,,.....................,....................,...,,,,,,,,,,,,,##                           ",
                 @"                   &.,,,,,,,,,,,,,,,,,,,,,,,,,,.,,(,...............,..............................**,,,,,,, &/                           ",
                 @"                    #..,,,,,,,,,,,,,,,,,,,,,,,,(........,.,......,,......*//##%#%##%&&&&##*....,.....*,,,,./#,                           ",
                 @"                     *..,,,,,,,,,,,,,,,,,,,,,,,......,../%#/,....................................(,.../,*.,%/                            ",
                 @"                      .#..,,,,,,,,,,,,,,,,,,,*,.....*.......,...........,......,.........,............*,.*&/                             ",
                 @"                        *#.,,,,,,,,,,,,,,,,,,,,**................,.,......,.............,.......,,//,,,.@%*                              ",
                 @"                          */.,,,,,,,,,,,,,,,,,,,,,,,,.......,..,....................,.,.........,,,,,,,%(.                               ",
                 @"                            **.,,,,,,,,,,,,,,,,.......,...,........................,......,.....,,,,,#%,                                 ",
                 @"                              %..,,,,,,,,,,,,,,*......................................,.........,,,,#%,                                  ",
                 @"                               ,*.,,,,,,,,,,,,,,,,............,.,.....,.......,.....,...,......,,,,.&/                                   ",
                 @"                                ./.,,,,,,,,,,,,,,,,,....,.,.........................,..........,,,./#.                                   ",
                 @"                                  (..,,,,,,,,,,,,,,,,,,......,.........,..............,...,.,..,,..@/                                    ",
                 @"                                   &..,,,,,,,,,,,,,,,,,,..................................,....,..,#,                                    ",
                 @"                                    %..,,,,,,,,,,,,,,,,,,...............................,.....,...@(                                     ",
                 @"                                     (..,,,,,,,,,,,,,,,,,.............,...............,.....,....,@/                                     ",
                 @"                                      .(..,,,,,,,,,,,,,,.......,.................................*%,                                     ",
                 @"                                        &..,,,,,,,,,,,,,,........,.............,...,............,&(.                                     ",
                 @"                                         (...,,,,,,,,,,,,,......................................,&/                                      ",
                 @"                                          .#..,,,,,,,,,,,,,...........,...,.............,......,,@*                                      ",
                 @"                                            (,..,,,,,,,,,,,,.....,.............,............,..,*%*                                      ",
                 @"                                              &..,,,,,,,,,,,,..............................,..,,##.                                      ",
                 @"                                                &...,,,,,,,,,,*..,.,.,...................,..,,,,&*                                       ",
                 @"                                                  *&...,,,,,,,,,,..........................,,,/%(                                        ",
                 @"                                                    .(#..,,,,,,,,,,,,,............,....,,,,,&%#,                                         ",
                 @"                                                       .*%&/,,,,,,,,,,,,,....,...,,,,,,,(@%(,                                            ",
                 @"                                                            .,((&&#*,,,,,,,,,,,,,,,,#&%#/.                                               ",
                 @"                                                                     .,*/((#%#%%%(/,.                                                    ",
                 @"",
                 @"",
                 @"",
                 @"youve won wow",
                 @"",
                 @"",
                 @"[ ENTER ]",
                };

            foreach (string line in poi)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
            Console.WriteLine(x);

            foreach (string line in lyrics)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(100);
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string line in arr2)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(100);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

        }

        private Dictionary<int, int> answers = new Dictionary<int, int>
        {
            {1, 3},
            {2, 4},
            {3, 1},
            {4, 3},
            {5, 2},
            {6, 2},
            {7, 1},
            {8, 3},
            {9, 4},
            {10, 3},
        };

        private static Dictionary<int, int> usrAnswers = new Dictionary<int, int> { };

        private static string[] q1 = 
        {
            @"       [ 1 ]         ",
            @"Oh, yeah!            ",
            @"You gotta get _______",
            @"[1] nifty            ",
            @"[2] quickly          ",
            @"[3] schwifty         ",
            @"[4] serious          ",
        };
        private static string[] q2 =
        {
            @"________________________________________________________________",
            @"You gotta get schwifty in here",
            @"It's time to get schwifty",
            @"Oh oh",
            @"You gotta get schwifty",
            @"Oh, yeah!",
            @"________________________________________________________________",
            @"",
            @"",
            @"               [ 2 ]                ",
            @"Take off your _____ and your panties",
            @"[1] aunts                           ",
            @"[2] eggplants                       ",
            @"[3] romance                         ",
            @"[4] pants                           ",
        };
        private static string[] q3=
        {
            @"     [ 3 ]       ",
            @"Shit on the _____",
            @"[1] floor        ",
            @"[2] galore       ",
            @"[3] shore        ",
            @"[4] war          ",
        };
        private static string[] q4 =
        {
            @"            [ 4 ]           ",
            @"____ to get Schwifty in here",
            @"[1] crime                   ",
            @"[2] rhyme                   ",
            @"[3] time                    ",
            @"[4] slime                   ",

        };
        private static string[] q5 =
        {
            @"Gotta shit on the floor",
            @"",
            @"________________________________________________________________",
            @"     [ 5 ]      ",
            @"I'm Mr. ________",
            @"[1] Bulldog     ",
            @"[2] Bulldops    ",
            @"[3] Robot       ",
            @"[4] Meeseeks    ",
        };
        private static string[] q6 =
        {
            @"         [ 6 ]          ",
            @"Take ___________________",
            @"[1] a bus to your home  ",
            @"[2] a shit on the floor ",
            @"[3] the kids to your hoe",
            @"[4] me to the war       ",
        };
        private static string[] q7 =
        {
            @"________________________________________________________________",
            @"Take off your panties and your pants",
            @"It's time to get schwifty in here",
            @"________________________________________________________________",
            @"",
            @"",
            @"      [ 4 ]       ",
            @"New ____, schwifty",
            @"[1] song          ",
            @"[2] bong          ",
            @"[3] thong         ",
            @"[4] mahjong       ",
        };
        private static string[] q8 =
        {
            @"    [ 8 ]    ",
            @"Double ______",
            @"[1] martinis ",
            @"[2] kill     ",
            @"[3] x        ",
            @"[4] time     ",
        };
        private static string[] q9 =
        {
            @"________________________________________________________________",
            @"Schwifty song, comin' at ya",
            @"It's the schwif-schwifty",
            @"________________________________________________________________",
            @"",
            @"",
            @"         [ 9 ]          ",
            @"Hey, take your _____ off",
            @"[1] socks               ",
            @"[2] panties             ",
            @"[3] bra                 ",
            @"[4] pants               ",
        };
        private static string[] q10 =
        {
            @"        [ 10 ]          ",
            @"It's schwifty time _____",
            @"[1] folks               ",
            @"[2] Morty               ",
            @"[3] today               ",
            @"[4] bitch               ",
        };

        private List<string[]> questions = new List<string[]> { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10 };
        


        private string[] lyrics = 
        {
            @"________________________________________________________________",
            @"",
            @"Oh, yeah!",
            @"You gotta get schwifty",
            @"You gotta get schwifty in here",
            @"It's time to get schwifty",
            @"Oh oh",
            @"You gotta get schwifty",
            @"Oh, yeah!",
            @"Take off your pants and your panties",
            @"Shit on the floor",
            @"Time to get Schwifty in here",
            @"Gotta shit on the floor",
            @"I'm Mr. Bulldops",
            @"I'm Mr. Bulldops",
            @"Take a shit on the floor",
            @"Take off your panties and your pants",
            @"It's time to get schwifty in here",
            @"New song, schwifty",
            @"Double x",
            @"Schwifty song, comin' at ya",
            @"It's the schwif-schwifty",
            @"Hey, take your pants off",
            @"It's schwifty time today",
            @"",
            @"________________________________________________________________",
        };

        public bool quizGame()
        {
            introduction();
            int tempAns = 0;
            
            for (int i = 0; i < questions.Count; i++)
            {
                Console.Clear();
                foreach (string line in questions[i])
                {
                    Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                    Console.WriteLine(line);
                    Thread.Sleep(200);
                }





                while (tempAns != 1 && tempAns != 2 && tempAns != 3 && tempAns != 4)
                {
                    try
                    {
                        tempAns = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(FormatException)
                    {
                    }
                    if (tempAns != 1 && tempAns != 2 && tempAns != 3 && tempAns != 4)
                    {
                        string z = "You should enter 1,2,3 or 4";
                        Console.SetCursorPosition((Console.WindowWidth - z.Length) / 2, Console.CursorTop);
                        Console.WriteLine(z);
                    }

                }


                if (tempAns == answers[i + 1])
                {
                    points++;
                    tempAns = 0;
                }
                else
                {
                    tempAns = 0;
                    continue;
                }
               

            }

            if (points >= 8)
            {
                congratsWin();
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

    }
}
