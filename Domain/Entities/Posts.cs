using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Posts
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<PostLanguages> PostLanguages { get; set; }

    }
}
