using System;
using System.Text;
using Faker;

namespace ParaBankFramework.Generators
{
    public static class CustomerGenerator
    {
        public static Customer LastGeneratedCustomer;
        private const int SsnLength = 9;

        public static void Initialize()
        {
            LastGeneratedCustomer = null;
        }

        public static Customer Generate()
        {
            // Start with separate first and last names to build fullname. It 
            // avoids having to split the string returned by Faker.Name.Fullname
            // into separate parts
            
            var firstName = Name.First();
            var lastName = Name.Last();
            var name     = firstName + " " + lastName;

            // Uses Faker.NET available as a NuGet package to generate fake data
            var customer = new Customer
            {
                Firstname = firstName,                          //"John",
                Lastname = lastName,                            //"Smith",
                AddressStreet = Faker.Address.StreetAddress(),  //"1431 Main St",
                AddressCity = Faker.Address.City(),             //"Beverly Hills",
                AddressState = Faker.Address.UsStateAbbr(),     //"CA",
                AddresZipcode = Faker.Address.ZipCode(),        //"90210",
                Phonenumber = Phone.Number(),             //"310-447-4121",
                Ssn = RandomSsn(),
                EmailAddress = Internet.Email(name),      // generate email based on fullname
                Username = Internet.UserName(name),       // generate username based on fullname
                Password = PasswordGenerator.Generate(),
            };

            LastGeneratedCustomer = customer;
            return customer;
        }

        private static Customer GenerateUnused()
        {
            // hardcoded to default test user
            var customer = new Customer
            {
                Firstname       = "John",
                Lastname        = "Smith",
                AddressStreet   = "1431 Main St",
                AddressCity     = "Beverly Hills",
                AddressState    = "CA",
                AddresZipcode   = "90210",
                Phonenumber     = "310-447-4121",
                Ssn             = "",           // Unknown 
                EmailAddress    = "",           // Unknown
                Username        = "john",
                Password        = "demo"
            };

            LastGeneratedCustomer = customer;
            return customer;
        }

        /// <summary>
        /// Random Number Generator
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <example>int myInt = GetRandomInt(5, 1000); // gives in random integer between 5 and 1000</example>
        private static int RandomInt(int min, int max)
        {
            var rnd = new Random();
            return rnd.Next(min, max);
        }

        /// <summary>
        /// Returns a 9 digit phone number in the format ###-##-####
        /// </summary>
        /// <remarks>Area codes are unlikely to be real</remarks>
        private static string RandomSsn()
        {
            var phone = new StringBuilder();

            while (phone.Length < SsnLength)
            {
                var next = RandomInt(1, 999);
                phone.Append(next.ToString());
            }

            return String.Format("{0:###-##-####}", Convert.ToInt64(phone.ToString().Substring(0, SsnLength)));
        }
    }

    // TODO - Refactor to extract Customer to its own class file
    public class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddresZipcode { get; set; }
        public string Phonenumber { get; set; }
        public string Ssn { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
        

