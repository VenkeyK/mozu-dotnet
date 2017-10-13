
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

namespace Mozu.Api.Clients.Commerce.Carts
{
	/// <summary>
	/// Use the Cart Items subresource to manage a collection of items in an active shopping cart.
	/// </summary>
	public partial class CartItemClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCartItem( cartItemId,  responseFields);
		///   var cartItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> GetCartItemClient(string cartItemId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.CartItemUrl.GetCartItemUrl(cartItemId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCartItems( responseFields);
		///   var cartItemCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection> GetCartItemsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.CartItemUrl.GetCartItemsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartItem">Properties of an item added to an active shopping cart.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddItemToCart( cartItem,  responseFields);
		///   var cartItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> AddItemToCartClient(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.CartItemUrl.AddItemToCartUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem>(cartItem);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <param name="quantity">The number of cart items in the shopper's active cart.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCartItemQuantity( cartItemId,  quantity,  responseFields);
		///   var cartItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> UpdateCartItemQuantityClient(string cartItemId, int quantity, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.CartItemUrl.UpdateCartItemQuantityUrl(cartItemId, quantity, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartItem">Properties of an item added to an active shopping cart.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCartItem( cartItem,  cartItemId,  responseFields);
		///   var cartItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> UpdateCartItemClient(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string cartItemId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.CartItemUrl.UpdateCartItemUrl(cartItemId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem>(cartItem);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveAllCartItems();
		///   var cartClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> RemoveAllCartItemsClient()
		{
			var url = Mozu.Api.Urls.Commerce.Carts.CartItemUrl.RemoveAllCartItemsUrl();
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCartItem( cartItemId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCartItemClient(string cartItemId)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.CartItemUrl.DeleteCartItemUrl(cartItemId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


