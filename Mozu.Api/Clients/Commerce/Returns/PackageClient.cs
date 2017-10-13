
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

namespace Mozu.Api.Clients.Commerce.Returns
{
	/// <summary>
	/// Use the Return Packages subresource to manage physical packages used to ship return replacement items.
	/// </summary>
	public partial class PackageClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <param name="returnAsBase64Png">Specifies whether to return the RMA label image as Base64-encoded PNG image instead of as a byte array encoded in the original image format. The default is .</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackageLabel( returnId,  packageId,  returnAsBase64Png);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> GetPackageLabelClient(string returnId, string packageId, bool? returnAsBase64Png =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.GetPackageLabelUrl(returnId, packageId, returnAsBase64Png);
			const string verb = "GET";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackage( returnId,  packageId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> GetPackageClient(string returnId, string packageId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.GetPackageUrl(returnId, packageId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="package">Properties of a physical package shipped for an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePackage( pkg,  returnId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> CreatePackageClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.CreatePackageUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>(pkg);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="package">Properties of a physical package shipped for an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePackage( pkg,  returnId,  packageId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> UpdatePackageClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string returnId, string packageId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.UpdatePackageUrl(returnId, packageId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>(pkg);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePackage( returnId,  packageId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePackageClient(string returnId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.DeletePackageUrl(returnId, packageId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


