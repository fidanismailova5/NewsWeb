using Application.DTOs.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class UserTypeDto : BaseDto
	{
		public string Title { get; set; }

		public ICollection<UsersDto> Users { get; set; }
	}
}
