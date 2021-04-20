using System;

namespace lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1

            int a = 5;
            int b = 6;
            Console.WriteLine(a > b ? a : b);

            #endregion
            #region Practice2

            //Console.WriteLine("请输入您的姓名：");
            //string userName = Console.ReadLine();
            //Console.WriteLine(userName == "帅哥" ?userName:"美女");

            #endregion
            #region Practice3
            
            //Console.WriteLine("请输入您的姓名：");
            //string studentName = Console.ReadLine();
            //Console.WriteLine("请输入您的C#语言成绩：");
            //int cSharpGrade = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入您的Unity成绩：");
            //int unityGrade = int.Parse(Console.ReadLine());

            //string managedGraduated = "恭喜您成功毕业~！";
            //string failedGraduated = "很遗憾您无法毕业。";

            //Console.WriteLine(studentName + "," + (cSharpGrade >= 90 && unityGrade >= 90 ? managedGraduated : failedGraduated));

            #endregion
            #region Practice4

            Console.WriteLine("请输入一个年份：");
            int inputYear = int.Parse(Console.ReadLine());
            string isLeapYear = "这个年份是闰年";
            string isNotLeapYear = "这个年份不是闰年";

            string reply = inputYear % 400 == 0 || inputYear % 4 == 0 && inputYear % 100 != 0 ? isLeapYear : isNotLeapYear;

            Console.WriteLine(reply);
            #endregion
        }
    }
}
