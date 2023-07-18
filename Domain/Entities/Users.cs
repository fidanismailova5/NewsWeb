using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Users :BaseDomainEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
        public UserType UserType { get; set; }

        public ICollection<PostLanguages> PostLanguages { get; set; }

    }
}
