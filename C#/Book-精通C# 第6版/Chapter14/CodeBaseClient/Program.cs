﻿using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBaseClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with CodeBases *****");
            SportsCar c = new SportsCar();
            Console.WriteLine("Sports car has been allocated");
            Console.ReadLine();
        }
    }
}
