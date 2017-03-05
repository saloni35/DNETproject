using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
   class People:Common
    {
        public String loginId;
        public String password;
        public String temp;
public void register()
        {
            Console.WriteLine("Welcome to registration page");
   back:    Console.WriteLine("Enter your login id");
            loginId = Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Renter your password");
            temp = Console.ReadLine();
            if(temp.Equals(password))
            {
                Console.WriteLine("Registered Successfully");
            }
            else
            {
                Console.WriteLine("Password mismatch! \n please re-enter the registration details");
                goto back;
            }
        }
        public void login()
        {
            Console.WriteLine("Welcome to login page");
        back: Console.WriteLine("Enter your login id");
            loginId = Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Renter your password");
            temp = Console.ReadLine();
            if (temp.Equals(password))
            {
                Console.WriteLine("Loggged In Successfully");
            }
            else
            {
                Console.WriteLine("Password mismatch! \n please re-enter the login details");
                goto back;
            }
        }
       
    }
    interface Common
    {
        void register();
        void login();
    }   
    interface Common1
    {
        void generateConsignment(Consignment c);
        void uploadConsignment(Consignment c);
        void viewConsignment();
    }
    
    class Consignment
    {
       
        private String origin;
       public String Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        private String destination;


        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        private string date;
        private bool non_docs;
        public bool Non_docs
        {
            get
            {
                return non_docs;
            }
            set
            {
                non_docs = value;
            }
        }

        public string Booked_by
        {
            get
            {
                return booked_by;
            }

            set
            {
                booked_by = value;
            }
        }

        public string Declared_value
        {
            get
            {
                return declared_value;
            }

            set
            {
                declared_value = value;
            }
        }

        public string Consigner_name
        {
            get
            {
                return consigner_name;
            }

            set
            {
                consigner_name = value;
            }
        }

        public string Consignee_name
        {
            get
            {
                return consignee_name;
            }

            set
            {
                consignee_name = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }
        private bool docs;
        public bool Docs
        {
            get
            {
                return docs;
            }
            set
            {
                docs = value;
            }
        }

        public bool Insurance
        {
            get
            {
                return insurance;
            }

            set
            {
                insurance = value;
            }
        }

        public float Weight_kg
        {
            get
            {
                return weight_kg;
            }

            set
            {
                weight_kg = value;
            }
        }

        public float Weight_gm
        {
            get
            {
                return weight_gm;
            }

            set
            {
                weight_gm = value;
            }
        }

        public int Pkgs
        {
            get
            {
                return pkgs;
            }

            set
            {
                pkgs = value;
            }
        }

        public float Service_tax
        {
            get
            {
                return service_tax;
            }

            set
            {
                service_tax = value;
            }
        }

        public float Total_amount
        {
            get
            {
                return total_amount;
            }

            set
            {
                total_amount = value;
            }
        }

        private String booked_by;
        private String declared_value;
        private bool insurance;
        private float weight_kg;
        private float weight_gm;
        private int pkgs;
        private float service_tax;
        private float total_amount;
        private String consigner_name;
        private String consignee_name;
     }
    class Admin : People, Common
    {


    }

    class Employee : People,Common
    {
        Consignment c = new Consignment();
        public void generateConsignment()
        {
            c.Booked_by = Console.ReadLine();
            c.Consignee_name = Console.ReadLine();
            c.Consigner_name = Console.ReadLine();
            c.Date = Console.ReadLine();
            c.Declared_value = Console.ReadLine();
            c.Destination = Console.ReadLine();
            c.Docs = bool.Parse(Console.ReadLine());
            c.Insurance =bool.Parse(Console.ReadLine());
            c.Non_docs = bool.Parse(Console.ReadLine());
            c.Origin = Console.ReadLine();
            c.Pkgs =int.Parse( Console.ReadLine());
            c.Service_tax = Console.ReadLine();
            c.Total_amount = Console.ReadLine();
            c.Weight_gm = Console.ReadLine();
            c.Weight_kg = Console.ReadLine();

        }


    }
    class Program
    {
       
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Choose the desired option \n 1.Register 2.Login");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        Console.WriteLine("Choose the desired option");
                        Console.WriteLine("1.Admin 2.User 3.Employee");
                        choice = int.Parse(Console.ReadLine());
                        switch(choice)
                        {
                            case 1:
                                {
                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                        }
                        break;
                            }
                case 2:
                    {
                        Console.WriteLine("Choose the desired option");
                        Console.WriteLine("1.Admin 2.User 3.Employee");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                        }
                        break;
                    }

            }
        }
    }
}
