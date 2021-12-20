using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Building
    {
        string address;
        int lenght;
        int width;
        int height;

        int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value > 100)
                    lenght = 100;
                else if (value < 0)
                    lenght = 1;
                else
                    lenght = value;
            } 
        }

        public Building(string address, int lenght, int width, int height)
        {
           this.address = address;
           this.Lenght = lenght;
           this.width = width;
           this.height = height;
        }
        public string Print ()
        {
        return $"{address} {lenght} {width} {height}";
        }
    }
}
