using System;
using System.Threading;
namespace DomRia
{
    class Program
    {
        delegate void Delegate();
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Delegate[] items = new Delegate[3];
            items[0] = Manager;
            items[1] = Client;
            items[2] = Exit;
            do
            {

                Console.WriteLine("\n\n\n\n\n\n\t\t\tЗдравствуйте, вы попали в центр обслуживания Дом.Риа");
                Thread.Sleep(1500);
                Console.WriteLine("\t\t\t\t1 - Меню Менджера\n");
                Thread.Sleep(1500);
                Console.WriteLine("\t\t\t\t2 - Меню Клиента\n");
                Thread.Sleep(500);
                Console.WriteLine("\t\t\t\t3 - Выйти\n");
                Thread.Sleep(500);
                Console.Write("\t\t\t\tСделайте свой выбор: ");
                int i = System.Int32.Parse(Console.ReadLine());

                if (i >= 1 && i <= items.Length)
                    items[i - 1]();

            } while (true);

        }
        static void Manager()
        {

            const char x = '█';
            Console.Write("\n\t\tLOADING: ");
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
                Console.Write(x);
            }
            Console.Write("\n");
            Console.Clear();
            Menu menu = new Menu();
            menu.MManager();

        }

        static void Client()
        {
            const char x = '█';
            Console.Write("\n\t\tLOADING: ");
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
                Console.Write(x);
            }
            Console.Write("\n");
            Console.Clear();
            Menu menu = new Menu();
            menu.MClient();
        }
        static void Exit()
        {

            Console.Write("THE END");
            Environment.Exit(0);
        }

    }
}

