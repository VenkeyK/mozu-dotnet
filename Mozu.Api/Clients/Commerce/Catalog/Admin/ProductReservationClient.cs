
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Product Reservations resource to temporarily hold a product from inventory while a shopper is filling out payment information. You can create a product reservation when a shopper proceeds to check out and then release the reservation when the order process is complete.
	/// </summary>
	public partial class ProductReservationClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductReservations(dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var productReservationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection> GetProductReservationsClient(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.GetProductReservationsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the product reservation.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductReservation(dataViewMode,  productReservationId,  responseFields);
		///   var productReservationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation> GetProductReservationClient(DataViewMode dataViewMode, int productReservationId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.GetProductReservationUrl(productReservationId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productReservations">A hold placed on product inventory for a particular product so that the quantity specified is set aside and available for purchase during the ordering process.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddProductReservations(dataViewMode,  productReservations,  skipInventoryCheck);
		///   var productReservationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> AddProductReservationsClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations, bool? skipInventoryCheck =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.AddProductReservationsUrl(skipInventoryCheck);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>>(productReservations)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productReservations">A hold placed on product inventory for a particular product so that the quantity specified is set aside and available for purchase during the ordering process.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CommitReservations(dataViewMode,  productReservations);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient CommitReservationsClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.CommitReservationsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>>(productReservations)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productReservations">A hold placed on product inventory for a particular product so that the quantity specified is set aside and available for purchase during the ordering process.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductReservations(dataViewMode,  productReservations,  skipInventoryCheck);
		///   var productReservationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> UpdateProductReservationsClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations, bool? skipInventoryCheck =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.UpdateProductReservationsUrl(skipInventoryCheck);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>>(productReservations)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the product reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProductReservation(dataViewMode,  productReservationId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteProductReservationClient(DataViewMode dataViewMode, int productReservationId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.DeleteProductReservationUrl(productReservationId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


