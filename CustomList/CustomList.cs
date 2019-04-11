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
        private T[] newArray;

        public T this[int i]
        {
            get { return originalArray[i]; }
            set { originalArray[i] = value; }
        }
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
        

        public void AddThingy(T newValue)
        {
            if (count == capacity)
            {
                capacity *= 2;
                newArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = originalArray[i];
                }
                originalArray = newArray;
                originalArray[count] = newValue;                
            }
            else
            {
                originalArray[count] = newValue;                
            }
            count++;
        }
        public void RemoveThingy(T theRemoved)
        {
            for (int i = 0; i < count; i++)
            {                
                if (i = theRemoved)
                {
                    continue;
                }
                else
                {
                    newArray[i] = originalArray[i];
                }
            }
            originalArray = newArray;
            count--;
        }

    }
}
