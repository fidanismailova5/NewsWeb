using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category : BaseDomainEntity
    {
        public string Name { get; set; }

        public ICollection<CategoryLanguages> CategoryLanguages { get; set; }
        public ICollection<Posts> Posts { get; set; }

    }
}
