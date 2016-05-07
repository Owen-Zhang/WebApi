namespace Owen.Site.Core.Auth
{
    public class Authentication : IAuthentication
    {
        public bool Authenticate(string key, string value)
        {
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
                return false;
            return true;
        }   

        public bool Authenticate(string token)
        {
            throw new System.NotImplementedException();
        }
    }
}
