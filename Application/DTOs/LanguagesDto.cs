using Application.DTOs.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class LanguagesDto : BaseDto
	{
		public string Name { get; set; }

		public ICollection<PostLanguagesDto> PostLanguages { get; set; }
		public ICollection<CategoryLanguagesDto> CategoryLanguages { get; set; }
	}
}
