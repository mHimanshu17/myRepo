using InterviewTask.Models;

namespace InterviewTask.UserContract
{
    public interface IUserService
    {
        void AddUser(UserDetail user);
        List<UserDetail> GetUsers();
        List<UserDetail> SearchUser(string userName);
    }
}
