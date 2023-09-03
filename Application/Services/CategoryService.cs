using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
	public class CategoryService
	{
		private readonly NewsContext _context;
		private readonly IMapper _mapper;

		public CategoryService(NewsContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public List<DTOs.CategoryDto> Select()
		{
			var categories = _context.Categories.ToList();

			return _mapper.Map<List<DTOs.CategoryDto>>(categories);
		}

		public DTOs.CategoryDto Select(int id)
		{
			var category = _context.Categories.Find(id);

			_context.Entry(category).State = EntityState.Detached;

			return _mapper.Map<DTOs.CategoryDto>(category);
		}

		public void Create(DTOs.CategoryDto categoryDto)
		{
			//var categoryEntity = _mapper.Map<Domain.Entities.Category>(categoryDto);
			//var category = _context.Categories.Add(categoryEntity);
			//_context.SaveChanges();

			//var categoryLanguage = _mapper.Map<Domain.Entities.CategoryLanguage>(categoryDto);

			//_context.CategoryLanguages.Add(categoryLanguage);
			//_context.SaveChanges();

			var category = _mapper.Map<Domain.Entities.Category>(categoryDto);

			_context.Categories.Add(category);

			_context.SaveChanges();
		}

		public void CreateTranslation(DTOs.CategoryLanguagesDto categoryLanguageDto)
		{
			var categoryLanguage = _mapper.Map<Domain.Entities.CategoryLanguages>(categoryLanguageDto);

			_context.CategoryLanguage.Add(categoryLanguage);

			_context.SaveChanges();
		}

		public void Update(Domain.Entities.Category category)
		{
			_context.Categories.Update(category);
			_context.SaveChanges();
		}

		public void Delete(DTOs.CategoryDto categoryDto)
		{
			var category = _mapper.Map<Domain.Entities.Category>(categoryDto);
			category.Id = categoryDto.Id;

			_context.Categories.Remove(category);
			_context.SaveChanges();
		}

	}
}
