using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadOps
{
    class Program
    {
        //  加减两个Point
        //  重载二元操作符时,能产生新的简写赋值操作符
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Overloaded Operstors *****\n");

            //  创建两个点
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Console.WriteLine("ptOne = {0}", ptOne);
            Console.WriteLine("ptTwo = {0}", ptTwo);

            //  将两个点相加得到一个更大的点
            Console.WriteLine("ptOne + ptTwo: {0}", ptOne + ptTwo);

            //  将两个点相减得到一个更小的点
            Console.WriteLine("ptOne - ptTwo: {0}", ptOne - ptTwo);

            Point biggerPoint = ptOne + 10;
            Console.WriteLine("ptOne + 10 = {0}", biggerPoint);

            Console.WriteLine("10 + biggerPoint = {0}", 10 + biggerPoint);

            //  自动改变功能的 +=
            Point ptThree = new Point(90, 5);
            Console.WriteLine("ptThree = {0}", ptThree);
            Console.WriteLine("ptThree += ptTwo: {0}", ptThree += ptTwo);

            //  自动改变功能的 -=
            Point ptFour = new Point(0, 500);
            Console.WriteLine("ptFour = {0}", ptFour);
            Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);

            //  向Point应用++和-- 一元操作符
            Point ptFive = new Point(1, 1);
            Console.WriteLine("++ptFive = {0}", ++ptFive);
            Console.WriteLine("--ptFive = {0}", --ptFive);

            //  使用相同的操作符进行后递增和后递减
            Point ptSix = new Point(20, 20);
            Console.WriteLine("ptSix++ = {0}", ptSix++);
            Console.WriteLine("ptSix-- = {0}", ptSix--);

            Console.WriteLine("ptOne == ptTwo : {0}", ptOne == ptTwo);
            Console.WriteLine("ptOne != ptTwo : {0}", ptOne != ptTwo);

            Console.WriteLine("ptOne<ptTwo : {0}", ptOne < ptTwo);
            Console.WriteLine("ptOne>ptTwo : {0}", ptOne > ptTwo);

            Console.ReadLine();
        }
    }
}
