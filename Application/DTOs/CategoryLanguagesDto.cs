using Application.DTOs.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class CategoryLanguagesDto : BaseDto
	{
		public string Title { get; set; }
		public string Status { get; set; }
		public DateTime PublishDate { get; set; }
		public DateTime InsertDate { get; set; }

		public int CategoryId { get; set; }
		public CategoryDto Category { get; set; }
		public int LanguageId { get; set; }
		public LanguagesDto Languages { get; set; }
	}
}
