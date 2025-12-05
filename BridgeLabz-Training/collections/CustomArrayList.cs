using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections
{

    internal class MyArrayList<T> 
    { 
        public T[] arr = new T[5];     

        public int count = 0;

        public void Add(T item)
        {
            EnsureCapacityInArray();    

            arr[count] = item;
            count++;
        }

        public void Insert(int index, T item)
        {
            EnsureCapacityInArray();

            for(int i = index; i < count; i++)
            {
                arr[i] = arr[i - 1];
            }

            arr[index - 1] = item;

            count++;
        }

        public void RemoveAt(int index)
        {
            for(int i = index - 1; i < count; i++)
            {
                arr[i] = arr[i + 1];
            }

            count--;
        }

        public T Get(int index)
        {
            return arr[index - 1];
        }

        public void Display()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void EnsureCapacityInArray()
        {
            if (count < arr.Length)
            {
                return;
            }
            else
            {
                int newSize = arr.Length * 2;
                T[] tempArr = new T[newSize];
                Array.Copy(arr, tempArr, arr.Length);

                arr = tempArr;
            }
        }


    }

    internal class CustomArrayList
    {

        static void Main(string[] args)
        {
           
            MyArrayList<int> ArrayList1 = new MyArrayList<int>();

            ArrayList1.Add(1);
            ArrayList1.Add(2);
            ArrayList1.Add(3);
            ArrayList1.Add(4);
            ArrayList1.Add(5);
            ArrayList1.Add(6);
            ArrayList1.Add(7);
        
            ArrayList1.RemoveAt(3);
            ArrayList1.RemoveAt(6);

            ArrayList1.Get(1);

            ArrayList1.Display();
            
        }
    }
}
