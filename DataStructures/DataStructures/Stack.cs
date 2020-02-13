using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack<T>
    {
        T[] arr;
        int pointer;

        public Stack()
        {
            arr = new T[1];
            pointer = 0;
        }

        public void Push(T t)
        {
            arr[pointer] = t;
            arr = arr.Concat(new T[1]).ToArray();
            pointer++;
        }

        public T Pop()
        {
            if (arr.Count() >= 1)
            {
                pointer--;
                T value = arr[pointer];
                arr = arr.Take(pointer).Concat(new T[1]).ToArray();
                return value;
            }
            else { return default(T); }
        }

        public T Peek()
        {
            if (arr.Count() >= 1)
            {
                T value = arr[pointer-1];
                return value;
            }
            else { return default(T); }
        }

        public void Print_Stack()
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
