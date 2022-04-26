using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
namespace DomRia
{
    class Manager : Human
    {

        public Manager()
        {
            flat = new Flat();
            flats = new List<Flat>();
        }
        public void Add()
        {
            Read();
            flat = new Flat();
            if (flats.Count > 0)
            {
                flat.ID = flats[flats.Count - 1].ID + 1;
            }
            else
            {
                flat.ID = 0;
            }
            Console.Write("Введите заголовок: ");
            flat.Title = Console.ReadLine();

            Console.Write("Введите город: ");
            flat.location.City = Console.ReadLine();
            Console.Write("Введите район: ");
            flat.location.District = Console.ReadLine();
            Console.Write("Введите улицу: ");
            flat.location.Street = Console.ReadLine();
            Console.Write("Введите номер дома: ");
            flat.location.HomeNumber = Console.ReadLine();

            Console.Write("Введите общую площадь: ");
            flat.information_Flat.Quadrature = double.Parse(Console.ReadLine());

            Console.Write("Введите стоимость в долларах за 1: ");
            flat.price.PricePerSquareMeter = double.Parse(Console.ReadLine());
            //
            flat.price.AmericanCurrency = flat.price.PricePerSquareMeter * flat.information_Flat.Quadrature;
            flat.price.UkraineCurrency = flat.price.AmericanCurrency * 30.10; // Dollar 
            //
            Console.Write("Введите этаж: ");
            flat.information_Flat.Floor = int.Parse(Console.ReadLine());
            Console.Write("Введите количество комнат: ");
            flat.information_Flat.CountRoom = int.Parse(Console.ReadLine());
            Console.Write("Введите имя риелтора: ");
            flat.realtor.Name = Console.ReadLine();

            Console.Write("Введите желаемое сообщение: ");
            flat.Text = Console.ReadLine();
            flats.Add(flat);
            Console.Clear();
            Console.Write("Объявление добавлено!");
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void Save()
        {
            File.Delete("domria.txt");
            foreach (var item in flats)
            {
                File.AppendAllText("domria.txt", item.ToString());
            }
        }
        public void RemoveAdvertisment()
        {
            Console.WriteLine("Введите номер объявления, которое хотите удалить: ");
            int id = int.Parse(Console.ReadLine());
            if (id - 1 <= flats.Count - 1)
            {
                flats.Remove(flats[id - 1]);
                Console.WriteLine("Удалено!");
                Save();
            }
            else
            {
                Console.WriteLine("Объявления с таким номером не найдено!");
            }
        }
    }
}
