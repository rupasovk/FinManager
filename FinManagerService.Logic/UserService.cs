using FinManagerService.Domain;

namespace FinManagerService.Logic
{
    public class UserService
    {
        public UserService() { }

        public User CreateUser(string _name, string _email, string _password)
        {
            return new User()
            {
                Name = _name,
                Email = _email,
                Password = _password
            };
        }
    }

}
