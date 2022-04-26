using System;
using System.Collections.Generic;
using System.Text;

namespace DomRia
{
    class Realtor
    {
        public Realtor(string name, string surname, double rating)
        {
            Name = name;
            Surname = surname;
            Rating = rating;

        }
        public Realtor()
        {
            Name = String.Empty;
            Surname = String.Empty;
            Rating = 0.0;
        }

        public string Name { get; set; }
            public string Surname { get; set; }

        public double Rating { get; set; }

    }
}
