using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetRentalManagement.Server.Configurations.Entities
{
	public class ColorSeedConfiguration : IEntityTypeConfiguration<Color>
	{
		public void Configure(EntityTypeBuilder<Color> builder)
		{
			builder.HasData(
				new Color
				{
					Id = 1,
					CreatedBy = "System",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					Name = "Black",
					UpdatedBy = "System"
				},
				new Color
				{
					Id = 2,
					CreatedBy = "System",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					Name = "White",
					UpdatedBy = "System"
				}


			);
		}
	}
}
