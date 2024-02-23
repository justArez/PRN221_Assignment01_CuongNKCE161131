using BusinessObject;

namespace DataAccess
{
    public class UserService: IUserService
    {
        public void AddUser(User user) => UserRepo.Instance.AddUser(user);

        public void DeleteUserById(string id) => UserRepo.Instance.DeleteUserById(id);

        public User GetUserById(string id) => UserRepo.Instance.GetUserById(id);

        public User AuthenticateUser(string username, string password) => UserRepo.Instance.AuthenticateUser(username, password);

        public IEnumerable<User> GetUserList() => UserRepo.Instance.GetUserList();

        public void UpdateUser(User user) => UserRepo.Instance.UpdateUser(user);
    }
}
