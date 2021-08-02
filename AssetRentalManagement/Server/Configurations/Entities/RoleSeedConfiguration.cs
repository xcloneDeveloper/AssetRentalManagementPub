using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetRentalManagement.Server.Configurations.Entities
{
	public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
	{


		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
				new IdentityRole
				{
					//Id = Guid.NewGuid().ToString();   or if needed to know you can edit or create your own @ https://www.guidgenerator.com/online-guid-generator.aspx
					Id = "efa81d14-1853-475c-84fd-1b886144644f",
					Name = "User",
					NormalizedName = "USER"
				},
				new IdentityRole
				{
					Id = "0480b649-b644-4760-a3b5-a272a6f90791",
					Name = "Administrator",
					NormalizedName = "ADMINISTRATOR"
				}
			);
		}
	}
}

