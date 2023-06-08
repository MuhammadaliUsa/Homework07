using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework07
{
    internal class User
    {
        //fulName,userName,password, phone)
        string fullName, userName, password, phoneNumber;
        int option;
        public string FullName { get; set; }    
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNuber { get; set; }
        public User()
        {
            
        }
        public  void Option()
        {
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Login up");
            Console.Clear();
            option=int.Parse(Console.ReadLine());
            if (option==1)
            {
                SignUp();
            }


        }
        public void SignUp()
        {   
            Console.Write("Enter the fullName:");
            fullName = Console.ReadLine();

            Console.Write("Enter the userName:");
            userName = Console.ReadLine();

            Console.Write("Enter the password:");
            password = Console.ReadLine();

            Console.Write("Enter the phoneNumber:");
            phoneNumber = Console.ReadLine();

            //Console.WriteLine("Account created successfully");

        }
       
    }
}
