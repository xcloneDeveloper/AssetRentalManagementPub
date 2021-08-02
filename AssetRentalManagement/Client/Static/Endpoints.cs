using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetRentalManagement.Client.Static
{
	public static class Endpoints
	{
		public static string Prefix = "api";
		
		public static string MakesEndPoint = $"{Prefix}/makes";
		public static string VehiclesEndPoint = $"{Prefix}/vehicles";
		public static string ModelsEndPoint = $"{Prefix}/models";
		public static string BookingsEndPoint = $"{Prefix}/bookings";
		public static string CustomersEndPoint = $"{Prefix}/customers";
		public static string ColorsEndPoint = $"{Prefix}/colors";

		public static string CustomersEndpoint { get; internal set; }
	}
}
