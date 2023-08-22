namespace Basics.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public String FirstName { get; set; } = string.Empty;
        public String LastName { get; set; } = string.Empty;
        public String FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age { get; set; }

    }
}
