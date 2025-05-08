namespace UsersLib
{
    public class User
    {
        //public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public User(string? username, string? password)
        {
            Username = username;
            Password = password;
        }
        public void ValidateName()
        {
            if (Username == null) throw new ArgumentNullException("Name can't be null");
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
            //return $"Id: {Id} -- Name: {UserName} -- Password: {Password}";
            return $"Name: {Username} -- Password: {Password}";
        }
    }
}
