using System;
using System.Collections.Generic;
using System.Text;

namespace DomRia
{
    class Information_about_the_apartment
    {
        public int Floor { get; set; }
        public int CountRoom { get; set; }
        public double Quadrature { get; set; }
        public Information_about_the_apartment()
        {
            Floor = 0;
            CountRoom = 0;
            Quadrature = 0.0;
        }

        public Information_about_the_apartment(int floor, int countRoom, double generalQuadrature)
        {
            Floor = floor;
            CountRoom = countRoom;
            Quadrature = generalQuadrature;
        }
    }
}
