using System;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Practice3
/*
            ushort Grade1, Grade2, Grade3;
            try
            {
                Console.WriteLine("请输入语文成绩：");
                Grade1 = ushort.Parse(Console.ReadLine());

                Console.WriteLine("请输入数学成绩：");
                Grade2 = ushort.Parse(Console.ReadLine());

                Console.WriteLine("请输入英语成绩：");
                Grade3 = ushort.Parse(Console.ReadLine());

                Console.WriteLine("三门成绩的总分是：{0}", Grade1 + Grade2 + Grade3);
                Console.WriteLine("三门成绩的平均分是：" + (Grade1 + Grade2 + Grade3) / 3);
            }
            catch
            {
                Console.WriteLine("请输入正确的格式！");
            }*/

            #endregion

            #region Practice4

            int TshirtPrice = 285;
            int pantsPrice = 720;

            Console.WriteLine($"小明一共需要付：{TshirtPrice + pantsPrice}元");
            Console.WriteLine($"打3.8折后，小明一共需要付：{(TshirtPrice + pantsPrice) * 0.38f}元");


            #endregion

            #region Practice5

            int a = 10, b = 20;
            int number1 = ++a + b;//31

            a = 10;
            b = 20;
            int number2 = a + b++;//30

            a = 10; 
            b = 20;
            int number3 = a++ + ++b + a++;//42

            Console.WriteLine("a:{0}, b:{1}, c:{2}", number1, number2, number3);

            #endregion

            #region Practice6

            int a1 = 99, b1 = 87;
            //方法1
            int c = a1;
            a1 = b1;
            b1 = c;
            Console.WriteLine("a:{0}, b:{1}", a1, b1);
            //方法2
            a1 = 99; b1 = 87;
            a1 = 87;
            b1 = 99;
            Console.WriteLine("a:{0}, b:{1}", a1, b1);
            //方法3
            a1 = 99; b1 = 87;
            a1 -= 12;
            b1 += 12;
            Console.WriteLine("a:{0}, b:{1}", a1, b1);
            //方法4
            a1 = 99; b1 = 87;
            a1 = a1 + b1;
            b1 = a1 - b1;
            a1 = a1 - b1;
            Console.WriteLine("a:{0}, b:{1}", a1, b1);

            #endregion

            #region Practice7

            int second, minute, hour, day;
            day = 987652 / (24 * 60 * 60);
            hour = 987652 % (24 * 60 * 60) / 3600;
            minute = 987652 % (24 * 60 * 60) % 3600 / 60;
            second = 987652 % (24 * 60 * 60) % 3600 % 60;

            Console.WriteLine($"987652为{day}天{hour}小时{minute}分钟{second}秒");

            #endregion
        }
    }
}
