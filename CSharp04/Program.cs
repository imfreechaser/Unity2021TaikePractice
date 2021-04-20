using System;

namespace CSharp04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(short.Parse("30000"));

            float f = 123.56f;
            //int i = (int)f;
            int i = Convert.ToInt32(f);
            Console.WriteLine(i);
            Console.WriteLine(1.ToString());
            Console.WriteLine(24069.ToString());
            Console.WriteLine(Convert.ToString(24069));
            */
            #region 练习题3

            Console.WriteLine("请输入语文成绩：");
            string chineseScore = Console.ReadLine();
            int ics = Convert.ToByte(chineseScore);
            Console.WriteLine(ics);

            Console.WriteLine("请输入数学成绩：");
            string mathScore = Console.ReadLine();
            int ims = Convert.ToByte(mathScore);
            Console.WriteLine(ims);

            Console.WriteLine("请输入英语成绩：");
            string englishScore = Console.ReadLine();
            int ies = Convert.ToByte(englishScore);
            Console.WriteLine(ies);

            #endregion




        }
    }
}
