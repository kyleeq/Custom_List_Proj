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
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();

            listOne.AddThingy(1);
            listOne.AddThingy(5);
            listOne.AddThingy(3);
            listTwo.AddThingy(3);
            listTwo.AddThingy(4);
            listTwo.AddThingy(6);

            customList = listOne - listTwo;
        }
    }
}
