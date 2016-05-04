
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the Wish Lists resource to manage the shopper wish lists of products associated with a customer account. Although customer accounts are managed at the tenant level, the system stores shopper wish lists at the site level. This enables the same customer to have wish lists for each of a merchant's sites. Use the Wish List Items resource to manage items in a wish list.
	/// </summary>
	public partial class WishlistResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public WishlistResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public WishlistResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new WishlistResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of shopper wish lists according to any filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlistCollection = wishlist.GetWishlists( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection GetWishlists(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.GetWishlistsClient( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of shopper wish lists according to any filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlistCollection = await wishlist.GetWishlistsAsync( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection> GetWishlistsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.GetWishlistsClient( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the shopper wish list specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlist = wishlist.GetWishlist( wishlistId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist GetWishlist(string wishlistId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.GetWishlistClient( wishlistId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the shopper wish list specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlist = await wishlist.GetWishlistAsync( wishlistId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> GetWishlistAsync(string wishlistId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.GetWishlistClient( wishlistId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a wish list by supplying the wish list name.
		/// </summary>
		/// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistName">The name of the wish list to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlist = wishlist.GetWishlistByName( customerAccountId,  wishlistName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist GetWishlistByName(int customerAccountId, string wishlistName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.GetWishlistByNameClient( customerAccountId,  wishlistName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a wish list by supplying the wish list name.
		/// </summary>
		/// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistName">The name of the wish list to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlist = await wishlist.GetWishlistByNameAsync( customerAccountId,  wishlistName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> GetWishlistByNameAsync(int customerAccountId, string wishlistName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.GetWishlistByNameClient( customerAccountId,  wishlistName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new shopper wish list for the associated customer account. Although customer accounts are maintained at the tenant level, the system stores wish lists at the site level. Newly created wish lists do not have any items.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlist">Properties of a shopper wish list defined for a site, associated with a customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlist = wishlist.CreateWishlist( wishlist,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist CreateWishlist(Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist wishlist, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.CreateWishlistClient( wishlist,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new shopper wish list for the associated customer account. Although customer accounts are maintained at the tenant level, the system stores wish lists at the site level. Newly created wish lists do not have any items.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlist">Properties of a shopper wish list defined for a site, associated with a customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlist = await wishlist.CreateWishlistAsync( wishlist,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> CreateWishlistAsync(Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist wishlist, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.CreateWishlistClient( wishlist,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates one or more properties of a shopper wish list defined for a customer account.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <param name="wishlist">Properties of a shopper wish list defined for a site, associated with a customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlist = wishlist.UpdateWishlist( wishlist,  wishlistId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist UpdateWishlist(Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist wishlist, string wishlistId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.UpdateWishlistClient( wishlist,  wishlistId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more properties of a shopper wish list defined for a customer account.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <param name="wishlist">Properties of a shopper wish list defined for a site, associated with a customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   var wishlist = await wishlist.UpdateWishlistAsync( wishlist,  wishlistId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> UpdateWishlistAsync(Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist wishlist, string wishlistId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.UpdateWishlistClient( wishlist,  wishlistId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the shopper wish list specified in the request and all items associated with it.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   wishlist.DeleteWishlist( wishlistId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteWishlist(string wishlistId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.DeleteWishlistClient( wishlistId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the shopper wish list specified in the request and all items associated with it.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlist = new Wishlist();
		///   await wishlist.DeleteWishlistAsync( wishlistId);
		/// </code>
		/// </example>
		public virtual async Task DeleteWishlistAsync(string wishlistId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.WishlistClient.DeleteWishlistClient( wishlistId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


