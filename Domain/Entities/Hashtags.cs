using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Hashtags
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PostHashtags> PostHashtags { get; set; }

    }
}
