using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace gra
{
    class Info
    {
        public bool ShowMenu { get; set; }
        private bool showSMenu = true;
        private string x = "";
        private int progress = 0;

        public You character = new You();

        public void menuLogo()
        {
            Console.Clear();
            var arr = new[]
            {
             @"                                                                                                                                          (",
             @"                                                                                                                                       (((",
             @"             /((((((.                                                                                                                ((((",
             @"      (((((((((((((((((((.                                                                                              /((          (((",
             @"   ((((((((((((((((((((((((((                                                                                          .((         ((((,",
             @"     (((((((((     ((((((((((     ((                                                                               ((*((((        ((((((",
             @"     ((((((           ((((((((    (((                   ((((                                                      (((((((((       ((((((                                              ((/",
             @"     ((((((             ((((((   ((((                   (((*                                                      (((((((((      ((((((((                                  /((        *((,",
             @"       (((((*           ((((((                          ((((       ((((                                          (((( ((((((   /(((((((((                  (( ,(((((      (((         ((((",
             @"       ((((((         /((((((    /(((         (((.,,.  /((((   (((((,                              .(/          ((((( /(((((* (((((,(((((        ((((/    ((((((((((,     ((((        (((((/",
             @"       (((((((        ((((((     ((((      ,(((((((,   (((((((((((                ((               ((           (((((   *(((* (((((, /(((*     (((((((((  ((((( ((((((   ((((         ((((((",
             @"       ((((((( ,  (((((((((       (((     (((((       ((((((((((                ((((   ((   (((   (((           (((((    (((( (((((  (((((   (((( ((((((  (((((,(((((   *(((.          (((((           (((/",
             @"        (((((((((((((((          (((((   (((/         ( (((((                  (((((( (((( (((   ((((           ((((/     (((((((,  ((((((  ((((, ,((((,   ((((((    ((((((((((,       ((((((      (((((",
             @"         (((((((((((((((          (((,  (((((           ((((((*                (((((( (((((((( (((((.           ((((      (((((((    (((((  ((((   (((((  ((((((((.     ((((((((((((    ((((((((((((",
             @"         (((((( ((((((((((        ((((  (((( /(((.  (   ((((((((((            ((( .(((((( ((((((  ((.         ((((((      ,((((((    ((((    ((((( ((((((  (((,((((     ((((           .(((((((((",
             @"         ((((((.    ((((((((((    (((   ((((((((((((.  (((    (((((          (((   /((*((  ((((((((((         ((((((        .(((     (((((   ((((((((((    ((   /(((    ((((           ((((((*",
             @"          (((((,         (((((((  .((      (((         ((/    ,(((((          (,    .(          *  (((        ((((           ((*      ((((       ((*       ((     ((    (((        ((((((((",
             @"          (((((            . ((((  (        ,         (((       ((((                                          *(((                     ((((                       (((   (((       ((((((",
             @"          (((((.              (((((.                             ((((                                         /(((                     ((((                        ((   ((.     ((((((",
             @"           (((((                 (((((                            ((((                                         ((                       (((                             ((     (((((",
             @"            ((((                    (((                            ((                                          (/                         ((                                 (((((",
             @"            ((((/                   ((((                                                                                                                                  /(((((",
             @"             ((                       ((                                                                                                                               (((((",
             @"                                                                                                                                                                     ((",
             @"",
             @"",
            
            };
            Console.WindowWidth = 232;
            Console.WindowHeight = 65;
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string line in arr)
            {
                Console.SetCursorPosition((30) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(20);
            }

            var arr2 = new[]
            {
             @"     _______ _     _ _______       ______ _______ _______ _______        ",
             @"        |    |_____| |______      |  ____ |_____| |  |  | |______        ",
             @"        |    |     | |______      |_____| |     | |  |  | |______        ",
             @"",
             @"",
             @"",
            };
            foreach (string line in arr2)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(20);
            }
        }

        public void menuM()
        {

            //wez zeby progress liczylo tez osobno
            var arr1 = new[]
            {

                @"[ 1 ] Use Portal Gun         ",
                @"",
                @"",
                @"[ 2 ] Check your progress    ",
                @"",
                @"",
                @"[ 3 ] Check your EQ and stats",
                @"",
                @"",
                @"[ 4 ] Game info              ",
                @"",
                @"",
                @"[ 5 ] Exit                   ",
                @"",
                @"",
                
            };
            Console.ForegroundColor = ConsoleColor.Green;
            menuLogo();
            foreach (string line in arr1)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(50);
            }
            choiceMenuM();
        }

        public void choiceMenuM()
        {

            int chSwitch = getInput();
            

            switch(chSwitch)
            {
                case 1:
                    Console.Clear();
                    while (showSMenu)
                    {
                        secondMenu();
                    }
                    break;
                case 2:
                    progressCheck();
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                    break;

                case 3:
                    menuLogo();
                    character.viewEQ();
                    break;

                case 4:
                    gameInfo();
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                    break;
                case 5:
                    Console.Clear();
                    x = "See ya later!";
                    Console.SetCursorPosition((Console.WindowWidth - x.Length)/2, Console.CursorTop);
                    Console.WriteLine(x);
                    ShowMenu = false;
                    break;
                default:
                    break;



            }

        }

        public void pressMenu()
        {
            var arr3 = new[]
            {
             @"___  ____ ____ ____ ____    ____ _  _ ___ ____ ____    ___ ____    ____ ___ ____ ____ ___",
             @"|__] |__/ |___ [__  [__     |___ |\ |  |  |___ |__/     |  |  |    [__   |  |__| |__/  | ",
             @"|    |  \ |___ ___] ___]    |___ | \|  |  |___ |  \     |  |__|    ___]  |  |  | |  \  | ",
            };

            foreach (string line in arr3)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(100);
            }
            Console.ForegroundColor = ConsoleColor.Black;
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }

        public void introduction()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var arr = new[]
            {
             @"_  _ ____ ____ ___ _   _    _    _  _ ____ ____ ___     _   _ ____ _  _ ____    _  _ ____ _    ___",
             @"|\/| |  | |__/  |   \_/     |    |\ | |___ |___ |  \     \_/  |  | |  | |__/    |__| |___ |    |__]",
             @"|  | |__| |  \  |    |      |    | \| |___ |___ |__/      |   |__| |__| |  \    |  | |___ |___ |    ...",
             @"",
             @"",
             @"",
             @"",
            };

            foreach (string line in arr)
            {
                Console.SetCursorPosition(65, Console.CursorTop);
                Console.WriteLine(line);
            }



            var arr1 = new[]{
                @"Thanks for sticking this seeds for me Morty. Even if now you will be in great pain and no longer smart.",
                @"But I’m sorry, Morty. It’s a bummer. In reality, you’re as dumb as they come and I needed those seeds real bad, ",
                @"and I had to give them up just to get your parents off my back, so now we’re gonna have to go get more.",
                @"And then we’re gonna go on even more adventures after that, Morty and you’re gonna keep your mouth shut about it, Morty,",
                @"because the world is full of idiots that don’t understand what’s important, and they’ll tear us apart,",
                @"Morty but if you stick with me, I’m gonna accomplish great things, Morty, and you’re gonna be part of them, and together, we’re gonna run around, Morty.",
                @"We’re gonna do all kinds of wonderful things, Morty. Just you and me, Morty.",
                @"The outside world is our enemy, Morty. We’re the only friends we’ve got, Morty.",
                @"It’s just Rick and Morty.",
                @"Rick and Morty and their adventures, Morty. ",
                @"Rick and Morty forever and forever.",
                @"Morty’s things. ",
                @"Me and Rick and Morty running around, and Rick and Morty time.",
                @"All day long, forever. ",
                @"All a hundred days.",
                @"Rick and Morty forever 100 times.",
                @"Over and over, rickandmortyadventures.com.",
                @"All 100 years.",
                @"Every minute, ",
                @"rickandmorty.com.",
                @".",
                @".",
                @".",
                @"Press enter to continue...",
        };
            foreach (string line in arr1)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            Console.Clear();
        }

        public void secondMenu()
        {
            menuLogo();
            var arr = new[]
            {
                @"___  _ ____ _  _    _   _ ____ _  _ ____    ___  ____ ____ ___ _ _  _ ____ ___ _ ____ _  _",
                @"|__] | |    |_/      \_/  |  | |  | |__/    |  \ |___ [__   |  | |\ | |__|  |  | |  | |\ |",
                @"|    | |___ | \_      |   |__| |__| |  \    |__/ |___ ___]  |  | | \| |  |  |  | |__| | \|",
                @"",
                @"",
                @"",
            };
            foreach (string line in arr)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop); //132
                Console.WriteLine(line);
                Thread.Sleep(50);
            }
            var arr1 = new[]
            {

                @"[ 1 ] Cromulon Dimension    ",
                @"",
                @"",
                @"[ 2 ] Snake Planet          ",
                @"",
                @"",
                @"[ 3 ] Interdimensional Cable",
                @"",
                @"",
                @"[ 4 ] The Citadel           ",
                @"",
                @"",
                @"[ 5 ] Back                  ",
                @"",
                @"",

            };
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string line in arr1)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length)/2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(50);
            }
            choiceSecondM();

        }

        public void choiceSecondM()
        {
            int chSwitch = getInput();

            

            switch (chSwitch)
            {
                case 1:
                    CromulonD hed = new CromulonD();
                    if (hed.quizGame() == true)
                    {
                        character.progress();
                        /*chSwitch = 7;*/
                        progress++;
                        showSMenu = false;
                        break;
                    }
                    else
                    {
                        showSMenu = false;
                        break;
                    }
                case 2:
                    
                    SnakePlanet wonsz = new SnakePlanet();          
                    if (wonsz.gameMaze() == true)
                    {
                        character.progress();
                        /*chSwitch = 7;*/
                        progress++;
                        showSMenu = false;
                        break; 
                    }
                    else
                    {
                        showSMenu = false;
                        break;
                    }
                case 3:
                    InterdimensionalCable id = new InterdimensionalCable();

                    id.idIntroduction();
                    while (!id.TheEnd)
                    {
                        id.displayCurrentLvl();
                        Cables word;

                        do
                        {
                           
                            Console.WriteLine("Enter word: ");
                            string wordAsString = Console.ReadLine();
                            word = StringToWordConv.Convert(wordAsString);

                        } while (id.makeGuess(word));
                    }
                    if (id.Win == false)
                    {
                        x = "Game over, loser!\nPress enter to exit!";
                        Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                        Console.WriteLine(x);
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                    }

                    else
                    {

                        id.idWinCongrats();
                        character.progress();
                        progress++;
                        Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                        Console.WriteLine(x);
                    }
                    
                    break;
                case 4:
                    
                    if (progress >= 3)
                    {
                        Citadel cytadel = new Citadel(ref character);
                        if (cytadel.game() == true) gameWon();
                        else youLost();
                        break;
                    }
                    else
                    {
                        menuLogo();
                        x = "Not having finished all missions you cannot enter citadel - are you dumb Morty?";
                        Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                        Console.WriteLine(x);
                        Thread.Sleep(100);
                        x = ".";
                        int g = 0;
                        while(g < 3)
                        {
                            Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                            Console.WriteLine(x);
                            Thread.Sleep(500);
                            g++;
                        }
                        x = "Yep, Morty you are dumb. Do you wnat to die that much?? I will get you out of here but it's last time...";
                        Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                        Console.WriteLine(x);
                        Thread.Sleep(200);
                        x = "Pls, press enter";
                        Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                        Console.WriteLine(x);
                        Thread.Sleep(200);
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                        secondMenu();
                        break;
                    }
                    
                case 5:
                    showSMenu = false;
                    break;
                default:
                    
                    menuLogo();
                    string s = "That's not right! I will transport you back as a punishement!";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(s);
                    Thread.Sleep(1500);
                    showSMenu = false;
                    break;
                    


            }
        }

        public int getInput()
        {
            int choiceSwitch = 7;

            do
            {
                try
                {
                    choiceSwitch = Convert.ToInt32((Console.ReadLine()));
                }
                catch (FormatException)
                {
                }

            } while (choiceSwitch > 5);
            return choiceSwitch;

        }

        public void progressCheck()
        {
            x = "You've completed " + progress + " out of 3 obligatory levels. ";
            Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
            Console.WriteLine(x);
            Console.WriteLine("\n\n");

            switch (progress)
            {
                case 0:
                    x = "Console - please change Morty's name to Jerry. He doesn't deserve it";
                    Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                    Console.WriteLine(x);
                    break;
                case 1:
                    x = "Only one? C'mon Morty, you are really like your father.";
                    Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                    Console.WriteLine(x);
                    break;
                case 2:
                    x = "You are really close!! Don't give up on your dream boy - it's 20 minute adventure - in and out!";
                    Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                    Console.WriteLine(x);
                    break;
                case 3:
                    x = "With your expertise you can now face Evil Morty at the Citadel! But remember, you have one chance! If you don't feel it redo some levels - that will give you additional weapons";
                    Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
                    Console.WriteLine(x);
                    break;

                default:
                    progress = 3;
                    break;
            }
            x = "[ ENTER ]";
            Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop);
            Console.WriteLine(x);
        }

        public void gameInfo()
        {
            var info = new[]
            {
                @"_____________________________________________________________________________________________________________________",
                @"Main goal of the game? Kill Evil Morty in the Citadel",
                @"But it's not that easy",
                @"First you need to pass three tasks in each dimension: Cromulon, Snake and Interdimensional Cable",
                @"Completing each task will add you some HP and drop some cool weapons",
                @"And you better get some good amount of that HP 'cause you'll need a lot fighting with Morty. (He has 500!)",
                @"You can redo some levels to HP up - but I reckon you know it already",
                @"If you lose final fight the game will end and you'll have to start all over again - so be careful",
                @"And remember - it's not a masterpiece.",
                @"It's awfully simple and cringe game that I had to do to pass this year.",
                @"Please have fun, this game is literally full of my tears ;;---;;",
                @"So wubba lubba dub dub and go for it",
                @"_____________________________________________________________________________________________________________________",
                @"[ ENTER ]",
            };
            foreach (string line in info)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);

            }
        }

        public void gameWon()
        {
            var won = new[]
            {
             @"                                                                                                                                                                                           ",
             @"                                                                                                                                                                                           ",             @"                                                                                                                                                                                           ",
             @"                                                                                                                                                                                           ",
             @"                                                                                                                                                                                           ",
             @"                                  @&@/                                                                                                                                                     ",
             @"                                @../*...@&                        @@.                                                                                                                      ",
             @"                              (#..&&...*@.@                       @.,@                                                                                                                     ",
             @"                             @...*@/....@.,@                     @,...@*                                                                                                                   ",
             @"                           %(.........@..&%                      @.....*&                                                                                                                  ",
             @"                         .@......@*,@@@/          ,             @........@           .@##                                                                                                  ",
             @"                        @,./@,.,#%                @..&@/       &,.........@       &@,..@.                                                                                                  ",
             @"                     @ @,...%(                    ((......,#@@@,...........@/@@*.......@                                                                                                   ",
             @"                   &*     &@%,                     @..................................@                                                                                                    ",
             @"                  @        .@                      @,........./@&*.....,(@&.........,@                                                                                                     ",
             @"               .&.       .@                        ,&.....,@.................(%....%.                                                                                                      ",
             @"               @        @               .../%@@@#,......,&........,,,..........*(........,*(%@,                                                                                            ",
             @"             %.       &*                .,@............%,...&,............,&&..%/...*#....&#.                                                                                              ",
             @"            @        @                      @&........&..................,@#%...&#..*..@#                                                                                                  ",
             @"          @.       @,                          @*....#,...*#       (#......&.,&..%#..,,..@                                                                                                 ",
             @"        (#       *&                         ,@@/.....#...@           @....#%@,..@..@.....(.                                                                                                ",
             @"       @        @.                     %(...........@....@           @.@       #%&,/,*@..@                                                                                                 ",
             @"     @,       #(                         #&......,@@,.....@     &@  @.@          @((.....@                                                                                                 ",
             @"  ,@        @                              ,@,.@..@....&,..../&@%,...*,     .  #.#%@(.&,../#%@                                                                                             ",
             @"  #       &     ,&@&,                     ,@...//.(........*(.....*..&.*@*  ,@(..@   @,...&   *&                                                                                           ",
             @"      *&@&,                      #@@/          %/,/...%@%,.........@&.......#..,/(#%@  .@         @,                                                                                       ",
             @"              .#@@/                     .#@@%/&...@..*/..@.................%.@            @.        (#                                                                                     ",
             @"                      ./@@#.                    #,.(........,&&*.........&&..(*             @/        (%                                          /@@,@@                                   ",
             @"                               ,&@&,        .#  (@..@.................../#           ..,*/(#(#@/        (&                                        */#.&.@(                                 ",
             @"                                      *(   @   @...(@/@*..............%,                        /#        #/                                    @/ @.#*,@,&                                ",
             @"                                      @  *,   ,,........& #@#///#&@*                              ,&      ,%                                    %,.@....&*%                                ",
             @"                                     .% &     @.........%    &     %  .....,*//(###%&&@@@@@@@@@@@@@@@%/,(@.                                      #/..%,..@                                 ",
             @"                                     @ @     ./.........#     ,    %                                                                              &*....@                                  ",
             @"                                     @&      #..........#     #    &                                                   .......                     @....@                                  ",
             @"                                    &/       &..........#      @   &                                            #@&###############%@@*             .&....@                                 ",
             @"                                    @@       &..........&     &    @                                         &&#########################@*          //....@                                ",
             @"                                    @  ,#    (..........&   &      @                                       (&###########%%%%%##############@.        &,....@                               ",
             @"                                    &   */  *,..........&  &       @                                     #&#####&@%...............#@&########@        @.....@                              ",
             @"                                    %.%     &...........*.    &    #.                                  ,@####@,..............,***,....*@######&/       @.....@                             ",
             @"                                    (*      @...........,%      .  .%                                  @##%%.............................@#####&*       @.....@                            ",
             @"                                     @      %............%      %   @                                  @#@&,..............(/       &,.....*&####@       .@....,&                           ",
             @"                                     &,     %.............#     &   @                                 @%@..@(  .(@,......&  /        @.....,@###&.       @&....@                           ",
             @"                                     @#     (.............#     %   #*                                .@./ @(       #...#             &.....#%##@,     ##.....@                            ",
             @"                                     @ &   ./..............&    %    @                                 @#           ,....@           ,,......@##@   ,@@.....*&                             ",
             @"                                     @  ,  .*...............&   %    .#                                @,/          &.....*%       ##........,@@( &/&#.....@.                              ",
             @"                                     @  @  *,................@  &     *(                               #,.@       *#..%*.......................*@@ . .&,.,@                                ",
             @"                                     @  .. /..................& &      ,&                               @............,#,@(......,..&(.........,@        .,&                                ",
             @"                                     */    (.................../,        @                              .&.................,@,&&&&@(.@......@@         .@,                                 ",
             @"                                     .@    (.....................&        %*                             .@.......,@&@@@@@@@&&&&&&&@.@.....# .        /&                                   ",
             @"                                      @    #......................&        .@                              &(......@&&&&&&&&&&&@&&@@.....@.         .@                                     ",
             @"                                      @    #.......................*,        @.                              *@......&@&&&&&&&&@@&....@,           @                                       ",
             @"                                      %.   #/.......................,(        (#                                 &@,.............&%              *  %&                                     ",
             @"                                      //   #*,......,.........&.,(@@&&%         @                                        ..%%                        .@                                    ",
             @"                                      .#   &.#*,,,.,,#,*#@@@@&@&&&&&@@%@         &,                                      @/ .                          ,&                                  ",
             @"                                       &   @..(@&&&&@*.....&@@@&########@         (/                                   @*       ..                       @                                 ",
             @"                                       &   &....@########################@         %.                                #( .        @.                      .@                                ",
             @"                                       &   %.....@########################@         @                               ,#        *@. @.                       @.                              ",
             @"                                       &   #....,%################@########@        %,                             @,.%    .@#     @.                      .@                              ",
             @"                                       %   #...(%#######(@........@#######@.&        @                           *&.....#@@..       &                        %,                            ",
             @"                                      .%   (..&#########%........(########@../       @                          @.....@@.           (/                        #*                           ",
             @"                                       ,#   /.@########&*.........@#######%,..,,      *#                        .@..........#@@       @                        .%,                         ",
             @"                                       /,  .,@########@...........&#######@..../       @                            #@#.........../@@. @                         &,                        ",
             @"                                       &   *@########@...........(########&.....&      @                                  /@@,.........%                          @                        ",
             @"                                      @   @########&............@#######%,......@     /*                                       .@@(....@                          @                        ",
             @"                                      @ .&#######%/.............@#######@........&     &                                        *&#((*./.                         .&                       ",
             @"                                     .%/%#####(#@............../########%........,.    @                                         @&%#*..@                          ((                      ",
             @"                                     *%#(######@...............&#######&..........@    @                                          @/...%@.                          @.                     ",
             @"                                     @########@................@######(@..........,.   @                                           &@@@@&@                           @                     ",
             @"                                    @#######%(................,%#######/...........@   @                                                 @                           (,                    ",
             @"                                  .@#######@..................########@............/   @                                                 &.                         %@.                    ",
             @"                                 ,@#######@...................@#######&.............@  @                                                 ,#                    *@@%%%%@                    ",
             @"                                (&#######@....................@######%,.............*  @                                                  @           . .%@@%%%%%%%%%%@                    ",
             @"                               &%######%#....................*%######@...............# @                                                  #@@&@&&&%%%%%%%%%%%%%%%%%%%@                     ",
             @"                              *&######&,.......(&@@@&(**,,,,*@#######@.*/#&@@@@@(....@ @                                               #@%%%%%%%%%%%%%%%%%%%%%%%%%%%@.                     ",
             @"                               @#######@#.                   @######%(              (@**                                            &@%%%%%%%%%%%%%@@@@@@&%%%%%%%%%@,                      ",
             @"                               @#######@                     *&######@               (@                                          @&%%%%%%%%%%%%%@@     .@%%%%%%%%%&/                       ",
             @"                               @#######@                      @######&*              .,                                      .@&%%%%%%%%%%%%&@,        @%%%%%%%%%&%                        ",
             @"                               /%######@,                     (#######@                                                   ,@%%%%%%%%%%%%%@#           (&%%%%%%%%&%                         ",
             @"                               .@########                      @######@.                                               /@%%%%%%%%%%%%@@              .@%%%%%%%%%@                          ",
             @"                                @#######@                      #&######&                                             @%%%%%%%%%%%&@*                 @%%%%%%%%%@                           ",
             @"                                *&######@                       @######@                                             @%%%%%%%%@%                    ,@%%%%%%%%@                            ",
             @"                                 @######@                       *&#####&,                                            .@%%%%@%%@                     @%%%%%%%%@                             ",
             @"                                 @######&.                       @######@                                              @%%%%%%%@                   %&%%%%%%%@                              ",
             @"                                 ,&######&                        @#####@                                               @%%%%%%%@                  @%%%%%%%@                               ",
             @"                                  @######@                        @#####&,                                              .@%%%%%%%@                @%%%%%%%@%                               ",
             @"                                  @######%/                       .@#####@                                                @%%%%%%%@                @&%%%%%%%@,                             ",
             @"                                  @#######%                        @#####&,                                                @%%%%%%&%                ,@%%%%%%%%@.                           ",
             @"                                  .&@(/, @                          @%@%.@                                                  @%%%%%%&%                 &&%%%%%%%@*                          ",
             @"                                    @    @                           &    @                                                  @%%%%%%@/                  @%%%%%%%%@                         ",
             @"                                    @    @                           @    #,                                                  @&@@. @.                   ,@%%%%%%%&%                       ",
             @"                                   %@@&&&&&@                         @@@@@@&@                                                    @   &.                   .&&%%%%%%%@                      ",
             @"                                /@&&&&&&&&&&&                      @&&&&&&&&&@                                                  %@.,,,*@.                    @%%%%%%%&%                    ",
             @"                             #@&&&&&&&&&&&&&@.                  /@&&&&&&&&&&&&#                                             (@.        .#                     ,@%%%%&%@                    ",
             @"                          .@&&&&&&&&&&&&&&&&&&                @&&&&&&&&&&&&&&&@                                          @/            */                       ,@@.   @..                 ",
             @"                         .&@@@@@@@@@@@@@@@%*.               @@&&&&&&&&&&&&&@@&                                                                                  .@,      //                ",
             @"                                                                                                                                                             .@,          @                ",
             @"                                                                                                                                                           @*         ,/%@@                ",
             @"                                                                                                                                                                                           ",
             @"                                                                                                                                                                                           ",
             @"                                                                                                                                                                                           ",
             @"                                                                                                                                                                                           ",
            };

            var youW = new[]
            {

                @"___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___",
                @"",
                @"",
                @"_   _ ____ _  _ . _  _ ____    _ _ _ ____ _  _",                              
                @" \_/  |  | |  | ' |  | |___    | | | |  | |\ |",                              
                @"  |   |__| |__|    \/  |___    |_|_| |__| | \|",
                @"",
                @"",
                @"___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___",

            };
            foreach (string line in youW)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);

            }
            foreach (string line in won)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(50);

            }
            ShowMenu = false;
            showSMenu = false;
        }

        public void youLost()
        {
            var youL= new[]
            {
                @"___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___",
                @"",
                @"",
                @"_   _ ____ _  _ . _  _ ____    _    ____ ____ ___",                           
                @" \_/  |  | |  | ' |  | |___    |    |  | [__   | ",                          
                @"  |   |__| |__|    \/  |___    |___ |__| ___]  | ",
                @"",
                @"",
                @"___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___",

            };
            var lost = new[]
            {
             @"                                                                                                                                                                                              ",
             @"                                                                                                                                                                                              ",
             @"                                                                                                                                                                                              ",
             @"                                                                                                                                                                                              ",
             @"                                                                                                                                                                                              ",
             @"                                                                             ./(#&@@@@@@@@@@@@@@@@@#(/*.                                                                                      ",
             @"                                                                   ,@@@@%#####################################%&@@@@@@&*                                                                      ",
             @"                                                              .@@@#########################################################&@@@&,                                                             ",
             @"                                                          ,@@%####################################################################&@@#                                                        ",
             @"                                                      .@@%#############################################################################@@*                                                    ",
             @"                                                  (@@&####################################################################################@@,                                                 ",
             @"                                             #@@&############################################################################################@&                                               ",
             @"                                        .@@&###################################################################################################@@                                             ",
             @"                                    .@@&#########################################################################################################@&                                           ",
             @"                                 %@@###############################################################################################################@*                                         ",
             @"                              @@%###################################################################################################################@@                                        ",
             @"                           @@#########################################################################################################################@/                                      ",
             @"                        &@%####################################################################%@@@@@@@&%/*,,.,.,.,.,,*/%&@@@@@@&######################@@                                     ",
             @"                     *@&##############################################################&@@@@/,......................................,(@@@&###############%@                                    ",
             @"                   %@###########################################################@@@(,.....................................................,&@@%##########%@                                   ",
             @"                 &@########################################################&@@/................................................................,@@@#######@@                                  ",
             @"               *@######################################################&@@,........................................................................,@@&####@                                  ",
             @"              @@###################################################%@@,................................................................................(@@#@                                  ",
             @"             @%#################################################&@%.......................................................................,...............(@#                                 ",
             @"            @%###############################################@@#...........................................................................*@@@#,,........,/&@@%                              ",
             @"           @&#############################################&@%.........................................(*......................................................./@/                            ",
             @"          (@############################################@@........................................../@*...................................................../@@@@@@%#(#&@@@@@,                ",
             @"          @%#########################################&@/..........................................@@,..................................................(@@/                    &@#            ",
             @"         @&########################################@@,........................................,@@,.................................................,@@,                           #@*         ",
             @"        @&#######################################@@.......................................,&@%...................................................@@                                 ,@,       ",
             @"       @&######################################@@..................................,/@@@%,....................................................,@&                                     &@      ",     
             @"      @@#####################################@@............................................,&@@@@#*.       ./&@@@&,..........................@@                                        *@     ",
             @"     #@####################################&@,........................................*@@%                          @@%....................,@*                                          ,@    ",     
             @"    .@####################################@#......................................,@@,                                 *@%.................@*                                            #@   ",
             @"    @&##################################&@.....................................,@@                                        @@..............@&                                 *@@@#.       @(  ",
             @"   *@##################################@%....................................%@.                                            @(............@,                                .@@@@@        *@  ",
             @"   @&#################################@*...................................%@                                                @@..........,@.                                  *@&          @  ",
             @"   @%###############################%@,..................................,@*                                                  @@..........@/                                               @. ",
             @"   @###############################%@,..................................*@                                                     @(.........#@                                              .@  ",
             @"   @##############################%@,..................................,@                                                      ,@..........@#                                             %@  ",
             @"   @##############################@,...................................@%                                                       @,..........@*                                           .@   ",
             @"   @#############################@#...................................,@                %&@@@@.                                 @*...........@(                                         .@.   ",
             @"   @&###########################&@....................................,@                #@@@@@.                                .@,............@@                                       %@     ",
             @"   #@###########################@*.....................................@/               @@@@@                                  &@..............,@(                                   *@*      ",
             @"    @##########################&@....................................../@                                                     *@,................*@%                               @@,(@      ",
             @"    /@#########################@(.......................................@&                                                   ,@,....................&@#                        *@@*....@/     ",
             @"     @&########################@.........................................@&                                                 (@.........................,&@@#.           ,&@@@#.........#@     ",
             @"     (@#######################%@..........................................&@                                               @&....................(@@&,.........,,,,,,..................,@.    ",
             @"      @#######################&@...........................................*@.                                           %@...........................*@@/..............................@%    ",
             @"      @#######################&@.............................................&@                                        %@,................................@&............................#@    ",
             @"      @%######################&@...............................................&@.                                   @@....................................@&...........................,@    ",
             @"      @@######################%@.................................................,@@.                             @@*.....................................,@*...........................,@    ",
             @"      (@#######################@,....................................................(@@%                   .%@@%,....................................../@@.............................,@.   ",
             @"       @&######################@%..........................................................*%@@@@@@@@@@@&/,.....................................,*(((*,.................................,@    ",
             @"        @&#####################&@.......................................................................................................................................................,@    ",
             @"         @@#####################@*......................................................................................................................................................(@    ",
             @"          .@%###################&@......................................................................................................................................................@%    ",
             @"            #@###################@(....................................................................................................................,...............................,@     ",
             @"              &@##################@,......*@@&,.......................................................................................................,@,..............................%@     ",
             @"                &@################&@...*@&.............................................................................................................@%.............................,@      ",
             @"                  &@###############@@/@*...............................................................................................................#@.............................@#      ",
             @"                    @@##############@@.................................................................................................................,@............................&@       ",
             @"                      @%###########&@..................................................................................................................,@,..........................%@        ",
             @"                       @@##########@%...................................................................................................................@,.........................%@         ",
             @"                        @@#########@%................................................................................................,@,.......,,......*@.........................@@          ",
             @"                         @@########%@.................................................................................................@/.......#@%.....@%........................@(           ",
             @"                           @@%######@@................................................................................................@@.......%@,@@@@@*.......................(@             ",
             @"                               /@@@@@@@.............................................................................................../@.......@/............................,@#              ",
             @"                                      .@#..............................................................................................@%.....&@............................@@                ",
             @"                                         @@(..............,,............................................................................@@,./@#...........................@@                  ",
             @"                                             *@@@@@@@@@@/,.............................................................................................................,@@                    ",
             @"                                                 ,@/................................................................................................................./@(                      ",
             @"                                                   .@&............................................................................................................,@@                         ",
             @"                                                      #@(......................................................................................................,@@.                           ",
             @"                                                    #@@&.%@%................................................................................................/@@@*                             ",
             @"                                               .@@&.        ,@@/........................................................................................,@@/     .@@&                         ",
             @"                                            #@&.                ,@@&,..............................................................................,%@@(             *@@                      ",
             @"                                         /@%                         ,@@@#,.................................................................*%@@@(.                     /@%                   ",
             @"                                       @@.                                  (@@@@(,..............................................,*#@@@@@/.                               .@@                 ",
             @"                                     @@                                             .,(@@@@@@@@@&#/*,,,,,,,,,,**(&&@@@@@@@@@&/..                                            .@@               ",
             @"                                   /@,                                                                                                                                        ,@/             ",
             @"                                  @@                                                                                                                                            @@            ",
             @"                                 @(                                                                                                                                              *@.          ",
             @"                                @#                                                                                                                                                .@*         ",
             @"                               @@                                   ,@.                                                                                       @&                   .@/        ",
             @"                              .@@&,                                .@.                                                                                         #@                 .*@@.       ",
             @"                                    *@@@@@%,.                      @#                                                                                           %@     ../&@@@@@#.            ",
             @"                                               ,(&@@@@@@@@&&(,..  .@.                                                                           ..,/(&&@@@@@@@@@@&(*..                        ",
             @"                                                                     .,,//#&%%&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&%%%(/*,,,                                                    ",    
             @"                                                                                                                                                                                              ",
             @"                                                                                                                                                                                              ",
             @"                                                                                                                                                                                              ",
             @"                                                                                                                                                                                              ",
             @"                                                                                                                                                                                              ",
            };
            foreach (string line in youL)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);

            }
            foreach (string line in lost)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                Thread.Sleep(50);

            }
            ShowMenu = false;
            showSMenu = false;
        }

    }

}
