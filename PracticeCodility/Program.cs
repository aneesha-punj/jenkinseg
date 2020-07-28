using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodility
{
    class Program
    {
        int MaxEven(int[] A)
        {
            int sum = 0;
            int maxEvenSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]>0)
                {
                    sum = sum + A[i];
                }
                
            }
            if (sum % 2 == 0)
            {
                maxEvenSum = sum;
            }
            for (int i = 0; i < A.Length; ++i)
            {
                if(A[i]%2!=0)
                {
                    if(A[i]>0)
                    {
                        maxEvenSum = (maxEvenSum > (sum - A[i])) ? maxEvenSum : (sum - A[i]);
                    }
                    else
                    {
                        maxEvenSum = (maxEvenSum) > (sum + A[i]) ? maxEvenSum : (sum + A[i]);
                    }
                }
                Console.WriteLine(maxEvenSum);
                Console.ReadLine();
            }
            return maxEvenSum;
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = { -2, 2, -3, 1, 3 };
            p.MaxEven(A);
           
        }
    }
}
