namespace Part4.demo
{
    public class Staff: Employee
    {
        public string title { get; set; }

        public Staff()
        {
        }

        public Staff(string title)
        {
            this.title = title;
        }
    }
}