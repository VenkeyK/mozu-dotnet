
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Settings
{
	/// <summary>
	/// Use the Location Usages resource to define the locations and location types that interact with the specified site. The system creates three default location usage types for each site after provisioning a new tenant - one for direct ship (DS), one for in-store pickup (SP), and one for store finder (storeFinder). Each site can only use a single location for the direct ship location usage type, and the location must support the direct ship fulfillment type (DS). For the in-store pickup location usage type, each site can use one or more location types. The location service identifies all locations of the specified type that support the in-store pickup fulfillment type (SP). For the store finder location usage type, each site can use one or more location types. The location service identifies all locations of the type. Locations configured for the store finder type do not typically maintain inventory. You cannot create additional location usage types at this time.
	/// </summary>
	public partial class LocationUsageClient 	{
		
		/// <summary>
		/// Retrieves the configured site location usages for the location usage code specified in the request.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationUsageCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationUsages();
		///   var locationUsageCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationUsageCollection> GetLocationUsagesClient()
		{
			var url = Mozu.Api.Urls.Commerce.Settings.LocationUsageUrl.GetLocationUsagesUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationUsageCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the location usages for the site specified in the request header.
		/// </summary>
		/// <param name="code">Code that identifies the location usage type, which is "DS" for direct ship, "SP" for in-store pickup, or "storeFinder" for store finder.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationUsage"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationUsage( code);
		///   var locationUsageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationUsage> GetLocationUsageClient(string code)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.LocationUsageUrl.GetLocationUsageUrl(code);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationUsage>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the location usage for the site based on the location usage code specified in the request.
		/// </summary>
		/// <param name="code">Code that identifies the location usage type, which is "DS" for direct ship, "SP" for in-store pickup, or "storeFinder" for store finder.</param>
		/// <param name="usage">Properties of the location usage type to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationUsage"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateLocationUsage( usage,  code);
		///   var locationUsageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationUsage> UpdateLocationUsageClient(Mozu.Api.Contracts.Location.LocationUsage usage, string code)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.LocationUsageUrl.UpdateLocationUsageUrl(code);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationUsage>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Location.LocationUsage>(usage);
			return mozuClient;

		}


	}

}

