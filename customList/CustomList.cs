using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{ 
    public class CustomList<T>
    {
        T[] items;
        int capacity;
        int count;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];

        }


    }
}
