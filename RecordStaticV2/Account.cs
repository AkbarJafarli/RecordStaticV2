namespace RecordStaticV2
{
    abstract class Account
    {
        protected string Password;

        protected Account(string password)
        {
            Password = password;
        }
        public abstract bool PasswordChecker(string password);
        public abstract string ShowInfo();
    }
}


