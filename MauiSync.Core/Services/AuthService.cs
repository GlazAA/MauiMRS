using MauiSync.Core.Models;

namespace MauiSync.Core.Services
{
    public interface IAuthService
    {
        bool IsAuthenticated { get; }
        User? CurrentUser { get; }
        void Login(string username, string password);
        void Logout();
    }

    public class AuthService : IAuthService
    {
        public bool IsAuthenticated { get; private set; }
        public User? CurrentUser { get; private set; }

        public void Login(string username, string password)
        {
            // TODO: Реальная авторизация
            IsAuthenticated = true;
            CurrentUser = new User
            {
                Id = 1,
                FirstName = "Тест", 
                LastName = "Пользователь",
                Login = username
            };
        }

        public void Logout()
        {
            IsAuthenticated = false;
            CurrentUser = null;
        }
    }
}