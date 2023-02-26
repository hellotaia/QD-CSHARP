using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] myArr = new int[8, 8];
            
            int x = 0;
            int count = 0;
            int max = myArr[0, 0];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // заповнення масива рандомними числами- треба винести із цикла - куди?
                    myArr[i, j] = random.Next(-50, 51);
                    if (myArr[i, j] % 2 != 0 && myArr[i, j] > 0)
                    {
                        Console.Write("{0}\t", myArr[i, j]);
                        x++;
                        count++;
                        if (x > 4)
                        {
                            Console.WriteLine();
                            x = 0;
                        }
                        if (myArr[i, j] > max)
                        {
                            max = myArr[i, j];
                        }
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("total filtered elements:  {0}", count);
            Console.WriteLine("max value is:  {0}", max);
        }
    }
}