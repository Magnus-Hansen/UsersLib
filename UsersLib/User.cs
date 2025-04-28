namespace UsersLib
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            
        }
        public void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException("Name can't be null");
        }
        public void ValidatePassword()
        {
            if (Password == null) throw new ArgumentNullException("Password can't be null");
        }
        public void Validate()
        {
            ValidateName();
            ValidatePassword();
        }
        public override string ToString()
        {
            return $"Id: {Id} -- Name: {Name} -- Password: {Password}";
        }
    }
}
