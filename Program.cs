using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vaccine registration system.");
            Console.WriteLine("Please wait!");
            Console.WriteLine("Enter your SA ID:");
            string userID = Console.ReadLine();

            if (string.IsNullOrEmpty(userID))
            {
                Console.WriteLine("ID can't be empty! Input your SA ID once more");
                userID = Console.ReadLine();
            }

            Console.WriteLine("Enter your Full Name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your Surname:");
            string userSurname = Console.ReadLine();

            Console.WriteLine("Enter your Provice:");
            string Province = Console.ReadLine();

            Console.WriteLine("Have you been in contact with any covid cases? (Awnser 'Y' or 'N')");
            string contact = Console.ReadLine();

            Console.WriteLine("Do you have any of the covid 19 symptons? (Awnser 'Y' or 'N')");
            string symptons = Console.ReadLine();

            if (contact == "Y" || contact == "y" || symptons == "Y" || symptons == "y")
            {
                Console.WriteLine("Full Name: " + userName + " SA ID " + userID + " Surname: " + userSurname + " Province: " + Province + " YOU MIGHT HAVE COVID 19" );
            }
            else
            {
                Console.WriteLine("Full Name: " + userName + " SA ID " + userID + " Surname: " + userSurname + " Province: " + Province + ", You do not have covid 19");
            }


            Console.Read();
            
        }
    }
}
