using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
	public class NewsContext : ContextApplication
	{
		public NewsContext() : base() { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-KOMMVAR\SQLEXPRESS01;Database=NewsWeb;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasKey(c => c.Id);
			modelBuilder.Entity<CategoryLanguages>().HasKey(ct => ct.Id);
			modelBuilder.Entity<Hashtags>().HasKey(h => h.Id);
			modelBuilder.Entity<Languages>().HasKey(l => l.Id);
			modelBuilder.Entity<Posts>().HasKey(p => p.Id);
			modelBuilder.Entity<PostLanguages>().HasKey(pt => pt.Id);
			modelBuilder.Entity<PostHashtags>().HasKey(pth => pth.Id);
			modelBuilder.Entity<UserType>().HasKey(r => r.Id);
			modelBuilder.Entity<Users>().HasKey(u => u.Id);

			modelBuilder.Entity<Posts>()
				.HasOne(p => p.Category)
				.WithMany(c => c.Posts)
				.HasForeignKey(p => p.CategoryId);
			modelBuilder.Entity<CategoryLanguages>()
				.HasOne(ct => ct.Category)
				.WithMany(c => c.CategoryLanguages)
				.HasForeignKey(ct => ct.CategoryId);
			modelBuilder.Entity<CategoryLanguages>()
				.HasOne(ct => ct.Languages)
				.WithMany(l => l.CategoryLanguages)
				.HasForeignKey(ct => ct.LanguageId);
			modelBuilder.Entity<PostLanguages>()
				.HasOne(pt => pt.Posts)
				.WithMany(p => p.PostLanguages)
				.HasForeignKey(pt => pt.PostId);
			modelBuilder.Entity<PostLanguages>()
				.HasOne(pt => pt.Publisher)
				.WithMany(u => u.PostLanguages)
				.HasForeignKey(pt => pt.PublisherId);
			modelBuilder.Entity<PostLanguages>()
				.HasOne(pt => pt.Languages)
				.WithMany(l => l.PostLanguages)
				.HasForeignKey(pt => pt.LanguageId);
			modelBuilder.Entity<PostHashtags>()
				.HasOne(pth => pth.Hashtags)
				.WithMany(h => h.PostHashtags)
				.HasForeignKey(pth => pth.HashtagId);
			modelBuilder.Entity<PostHashtags>()
				.HasOne(pth => pth.PostLanguages)
				.WithMany(pt => pt.PostHashtags)
				.HasForeignKey(pth => pth.PostLanguageId);
			modelBuilder.Entity<Users>()
				.HasOne(u => u.UserType)
				.WithMany(r => r.Users)
				.HasForeignKey(u => u.RoleId);
		}
	}
}
