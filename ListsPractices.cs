using System;
using System.Collections;
using System.Collections.Generic;
namespace Udemy_dotNet
{
    public class ListsPractices
    {
        public static void Run()
        {


            //Student stud1 = new Student(1, "Andreea", 98);
            //Student stud2 = new Student(2, "Codrin", 95);
            //Student stud3 = new Student(3, "Alexandra", 94);
            //Student stud4 = new Student(4, "Alex", 99);
            //Student stud5 = new Student(5, "Vali", 78);

            //studentsTable.Add(stud1.Id, stud1);
            //studentsTable.Add(stud2.Id, stud2);
            //studentsTable.Add(stud3.Id, stud3);
            //studentsTable.Add(stud4.Id, stud4);
            //studentsTable.Add(stud5.Id, stud5);

            //Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // accesare toate valorile dintr un hashtable
            //foreach (DictionaryEntry entry in studentsTable)
            //{
            //    Student temp = (Student)entry.Value;
            //    Console.WriteLine("Student id: {0}", temp.Id);
            //    Console.WriteLine("Student name: {0}", temp.Name);
            //    Console.WriteLine("Student GPA: {0}", temp.GPA);
            //}

            //foreach(Student value in studentsTable.Values)
            //{
            //    Console.WriteLine("Student id: {0}", value.Id);
            //    Console.WriteLine("Student name: {0}", value.Name);
            //    Console.WriteLine("Student GPA: {0}", value.GPA);
            //}


            //Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);



            Hashtable studentsTable = new Hashtable(5);

            Student[] students = new Student[5];

            students[0] = new Student(1, "Andreea", 98);
            students[1] = new Student(2, "Codrin", 95);
            students[2] = new Student(3, "Alexandra", 94);
            students[3] = new Student(1, "Alex", 99);
            students[4] = new Student(5, "Vali", 78);

            foreach(Student value in students)
            {
                if (studentsTable.ContainsKey(value.Id))
                {
                    Console.WriteLine("Sorry, A student with the same ID already Exists.");
                }
                else
                {
                    studentsTable.Add(value.Id, value);
                }
                
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student id: {0}", value.Id);
                Console.WriteLine("Student name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }
        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
