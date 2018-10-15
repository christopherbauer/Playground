using System;

namespace PatternsPlayground.Builder
{
    public class UserBuilder
    {
        private User _user;

        public User User
        {
            get { return _user; }
            private set { _user = value; }
        }

        public UserBuilder()
        {
            _user = new User();
        }

        public UserBuilder ConstructName()
        {
            _user.FirstName = "Chris";
            _user.LastName = "Bauer";
            return this;
        }

        public UserBuilder ConstructAddress()
        {
            _user.AddressLine1 = "43 Oakview Avenue";
            _user.City = "Farmingdale";
            _user.State = "NY";
            return this;
        }

        public UserBuilder ConstructAge()
        {
            _user.DateOfBirth = DateTime.Parse("1987-02-03");
            _user.Age = 27;
            return this;
        }
    }
}