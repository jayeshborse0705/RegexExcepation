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

            //uc2 : last name
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Last Name");
            var last_Name = Console.ReadLine();
            validation.Last_Name(last_Name);

            //uc3 : Email
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Email Id");
            var email_Id = Console.ReadLine();
            validation.EmailId(email_Id);

            //uc4 : Mobile Number
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Mobile Number");
            var mobileNum = Console.ReadLine();
            validation.Mobile(mobileNum);

            //uc5 : Password
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password");
            var Password = Console.ReadLine();
            validation.Validate_PassWord(Password);

            //uc6 : Password is  minimum one upper case letter
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one upper case: ");
            var Password2 = Console.ReadLine();
            validation.Validate_PassWord(Password2);

            //uc7 : Password
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one numeric value : ");
            var Password3 = Console.ReadLine();
            validation.Validate_PassWord(Password3);

            //uc8 : Password with exactly one special character
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with exactly one special character : ");
            var Password4 = Console.ReadLine();
            validation.Validate_PassWord(Password4);
        }
    }
}