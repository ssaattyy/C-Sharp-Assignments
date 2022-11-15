using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1csharp
{
    internal class csharpQ3
    {
        public static void Main()
        {
            try
            {
                int[] num = new int[5];
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());
                }
                int addition = csharpQ3.Sumof(num);
                Console.WriteLine("The sum of all the Integer Elements in the array={0}", addition);
            }
            catch (Exception Error)
            {
                Console.WriteLine("It is final");
            }
            Console.ReadLine();
        }
        public static int Sumof(params int[] num)
        {
            int add = 0;
            for (int i = 0; i < num.Length; i++)
            {
                add = add + num[i];
            }
            return add;
        }
    }
}
