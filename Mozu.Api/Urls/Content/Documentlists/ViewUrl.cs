
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

namespace Mozu.Api.Urls.Content.Documentlists
{
	public partial class ViewUrl 
	{

		/// <summary>
        /// Get Resource Url for GetViewDocuments
        /// </summary>
        /// <param name="documentListName"></param>
        /// <param name="filter"></param>
        /// <param name="includeInactive"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <param name="viewName"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetViewDocumentsUrl(string documentListName, string viewName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, bool? includeInactive =  null, string responseFields =  null)
		{
			var url = "/api/content/documentlists/{documentListName}/views/{viewName}/documents?filter={filter}&sortBy={sortBy}&pageSize={pageSize}&startIndex={startIndex}&includeInactive={includeInactive}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "includeInactive", includeInactive);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			mozuUrl.FormatUrl( "viewName", viewName);
			return mozuUrl;
		}

								
	}
}

