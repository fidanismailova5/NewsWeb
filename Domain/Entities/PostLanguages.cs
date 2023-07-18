using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostLanguages
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime InsertDate { get; set; }

        public int PostId { get; set; }
        public Posts Posts { get; set; }
        public int PublisherId { get; set; }
        public Users Publisher { get; set; }
        public int LanguageId { get; set; }
        public Languages Languages { get; set; }

        public ICollection<PostHashtags> PostHashtags { get; set; }

    }
}
