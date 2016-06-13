
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

namespace Mozu.Api.Urls.Content
{
	public partial class PublishSetSummaryUrl 
	{

		/// <summary>
        /// Get Resource Url for GetPublishSets
        /// </summary>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPublishSetsUrl(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = "/api/content/publishsets/?pageSize={pageSize}&startIndex={startIndex}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPublishSetItems
        /// </summary>
        /// <param name="code">User-defined code that uniqely identifies the channel group.</param>
        /// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
        /// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPublishSetItemsUrl(string code, int? pageSize =  null, int? startIndex =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/content/publishsets/{code}/items?pageSize={pageSize}&startIndex={startIndex}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeletePublishSet
        /// </summary>
        /// <param name="code">User-defined code that uniqely identifies the channel group.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
        /// <param name="shouldDiscard">Specifies whether to discard the pending content changes assigned to the content publish set when the publish set is deleted.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePublishSetUrl(string code, bool? shouldDiscard =  null, string responseFields =  null)
		{
			var url = "/api/content/publishsets/{code}?shouldDiscard={shouldDiscard}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "shouldDiscard", shouldDiscard);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddPublishSetItems
        /// </summary>
        /// <param name="code">User-defined code that uniqely identifies the channel group.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. For example, ) returns only the  and  items inside the  array of the specified product.This paramter should only be used to retrieve data. Attempting to update data using this parmater may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddPublishSetItemsUrl(string code, string responseFields =  null)
		{
			var url = "/api/content/publishsets/{code}/items?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				
	}
}

