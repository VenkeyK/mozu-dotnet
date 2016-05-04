
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

namespace Mozu.Api.Clients.Commerce.Returns
{
	/// <summary>
	/// Use the Return Shipments subresource to manage shipments for a return replacement.
	/// </summary>
	public partial class ShipmentClient 	{
		
		/// <summary>
		/// Retrieves the details of the specified return replacement shipment.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="shipmentId">Unique identifier of the shipment to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetShipment( returnId,  shipmentId,  responseFields);
		///   var shipmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment> GetShipmentClient(string returnId, string shipmentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.ShipmentUrl.GetShipmentUrl(returnId, shipmentId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a shipment from one or more packages associated with a return replacement.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="packageIds">List of unique identifiers for each package associated with this shipment. Not all packages must belong to the same shipment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePackageShipments( packageIds,  returnId);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>> CreatePackageShipmentsClient(List<string> packageIds, string returnId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.ShipmentUrl.CreatePackageShipmentsUrl(returnId);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(packageIds);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a shipment for a return replacement.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="shipmentId">Unique identifier of the shipment to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteShipment( returnId,  shipmentId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteShipmentClient(string returnId, string shipmentId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.ShipmentUrl.DeleteShipmentUrl(returnId, shipmentId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


