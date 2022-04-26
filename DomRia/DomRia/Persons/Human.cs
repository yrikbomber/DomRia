using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DomRia
{
    abstract class Human
    {
        public List<Flat> flats { get; set; }
        public Flat flat { get; set; }
        public Human()
        {
            flat = new Flat();
            flats = new List<Flat>();
        }
        public void Read()
        {
            string read_file = File.ReadAllText("domria.txt");
            string[] mas = read_file.Split(':', '\n');
            string[] tmp = new string[mas.Length / 2];
            int j = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 != 0)
                {
                    tmp[j] = mas[i].TrimStart();
                    j++;
                }
            }
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                flat = new Flat();
                flat.Title = tmp[i];
                flat.location.City = tmp[i + 1];
                flat.location.District = tmp[i + 2];
                flat.location.Street = tmp[i + 3];
                flat.location.HomeNumber = tmp[i + 4];
                flat.price.AmericanCurrency = double.Parse(tmp[i + 5]);
                flat.price.UkraineCurrency = double.Parse(tmp[i + 6]);
                flat.price.PricePerSquareMeter = double.Parse(tmp[i + 7]);
                flat.information_Flat.Floor = int.Parse(tmp[i + 8]);
                flat.information_Flat.CountRoom = int.Parse(tmp[i + 9]);
                flat.information_Flat.Quadrature = double.Parse(tmp[i + 10]);
                flat.realtor.Name = tmp[i + 11];
                flat.realtor.Surname = tmp[i + 12];
                flat.Text = tmp[i + 13];
                flat.ID = int.Parse(tmp[i + 14]);
                flats.Add(flat);
                i += 14;
            }
        }
        public void ShowAll()
        {
            if (flats.Count == 0) Read();
            foreach (var item in flats)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}