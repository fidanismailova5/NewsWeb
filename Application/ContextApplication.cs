using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;



namespace Application
{
	public class ContextApplication:DbContext
	{
		public ContextApplication() : base() { }

		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryLanguages> CategoryLanguage { get; set; }
		public DbSet<Hashtags> Hashtag { get; set; }
		public DbSet<Languages> Languages { get; set; }
		public DbSet<Posts> Post { get; set; }
		public DbSet<PostLanguages> PostLanguage { get; set; }
		public DbSet<PostHashtags> PostHashtag { get; set; }
		public DbSet<UserType> UserTypes { get; set; }
		public DbSet<Users> User { get; set; }

	}
}
