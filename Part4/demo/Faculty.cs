using System;

namespace Part4.demo
{
    public class Faculty: Employee
    {
        public string officeHours { get; set; }

        public string aRank { get; set; }

        public Faculty()
        {
        }

        public Faculty(string officeHours, string aRank)
        {
            this.officeHours = officeHours;
            this.aRank = aRank;
        }
    }
}