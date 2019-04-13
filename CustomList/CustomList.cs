using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        // member variables
        private int count;
        private int capacity;
        private T[] originalArray;

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
            T[] newArray = new T[capacity];
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
            T[] newArray = new T[capacity];
            int j = 0;
            for (int i = 0; i < count; i++, j++)
            {
                if (originalArray[i].Equals(theRemoved))
                {
                    j--;
                    continue;
                }
                newArray[j] = originalArray[i];
            }
            originalArray = newArray;
            count--;
        }

        public override string ToString()
        {
            return "";
        }



        public void ZippidyDippidy(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < listOne.Count; i++)
            {
                newList[i] = listOne[i];
                newList[i+1] = listTwo[i];
            }
        }
        public IEnumerator GetEnumerable()
        {
            for (int i = 0; i < count; i++)
            {
                yield return originalArray[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }    
}

