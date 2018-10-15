using System;
using System.IO;
using PatternsPlayground.Builder;

namespace PatternsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var userBuilder = new UserBuilder();
            var director = new Director(userBuilder);
            var user = userBuilder.User;

            Console.WriteLine("{0} {1} @ {2} {3}, {4}", user.FirstName, user.LastName, user.AddressLine1, user.City,
                user.State);
        }
    }
}
