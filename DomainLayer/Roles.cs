using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Roles
    {
        public int ID { get; set; }

        [DisplayName("Role Id")]
        public int RoleId { get; set; }

        [DisplayName("Role Name")]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users {get; set;}
    }
}
