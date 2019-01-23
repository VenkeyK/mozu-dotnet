
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
	public partial class QuoteUrl 
	{

		/// <summary>
        /// Get Resource Url for GetQuotes
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="q"></param>
        /// <param name="qLimit"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetQuotesUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			var url = "/api/commerce/quotes/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&q={q}&qLimit={qLimit}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "q", q);
			mozuUrl.FormatUrl( "qLimit", qLimit);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetQuote
        /// </summary>
        /// <param name="quoteId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetQuoteUrl(string quoteId, string responseFields =  null)
		{
			var url = "/api/commerce/quotes/{quoteId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "quoteId", quoteId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetQuoteByName
        /// </summary>
        /// <param name="customerAccountId"></param>
        /// <param name="quoteName"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetQuoteByNameUrl(int customerAccountId, string quoteName, string responseFields =  null)
		{
			var url = "/api/commerce/quotes/customers/{customerAccountId}/{quoteName}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "customerAccountId", customerAccountId);
			mozuUrl.FormatUrl( "quoteName", quoteName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateQuote
        /// </summary>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateQuoteUrl(string responseFields =  null)
		{
			var url = "/api/commerce/quotes/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateQuote
        /// </summary>
        /// <param name="quoteId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateQuoteUrl(string quoteId, string responseFields =  null)
		{
			var url = "/api/commerce/quotes/{quoteId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "quoteId", quoteId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteQuote
        /// </summary>
        /// <param name="quoteId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteQuoteUrl(string quoteId)
		{
			var url = "/api/commerce/quotes/{quoteId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "quoteId", quoteId);
			return mozuUrl;
		}

		
	}
}

