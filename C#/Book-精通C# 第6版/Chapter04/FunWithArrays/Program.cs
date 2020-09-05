using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Arrays *****");

            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFunctionality();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation");

            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            string[] stringArray = new String[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            bool[] boolArray = { false, true, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);

            Console.WriteLine();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a:{0}", a.ToString());

            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a:{0}", b.ToString());

            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a:{0}", c.ToString());

            Console.WriteLine();
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
            {
                Console.WriteLine("Type:{0},Value:{1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");

            int[,] myMatrix;
            myMatrix = new int[6, 6];

            //填充6*6数组
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            //输出6*6数组
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            //交错多维数组
            int[][] myJagArray = new int[5][];

            //创建交错多维数组
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }

            //输出每一行.
            for (int i = 0; i < myJagArray.Length; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "form", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values");

            //传递数组作为参数
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            //获取数组作为返回值
            string[] strs = GetStringArray();
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            //初始化输出项
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            //按声明的次序输出名字
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ",");
            }
            Console.WriteLine("\n");

            //反转他们
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            //输出他们
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ",");
            }
            Console.WriteLine("\n");

            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            Console.WriteLine("-> The reversed array");
            //输出他们
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ",");
            }
            Console.WriteLine("\n");
        }
    }
}
