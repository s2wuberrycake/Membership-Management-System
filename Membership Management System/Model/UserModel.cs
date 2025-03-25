using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_Management_System.Model
{
    class UserModel
    {
        public Guid employee_id { get; set; }  // UUID (MySQL CHAR(36))
        public string username { get; set; }
        public string password_hash { get; set; }
        public DateTime birthday { get; set; } // Use DateTime for date fields
        public string role { get; set; }  // 'admin' or 'staff'
        public DateTime created_at { get; set; } // Timestamp field
    }
}
