using System;
using System.Collections.Generic;
using System.Linq;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            Console.Write("Enter numbers: ");
            string numss = Console.ReadLine();
            List<int> num = new List<int>();
            List<string> nums = numss.Split(" ").ToList();
            for (var j = 0; j < nums.Count; j++)
            {
                num.Add(int.Parse(nums[j]));
            }
            do
            {
                i = 0;
                do
                {
                    i++;
                    if (num[i] == num[i+1])
                    {
                        num[i] = num[i] + num[i + 1];
                        num.RemoveAt(i + 1);
                    }
                    Console.WriteLine(num.Count);
                }while (num[i] != num[i + 1]);
            } while (i != num.Count);
           
            Console.Write(string.Join(" ", num));
        }
    }
}
