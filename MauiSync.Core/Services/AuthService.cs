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
            // TODO: �������� �����������
            IsAuthenticated = true;
            CurrentUser = new User
            {
                Id = 1,
                FirstName = "����", 
                LastName = "������������",
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