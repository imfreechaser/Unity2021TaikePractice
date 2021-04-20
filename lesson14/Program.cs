using System;

namespace lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;//001
            int b = 5;//101
            int c = a & b;
            //  001
            //& 101
            //  001
            Console.WriteLine(c);

            a = 3;//00011
            b = 19;//1 2 0 0 16 -->10011
            c = a & b;
            //  00011
            //& 10011
            //  00011
            Console.WriteLine(c);

            a = 35;//1 2 4 8 16 32-->100011
            b = 4;
            c = a << b;//1000110000-->560
            Console.WriteLine(c);

            a = 66;//64+2-->100010
            b = 1;
            c = a >> 1;//10001-->33
            Console.WriteLine(c);

            a = 99;//64+32+2+1-->110011
            b = 33;//32+1-->10001
            c = a ^ b;
            // 110011
            // 010001
            // 100010
            Console.WriteLine(c);

            a = 76;//64+8+4-->1001100
            b = 85;//64+16+4+1-->1010101
            c = a | b;
            // 1001100
            // 1010101
            // 1011101-->1 4 8 16 64
            Console.WriteLine(c);



        }
    }
}
