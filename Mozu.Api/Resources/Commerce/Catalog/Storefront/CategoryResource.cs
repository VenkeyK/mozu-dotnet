
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

namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Use the Storefront Categories resource to view the product category hierarchy as it appears to shoppers who are browsing the storefront. The hierarchy can be returned as a flat list or as a category tree.
	/// </summary>
	public partial class CategoryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CategoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CategoryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CategoryResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter product category search results by any of its properties, including its position in the category hierarchy. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = category.GetCategories( filter,  startIndex,  pageSize,  sortBy,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection GetCategories(string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoriesClient( filter,  startIndex,  pageSize,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter product category search results by any of its properties, including its position in the category hierarchy. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = await category.GetCategoriesAsync( filter,  startIndex,  pageSize,  sortBy,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection> GetCategoriesAsync(string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoriesClient( filter,  startIndex,  pageSize,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
		/// <param name="categoryId">Unique identifier for the storefront container used to organize products.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.GetCategory( categoryId,  allowInactive,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.Category GetCategory(int categoryId, bool? allowInactive =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryClient( categoryId,  allowInactive,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
		/// <param name="categoryId">Unique identifier for the storefront container used to organize products.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = await category.GetCategoryAsync( categoryId,  allowInactive,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.Category> GetCategoryAsync(int categoryId, bool? allowInactive =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryClient( categoryId,  allowInactive,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the list of product categories that appear on the storefront organized in a hierarchical format. Hidden categories do not appear in the list.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryCollection = category.GetCategoryTree( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.CategoryCollection GetCategoryTree(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryTreeClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the list of product categories that appear on the storefront organized in a hierarchical format. Hidden categories do not appear in the list.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryCollection = await category.GetCategoryTreeAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.CategoryCollection> GetCategoryTreeAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryTreeClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


