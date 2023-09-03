using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CategoryLanguages, CategoryLanguagesDto>().ReverseMap();
            CreateMap<Hashtags, HashtagsDto>().ReverseMap();
            CreateMap<Languages, LanguagesDto>().ReverseMap();
            CreateMap<PostHashtags, PostHashtagsDto>().ReverseMap();
            CreateMap<PostLanguages, PostLanguagesDto>().ReverseMap();
            CreateMap<Posts, PostsDto>().ReverseMap();
            CreateMap<Users,  UsersDto>().ReverseMap();
            CreateMap<UserType, UserTypeDto>().ReverseMap();
        }
    }
}
