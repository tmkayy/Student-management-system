using Microsoft.AspNetCore.Identity;

namespace StudentManagementSystem.Data.Models
{
	public class ApplicationUser : IdentityUser
	{
		public ApplicationUser() => this.Id = Guid.NewGuid().ToString();
	}
}