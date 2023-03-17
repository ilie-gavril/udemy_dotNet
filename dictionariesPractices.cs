using System;
using System.Collections.Generic;
using System.Linq;

namespace Udemy_dotNet
{
    public class dictionariesPractices
    {
        public static void Run()
        {
            Employee[] employees =
            {
                new Employee("CEO", "Codrin", 27, 500),
                new Employee("HR", "Dana", 24, 200),
                new Employee("Intern Front-End", "Alexandra", 28, 180),
                new Employee("Intern", "Ilie", 25, 180),
                new Employee("Junior", "Andreea", 24, 250),

            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            // add all
            foreach(Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }
            // update
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Denisa", 26, 185);
            }
            else
            {
                Console.WriteLine("Key {0} not found ", KeyToUpdate);
            }

            //remove


            string KeyToRemove = "Intern";

            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was Removed!", KeyToRemove);
            }


            //string key = "Intern Front-End";

            //if (employeesDirectory.ContainsKey(key))
            //{
            //    Employee empl = employeesDirectory[key];
            //    Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("No employee found with this key {0}", key);
            //}

            //Employee result = null;

            //if(employeesDirectory.TryGetValue("CEO", out result))
            //{
            //    Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", result.Name, result.Role, result.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("No employee found with this key");
            //}


            //for(int i = 0; i < employeesDirectory.Count; i++)
            //{
            //    KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

            //    Console.WriteLine("Key: {0}", keyValuePair.Key);

            //    Employee employeeValue = keyValuePair.Value;

            //    Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", employeeValue.Name, employeeValue.Role, employeeValue.Salary);
            //}



            Dictionary<int, string> numbers = new Dictionary<int, string>(5);

            numbers.Add(1, "one");
            numbers.Add(2, "two");
            numbers.Add(3, "three");
            numbers.Add(4, "four");
            numbers.Add(5, "five");

            int input = 6;
            if (numbers.ContainsKey(input))
            {
                Console.WriteLine(numbers[input]);
            }
            else
            {
                Console.WriteLine("nope");
            }


        }
    }
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }


}
