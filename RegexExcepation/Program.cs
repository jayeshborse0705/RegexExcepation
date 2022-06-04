using RegexExcepation;

namespace RegexExpection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Validation");
            Validation validation = new Validation();
            //uc1 : first  name
            Console.WriteLine("Enter the First Name : ");
             var first_Name = Console.ReadLine();
            validation.First_Name(first_Name);
        }
    }
}