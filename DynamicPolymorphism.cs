using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Car
    {

        public virtual void CarSound()
        {
            Console.WriteLine("The Car sound tuu tuuu!");
        }
    }

    class Hyundai : Car  // Derived class (child) 
    {
        public override void CarSound()
        {
            Console.WriteLine("The Hyundai Sounds Vrumm Vrumm!");
        }
    }

    class BMW : Car  // Derived class (child) 
    {
        public override void CarSound()
        {
            Console.WriteLine("The BMW Sounds Broom Broom!");
        }
    }
}
