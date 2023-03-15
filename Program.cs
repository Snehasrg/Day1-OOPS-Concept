namespace OopsConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Encapsulation encapsulation= new Encapsulation();
            Console.WriteLine("Enter employee name");
            encapsulation.Name = Console.ReadLine();
            encapsulation.SetSalary(100000);
            Console.WriteLine("Salary of "+encapsulation.Name+ " is " +encapsulation.Salary);
        }
    }
}