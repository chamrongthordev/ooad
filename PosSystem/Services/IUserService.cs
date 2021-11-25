using PosSystem.Repositories;
using PosSystem.Services.Implement;

namespace PosSystem.Services
{
    public class IUserService
    {
        private static IUserService? _userService;
        public IUserRepository UserRepository =  new UserService();

        // defind singleton pattern
        private IUserService(){}

        /// <summary>
        /// Get an instance object of UserService
        /// </summary>
        /// <returns></returns>
        public static IUserService getInstance()
        {

            if (_userService == null)
            {
                _userService = new IUserService();
            }

            return _userService;
        }

    }
}
