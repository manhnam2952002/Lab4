namespace Part4.demo
{
    public class Student: Person
    {
        private string classStatus;

        public Student(string classStatus)
        {
            this.classStatus = classStatus;
        }

        public string getClassStatus()
        {
            return classStatus;
        }
    }
}