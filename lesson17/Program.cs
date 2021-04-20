using System;

namespace lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //const int a1 = 2;
            //switch (a)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine(1);

            //        break;

            //    default:
            //        break;

            #region Practice1

            //int performanceSalary = 0;
            //string studentComment;

            //Console.WriteLine("请输入唐老师的评级：");
            //studentComment = Console.ReadLine();
            //char teacherGrade = 'A';

            //switch (studentComment)
            //{
            //    case "很兴奋":
            //        teacherGrade = 'A';
            //        performanceSalary = 500;
            //        break;
            //    case "很充实":
            //        teacherGrade = 'B';
            //        performanceSalary = 0;
            //        break;
            //    case "还好吧":
            //        teacherGrade = 'C';
            //        performanceSalary = -300;
            //        break;
            //    case "难理解":
            //        teacherGrade = 'D';
            //        performanceSalary = -500;
            //        break;
            //    case "枯燥乏味":
            //        teacherGrade = 'E';
            //        performanceSalary = -800;
            //        break;
            //    default:
            //        break;
            //}
            //int finalSalary = 4000 + performanceSalary;
            //Console.WriteLine(finalSalary);

            #endregion
            #region Practice2

            //int coffeePrice = 0;
            //int moneyWeHave = 10;
            //Console.WriteLine("请输入选择的咖啡型号：");
            //char coffeeType = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //switch (coffeeType)
            //{
            //    case '1':
            //        coffeePrice = 5;
            //        break;
            //    case '2':
            //        coffeePrice = 7;
            //        break;
            //    case '3':
            //        coffeePrice = 11;
            //        break;
            //    default:
            //        Console.WriteLine("请输入1/2/3中的任意数字！");
            //        break;
            //}
            //if(coffeePrice != 0) 
            //{ 
            //    if (moneyWeHave >= coffeePrice)
            //    {
            //        int moneyLeft = moneyWeHave - coffeePrice;
            //        Console.WriteLine("购买成功，还剩{0}元。", moneyLeft);
            //    }
            //    else Console.WriteLine("钱不够，请换其他型号！");
            //}

            #endregion
            #region Practice3

            //Console.WriteLine("请输入学生的考试成绩：");
            //int studentScore = int.Parse(Console.ReadLine());
            //char studentGrade = 'A';

            //switch (studentScore)
            //{
            //    case 100:
            //    case 99:
            //    case 98:
            //    case 97:
            //    case 96:
            //    case 95:
            //    case 94:
            //    case 93:
            //    case 92:
            //    case 91:
            //    case 90:
            //        studentGrade = 'A';
            //        break;
            //}

            //Console.WriteLine("学生的考试等级为：{0}",studentGrade);

            #endregion

            #region Practice4

            Console.WriteLine("请输入一个0~9之间的数字：");
            char num = Console.ReadKey().KeyChar;
            Console.WriteLine();
            string outputNum = "null";

            switch (num)
            {
                case '0':
                    outputNum = "零";
                    break;
                case '1':
                    outputNum = "一";
                    break;
                case '2':
                    outputNum = "二";
                    break;
                case '3':
                    outputNum = "三";
                    break;
                case '4':
                    outputNum = "四";
                    break;
                case '5':
                    outputNum = "五";
                    break;
                case '6':
                    outputNum = "六";
                    break;
                case '7':
                    outputNum = "七";
                    break;
                case '8':
                    outputNum = "八";
                    break;
                case '9':
                    outputNum = "九";
                    break;
                default:
                    Console.WriteLine("请输入正确的数字！");
                    break;
            }
            Console.WriteLine(outputNum);

            #endregion

        }
    }
    
}
