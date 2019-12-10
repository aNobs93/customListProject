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
        private int count;

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
            
            count++;                    
        }

        public bool Remove(T item)
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

        public void ResizeArray()
        {
            T[] temp = new T[capacity *= 2];
            for (int i = 0; i < count; i++)
            {
                temp[i] = Items[i];
            }
            Items = temp;
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

        public CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            if(list1.Count > list2.Count)
            {
                for(int i = 0; i < list1.Count; i++)
                {
                    if(i < list2.Count)
                    {
                    newList.Add(list2[i]);
                    }
                    newList.Add(list1[i]);
                    
                }

            }else if(list1.Count < list2.Count)
            {
                for(int i = 0; i < list2.Count; i++)
                {
                    if (i < list1.Count)
                    {
                        newList.Add(list1[i]);
                    }
                    newList.Add(list2[i]);
                }

            }
            else
            {
            for (int i = 0, j = 0; i < list1.Count && j < list2.Count; i++, j++)
            {
                newList.Add(list1[i]);
                newList.Add(list2[j]);

            }
            }

            return newList;
        }   
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Items[i];
            }
        }

        public void RemoveRange(int r1, int r2)
        {
            int i;
            int j;
            for(i = 0, j = r1; i < r2; i++)
            {
                Remove(Items[j]);
            }
            //return newList;
        }

        public void RemoveAt(int r1)
        {
            Remove(Items[r1]);
        }

        public void RemoveAll(T item)
        {
            //int tempCount = count;
            
            for(int i = 0; i < Count; i++)
            {
                if (Equals(Items[i], item))
                {
                    Remove(Items[i]);
                    i--;
                }
                else
                {
                    
                }
            }
         

        }

        public void Reverse()
        {
            int i;
            int j;
            T[] temp = new T[capacity];
            for(i = count -1, j = 0; i >= 0; i--, j++)
            {
                temp[j] = Items[i];
            }
            Items = temp;
        }

    }
}
