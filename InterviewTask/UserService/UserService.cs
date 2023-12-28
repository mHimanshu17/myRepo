using InterviewTask.Entity;
using InterviewTask.Models;
using InterviewTask.UserContract;

namespace InterviewTask.UserService
{
    public class UserService : IUserService
    {
        private readonly UserContext _userContext;
        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }    
        public void AddUser(UserDetail user)
        {
            _userContext.Users.Add(user);
            _userContext.SaveChanges();
        }

        public List<UserDetail> GetUsers()
        {
            return _userContext.Users.ToList();
        }

        public List<UserDetail> SearchUser(string userName) 
        { 
            return _userContext.sp_GetUsers(userName); 
        }
    }
}
