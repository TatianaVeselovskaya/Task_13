using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class MultiBuilding:Building
    {
        int level;

        public MultiBuilding(string address, int lenght, int width, int height, int level)
          :base(address, lenght, width, height)
        {
            this.level = level;
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {level}";
            return result;
        }
    }
}