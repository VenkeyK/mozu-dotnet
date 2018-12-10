
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
using System.Threading;

namespace Mozu.Api.Clients.Commerce.Shipping.Admin
{
	/// <summary>
	/// Use the Profiles resource to manage your shipping profiles.
	/// </summary>
	public partial class ShippingProfileClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingProfileCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProfiles( responseFields);
		///   var shippingProfileCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingProfileCollection> GetProfilesClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Shipping.Admin.ShippingProfileUrl.GetProfilesUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingProfileCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


