using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Elsa_Scan_V2.BLL.Models.ApplicationModels
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }

        public User(Guid userId, string userName)
        {
            this.UserId = userId;
            this.Username = userName;
        }
    }
}
