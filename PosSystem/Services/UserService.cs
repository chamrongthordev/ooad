using PosSystem.Repositories;
using PosSystem.Services.Implement;

namespace PosSystem.Services
{
    public class UserService
    {
        private static UserService? _userService;
        public IUserRepository UserRepository =  new UserServiceImplement();

        // defind singleton pattern
        private UserService(){}

        /// <summary>
        /// Get an instance object of UserService
        /// </summary>
        /// <returns></returns>
        public static UserService getInstance()
        {

            if (_userService == null)
            {
                _userService = new UserService();
            }

            return _userService;
        }

    }
}
