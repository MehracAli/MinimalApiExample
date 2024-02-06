using MinimalApiExample.Services;

namespace MinimalApiExample.Utilities.Extensions
{
	public static class AddServicesEX
	{
		public static void AddServices(this IServiceCollection services)
		{
			services.AddSingleton<ICategoryService, CategoryService>();
		}
	}
}
