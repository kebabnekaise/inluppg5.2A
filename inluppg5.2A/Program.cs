using System;

namespace inluppg5_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal vill du skriva in?");
            int length = int.Parse(Console.ReadLine());
            int[] nums = new int[length];

            Console.WriteLine($"Skriv in {3} heltal");
            for (int i = 0; i < length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Här är talen du skrev in");
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"Tal {j + 1}: {nums[j]}");
            }
        }
    }
}