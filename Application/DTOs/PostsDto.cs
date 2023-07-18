using Application.DTOs.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class PostsDto : BaseDto
	{
		public string ImagePath { get; set; }

		public int CategoryId { get; set; }
		public CategoryDto Category { get; set; }

		public ICollection<PostLanguagesDto> PostLanguages { get; set; }
	}
}
