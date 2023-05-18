using System.Net;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, string address, int age, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Address = person.Address;
            Age = person.Age;
            PhoneNumber = person.PhoneNumber;
        }

        public static void SayHello()
        {
            Console.WriteLine($"Hello");
        }

        public void FullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName} Age: {Age} Address: {Address} Phone: {PhoneNumber}";
        }
    }
}
