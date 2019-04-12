using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.AddThingy(1);
            customList.AddThingy(2);
            customList.AddThingy(3);
            customList.AddThingy(4);
        }
    }
}
