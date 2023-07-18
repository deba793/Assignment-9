using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name, email, password;
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                email = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                password = Console.ReadLine();

                if (name.Length < 6)
                {
                    throw new ValidationException("Name should have minimum 6 characters");
                }
                else if (password.Length < 8)
                {
                    throw new ValidationException("Password length should be of more than 8");
                }
                else
                {
                    Console.WriteLine("User Registration Success");
                    Console.WriteLine($"Name: {name} \nEmail: {email} \nPassword: {password}");
                }
            }
            catch (ValidationException ve)
            {
                Console.WriteLine("Validation Exception!! " + ve.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("**End of Registration**");
                Console.ReadKey();
            }
        }
    }
}