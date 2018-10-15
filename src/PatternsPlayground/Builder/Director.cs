namespace PatternsPlayground.Builder
{
    public class Director //I construct a userbuilder for you!
    {
        public Director(UserBuilder userBuilder)
        {
            userBuilder.ConstructName();
            userBuilder.ConstructAddress();
            userBuilder.ConstructAge();
        }
    }
}