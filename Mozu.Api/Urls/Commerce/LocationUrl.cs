
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce
{
	public partial class LocationUrl 
	{

		/// <summary>
        /// Get Resource Url for GetLocation
        /// </summary>
        /// <param name="includeAttributeDefinition"></param>
        /// <param name="locationCode"></param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationUrl(string locationCode, bool? includeAttributeDefinition =  null, string responseFields =  null)
		{
			var url = "/api/commerce/storefront/locations/{locationCode}?includeAttributeDefinition={includeAttributeDefinition}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "includeAttributeDefinition", includeAttributeDefinition);
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLocationsInUsageType
        /// </summary>
        /// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
        /// <param name="includeAttributeDefinition"></param>
        /// <param name="locationUsageType">System-defined location usage type code, which is DS for direct ship, SP for in-store pickup, or storeFinder.</param>
        /// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationsInUsageTypeUrl(string locationUsageType, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, bool? includeAttributeDefinition =  null, string responseFields =  null)
		{
			var url = "/api/commerce/storefront/locationUsageTypes/{locationUsageType}/locations?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&includeAttributeDefinition={includeAttributeDefinition}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "includeAttributeDefinition", includeAttributeDefinition);
			mozuUrl.FormatUrl( "locationUsageType", locationUsageType);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDirectShipLocation
        /// </summary>
        /// <param name="includeAttributeDefinition"></param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDirectShipLocationUrl(bool? includeAttributeDefinition =  null, string responseFields =  null)
		{
			var url = "/api/commerce/storefront/locationUsageTypes/DS/location?includeAttributeDefinition={includeAttributeDefinition}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "includeAttributeDefinition", includeAttributeDefinition);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetInStorePickupLocation
        /// </summary>
        /// <param name="includeAttributeDefinition"></param>
        /// <param name="locationCode"></param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetInStorePickupLocationUrl(string locationCode, bool? includeAttributeDefinition =  null, string responseFields =  null)
		{
			var url = "/api/commerce/storefront/locationUsageTypes/SP/locations/{locationCode}?includeAttributeDefinition={includeAttributeDefinition}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "includeAttributeDefinition", includeAttributeDefinition);
			mozuUrl.FormatUrl( "locationCode", locationCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetInStorePickupLocations
        /// </summary>
        /// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
        /// <param name="includeAttributeDefinition"></param>
        /// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetInStorePickupLocationsUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, bool? includeAttributeDefinition =  null, string responseFields =  null)
		{
			var url = "/api/commerce/storefront/locationUsageTypes/SP/locations?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&includeAttributeDefinition={includeAttributeDefinition}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "includeAttributeDefinition", includeAttributeDefinition);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

								
	}
}

