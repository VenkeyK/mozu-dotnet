
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

namespace Mozu.Api.Resources.Commerce.Checkouts
{
	/// <summary>
	/// commerce/checkouts/checkoutitems related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class OrderItemResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderItemResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderItemResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderItemResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="itemId"></param>
		/// <param name="quantity">The number of cart items in the shopper's active cart.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var checkout = await orderitem.SplitItemAsync( checkoutId,  itemId,  quantity,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> SplitItemAsync(string checkoutId, string itemId, int? quantity =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> response;
			var client = Mozu.Api.Clients.Commerce.Checkouts.OrderItemClient.SplitItemClient( checkoutId,  itemId,  quantity,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="itemsForDestination"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var checkout = await orderitem.BulkUpdateItemDestinationsAsync( itemsForDestination,  checkoutId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> BulkUpdateItemDestinationsAsync(List<Mozu.Api.Contracts.CommerceRuntime.Checkouts.ItemsForDestination> itemsForDestination, string checkoutId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> response;
			var client = Mozu.Api.Clients.Commerce.Checkouts.OrderItemClient.BulkUpdateItemDestinationsClient( itemsForDestination,  checkoutId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields"></param>
		/// <param name="item"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var checkout = await orderitem.AddCheckoutItemAsync( item,  checkoutId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> AddCheckoutItemAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem item, string checkoutId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> response;
			var client = Mozu.Api.Clients.Commerce.Checkouts.OrderItemClient.AddCheckoutItemClient( item,  checkoutId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="destinationId"></param>
		/// <param name="itemId"></param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var checkout = await orderitem.UpdateItemDestinationAsync( checkoutId,  itemId,  destinationId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> UpdateItemDestinationAsync(string checkoutId, string itemId, string destinationId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> response;
			var client = Mozu.Api.Clients.Commerce.Checkouts.OrderItemClient.UpdateItemDestinationClient( checkoutId,  itemId,  destinationId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="itemId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var checkout = await orderitem.DeleteCheckoutItemAsync( checkoutId,  itemId);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> DeleteCheckoutItemAsync(string checkoutId, string itemId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> response;
			var client = Mozu.Api.Clients.Commerce.Checkouts.OrderItemClient.DeleteCheckoutItemClient( checkoutId,  itemId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


