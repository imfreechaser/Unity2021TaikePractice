using System;

namespace lesson19
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1

            //do
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    string password = Console.ReadLine();

            //    if(userName == "admin" && password == "8888")
            //    {
            //        break;  
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误！");
            //    }
            //} while (true);

            #endregion
            #region Practice2

            do
            {
                Console.WriteLine("请输入你的姓名：");
                if(Console.ReadKey().KeyChar == 'q')
                {
                    break;
                }
            } while (true);

            #endregion
        }
    }
}
