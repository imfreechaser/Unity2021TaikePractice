using System;

namespace lesson20
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1

            //for(int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Practice2

            //int sum = 0;
            //for(int i = 2; i <= 100; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            #endregion
            #region Practice3
            //int hundred, ten, one;
            //for (int i = 100; i <= 999; i++)
            //{
            //    hundred = i / 100;
            //    ten = i % 100 / 10;
            //    one = i % 10;
            //    if (i == hundred * hundred * hundred + ten * ten * ten + one * one * one)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            #region Practice4
            //方法一
            //int i = 1;
            //for (int j = 1; j <= 9; i++)
            //{
            //    Console.Write("{0}X{1}={2}\t", i, j, i * j);
            //    if (i == j)
            //    {
            //        Console.WriteLine();
            //        i = 0;
            //        j++;
            //    }
            //}
            ////1 1 
            ////1 2  2 2
            ////1 3  2 3  3 3
            ////1 4  2 4  3 4  4 4
            //方法二
            //for(int i = 1; i <=9; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}X{1}={2}\t",j,i,j*i);
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Practice5

            //for(int i = 1; i <= 10; i++)
            //{
            //    if(i == 1 || i == 10)
            //    {
            //        Console.WriteLine("**********\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*        *\n");
            //    }
            //}

            #endregion
            #region Practice6

            //for (int i = 1; i <= 10; i++)
            //{
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine();
            //}


            #endregion
            #region Practice7

            for (int j = 20, n = 1; j >= 11; j--)
            {
                for (int i = j; i >= 1; i--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= n; k++)
                {
                    Console.Write("*");
                }
                n += 2;
                Console.WriteLine();
                Console.WriteLine();

            }

            //20个空格*
            //19个空格***
            //18个空格*****
            //17个空格*******
            //...
            //1个空格*******************
            #endregion
        }
    }
}
