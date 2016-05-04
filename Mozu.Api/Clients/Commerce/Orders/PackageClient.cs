
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

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the Packages subresource to manage the physical packages to ship for an order.
	/// </summary>
	public partial class PackageClient 	{
		
		/// <summary>
		/// Retrieves a list of the actions available to perform for a package associated with order fulfillment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailablePackageFulfillmentActions( orderId,  packageId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailablePackageFulfillmentActionsClient(string orderId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PackageUrl.GetAvailablePackageFulfillmentActionsUrl(orderId, packageId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the package label image supplied by the carrier.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackageLabel( orderId,  packageId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> GetPackageLabelClient(string orderId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PackageUrl.GetPackageLabelUrl(orderId, packageId);
			const string verb = "GET";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a package of order items.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackage( orderId,  packageId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> GetPackageClient(string orderId, string packageId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PackageUrl.GetPackageUrl(orderId, packageId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new physical package of order items.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="package">Properties of a physical package shipped for an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePackage( pkg,  orderId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> CreatePackageClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PackageUrl.CreatePackageUrl(orderId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>(pkg);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of a physical package of order items.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="package">Properties of a physical package shipped for an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePackage( pkg,  orderId,  packageId,  responseFields);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> UpdatePackageClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string orderId, string packageId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PackageUrl.UpdatePackageUrl(orderId, packageId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>(pkg);
			return mozuClient;

		}

		/// <summary>
		/// Removes a physical package of items from the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePackage( orderId,  packageId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePackageClient(string orderId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PackageUrl.DeletePackageUrl(orderId, packageId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


