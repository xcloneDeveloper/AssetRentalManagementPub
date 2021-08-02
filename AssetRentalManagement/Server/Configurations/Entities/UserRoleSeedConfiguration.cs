using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetRentalManagement.Server.Models;
using AssetRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetRentalManagement.Server.Configurations.Entities
{
	public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
		{
			builder.HasData(
												new IdentityUserRole<string>
												{
													RoleId = "efa81d14-1853-475c-84fd-1b886144644f",
													UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
												},
												new IdentityUserRole<string>
												{
													RoleId = "0480b649-b644-4760-a3b5-a272a6f90791",
													UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
												}
			);
		}
	}
}
