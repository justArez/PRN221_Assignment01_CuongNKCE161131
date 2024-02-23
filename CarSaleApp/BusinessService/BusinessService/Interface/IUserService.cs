using BusinessObject;

namespace DataAccess
{
    public interface IUserService
    {
        public void AddUser(User user);

        public void DeleteUserById(string id) ;

        public User GetUserById(string id);

        public User AuthenticateUser(string username, string password);

        public IEnumerable<User> GetUserList();

        public void UpdateUser(User user);
    }
}
