using Messenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Services
{
    public interface IUserService
    {
        public IQueryable<User> GetAll();
        public User? Get(long UserSeq);
        public User? GetByEmpSeq(long EmpSeq);
        public User? GetByID(string ID);
    }
}
