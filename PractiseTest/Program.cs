using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTest
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             Array.Sort(A);

            int count = 1;

            if (A[0] < 0)
            {
                return 1;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != count)
                {
                    count++;
                }
                if (A[i] > count)
                {
                    return count;
                }
            }
            
            return count +1 ;
             */
            int[] A = new int[] { 1, 2, 3 };

            Array.Sort(A);

            int count = 1;

            if (A[0] < 0)
            {
                //return A[0];
                Console.WriteLine(A[0]);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != count)
                {
                    count++;
                }
                if (A[i] > count)
                {
                        Console.WriteLine(count);
                }
            }


            Console.WriteLine(++count);
        }
    }
}
