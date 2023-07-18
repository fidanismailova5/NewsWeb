using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Languages : BaseDomainEntity
    {
        public string Name { get; set; }

        public ICollection<PostLanguages> PostLanguages { get; set; }
        public ICollection<CategoryLanguages> CategoryLanguages { get; set; }

    }
}
