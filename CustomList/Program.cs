﻿using System;
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
            listOne.AddThingy(7);
            listOne.AddThingy(9);
            listOne.AddThingy(11);
            listTwo.AddThingy(2);
            listTwo.AddThingy(4);
            listTwo.AddThingy(6);

            customList.ZippidyDippidy(listOne, listTwo);
        }
    }
}
