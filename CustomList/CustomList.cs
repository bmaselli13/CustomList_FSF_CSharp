using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int count;
        private int capacity;
        private int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        // Indexer returns or sets the corresponding item from the internal array 
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }


        //Member Methods (CAN DO)
        public void Add(T item)
        {
            if (count >= capacity)
            {
                capacity += 4;
                T[] newArray = new T[capacity];

                
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;
                items[count] = item;
                count++;
            }
            else
            {
                items[count] = item;
                count++;
            }
        }


        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    count--;
                    ShiftMyArray(i);
                    return true;
                }
            }
            return false;
        }


        private void ShiftMyArray(int currentIndex)
        {
            for (int i = currentIndex; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            items[count + 1] = default(T);
        }


        public override string ToString()
        {
            string resultString = "";
            if (count != 0)
                for (int i = 0; i < count; i++)
                    resultString = ConvertValuesToString();

            return resultString;
        }


        private string ConvertValuesToString()
        {
            string myString = "";
            for (int i = 0; i < count; i++)
            {
                myString += items[i];
            }
            return myString;


        }



        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
