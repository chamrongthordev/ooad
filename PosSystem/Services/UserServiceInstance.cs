using PosSystem.Repositories;
using PosSystem.Services.Implement;

namespace PosSystem.Services
{
    public class UserServiceInstance
    {
        private static UserServiceInstance? _userService;
        public IUserRepository UserRepository =  new UserService();

        // defind singleton pattern
        private UserServiceInstance(){}

        /// <summary>
        /// Get an instance object of UserService
        /// </summary>
        /// <returns></returns>
        public static UserServiceInstance getInstance()
        {

            if (_userService == null)
            {
                _userService = new UserServiceInstance();
            }

            return _userService;
        }

    }
}
