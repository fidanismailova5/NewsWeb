using Application.DTOs.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class PostLanguagesDto : BaseDto
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public string Status { get; set; }
		public DateTime PublishDate { get; set; }
		public DateTime InsertDate { get; set; }

		public int PostId { get; set; }
		public PostsDto Posts { get; set; }
		public int PublisherId { get; set; }
		public UsersDto Publisher { get; set; }
		public int LanguageId { get; set; }
		public LanguagesDto Languages { get; set; }

		public ICollection<PostHashtagsDto> PostHashtags { get; set; }
	}
}
