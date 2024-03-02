namespace StudentManagementSystem.Data.Seeders
{
	public class StudentManagementSeeder : ISeeder
	{
		public async Task SeedAsync(StudentManagementDbContext context, IServiceProvider serviceProvider)
		{
			if (context is null) throw new ArgumentNullException(nameof(context));

			if (serviceProvider is null) throw new ArgumentNullException(nameof(serviceProvider));

			var seeders = new List<ISeeder>
			{
				new RoleSeeder(),
				new AdminSeeder(),
			};

			foreach (var seeder in seeders)
			{
				await seeder.SeedAsync(context, serviceProvider);
			}
		}
	}
}
