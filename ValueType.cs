using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ValueType
    {
        public static void TestValueType() 
        {
            int i = 100;
            Console.WriteLine("Before modifying value of x:" +i);
            ChangevalueType(i);
            Console.WriteLine("After modifying modifying value of x:" + i);


        }
        public static void ChangevalueType(int x)
        {
            x = x + 10;
            Console.WriteLine("Within method x value is" +x);
        }
    }
}
