using System;

namespace Prototype_Design_Pattern
{
    public class Address
    {
        public string State { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"City: {City}, State: {State}";
        }
    }

    // CREATE AUTHOR FOR SHALLOW COPY CLASS
    public class AuthorForShallowCopy : ICloneable
    {
        public string Name { get; set; }
        public string TwitterAccount { get; set; }
        public string Website { get; set; }
        public Address HomeAddress { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone(); // Shallow copy
        }

        public override string ToString()
        {
            return $"Name: {Name}, Twitter: {TwitterAccount}, Website: {Website}, Address: [{HomeAddress}]";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            AuthorForShallowCopy original = new AuthorForShallowCopy()
            {
                Name = "Shuk",
                TwitterAccount = "https://twitter.com",
                Website = "wshbfhf",
                HomeAddress = new Address()
                {
                    City = "Dhaka",
                    State = "Dhaka"
                }
            };

            AuthorForShallowCopy copy = (AuthorForShallowCopy)original.Clone();

            Console.WriteLine("Original: " + original);
            Console.WriteLine("Shallow Copy: " + copy);

            // Modify the address in the copy
            copy.HomeAddress.City = "Chittagong";

            Console.WriteLine("\nAfter modifying copy's address:");
            Console.WriteLine("Original: " + original); // Will also show Chittagong due to shallow copy
            Console.WriteLine("Shallow Copy: " + copy);
        }
    }
}
