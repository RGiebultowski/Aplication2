using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Finances.Employees  // Temat 1 Zadanie 6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Projekt Zaliczeniowy - ZPO");
            Console.WriteLine(" ");
            Console.WriteLine("1. Crate new Person.");
            Console.WriteLine("2. Crate new Employee.");
            Console.WriteLine("3. Crate new Operaation.");

            // Temat 2 Zadanie 1
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:

                    Person person1 = new Person("Rafał", "Giebułtowski", 23);

                    Console.WriteLine("Set Name: ");                    
                    var name = Console.ReadLine();
                    Console.WriteLine("Set Surname: ");
                    var surname = Console.ReadLine();
                    Console.WriteLine("Set Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    person1.SetPerson(name,surname,age);
                    person1.PersonInfo();
                    break;

                case 2:
                    
                    Employee employee1 = new Employee(4500, 700, 1100, 1000);

                    Console.WriteLine("Username: ");
                    var login = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    var password = Console.ReadLine();
                    if (login == "Admin" && password == "admin1")
                    {
                        Console.WriteLine("Set Name: ");
                        var employeename = Console.ReadLine();
                        Console.WriteLine("Set Surname: ");
                        var employeesurname = Console.ReadLine();
                        Console.WriteLine("Set Age: ");
                        var employeeage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Set basic salary: ");
                        decimal basicsalary = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Set bonus: ");
                        decimal bonus = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Set other: ");
                        decimal other = Convert.ToDecimal(Console.ReadLine());
                        employee1.SetEmployeeData(1, employeename, employeesurname, employeeage, 1000, basicsalary, bonus, other);
                        employee1.EmployeeData();
                    }
                    else
                    {
                        Console.WriteLine("Wrong inputs!");
                    }

                    break;

                case 3:
                    Operation operation1 = new Operation();
                    Console.WriteLine("Title: ");
                    var title = Console.ReadLine();
                    Console.WriteLine("Details: ");
                    var details = Console.ReadLine();
                    operation1.SetOperation(title, details, Operation.Operations.Main);
                    break;

                default:
                    break;
            }
        }
    }

    // Temat 6 Zadanie 1
    abstract class Person // Teamt 1 Zadanie 1
    {
        // Temat 1 Zadanie 2
        public int Id = 1;                  
        public string Name;
        public string Surname;
        public int Age;

        // Temat 1 Zadanie 9
        public Person(string personName, string personSurname, int personAge)
        {
            personName = Name;
            personSurname = Surname;
            personAge = Age;
        }

        // Temat 1 Zadanie 5

        public void SetPerson(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

            if (Name == name && Surname == surname && Age == age)
            {
                Id += Id;
            }
        }

               

        public void PersonInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("----------");
        }

        //Temat 6 Zadanie 2
        public abstract string Interests(Person person);

    }

    // Temat 1 Zadanie 10
    class Client
    {
        string ClientName;
        string ClientSurname;
        string ClientNumber;
    }

    // Temat 1 Zadanie 10
    class Manager
    {
        string MenagerName;
        string MenagerSurname;
        decimal MenagerSalary;

    }

    // Teamt 1 Zadanie 1
    class Employee : Operation // Temat 1 Zadanie 2
    {
        // Temat 1 Zadanie 2
        static decimal HolidayBonus = 1000;
        public Employee()
        {

        }

        // Temat 1 Zadanie 9
        public Employee(decimal basic, decimal bonus, decimal other, decimal holidaybonus)
        {
            basic = wage.Basic;
            bonus = wage.Bonus;
            other = wage.Other;
            holidaybonus = HolidayBonus;
        }

        // Temat 1 Zadanie 3
        public struct Wage
        {
            public decimal Basic;
            public decimal Bonus;
            public decimal Other;
        }

        Wage wage = new Wage();


        // Temat 1 Zadanie 4
        enum Contract
        {
            FullTime,
            PartTime,
            Contract,
        }

        // Temat 1 Zadanie 5
        Person person = new Person("Rafał", "Giebułtowski", 22);

        public void EmployeeData() 
        {

            decimal salary = wage.Basic + wage.Bonus + wage.Other;

            Console.WriteLine("Employee data: ");
            Console.WriteLine("Id: " + person.Id);
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Surname: " + person.Surname);
            Console.WriteLine("Age: " + person.Age);
            Console.WriteLine("HolidayBonus: " + HolidayBonus);
            Console.WriteLine("Basic sallary: " + wage.Basic);
            Console.WriteLine("Bonus: " + wage.Bonus);
            Console.WriteLine("Other: " + wage.Other);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("----------");


        }

        public void SetEmployeeData(int id, string employeeName, string employeeSurname, int employeeAge
        , decimal employeeHolidayBonus, decimal employeeBasic, decimal employeeBonus, decimal employeeOther)
        {

            person.Id = id;
            person.Name = employeeName;
            person.Surname = employeeSurname;
            person.Age = employeeAge;

            HolidayBonus = employeeHolidayBonus;

            wage.Basic = employeeBasic;
            wage.Bonus = employeeBonus;
            wage.Other = employeeOther;

        }

        //Temat 7 Zadanie 1
        public static bool operator ==(Employee employee, Employee employee1)
        {
            if(employee.Equals(name) && employee1.Equals(surname))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Temat 7 Zadanie 2
        public static bool operator <(Employee employee, Employee employee1)
        {
            bool status = employee.Salary < employee1.Salary;
            return status;
        }

        public static bool operator >(Employee employee, Employee employee1)
        {
            bool status = employee.Salary > employee1.Salary;
            return status;
        }

        //Temat 7 Zadanie 3
        public static implicit operator double(Employee employee)
        {
            return (double)employee.Salary;
        }

        //Temat 7 Zadanie 4
        public static int operator +(Employee employee, int number)
        {
            return employee.Salary + number;
        }

        //Temat 8 Zadanie 1 i 2
        public void ChangeEmployeeName(string firstName, string lastName)
        {
            person.Name = firstName;
            person.Surname = lastName;
            dataChange("Data changed.");
        }


        public delegate void ChangeData(string message);

        public ChangeData dataChange;

        public void AddCallback(ChangeData message)
        {
            dataChange += message;
        }
    }

    // Temat 5 Zadanie 1
    class EmployeeFactory
    {
        public static Employee CreateEmployee(int id, string name, string surname, int age)
        {
            return new Employee();
        }
    }

    // Temat 4 Zadanie 1
    class Employees<T>
    {

        private T[] ListOfEmployees = new T[100];
        int nextIndex = 0;

        public T this[int i] => ListOfEmployees[i];

        public void Add(T value)
        {
            if(nextIndex >= ListOfEmployees.Length)
            {
                throw new IndexOutOfRangeException($"The collection can hold only {ListOfEmployees.Length} elements.");
                ListOfEmployees[nextIndex++] = value;
            }
        }
        // Temat 4 Zadanie 1
        public void Get()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            var surname = Console.ReadLine();

            for(int i = 0; i < ListOfEmployees.Length; i++)
            {
                if(name.Equals(ListOfEmployees[i]) && surname.Equals(ListOfEmployees[i]))
                {
                    Console.WriteLine(ListOfEmployees[nextIndex]);
                }
                else
                {
                    Console.WriteLine("There is no existing Employee.");
                }
            }
        }

        // Temat 5 Zadanie 2
        public void AddEmployee()
        {
            
            ListOfEmployees.Add(EmployeeFactory.CreateEmployee);
        }

        // Temat 5 Zadanie 3
        public void AddEmployeeDemo()
        {
            Console.WriteLine("Set Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Set Surname: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Set age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ListOfEmployees.Length; i++)
            {
                if (name.Equals(ListOfEmployees[i]) && surname.Equals(ListOfEmployees[i]))
                {
                    Console.WriteLine("Already exists.");
                }
                else
                {

                    ListOfEmployees.Add(EmployeeFactory.CreateEmployee(nextIndex, name, surname, age));
                }
            }
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("Type id to delete: ");
            var id = Convert.ToInt32(Console.ReadLine());
            ListOfEmployees.Remove(ListOfEmployees.Where(id.Equals(ListOfEmployees[nextIndex])));
        }

        public void ShowEmployees()
        {
            Console.WriteLine("Employees");
            Console.WriteLine(ListOfEmployees);
        }

    }

    class Operation // Teamt 1 Zadanie 1
    {
        // Temat 1 Zadanie 2
        public List<string> listOfOperations = new List<string>();

        public string Title;
        public string Details;
        public enum Operations
        {
            Main,
            Correction,
        }
        public Operations TypesOfOperations  { get; set; }

        // Temat 1 Zadanie 9
        public Operation()
        {
            Console.WriteLine("Operation Type: " + Operation.Operations.Main);
        }

        // Temat 1 Zadanie 5
        public void SetOperation(string title, string details, Operations operations)
        {
            Title = title;
            Details = details;
            TypesOfOperations = operations;

        }

        public void ShowOperation()
        {
            Console.WriteLine("Operation: " + Title);
            Console.WriteLine("Details: " + Details);
            Console.WriteLine("Operation Type: " + TypesOfOperations);
            Console.WriteLine("-------------------------");
        }


    }
}
