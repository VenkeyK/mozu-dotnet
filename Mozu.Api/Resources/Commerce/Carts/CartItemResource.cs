
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

namespace Mozu.Api.Resources.Commerce.Carts
{
	/// <summary>
	/// Use the Cart Items subresource to manage a collection of items in an active shopping cart.
	/// </summary>
	public partial class CartItemResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CartItemResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CartItemResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CartItemResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = await cartitem.GetCartItemAsync( cartItemId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> GetCartItemAsync(string cartItemId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.GetCartItemClient( cartItemId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItemCollection = await cartitem.GetCartItemsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection> GetCartItemsAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.GetCartItemsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartItem">Properties of an item added to an active shopping cart.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = await cartitem.AddItemToCartAsync( cartItem,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> AddItemToCartAsync(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.AddItemToCartClient( cartItem,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <param name="quantity">The number of cart items in the shopper's active cart.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = await cartitem.UpdateCartItemQuantityAsync( cartItemId,  quantity,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> UpdateCartItemQuantityAsync(string cartItemId, int quantity, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.UpdateCartItemQuantityClient( cartItemId,  quantity,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartItem">Properties of an item added to an active shopping cart.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = await cartitem.UpdateCartItemAsync( cartItem,  cartItemId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> UpdateCartItemAsync(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string cartItemId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.UpdateCartItemClient( cartItem,  cartItemId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cart = await cartitem.RemoveAllCartItemsAsync();
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> RemoveAllCartItemsAsync(CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.RemoveAllCartItemsClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   await cartitem.DeleteCartItemAsync( cartItemId);
		/// </code>
		/// </example>
		public virtual async Task DeleteCartItemAsync(string cartItemId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.DeleteCartItemClient( cartItemId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


