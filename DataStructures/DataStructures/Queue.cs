using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queue<T>
    {
        T[] arr;
        int pointer;


        public Queue()
        {
            arr = new T[1];
            pointer = 0;
        }

        public void Enqueue(T t)
        {
            arr[pointer] = t;
            arr = arr.Concat(new T[1]).ToArray();
            pointer++;
        }
        public T Dequeue()
        {
            if (arr.Count() >= 1)
            {
                T value = arr.First();
                arr = arr.Skip(1).ToArray();
                pointer--;
                return value;
            }
            else { return default(T); }
        }
        public void Print_Queue()
        {
            string members_as_string = "{";
            foreach (T t in arr)
            {
                members_as_string += String.Format(" {0} ", t);
            }
            Console.WriteLine(members_as_string + '}');
        }
    }
}
