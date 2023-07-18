using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserType : BaseDomainEntity
    {
        public string Title { get; set; }

        public ICollection<Users> Users { get; set; }

    }
}
