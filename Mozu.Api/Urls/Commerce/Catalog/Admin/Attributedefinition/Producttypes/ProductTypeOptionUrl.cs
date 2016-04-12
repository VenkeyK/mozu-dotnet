
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

namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes
{
	public partial class ProductTypeOptionUrl 
	{

		/// <summary>
        /// Get Resource Url for GetOptions
        /// </summary>
        /// <param name="productTypeId">Identifier of the product type to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetOptionsUrl(int productTypeId)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/producttypes/{productTypeId}/Options";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productTypeId", productTypeId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetOption
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productTypeId">The identifier of the product type.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetOptionUrl(int productTypeId, string attributeFQN, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/producttypes/{productTypeId}/Options/{attributeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productTypeId", productTypeId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddOption
        /// </summary>
        /// <param name="productTypeId">Identifier of the product type.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddOptionUrl(int productTypeId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/producttypes/{productTypeId}/Options?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productTypeId", productTypeId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateOption
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productTypeId">Identifier of the product type.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateOptionUrl(int productTypeId, string attributeFQN, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/producttypes/{productTypeId}/Options/{attributeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productTypeId", productTypeId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteOption
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productTypeId">Identifier of the product type.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteOptionUrl(int productTypeId, string attributeFQN)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/producttypes/{productTypeId}/Options/{attributeFQN}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productTypeId", productTypeId);
			return mozuUrl;
		}

		
	}
}

