using MinimalApi.Models;

namespace MinimalApi.Interfaces
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
