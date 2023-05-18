using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> Autheticate(string email, string password);
        Task<bool> RegisterUser(string email, string password);
        Task Logout();
    }
}
