
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
	/// Use the Facets resource to manage the facets shoppers use to filter product display results on a storefront. Facets can include categories, product attributes, or prices, and use either a range of values or discrete values.
	/// </summary>
	public partial class FacetClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="validate">Validates that the product category associated with a facet is active. System-supplied and read only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFacet( facetId,  validate,  responseFields);
		///   var facetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> GetFacetClient(int facetId, bool? validate =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.GetFacetUrl(facetId, validate, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="includeAvailable">If true, returns a list of the attributes and categories associated with a product type that have not been defined as a facet for the category.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="validate">Validates that the product category associated with a facet is active. System-supplied and read only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.FacetSet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFacetCategoryList( categoryId,  includeAvailable,  validate,  responseFields);
		///   var facetSetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.FacetSet> GetFacetCategoryListClient(int categoryId, bool? includeAvailable =  null, bool? validate =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.GetFacetCategoryListUrl(categoryId, includeAvailable, validate, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.FacetSet>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="facet">Properties of the facet used to retrieve documents.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddFacet( facet,  responseFields);
		///   var facetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> AddFacetClient(Mozu.Api.Contracts.ProductAdmin.Facet facet, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.AddFacetUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Facet>(facet);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="facet">Properties of the facet used to retrieve documents.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateFacet( facet,  facetId,  responseFields);
		///   var facetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> UpdateFacetClient(Mozu.Api.Contracts.ProductAdmin.Facet facet, int facetId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.UpdateFacetUrl(facetId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Facet>(facet);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteFacetById( facetId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteFacetByIdClient(int facetId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.DeleteFacetByIdUrl(facetId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


