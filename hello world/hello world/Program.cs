﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你好世界");
            var obj = Console.ReadLine();
            Console.WriteLine(obj.GetType().ToString());
            var obj = Console.ReadLine();
        }
    }
}
