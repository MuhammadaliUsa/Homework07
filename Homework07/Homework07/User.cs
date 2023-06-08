namespace Homework07
{
    internal class User
    {
        
        string fullName, userName, password, phoneNumber;
        int option;
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNuber { get; set; }
        public User()
        {

        }
        public void Option()
        {
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Login up");
            Console.WriteLine();
            Console.Write("Select the desired section:");

            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Clear();
                SignUp();
            }
            else if (option==2)
            {
                Console.Clear();
                Loginup();
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

            string filePath = Path.Combine("D:\\ex\\",$"{userName+password}.txt");
            if (File.Exists(filePath))
            {
                Console.WriteLine("Accaount already created!");
            }
            else
            {
                File.Create(filePath).Close();
                using( StreamWriter writer = new StreamWriter(filePath)) 
                {
                    writer.WriteLine($"fullName:{fullName}");
                    writer.WriteLine($"userName:{userName}");
                    writer.WriteLine($"password:{password}");
                    writer.WriteLine($"phoneNumber:{phoneNumber}");


                }
                Console.WriteLine("Account created successfully");
            }
            Console.ReadKey();
            Console.Clear() ;
            Option();


        }
        public void Loginup()
        {
            Console.Write("Enter the your userName:");
            userName = Console.ReadLine();

            Console.Write("Enter the your password:");
            password = Console.ReadLine();
            string filePath = Path.Combine($"D:\\ex\\{userName + password}.txt");
            if (File.Exists(filePath)) 
            {
                string userDate=File.ReadAllText(filePath);
                Console.Clear();
                Console.WriteLine("User Data");
                Console.WriteLine();
                Console.WriteLine(userDate);
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Incorrect username or password.");
                Console.ReadKey();
                Console.Clear();
                Option();

            }

        }


    }

}

