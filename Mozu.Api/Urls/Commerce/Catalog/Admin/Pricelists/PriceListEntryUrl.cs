
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

namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Pricelists
{
	public partial class PriceListEntryUrl 
	{

		/// <summary>
        /// Get Resource Url for GetPriceListEntry
        /// </summary>
        /// <param name="currencyCode"></param>
        /// <param name="priceListCode"></param>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <param name="startDate"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPriceListEntryUrl(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/pricelists/{priceListCode}/Entries/{productCode}/{currencyCode}?startDate={startDate}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "currencyCode", currencyCode);
			mozuUrl.FormatUrl( "priceListCode", priceListCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "startDate", startDate);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPriceListEntries
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="priceListCode"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPriceListEntriesUrl(string priceListCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/pricelists/{priceListCode}/Entries?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "priceListCode", priceListCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddPriceListEntry
        /// </summary>
        /// <param name="priceListCode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddPriceListEntryUrl(string priceListCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/pricelists/{priceListCode}/Entries?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "priceListCode", priceListCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdatePriceListEntry
        /// </summary>
        /// <param name="currencyCode"></param>
        /// <param name="priceListCode"></param>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <param name="startDate"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdatePriceListEntryUrl(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/pricelists/{priceListCode}/Entries/{productCode}/{currencyCode}?startDate={startDate}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "currencyCode", currencyCode);
			mozuUrl.FormatUrl( "priceListCode", priceListCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "startDate", startDate);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeletePriceListEntry
        /// </summary>
        /// <param name="currencyCode"></param>
        /// <param name="priceListCode"></param>
        /// <param name="productCode"></param>
        /// <param name="startDate"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePriceListEntryUrl(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null)
		{
			var url = "/api/commerce/catalog/admin/pricelists/{priceListCode}/Entries/{productCode}/{currencyCode}?startDate={startDate}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "currencyCode", currencyCode);
			mozuUrl.FormatUrl( "priceListCode", priceListCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "startDate", startDate);
			return mozuUrl;
		}

		
	}
}

