
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the Location resource to retrieve details about a location from a Mozu hosted storefront.
	/// </summary>
	public partial class LocationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public LocationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public LocationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new LocationResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the details of the location specified in the request.
		/// </summary>
		/// <param name="code">User-defined code that identifies the location.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetLocation( code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.Location GetLocation(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetLocationClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.Location> GetLocationAsync(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetLocationClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a location associated with a defined location usage type for the site specified in the request.
		/// </summary>
		/// <param name="code">Retrieves the details of a location associated with a defined location usage type for the site specified in the request.</param>
		/// <param name="locationUsageType">System-defined location usage type code, which is DS for direct ship, SP for in-store pickup, or storeFinder.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetLocationInUsageType( locationUsageType,  code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.Location GetLocationInUsageType(string locationUsageType, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetLocationInUsageTypeClient( locationUsageType,  code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.Location> GetLocationInUsageTypeAsync(string locationUsageType, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetLocationInUsageTypeClient( locationUsageType,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of the locations configured for a specified location usage type for the specified site, according to any defined filter or sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="locationUsageType">System-defined location usage type code, which is DS for direct ship, SP for in-store pickup, or storeFinder.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var locationCollection = location.GetLocationsInUsageType( locationUsageType,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationCollection GetLocationsInUsageType(string locationUsageType, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetLocationsInUsageTypeClient( locationUsageType,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.LocationCollection> GetLocationsInUsageTypeAsync(string locationUsageType, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetLocationsInUsageTypeClient( locationUsageType,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the location configured for the direct shipping (DS) location usage type for the site specified in the request. This location acts as an origin address from which order packages will ship, as well as the location where product reservations are created when order items are submitted with the direct ship fulfillment type (DS). If the direct ship location usage type is not configured for this site, the operation returns an error.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetDirectShipLocation( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.Location GetDirectShipLocation(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetDirectShipLocationClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.Location> GetDirectShipLocationAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetDirectShipLocationClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the location configured for the in-store pickup (SP) location usage type for the site specified in the request. If the location is not associated with a location type configured for the in-store pickup location usage type (SP), the operation returns an error.
		/// </summary>
		/// <param name="code">The user-defined code that identifies the location to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetInStorePickupLocation( code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.Location GetInStorePickupLocation(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetInStorePickupLocationClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.Location> GetInStorePickupLocationAsync(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetInStorePickupLocationClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of locations valid for in-store pickup of an item in an order according to any filter and sort criteria. For example, an application could use this operation to provide a store finder feature based on the shopper's GPS coordinates. If the location types for the in-store pickup location usage type are not configured for the site, this operation returns an error.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var locationCollection = location.GetInStorePickupLocations( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationCollection GetInStorePickupLocations(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetInStorePickupLocationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Location.LocationCollection> GetInStorePickupLocationsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.LocationClient.GetInStorePickupLocationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


