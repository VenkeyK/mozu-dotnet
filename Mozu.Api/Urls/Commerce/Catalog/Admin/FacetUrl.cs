
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

namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class FacetUrl 
	{

		/// <summary>
        /// Get Resource Url for GetFacet
        /// </summary>
        /// <param name="facetId">Unique identifier of the facet to retrieve.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="validate">Validates that the product category associated with a facet is active. System-supplied and read only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetFacetUrl(int facetId, bool? validate =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/facets/{facetId}?validate={validate}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "facetId", facetId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "validate", validate);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetFacetCategoryList
        /// </summary>
        /// <param name="categoryId">Unique identifier of the category associated with the facets to retrieve.</param>
        /// <param name="includeAvailable">If true, returns a list of the attributes and categories associated with a product type that have not been defined as a facet for the category.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="validate">Validates that the product category associated with a facet is active. System-supplied and read only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetFacetCategoryListUrl(int categoryId, bool? includeAvailable =  null, bool? validate =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/facets/category/{categoryId}?includeAvailable={includeAvailable}&validate={validate}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "categoryId", categoryId);
			mozuUrl.FormatUrl( "includeAvailable", includeAvailable);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "validate", validate);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddFacet
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddFacetUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/facets/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateFacet
        /// </summary>
        /// <param name="facetId">Unique identifier of the facet to modify.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateFacetUrl(int facetId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/facets/{facetId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "facetId", facetId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteFacetById
        /// </summary>
        /// <param name="facetId">Unique identifier of the facet to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteFacetByIdUrl(int facetId)
		{
			var url = "/api/commerce/catalog/admin/facets/{facetId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "facetId", facetId);
			return mozuUrl;
		}

		
	}
}

