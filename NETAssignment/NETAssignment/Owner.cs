namespace NETAssignment
{
    public class Owner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Owner(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}