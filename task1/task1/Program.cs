using System.Data;
using System.Security.Cryptography;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
        }
        public static void IncArr(ref int[] arr)
        {
            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i] = arr[i];
            }

            int[] arr2 = { };

            Console.WriteLine("artiracagin ededlerin sayi : ");

            int num = Convert.ToInt32(Console.ReadLine());  

            Array.Resize(ref arr2, num);

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = arr.Length; i < arr2.Length - 1; i++)
            {
                Array.Resize(ref newArr, 1);

                newArr[i] = arr2[i - arr.Length - 1];
            }

            newArr = arr;     
        }
    }
}
