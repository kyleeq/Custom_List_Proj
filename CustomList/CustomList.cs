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
        private void HelperMethodAddAndExpand(T newValue)
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
            HelperMethodAddAndExpand(newValue);
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
            string emptyString = "";

            for (int i = 0; i < Count; i++)
            {
                emptyString += originalArray[i];
            }
            return emptyString;
        }

        public static CustomList<T> ZippidyDippidy(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();

            if (listOne.Count >= listTwo.Count)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    newList.HelperMethodAddAndExpand(listOne[i]);
                    if (i < listTwo.Count)
                    {
                        newList.HelperMethodAddAndExpand(listTwo[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    if (i < listOne.Count)
                    {
                        newList.HelperMethodAddAndExpand(listOne[i]);
                        newList.HelperMethodAddAndExpand(listTwo[i]);
                    }
                    else
                    {
                        newList.HelperMethodAddAndExpand(listTwo[i]);
                    }
                }
            }
            return newList;
        }
        public static CustomList<T> operator+(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            int newListCount = listOne.Count + listTwo.Count; 

            for (int i = 0; i < newListCount; i++)
            {
                if (i < listOne.Count)
                {
                    newList.HelperMethodAddAndExpand(listOne[i]);
                }
                else
                {
                    newList.HelperMethodAddAndExpand(listTwo[i-listOne.Count]);
                }
            }
            return newList;
        }
        public static CustomList<T> operator-(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            bool indexChecker = false;

            for (int i = 0; i < listOne.Count; i++)
            {
                for (int j = 0; j < listTwo.Count; j++)
                {
                    if (listOne[i].Equals(listTwo[j]))
                    {
                        indexChecker = true;
                        continue;
                    }
                }
                if (indexChecker == false)
                {
                    newList.HelperMethodAddAndExpand(listOne[i]);
                }
                indexChecker = false;
            }
            return newList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return originalArray[i];
            }
        }
    }    
}

