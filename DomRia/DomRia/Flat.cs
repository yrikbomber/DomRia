using System;
using System.Collections.Generic;
using System.Text;

namespace DomRia
{
    class Flat
    {
        public Price price { get; set; }
        public Position location { get; set; }
        public Information_about_the_apartment information_Flat { get; set; }

        public Realtor realtor { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int ID { get; set; }
        public Flat()
        {
            this.price = new Price();
            this.location = new Position();
            this.information_Flat = new Information_about_the_apartment();

            this.realtor = new Realtor();
            Title = String.Empty;
            Text = String.Empty;
            ID = 0;
        }
        public Flat(Price price, Position location, Information_about_the_apartment information_Flat, Realtor realtor, string title, string text, int id)
        {
            this.price = price;
            this.location = location;
            this.information_Flat = information_Flat;

            this.realtor = realtor;
            Title = title;
            Text = text;
            ID = id;
        }
        public override string ToString()
        {
            return string.Format("Заголовок: {0}\nГород: {1}\nРайон: {2}\nУлица: {3}\nНомер дома: {4}\nЦена в $: {5}\nЦена в грн: {6}\nЦена за кв.м: {7}\nЭтаж: {8}\nКоличество комнат: {9}" +
                "\nОбщая квадратура: {10}\nИмя риелтора: {11}\nФамилия риелтора: {12}" +
                "\nДополнительная информация: {13}\nНомер объявления: {14}\n"
                , Title, location.City, location.District, location.Street, location.HomeNumber, price.AmericanCurrency, price.UkraineCurrency, price.PricePerSquareMeter, information_Flat.Floor, information_Flat.CountRoom, information_Flat.Quadrature, realtor.Name, realtor.Surname, Text, ID);
        }
    }
}
