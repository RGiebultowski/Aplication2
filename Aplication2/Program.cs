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
        
        public struct Salary //Zadanie3 
        {
            public decimal Basic;
            public decimal Bonus;
            public decimal Other;
        }
        Salary salary = new Salary(); //Zadanie 3 
        Person person = new Person(); //Zadanie 5

        public Operation PayEmployee() //Zadanie 3 
        {
            decimal wage = salary.Basic + salary.Bonus + salary.Other;
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
            decimal bonus, decimal other, Contract contractType) //Zadanie 5
        {
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
        }
    }
}
