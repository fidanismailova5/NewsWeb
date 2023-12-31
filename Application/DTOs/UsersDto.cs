﻿using Application.DTOs.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
	public class UsersDto : BaseDto
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }

		public int RoleId { get; set; }
		public UserTypeDto UserType { get; set; }

		public ICollection<PostLanguagesDto> PostLanguages { get; set; }
	}
}
