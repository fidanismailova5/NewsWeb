using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostHashtags : BaseDomainEntity
    {

        public int HashtagId { get; set; }
        public Hashtags Hashtags { get; set; }
        public int PostLanguageId { get; set; }
        public PostLanguages PostLanguages { get; set; }

    }
}
