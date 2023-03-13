using System;
namespace Udemy_dotNet
{
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        public Human()
        {
            Console.WriteLine("Constructer called. Object created.");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void IntroduceMyself()
        {
            if (age != 0 && firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.My age is {2}, My eye color is {3}.", firstName, lastName, age, eyeColor);
            }
            else if (age != 0 && firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.My age is {2}", firstName, lastName, age);
            }
            else if (firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}", firstName);
            }
        }
    }
}
