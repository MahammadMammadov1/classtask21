using ConsoleApp14.Extension;
using ConsoleApp14.Models;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            

            try
            {
                Console.WriteLine("Adinizi daxil edin : ");
                person.FullName = Console.ReadLine();
                Console.WriteLine("Yashnizi daxil edin : ");
                person.Age=sbyte.Parse(Console.ReadLine());
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine(ex.Message); 
            }

            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            
                
        }
    }
}