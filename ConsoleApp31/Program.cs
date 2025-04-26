namespace ConsoleApp31
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("n ve s deyerlerini daxil edin (arada bosluq qoy):");
            string[] input = Console.ReadLine().Split();
            int n = Convert.ToInt32(input[0]); // məsələn: 2
            int s = Convert.ToInt32(input[1]); // məsələn: 5

            int start = (int)Math.Pow(10, n - 1);
            int end = (int)Math.Pow(10, n) - 1;

            // Əgər n = 1 isə, 0-dan başlayaq
            if (n == 1)
                start = 0;

            for (int i = start; i <= end; i++)
            {
                int sum = 0;
                int temp = i;

                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                if (sum == s)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
