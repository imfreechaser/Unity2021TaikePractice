using System;

namespace lesson18
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pratice1

            //int i = 1;
            //while(i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion
            #region Practice2

            //int i = 0;
            //int summary = 0;

            //while(i < 100)
            //{
            //    i++;
            //    summary += i;
            //}
            //Console.WriteLine(summary);

            #endregion
            #region Practice3

            //int i = 0;
            //int sum = 0;

            //while(i < 100)
            //{
            //    i++;
            //    if (i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            #endregion
            #region Practice4
            //方法一
            //try
            //{
            //    Console.WriteLine("请输入一个数：");
            //    int inputNum = int.Parse(Console.ReadLine());
            //    int i = 1;
            //    int j = 0;
            //    while (i < inputNum / 2)
            //    {
            //        i++;
            //        if (inputNum % i == 0)
            //        {
            //            Console.WriteLine("您输入的不是素数！");
            //            break;
            //        }
            //        else
            //        {
            //            j++;
            //        }
            //    }
            //    if (j == inputNum / 2 - 1)
            //    {
            //        Console.WriteLine("您输入的是素数！");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确格式的数字！");
            //}

            //方法二
            //try
            //{
            //    Console.WriteLine("请输入一个数：");
            //    int inputNum = int.Parse(Console.ReadLine());
            //    int i = 1;

            //    while (i < inputNum / 2)
            //    {
            //        i++;
            //        if (inputNum % i == 0)
            //        {
            //            break;
            //        }
            //    }
            //    if (i != inputNum / 2)
            //    {
            //        Console.WriteLine("您输入的不是素数！");
            //    }
            //    else
            //        Console.WriteLine("您输入的是素数！");
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确格式的数字！");
            //}
            #endregion
            #region Practice5

            //while(true) 
            //{
            //    string userName, password;

            //    Console.WriteLine("请输入用户名：");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    password = Console.ReadLine();

            //    if (userName == "admin" && password == "8888")
            //    {
            //        Console.WriteLine("登录成功~~！");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("用户名或密码不正确");
            //    }
            //}

            #endregion
            #region Practice6

            //int studentAmount = 1;
            //int studentIndex = 1;
            //int scoreAccumulation = 0;

            //Console.WriteLine("请输入班级人数");
            //studentAmount = int.Parse(Console.ReadLine());
            //while (studentIndex <= studentAmount)
            //{
            //    Console.WriteLine("请输入第{0}位学生的成绩：", studentIndex);
            //    scoreAccumulation += int.Parse(Console.ReadLine());
            //    studentIndex++;
            //}

            //float averageScore = (float)scoreAccumulation / studentAmount;
            //Console.WriteLine("班级总成绩为：{0}", scoreAccumulation);
            //Console.WriteLine("班级平均成绩为：{0}", averageScore);

            #endregion
            #region Practice7

            //int sum = 0;
            //int i = 0;

            //while(i < 100)
            //{
            //    i++;
            //    sum += i;
            //    if (sum > 500)
            //        break;
            //}
            //Console.WriteLine(i);
            //Console.WriteLine(sum);

            #endregion
            #region Practice8

            //int mouthCount = 0;
            //int studentCount = 100;
            //while (true)
            //{
            //    studentCount = (int)(studentCount * 1.2);
            //    mouthCount++;
            //    if (studentCount > 1000)
            //        break;
            //}
            //Console.WriteLine(mouthCount);

            #endregion
            #region Practice9

            //int i = 1;
            //int j = 0;
            //int k = 0;

            //while(i < 20)
            //{
            //    i++;      //2 3
            //    j += 1;   //1 2 3 4
            //    k = k + j;//1 3 6 10
            //}

            #endregion
            #region Practice10
            //int num = 2;
            //int i = 1;
            //while(num <= 100)
            //{
            //    i = 1;
            //    while(i < num)
            //    {
            //       i++;
            //       if (num % i == 0)
            //            break;
            //    }
            //    if(i == num)
            //    {   
            //        Console.WriteLine(num);
            //    }
            //    num++;
            //}
            #endregion
        }
    }
}
