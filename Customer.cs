using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Customer
    {
        private string firstName;
        private string secondName;
        private int age;
        private int egn;
        private bool isPensioner;
        private bool isBankClient;

        public Customer(string firstName, string secondName, bool isPensioner, bool isBankClient)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.isPensioner = isPensioner;
            this.isBankClient = isBankClient;
        }
        
        public string FirstName 
        { 
            get { return this.firstName; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException();
                }
                this.firstName = value;
            }
        }

        public string SecondName 
        { 
            get { return this.secondName; }
            set
            {

                if (value.Length < 2)
                {
                    throw new ArgumentException();
                }
                this.secondName = value;
            }
        }

        public int Age 
        { 
            get { return this.age; }
            set
            {
                if (value <= 0) {
                    throw new ArgumentException();
                }
                this.age = value; 
            }
        }

        public int Egn { get { return this.egn; } set { this.egn = value; } }

        public bool IsPensioner {  get { return this.isPensioner;} set { this.isPensioner = value; } }
        public bool IsBankClient {  get { return this.isPensioner;} set { this.isPensioner = value; } }

        public void Introduce()
        {
            if (age >= 65)
            {
                Console.WriteLine("Pensioner - 2% po-niska lihva");
            }
            else if (age >= 25 && age < 65)
            {
                Console.WriteLine("Vuzrasten - nqma privilegiq");
            }
            else
            {
                Console.WriteLine("Student - nqma privilegiq");
            }

        }


    }
}
