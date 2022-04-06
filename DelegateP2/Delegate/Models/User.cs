using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class User : IEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string MyProperty { get; set; }
        public Enum Role { get; set; }
        ////////////////////////////////////////////////////
        public User(string username, string email, Enum Role)
        {
            UserName = username;
            Email = email;  
            Role = Role;
        }
        ////////////////////////////////////////////////////
        public void ShowInfo()
        {

        }






















        public int Id => throw new NotImplementedException();
    }

}
