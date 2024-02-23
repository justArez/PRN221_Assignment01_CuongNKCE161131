using BusinessObject;

namespace DataAccess.Repository.Interface
{
    public interface IUserRepo
    {
        public void AddUser(User user) => UserDAO.Instance.AddUser(user);

        public void DeleteUserById(string id) => UserDAO.Instance.Delete(id);

        public User GetUserById(string id) => UserDAO.Instance.GetUserByID(id);

        public User AuthenticateUser(string username, string password) => UserDAO.Instance.AuthenticateUser(username, password);

        public IEnumerable<User> GetUserList() => UserDAO.Instance.GetUserList();

        public void UpdateUser(User user) => UserDAO.Instance.Update(user);
    }
}
