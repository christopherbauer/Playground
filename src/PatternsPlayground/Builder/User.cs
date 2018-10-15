using System;

namespace PatternsPlayground.Builder
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}