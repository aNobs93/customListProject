using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{ 
    public class CustomList<T>  : IEnumerable
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
            return RemoveFromArrayLoop(item);           
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

        public override string ToString()
        {
            string temp = "";
            for(int i = 0; i < count; i++)
            { if(i == count - 1)
                {
                    temp += Items[i].ToString();
                }
            else
                temp += Items[i].ToString() + " ";
            }
            return temp;
        }

        public static CustomList<T> operator+ (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();
            for(int i = 0; i < list1.count; i++)
            {
                result.Add(list1[i]);
            }
            for(int i = 0; i < list2.count; i++)
            {
                result.Add(list2[i]);
            }
            
            return result;
        }
        private CustomList<T> Copy()
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < count; i++)
            {
                newList.Add(Items[i]);
            }
            return newList;
        }
        public static CustomList<T> operator- (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = list1.Copy();
            for (int i = 0; i < list2.Count; i++)
            {
                newList.Remove(list2[i]);
            }
            return newList;
        }

        public void Zip()
        {

        }

        public bool RemoveFromArrayLoop(T item)
        {
            int tempCount = count;
            int i;
            int j;
            bool keyWord = true;
            T[] temp = new T[capacity];
            for (i = 0, j = 0; i < count && j < count; i++, j++)
            {
                if (Equals(Items[i], item) && (Equals(keyWord, true)))
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Items[i];
            }
        }



    }
}
