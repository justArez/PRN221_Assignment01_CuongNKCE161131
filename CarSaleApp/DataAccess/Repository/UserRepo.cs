using BusinessObject;
using DataAccess.Repository.Interface;

namespace DataAccess
{
    public class UserRepo: IUserRepo
    {
        private static UserRepo instance = null;
        private static readonly object instanceLock = new object();
        public static UserRepo Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserRepo();
                    }
                }
                return instance;
            }
        }
        public void AddUser(User user) => UserDAO.Instance.AddUser(user);

        public void DeleteUserById(string id) => UserDAO.Instance.Delete(id);

        public User GetUserById(string id) => UserDAO.Instance.GetUserByID(id);

        public User AuthenticateUser(string username, string password) => UserDAO.Instance.AuthenticateUser(username, password);

        public IEnumerable<User> GetUserList() => UserDAO.Instance.GetUserList();

        public void UpdateUser(User user) => UserDAO.Instance.Update(user);

    }
}
