using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data.Models;

namespace StudentManagementSystem.Data
{
	public class StudentManagementDbContext : IdentityDbContext<ApplicationUser>
	{
		public StudentManagementDbContext(DbContextOptions<StudentManagementDbContext> options) : base(options) { }
	}
}
