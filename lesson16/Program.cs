using System;

namespace lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1

            //Console.WriteLine("请输入今天看唐老师视频花了多少分钟：");
            //int time = int.Parse(Console.ReadLine());
            ////方法一
            //if (time > 60)
            //{
            //    Console.WriteLine("今天看视频花了{0}分钟，看来你离成功又进了一步！",time);
            //}
            ////方法二
            //Console.WriteLine(time > 60? $"今天看视频花了{time}分钟，看来你离成功又进了一步！":"");

            #endregion
            #region Practice2

            //int chineseGrade, mathGrade, englishGrade;

            //Console.WriteLine("请输入你的语文成绩：");
            //chineseGrade = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入你的数学成绩：");
            //mathGrade = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入你的英语成绩：");
            //englishGrade = int.Parse(Console.ReadLine());

            //bool firstCondition = chineseGrade > 70 && mathGrade > 80 && englishGrade > 90;
            //bool secondCondition = chineseGrade == 100 || mathGrade == 100 || englishGrade == 100;
            //bool thirdCondition = chineseGrade > 90 && (mathGrade > 70 || englishGrade > 70);

            //if (firstCondition || secondCondition || thirdCondition)
            //{
            //    Console.WriteLine("非常棒，请继续加油！");
            //}

            #endregion
            #region Practice3

            //int paperGrade;
            //Console.WriteLine("请输入小赵的考试成绩：");
            //paperGrade = int.Parse(Console.ReadLine());
            //方法1
            //if (paperGrade >= 90)
            //{
            //    Console.WriteLine("爸爸奖励小赵一百块钱！");
            //}
            //else
            //{
            //    Console.WriteLine("小赵一个月不能玩游戏！");

            //}
            //方法2
            //Console.WriteLine(paperGrade >= 90 ? "爸爸奖励小赵一百块钱！" : "小赵一个月不能玩游戏！");

            #endregion
            #region Practice4

            //Console.WriteLine("请输入a的值：");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入b的值：");
            //int b = int.Parse(Console.ReadLine());

            //if(a % b == 0 || b % a == 0 || a + b > 100)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}

            #endregion
            #region Practice5

            //Console.WriteLine("请输入一个数字：");
            //int inputNum = int.Parse(Console.ReadLine());
            //if(inputNum % 2 == 0)
            //{
            //    Console.WriteLine("Your input is even");
            //}
            //else
            //{
            //    Console.WriteLine("Your input is odd");
            //}

            #endregion
            #region Practice6

            int a = 5, b = 90, c = 50;
            if(a >= b)
            {
                if(a >= c)
                {
                    Console.WriteLine(a);
                }
                else Console.WriteLine(c);
            }
            else
            {
                if(b <= c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }

            #endregion
            #region Practice7
            Console.WriteLine("请输入一个字符：");
            char inputChar = Console.ReadKey().KeyChar;
            int transInput = int.Parse(inputChar.ToString());
            if (transInput >= 0 && transInput <= 9)
            {
                Console.WriteLine("您输入了一个数字{0}", transInput);
            }
            else
            {
                Console.WriteLine("这不是一个数字!{0}", transInput);
            }
            #endregion
            #region Practice8

            //Console.WriteLine("请输入用户名：");
            //string admin = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string password = Console.ReadLine();

            //if(admin == "admin")
            //{
            //    if(password == "8888")
            //    {
            //        Console.WriteLine("成功登陆！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误！");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("用户名不存在！");
            //}

            #endregion
            #region Practice9

            //Console.WriteLine("请输入您的年龄：");
            //int userAge = int.Parse(Console.ReadLine());

            //if (userAge >= 18)
            //{
            //    Console.WriteLine("可以查看");
            //}
            //else if (userAge < 13)
            //{
            //    Console.WriteLine("不可以查看");
            //}
            //else if (userAge >= 13 && userAge < 18)
            //{
            //    Console.WriteLine("是否继续查看？");
            //    string reply = Console.ReadLine();
            //    if(reply == "yes")
            //    {
            //        Console.WriteLine("请查看");
            //    }
            //    else if(reply == "no") 
            //    {
            //        Console.WriteLine("退出");

            //    }
            //}

            #endregion
        }
    }
}
