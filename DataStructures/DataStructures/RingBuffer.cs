using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class RingBuffer<T>
    {
        T[] arr;
        int read_pointer = 0;
        int write_pointer = 0;
        public RingBuffer(int size)
        {
            arr = new T[size];
        }

        public T Read()
        {
            if (read_pointer + 1 <= write_pointer)
            {
                
                T rv = arr[read_pointer % arr.Length];
                read_pointer++;
                return rv;
            }
            else 
            {
                Console.WriteLine("Cannot read past write pointer.");
                return default(T);
            }
            
        }
        public void Write(T t)
        {
            if (write_pointer >= read_pointer && write_pointer <= read_pointer + arr.Length - 1)
            {
                arr[write_pointer % arr.Length] = t;
                write_pointer++;
            }
            else
            {
                Console.WriteLine("Cannot write past read pointer.");
            }
        }


    }
}
