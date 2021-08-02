using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetRentalManagement.Shared.Domain
{
	public class Color : BaseDomainModel
	{
		[Required]
		public string Name { get; set; }

	}
}
