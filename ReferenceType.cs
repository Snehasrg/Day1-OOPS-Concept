﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ReferenceType
    {
        public static void TestReferenceType()
        {
            Student student = new Student();
            student.Id= 1;
            student.Name= "Rahul";
            Console.WriteLine("Before modify method: " + student.Id + "" + student.Name);
            ChangeReferenceType(student);
            Console.WriteLine("After modify method: " + student.Id + "" + student.Name);

        }
        public static void ChangeReferenceType(Student s)
        {
            s.Id= 11;
            s.Name = "Raj";
            Console.WriteLine("Within method: "+s.Id+ "" +s.Name);
        }
    }
}
