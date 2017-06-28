using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int[] MyArray = new int[] { 3, 12, 7, 9 ,2, 99,15,1,2,3,4,5 };


                fixed (int* pMyArray = &MyArray[0])
                {
                    Console.WriteLine(
                        (*(pMyArray+5)));
                    Console.ReadLine();
                }

            }


        }
    }
}
