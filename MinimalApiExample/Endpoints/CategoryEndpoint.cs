using Carter;
using MinimalApiExample.Entities;
using MinimalApiExample.Services;

namespace MinimalApiExample.Endpoints
{
	public class CategoryEndpoint : ICarterModule
	{
		public void AddRoutes(IEndpointRouteBuilder app)
		{
			var x = app.MapGroup("/products");
			x.MapGet("/", GetCategories);
			x.MapPost("/", CreateCategory);
		}

		public async Task<IResult> CreateCategory(Category category, ICategoryService categoryService)
		{
			var result = await categoryService.CreateCategory(category);
			if (!result)
			{
				return Results.BadRequest();
			}
			return Results.Ok("hersey eladi");
		}

		public async Task<IResult> GetCategories(ICategoryService categoryService)
		{
			var result = await categoryService.GetCategories();
			if (result == null)
			{
				return Results.BadRequest();
			}
			return Results.Ok(result);
		}
	}
}
