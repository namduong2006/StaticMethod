﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.Change();
            Student s1 = new Student(111, "Hoang");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");
            s1.Display();
            s2.Display();
            s3.Display();           
            Console.ReadLine();
        }
    }
}
