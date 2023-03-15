using System.Diagnostics.Tracing;

namespace OopsConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
          //Created object for Class and object Problem                  
            //ObjectandClass obj= new ObjectandClass();
            //Console.WriteLine(obj.Name);
            //Console.WriteLine(obj.Colour);

         // Created object for inheritance
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}