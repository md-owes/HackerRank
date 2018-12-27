using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            //int t = Convert.ToInt32(Console.ReadLine());

            //string[] nk = Console.ReadLine().Split(' ');

            //int n = Convert.ToInt32(nk[0]);

            //int k = Convert.ToInt32(nk[1]);

            //int[] v = Array.ConvertAll(Console.ReadLine().Split(' '), vTemp => Convert.ToInt32(vTemp));
            int n = Convert.ToInt32(Console.ReadLine());
            string[] strArr = Console.ReadLine().Split(' ');
            int[] intArr = new int[strArr.Length];
            for (int q = 0; q < strArr.Length; q++)
            {
                if (!int.TryParse(strArr[q], out int res))
                    continue;

                intArr[q] = res;
            }

            //int[] ar = Array.ConvertAll(strArr, arTemp => int.TryParse(arTemp, out result));

            //int result = problemSolving(k, v);
            int result = sockMerchant(n, intArr);

            Console.WriteLine(result);
        }

        static int sockMerchant(int n, int[] ar)
        {
            Array.Sort(ar);
            int[] disArr = ar.Distinct().ToArray();

            int[] newArr = new int[disArr.Length];
            int temp = 0;

            for (int i = 0, j = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] != ar[i + 1])
                {
                    newArr[j] = (i + 1) - temp;
                    temp = i + 1;
                    j++;
                }

                if (i + 1 == ar.Length - 1)
                    newArr[j] = (i + 2) - temp;
            }

            int sum = 0;
            for (int z = 0; z < newArr.Length; z++)
            {
                sum += newArr[z] / 2;
            }

            return sum;
        }
    }
}
