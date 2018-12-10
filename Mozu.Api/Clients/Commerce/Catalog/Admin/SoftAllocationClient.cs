
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
	/// The Soft Allocations resource allows you to temporarily hold a product from inventory while a shopper is filling out payment information. You create a product reservation when a shopper proceeds to check out and then release the reservation when the order process is complete.
	/// </summary>
	public partial class SoftAllocationClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSoftAllocations( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var softAllocationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection> GetSoftAllocationsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SoftAllocationUrl.GetSoftAllocationsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocationCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSoftAllocation( softAllocationId,  responseFields);
		///   var softAllocationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> GetSoftAllocationClient(int softAllocationId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SoftAllocationUrl.GetSoftAllocationUrl(softAllocationId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocationsIn"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddSoftAllocations( softAllocationsIn);
		///   var softAllocationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> AddSoftAllocationsClient(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocationsIn)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SoftAllocationUrl.AddSoftAllocationsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>>(softAllocationsIn);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ConvertToProductReservation( softAllocations);
		///   var productReservationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> ConvertToProductReservationClient(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SoftAllocationUrl.ConvertToProductReservationUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>>(softAllocations);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocationRenew"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RenewSoftAllocations( softAllocationRenew);
		///   var softAllocationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> RenewSoftAllocationsClient(Mozu.Api.Contracts.ProductAdmin.SoftAllocationRenew softAllocationRenew)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SoftAllocationUrl.RenewSoftAllocationsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.SoftAllocationRenew>(softAllocationRenew);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="softAllocations"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.SoftAllocation"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSoftAllocations( softAllocations);
		///   var softAllocationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>> UpdateSoftAllocationsClient(List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation> softAllocations)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SoftAllocationUrl.UpdateSoftAllocationsUrl();
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.SoftAllocation>>(softAllocations);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="softAllocationId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteSoftAllocation( softAllocationId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteSoftAllocationClient(int softAllocationId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SoftAllocationUrl.DeleteSoftAllocationUrl(softAllocationId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


