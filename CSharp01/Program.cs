using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习题2
            Console.WriteLine("请输入用户名：");
            string Name = Console.ReadLine();
            Console.WriteLine($"您的用户名为：{Name}\n");

            Console.WriteLine("请输入年龄：");
            string Age = Console.ReadLine();
            Console.WriteLine($"您的年龄为：{Age}\n");

            Console.WriteLine("请输入班级：");
            string Class = Console.ReadLine();
            Console.WriteLine($"您的班级为：{Class}\n");

            Console.WriteLine("输入完毕!");
            //

            //练习题3
            Console.WriteLine("请问您喜欢什么运动？");
            string Sport = Console.ReadLine();
            Console.WriteLine("哈哈，好巧，我也喜欢{0}。", Sport);
            //

            #region 边界检测
            Console.Write();
            Console.Write();

            Console.Write();

            Console.Write();
            Console.Write();
            Console.Write();


            #endregion

        }
    }
}
