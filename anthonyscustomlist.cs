using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;
        private int count;

        private int capacity;


        // constructor (SPAWNER)
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }
        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                items[index] = value;
            }
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
        // member methods (CAN DO)
        public void Add(T itemToAdd)
        {
            if(count == capacity)
            {
                //Increase capacty times 2


                //Instantiate new array with size of the new capactiy, call it tempArray


                //Make sure items from original array come over into new array!
                  



            }
            items[count] = itemToAdd;
            count++;
        }

        public void Remove(T itemToRemove)
        {

            items[count] = itemToRemove;
            count--;
        
        }
    }
}
