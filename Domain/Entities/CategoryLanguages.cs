﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CategoryLanguages : BaseDomainEntity
    {
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime InsertDate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int LanguageId { get; set; }
        public Languages Languages { get; set; }

    }
}
