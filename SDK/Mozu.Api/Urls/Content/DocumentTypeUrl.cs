
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
	public partial class DocumentTypeUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDocumentTypes
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentTypesUrl(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = "/api/content/documenttypes/?pageSize={pageSize}&startIndex={startIndex}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDocumentType
        /// </summary>
        /// <param name="documentTypeName"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentTypeUrl(string documentTypeName, string responseFields =  null)
		{
			var url = "/api/content/documenttypes/{documentTypeName}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentTypeName", documentTypeName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateDocumentType
        /// </summary>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateDocumentTypeUrl(string responseFields =  null)
		{
			var url = "/api/content/documenttypes/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateDocumentType
        /// </summary>
        /// <param name="documentTypeName"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDocumentTypeUrl(string documentTypeName, string responseFields =  null)
		{
			var url = "/api/content/documenttypes/{documentTypeName}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentTypeName", documentTypeName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				
	}
}
