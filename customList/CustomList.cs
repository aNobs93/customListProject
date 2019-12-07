using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{ 
    public class CustomList<T>
    {
        T[] Items;
        int capacity;
        int count;

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public T this[int i]
        {
            get
            {
                return Items[i];
            }
            set
            {
                Items[i] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            Items = new T[Capacity];
          

        }

        public void Add(T item)
        {
            if(count == capacity)
            {
                ResizeArray();
            }
            
            
           Items[count] = item;
                //put the thing in
            
            count++;
            
            
        }

        public bool Remove(T item)
        {
            int tempCount = count;
            int i;
            int j;
            bool keyWord = true;
            T[] temp = new T[capacity];
            for (i = 0, j = 0; i < count && j < count; i++, j++ )
            {
                if (Equals(Items[i], item) && (Equals(keyWord,true)))
                {
                    j--;
                    tempCount--;
                    keyWord = false;
                }
                else
                {
                    temp[j] = Items[i];
                    
                }

            }
            if (count == 0)
            {
                return false;
            }
            else
            {
                Items = temp;
                count = tempCount;
                return true;
            }
        }

        public void ResizeArray()
        {
            T[] temp = new T[capacity *= 2];
            for (int i = 0; i < count; i++)
            {
                temp[i] = Items[i];
            }
            Items = temp;
            //temp array create
            //move values to temp
            //resize original
            //move values back;

        }

        //public void RemoveItemFromArray(T item)
        //{
        //    T[] temp = new T[capacity];
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (Equals(Items[i], item))
        //        {

        //        }
        //        else
        //        {
        //            temp[i] = Items[i];
        //        }

        //    }
        //    Items = temp;
        //}


    }
}
