using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-----REGEX-----*");
            User user = new User();
            user.ValidateFirstName("Akshata");
            user.ValidateLastName("Patil");
            user.ValidateEmail("akshatapatil@gmail.com");
            user.ValidatePhoneNumber("1234567452");
            user.ValidatePasswordRule1("123455611");
            user.ValidatePasswordRule2("12345678A");
            Console.ReadKey();
        }
    }
}
