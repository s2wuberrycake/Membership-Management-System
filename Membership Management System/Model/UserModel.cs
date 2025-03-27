using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_Management_System.Model
{
    class UserModel
    {
        public int account_id { get; set; }  // Matches MySQL INT AUTO_INCREMENT
        public string username { get; set; }
        public string password_hash { get; set; }  // Store the hashed password
        public int role_id { get; set; }  // Foreign key from roles table
    }
}
