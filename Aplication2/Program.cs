using System;
using System.Collections;
using System.Collections.Generic;

namespace Finances.Employees //Zadanie 6
{
    class Person  //Zadanie 1
    {
        public int Id;
        public string Name;
        public string Surname;
        public int Age;

        public void SetPerson(string name, string surname, int age) //Zadanie 5
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void PrintPersonInfo() //Zadanie5
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(Age);
        }
    }

    class Employee : Operation //Zadanie1, Zadanie2 powiązanie klasy Empoyee z Operation
    {
        static decimal HolidayBonus = 1000; //Zadanie 2

        public Employee() : base("Title", LinkedOperation.Main, "Details: ")
        {
            
        }

        public struct Salary //Zadanie3 
        {
            public decimal Basic;
            public decimal Bonus;
            public decimal Other;
        }
        Salary salary = new Salary(); //Zadanie 3 
        Person person = new Person(); //Zadanie 5

        public decimal Wage { get; set; }
        
        public Operation PayEmployee() //Zadanie 3 
        {
            Wage = salary.Basic + salary.Bonus + salary.Other;
            Operation operation = new Operation("Salary", LinkedOperation.Main, "bigger bonus");
            listOfOperations.Add(operation.ToString());
            return operation;
        }

        public enum Contract //Zadanie 4
        {
            FullTime,
            PartTime,
            Contract,
        }
        
        public Contract ContractType { get; set; }

        public void ChangePersonData(int id, string name, string surname, int age, decimal holidaybonus, decimal basic,
            decimal bonus, decimal other, Contract contractType, decimal wage ) //Zadanie 5
        {
            //Temat 2 / Zadanie1
            Console.WriteLine("Give Username: ");
            var login = Console.ReadLine();
            Console.WriteLine("Give password: ");
            var password = Console.ReadLine();
            if (login == "Admin" && password == "Admin1")
            {
                Wage = wage;
                return;
            }
            else
            {
                Console.WriteLine("Wrong inputs!");
            }
            
            person.Id = id;
            person.Name = name;
            person.Surname = surname;
            person.Age = age;

            HolidayBonus = holidaybonus;
            salary.Basic = basic;
            salary.Bonus = bonus;
            salary.Other = other;
            ContractType = contractType;

            Operation operation = new Operation("Change Personal data", LinkedOperation.Correction, "Changed contract");
        }

        public void PrintChangedPersonData() //Zadanie 5
        {
            Console.WriteLine(person.Id);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Surname);
            Console.WriteLine(person.Age);
            Console.WriteLine(HolidayBonus);
            Console.WriteLine(salary.Basic);
            Console.WriteLine(salary.Bonus);
            Console.WriteLine(salary.Other);
        }
    }

    class Employess<Operation>
    //Temat 3 Zadanie 1
    {
        private string[] _employessArray;
        private Operation[] _genericArray;

        public void SizeOfGenericArray(int size)
        {
            _employessArray = new string[size + 1];
            _genericArray = new Operation[size + 1];
        }

        public string GetItem(int index) // Temat 4 Zadanie 1
        {
            return _employessArray[index];
        }

        public Operation GetGenericArray(int index) // Temat 4 Zadanie 1
        {
            return _genericArray[index];
        }

        public void SetValue(int index, string value)
        {
            _employessArray[index] = value;
        }

        public void SetGenericValue(int index, Operation value)
        {
            _genericArray[index] = value;
        }
    }

    class Operation //Zadanie1
    {
        public enum LinkedOperation // Zadanie 5
        {
            Main,
            Correction,
        }
        public string Title { get; set; }
        public string Details { get; set; }
        public LinkedOperation Type { get; set; } 
        public Operation(string title, LinkedOperation type, string details) //Zadanie 9
        {
            Title = title;
            Type = type;
            Details = details;
        }

        public List<string> listOfOperations = new List<string>();
        
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Employee employee = new Employee();
            Operation operation = new Operation("Correction" , Operation.LinkedOperation.Correction, "Data correction of person");
            
            Employess<string> employessArray = new Employess<string>(); //Temat 3 Zadanie 1
            for (int i = 0; i < employessArray.SizeOfGenericArray(size:) ; i++)
            {
                employessArray.SetGenericValue(i,person.Name);
            }
            
        }
    }
}
