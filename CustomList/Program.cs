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

            CustomList<int> aList = new CustomList<int>();

            aList.AddThingy(0);
            aList.AddThingy(1);
            aList.AddThingy(2);
            aList.AddThingy(3);

            aList.ToString();
        }
    }
}
