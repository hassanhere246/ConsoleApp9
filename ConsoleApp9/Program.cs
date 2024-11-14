using System;
using System.Security.Policy;

namespace ConsoleApp9
{
    // Define the Animal class outside of Program class
    public class Animal
    {
        // Protected fields that can be accessed by derived classes
        protected string name;
        protected int age;

        // Constructor to initialize name and age
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method to display name and age
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
            Console.ReadLine();
        }
    }

    // Define the Program class where the Main method is located
    internal class Program
    {
        // Main method to execute the program
        public static void Main(string[] args)
        {
            // Create an Animal instance
            Animal animal = new Animal("Elephant", 10);

            // Call the DisplayInfo method
            animal.DisplayInfo();  // Outputs: Name: Elephant, Age: 10
        }
    }
}


namespace ConsoleApp
{
    // Base class: Person
    public class Person
    {
        // Protected fields to store first and last names
        protected string firstName;
        protected string lastName;

        // Constructor to initialize firstName and lastName
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Method to get the full name
        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }
    }

    // Derived class: Employee
    public class Employee : Person
    {
        // New field specific to Employee
        private string employeeId;

        // Constructor to initialize firstName, lastName, and employeeId
        public Employee(string firstName, string lastName, string employeeId)
            : base(firstName, lastName) // Calling the base class constructor
        {
            this.employeeId = employeeId;
        }

        // Method to display full name and employee ID
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee Name: {GetFullName()}, Employee ID: {employeeId}");
            
        }
    }

    
}
