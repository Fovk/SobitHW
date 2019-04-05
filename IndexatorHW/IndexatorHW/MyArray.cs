using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace IndexatorHW
{
    public class MyArray
    {
        public int[] array;

        public MyArray(int size)
        {
            array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set { array[index] = Convert.ToInt32(Math.Pow(array[index], 2)); }
        }
        public void Print()
        {
            Console.WriteLine("Array:");
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
