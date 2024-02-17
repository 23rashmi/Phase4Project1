namespace BankDetailsProject1
{
    public class LoginService
    {
        public string Login(string username, string password)
        {
            if (IsValidUser(username, password))
            {
                return "Login Success";
            }
            else
            {
                return "Login Failed";
            }
        }

        private bool IsValidUser(string username, string password)
        {
            return username == "rashmi123" && password == "rashmi@123";
        }

    }
}
