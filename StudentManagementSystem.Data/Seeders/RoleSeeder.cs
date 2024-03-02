using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using static StudentManagementSystem.Common.GlobalConstants;

namespace StudentManagementSystem.Data.Seeders
{
	public class RoleSeeder : ISeeder
	{
		public async Task SeedAsync(StudentManagementDbContext context, IServiceProvider serviceProvider)
		{
			var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

			await SeedRoleAsync(roleManager, AdministratorRole);
			await SeedRoleAsync(roleManager, ProfessorRole);
			await SeedRoleAsync(roleManager, StudentRole);
		}

		private async Task SeedRoleAsync(RoleManager<IdentityRole> roleManager, string roleName)
		{
			// seed role if it does not exist
			if (await roleManager.FindByNameAsync(roleName) is null)
			{
				await roleManager.CreateAsync(new IdentityRole(roleName));
			}
		}
	}
}
