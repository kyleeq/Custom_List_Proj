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
            listOne.AddThingy(3);
            listOne.AddThingy(5);
            listTwo.AddThingy(2);
            listTwo.AddThingy(4);
            listTwo.AddThingy(6);
            listTwo.AddThingy(8);
            listTwo.AddThingy(10);
            listTwo.AddThingy(12);

            customList.ZippidyDippidy(listOne, listTwo);
        }
    }
}
