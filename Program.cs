namespace OopsConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //StaticPolymorphism obj= new StaticPolymorphism();
            //obj.Mult(4,5);
            //obj.Mult(6,7.5f,7);
            //obj.Mult(3.3f, 6.6f);

            Car obj2 = new Car();
            obj2.CarSound();
            obj2 = new Hyundai();
            obj2.CarSound();
            obj2= new BMW();
            obj2.CarSound();

        }
    }
}