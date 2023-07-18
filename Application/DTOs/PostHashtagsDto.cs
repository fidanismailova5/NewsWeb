using Application.DTOs.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class PostHashtagsDto : BaseDto
	{
		public int HashtagId { get; set; }
		public HashtagsDto Hashtags { get; set; }
		public int PostLanguageId { get; set; }
		public PostLanguagesDto PostLanguages { get; set; }
	}
}
