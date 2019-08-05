using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class User
    {
        public int ID { get; set; }

        [DisplayName("User Id")]
        public string UserId { get; set; }

        [DisplayName("User Name")]
        public string UserName { get; set; }

        public int RoleId { get; set; }

        public Roles Role { get; set; }
    }
}
