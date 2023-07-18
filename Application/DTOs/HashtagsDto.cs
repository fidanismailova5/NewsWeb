using Application.DTOs.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class HashtagsDto : BaseDto
	{
		public string Name { get; set; }

		public ICollection<PostHashtagsDto> PostHashtags { get; set; }
	}
}
