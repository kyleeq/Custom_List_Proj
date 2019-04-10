using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        // member variables
        private int count;
        private int capacity;
        private T[] originalArray;

        public int index;
        public int length;        
        public int value;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }


        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            originalArray = new T[capacity];

        }

        // member methods
        public int GetIndex(array[] value)
        {
            for (int i = 0; i <= value; i++)
            {
                if ()
            }
        }

        public T[] AddThingy(index)
        {

            count++;
        }


    }
}
