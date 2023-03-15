using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class StaticPolymorphism
    {
        public void Mult(int a, int b)
        {
            Console.WriteLine("The multiplication of two number is " + a*b);
        }
    
        public void Mult(int a,float b,int c)
        {
            Console.WriteLine("The multiplication of three number is " + a*b*c);
        }
   
        public void Mult(float a,float b)
        {
            Console.WriteLine("The multiplication of two number is " + a*b);
        }
    }
}
