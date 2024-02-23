using BusinessObject;

namespace DataAccess
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<User> GetUserList()
        {
            var members = new List<User>();
            try
            {
                using var context = new CarSaleManagementDbContext();
                members = context.Users.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return members;
        }

        public User GetUserByID(string userId)
        {
            User user = null;
            try
            {
                using var context = new CarSaleManagementDbContext();
                user = context.Users.SingleOrDefault(c => c.Userid == userId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return user;
        }

        public User AuthenticateUser(string username, string password)
        {
            User user = null;
            try
            {
                using var context = new CarSaleManagementDbContext();
                user = context.Users.SingleOrDefault(u => u.Username == username);
                if (!user.Password.Equals(password)){
                    throw new Exception("Wrong password.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return user;
        }

        public void AddUser(User user)
        {
            try
            {
                User _mem = GetUserByID(user.Userid);
                if (_mem == null)
                {
                    using var context = new CarSaleManagementDbContext();
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(User user)
        {
            try
            {
                User _mem = GetUserByID(user.Userid);
                if (_mem != null)
                {
                    using var context = new CarSaleManagementDbContext();
                    context.Users.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User does not exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(string userId)
        {
            try
            {
                User _mem = GetUserByID(userId);
                if (_mem != null)
                {
                    using var context = new CarSaleManagementDbContext();
                    context.Users.Remove(_mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User does not exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
