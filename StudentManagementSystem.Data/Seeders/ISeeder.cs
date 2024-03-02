namespace StudentManagementSystem.Data.Seeders
{
	public interface ISeeder
	{
		Task SeedAsync(StudentManagementDbContext context, IServiceProvider serviceProvider);
	}
}
