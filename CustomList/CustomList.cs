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
        private void HelperMethodAddAndZip(T newValue)
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

        public void AddThingy(T newValue)
        {
            HelperMethodAddAndZip(newValue);
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



        public static CustomList<T> ZippidyDippidy(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();

            if (listOne.Count >= listTwo.Count)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    newList.HelperMethodAddAndZip(listOne[i]);
                    if (i < listTwo.Count)
                    {
                        newList.HelperMethodAddAndZip(listTwo[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    if (i < listOne.Count)
                    {
                        newList.HelperMethodAddAndZip(listOne[i]);
                        newList.HelperMethodAddAndZip(listTwo[i]);
                    }
                    else
                    {
                        newList.HelperMethodAddAndZip(listTwo[i]);
                    }
                }
            }
            return newList;
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

