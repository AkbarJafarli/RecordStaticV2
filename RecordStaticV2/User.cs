namespace RecordStaticV2
{
    class User : Account
    {
        private int _id;
        public int Id { get; }
        public string FullName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public User(int id, string fullname, string email, string password): base (password)
        {
            Id = ++_id;
            Email = email;
            Password = password;
        }

        public override bool PasswordChecker(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool isdigit = false;
            if (password.Length >= 8)
            {
                return true;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    hasUpper = true;
                }

                if (Char.IsLower(password[i]))
                {
                    hasLower = true;
                }
                if (Char.IsDigit(password[i]))
                {
                    isdigit = true;
                }
            }
            return false;

        }

        public override string ShowInfo()
        {
            return $"Id: {Id} - Fullname: {FullName} - Email: {Email}";
        }
    }
}
