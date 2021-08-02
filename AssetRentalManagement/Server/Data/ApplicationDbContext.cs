using AssetRentalManagement.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetRentalManagement.Server.Configurations.Entities;
using AssetRentalManagement.Shared.Domain;

namespace AssetRentalManagement.Server.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}

		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Make> Makes { get; set; }
		public DbSet<Model> Models { get; set; }
		public DbSet<Vehicle> Vehicles { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new ColorSeedConfiguration());
			builder.ApplyConfiguration(new MakeSeedConfiguration());
			builder.ApplyConfiguration(new ModelSeedConfiguration());
			builder.ApplyConfiguration(new RoleSeedConfiguration());
			builder.ApplyConfiguration(new UserSeedConfiguration());
			builder.ApplyConfiguration(new UserRoleSeedConfiguration());
		}
	}
}
