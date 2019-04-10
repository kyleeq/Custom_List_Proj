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
        private readonly int count;
        public int index;
        public int length;

        public int Count
        {
                get
                {       
                    return count;                    
                }
        }

        // constructor

        // member methods
        public int GetIndex()
        {
            if (int index >= 0 && int index < length)
            {
                return Array[index];
            }
        }

    }
}
