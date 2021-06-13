using System;

namespace Part4.demo
{
    public class Employee: Person
    {
        public string department;

        public double salary;

        public DateTime theDateHired;

        public Employee()
        {
        }

        public Employee(string department, double salary, DateTime theDateHired)
        {
            this.department = department;
            this.salary = salary;
            this.theDateHired = theDateHired;
        }

        public string Department
        {
            get => department;
            set => department = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public DateTime TheDateHired
        {
            get => theDateHired;
            set => theDateHired = value;
        }

        public double CalculateBonus()
        {
            return salary;
        }

        public double CalculateVacation()
        {
            return salary;
        }
    }
}