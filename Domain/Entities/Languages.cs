﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Languages
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PostLanguages> PostLanguages { get; set; }
        public ICollection<CategoryLanguages> CategoryLanguages { get; set; }

    }
}
