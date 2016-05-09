namespace Owen.Site.Core.Auth
{
    public interface IAuthentication
    {
        bool Authenticate(string key, string value);

        bool Authenticate(string token);
    }
}
