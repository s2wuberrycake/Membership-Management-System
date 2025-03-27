using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Membership_Management_System.Model
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int account_id);
        UserModel GetById(int account_id);
        UserModel GetByUsername(string username);
        IEnumerable<UserModel> GetByAll();
    }
}

        //sign by strawberry
        //...dapat maHELLO
        //...signbyyashiro
