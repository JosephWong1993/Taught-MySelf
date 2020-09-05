using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnsafeCode
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            Console.WriteLine("***** Calling method with unsafe code *****");

            //以备交换的值
            int i = 10, j = 20;

            //  安全交换两个值
            Console.WriteLine("***** Safe Swap *****");
            Console.WriteLine("Values before safe swap: i = {0},j = {1}", i, j);
            SafeSwap(ref i, ref j);
            Console.WriteLine("Values after safe swap: i = {0},j = {1}", i, j);

            //  不安全交换两个值
            Console.WriteLine("***** Unsafe Swap *****");
            Console.WriteLine("Values before unsafe swap: i = {0},j = {1}", i, j);
            unsafe { UnsafeSwap(&i, &j); }
            Console.WriteLine("Values after unsafe swap: i = {0},j = {1}", i, j);
            Console.WriteLine();

            PrintValueAndAddress();
            Console.WriteLine();

            UsePointerToPoint();
            Console.WriteLine();

            UseSizeOfOperator();
            Console.ReadLine();
        }

        unsafe static void SquareIntPointer(int* myIntPointer)
        {
            //  将这个值平方后以供测试
            *myIntPointer *= *myIntPointer;
        }

        unsafe static void PrintValueAndAddress()
        {
            int myInt;

            //  定义一个整数指针并将myInt的地址分配给它
            int* ptrToMyInt = &myInt;

            //  使用指针间寻址为myInt赋值
            *ptrToMyInt = 123;

            //  输出一些状态
            Console.WriteLine("Value of myInt {0}", myInt);
            Console.WriteLine("Address of myInt {0:X}", (int)ptrToMyInt);
        }

        unsafe public static void UnsafeSwap(int* i, int* j)
        {
            int temp = *i;
            *i = *j;
            *j = temp;
        }

        public static void SafeSwap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }

        unsafe static void UsePointerToPoint()
        {
            //  通过指针访问成员
            Point point;
            Point* p = &point;
            p->x = 100;
            p->y = 200;
            Console.WriteLine(p->ToString());

            //  通过指针间接寻址访问成员
            Point point2;
            Point* p2 = &point2;
            (*p2).x = 100;
            (*p2).y = 200;
            Console.WriteLine();
        }

        unsafe static void UnSafeStackAlloc()
        {
            char* p = stackalloc char[256];
            for (int k = 0; k < 256; k++)
            {
                p[k] = (char)k;
            }
        }

        unsafe public static void UseAndPinPoint()
        {
            PointRef pt = new PointRef();
            pt.x = 5;
            pt.y = 6;

            //  在适当位置固定pt以免GC除去
            fixed (int* p = &pt.x)
            {
                //  在此使用int*变量
            }

            //  pt现未被固定,在该方法完成后可被GC清除
            Console.WriteLine("Point is: {0}", pt);
        }

        unsafe static void UseSizeOfOperator()
        {
            Console.WriteLine("The size of short is {0}.", sizeof(short));
            Console.WriteLine("The size of int is {0}.", sizeof(int));
            Console.WriteLine("The size of long is {0}.", sizeof(long));
            Console.WriteLine("The size of Point is {0}.", sizeof(Point));
        }
    }
}
