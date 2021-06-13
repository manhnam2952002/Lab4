namespace Part4.demo
{
    public class Person
    {
        public string name;
        
        public string address;

        public int phoneNumber;

        public string email;

        public Person()
        {
        }
        
        public Person(string name, string address, int phoneNumber, string email)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public int PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public override string ToString()
        {
            return $"Name: {name}, Address: {address}, PhoneNumber: {phoneNumber}, Email: {email}";
        }
    }
}