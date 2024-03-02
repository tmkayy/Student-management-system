using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using StudentManagementSystem.Data.Models;
using static StudentManagementSystem.Common.GlobalConstants;

namespace StudentManagementSystem.Data.Seeders
{
	public class AdminSeeder : ISeeder
	{
		public async Task SeedAsync(StudentManagementDbContext context, IServiceProvider serviceProvider)
		{
			var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
			await SeedAdminAsync(userManager, "admin@admin.com", "Admin123");
		}

		private async Task SeedAdminAsync(UserManager<ApplicationUser> userManager, string username, string password)
		{
			var user = new ApplicationUser()
			{
				UserName = username,
				Email = username,
				EmailConfirmed = true,
			};

			var result = await userManager.CreateAsync(user, password);

			if (result.Succeeded)
			{
				await userManager.AddToRoleAsync(user, AdministratorRole);
			}
		}
	}
}
