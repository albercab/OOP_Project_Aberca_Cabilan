using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoatRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.InitData();
            p.ProgramStart();
            Console.ReadLine();


        }
        public void ProgramStart()
        {
            var guid = Guid.NewGuid().ToString();
            
            Program p = new Program();
        NotLoginHome:

            switch (p.NotLoginHome())
            {
                case "a":
                case "A":
                    p.Login();
                    break;
                case "b":
                case "B":
                    p.Register();
                    break;
                default:
                    Console.Clear();

                    Console.WriteLine("\n\nInvalid Choice please select from valid choices\n");

                    goto NotLoginHome;


            };
        }
        public void Register()
        {
            String firstname, lastname, middlename, address, username, password, gender;
            byte age;

            Console.WriteLine("\t\t\tRegistration Form\n");
            Console.Write("Please Input First Name:");
            firstname = Console.ReadLine();
            Console.Write("Please Input Last Name:");
            lastname = Console.ReadLine();
            Console.Write("Please Input Middle Name:");
            middlename = Console.ReadLine();
            Console.Write("Please Input Address:");
            address = Console.ReadLine();
            Console.Write("Please Input age:");
            age = byte.Parse(Console.ReadLine());
            Console.Write("Please Input username:");
            username = Console.ReadLine();
            Console.Write("Please Input password:");
            password = Console.ReadLine();
            Console.Write("Please Input your Gender:");
            gender = Console.ReadLine();

            User u = new User(Guid.NewGuid().ToString(), firstname, lastname, middlename, address, age, username, password, gender);
            Data.UserList.Add(u);
            ProgramStart();
        }
        public String NotLoginHome()
        {
            
            String input;
            Console.WriteLine("\t\t\tWELCOME To PIKOYS BOAT RENTAL SERVICES");
            Console.WriteLine("Select Option\nA.Login\nB.Register");
            Console.Write("Please Select an Option\t");
            input = Console.ReadLine();
            return input;
        }

        public String LoginHome(String id)
        {
            Program p=new Program();
            User respond;
            String input = "";
            try
            {
                respond = Data.UserList.Find(r => (r.Id == id));
                Console.WriteLine("\nPIKOY BOAT RENTAL SERVICES" + respond.Username + "\tHAPPY TO SERVE YOU");
                Console.WriteLine("------------->       Menu       <----------");
                Console.WriteLine("----------> A. Rental           <----------");
                Console.WriteLine("----------> B. Account Settings <----------");
              

                Console.Write("Kindly input Letters from the following choices:  ");
                input = Console.ReadLine();
                switch(input)
                {
                    case "A":
                    case "a":
                        p.Rent();
                        break;
                    case "B":
                    case "b":
                        p.account();
                        break;
                }
                Console.ReadLine();
            }
            catch
            {

            }

            return input;
        }
            
        public void Login()
        {
            Program p = new Program();
        login:
            String username, password;
            Console.WriteLine("\t\t\t-----LOGIN-----\n");
            Console.Write("Please Input Username:");
            username = Console.ReadLine();
            Console.Write("Please Input Password:");
            password = Console.ReadLine();
            
            
          


            try
            {
                User respond = Data.UserList.Find(r => (r.Username == username) && (r.Password == password));
                switch (LoginHome(respond.Id))
                {
                    case "a":
                    case "A":  
                        break;
                    
                    
                };
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid Credentials !!!");
                goto login;
            }
        }

        public void setting()
        {
            Program p = new Program();
            string se;
            se = Console.ReadLine();
            Console.WriteLine("a.account\nb.blaa");
            Console.WriteLine("please choose");
            switch (se)
            {
                case "a":
                case "A":
                    p.account();
                    break;
            }
        }


        public void Rent()
        {
            string Go;
            double Days, Total,Cash,Change;
            Console.WriteLine("Welcome to Pikoy's Boat Rental Services\n\t\t\tKindly choose a Boat you want to Rent\nA.Slovak P5000/day\nB.Ringer P7000/day");
            Console.WriteLine("please input the correct letter of your choice:");
            Go = Console.ReadLine();
            switch (Go)
            {
                case "a":
                case "A":

                    Console.WriteLine("How many days you want to rent our boat?:");
                    Days = double.Parse(Console.ReadLine());
                    Total = Days * 5000;
                    Console.WriteLine("total expenses\t" + Total);
                    Console.WriteLine("please enter your cash:");
                    Cash = double.Parse(Console.ReadLine());
                    Change = Cash-Total;
                    if (Change > 1)
                    {

                        Console.WriteLine("Your change is:\t" + Change);
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                      
                    }
                    if (Change < 1)
                    {
                        
                    }
                    else
                    {

                        Console.WriteLine("Thankyou for renting here at PIKOY's Boat Rental\n Your Rent has been Confirmed\n");
                    }
                    
                    break;
                case "b":
                case "B":
                    
                    Console.WriteLine("How many days you want to rent our boat?:");
                    Days = double.Parse(Console.ReadLine());
                    Total = Days * 7000;
                    Console.WriteLine("total expenses\t" + Total);
                     Console.WriteLine("please enter your cash:");
                    Cash = double.Parse(Console.ReadLine());
                    Change = Cash-Total;
                    Console.WriteLine("Your change is:\t" + Change);
                    Console.WriteLine("Thankyou for renting here at PIKOY's Boat Rental\n");
                    break;
                    
                    

                    

            }
        }
        public void account()
        {

            double Total, Days;
            string firstname, lastname, boat;
            Console.WriteLine("NAme:Kevin Jay Alberca\nBoat type: Slovak\nTotal expenses: 15000\nDays to use: 5");
        }
            

          
        public void DisplayUserList()
        {
            
            Console.WriteLine("-----User's List-----");
            int count = 1;
            foreach (User ps in Data.UserList)
            {
                try
                {

                    Console.WriteLine(count++ + " " + ps.toString());
                }
                catch
                {

                }

            }

        }

        public void InitData()
        {
            string id1 = Guid.NewGuid().ToString();
            string id2 = Guid.NewGuid().ToString();

            Data.UserList.Add(new User(id1, "cabilan", "pikoyski", "v", "Manila", 27, "aa", "bb", "M"));

        }
    }
}

