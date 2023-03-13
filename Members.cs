using System;
using System.Diagnostics;

namespace Udemy_dotNet
{
    class Members
    {
        // member - private field

        private string memberName;
        private string jobTitle;
        private int salary;

        public int age;


        // member - property - exposes jobtitle safely - 
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }


        // public member method - can be called from other clases
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, My name is {0}, and my job title is {1}. Im {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        public Members()
        {
            age = 30;
            memberName = "Ilie";
            salary = 2500;
            jobTitle = "Dev";

            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor

        ~Members()
        {
            // cleanup statements
            
            Console.WriteLine("Deconstruction of members obj");
            Debug.Write("Destruction of members objects");
        }
    }
}
