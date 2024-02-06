using Microsoft.EntityFrameworkCore;
using MinimalApiExample.Contexts;
using MinimalApiExample.Entities;

namespace MinimalApiExample.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly AppDbContext _context;

		public CategoryService(AppDbContext context)
		{
			_context = context;
		}

		public async Task<bool> CreateCategory(Category category)
		{
			if (category.Name == null)
			{
				return false;
			}
			await _context.Categories.AddAsync(category);
			_context.SaveChanges();
			return true;
		}

		public async Task<List<Category>> GetCategories()
		{
			return await _context.Categories.ToListAsync();
		}
	}

	public interface ICategoryService
	{
		Task<bool> CreateCategory(Category category);

		Task<List<Category>> GetCategories();
	}
}
