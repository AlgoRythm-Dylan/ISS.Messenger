using Messenger.Models;

namespace Messenger.Services.Fake
{
    public class FakeUserService : IUserService
    {
        public User? Get(long UserSeq)
        {
            return GetAll().Where(u => u.Seq == UserSeq).FirstOrDefault();
        }

        public IQueryable<User> GetAll()
        {
            return (IQueryable<User>)UserMemDB.Users;
        }

        public User? GetByEmpSeq(long EmpSeq)
        {
            return GetAll().Where(u => u.EmployeeSeq == EmpSeq).FirstOrDefault();
        }

        public User? GetByID(string ID)
        {
            return GetAll().Where(u => u.ID == ID).FirstOrDefault();
        }
    }
}
