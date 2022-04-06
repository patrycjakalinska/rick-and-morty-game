using System;
using System.Threading;


namespace gra
{
    class Program
    {

        static void Main(string[] args)
        {
            You ja = new You();
            Info menu = new Info();
            
            menu.ShowMenu = true;
            menu.menuLogo();
            menu.pressMenu();
            menu.introduction();
            while (menu.ShowMenu)
            {
                Console.Clear();
                menu.menuM();
            }
           





        }


    }
}

