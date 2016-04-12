
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

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the Order Notes subresource to manage merchant-level notes associated with an active order.
	/// </summary>
	public partial class OrderNoteClient 	{
		
		/// <summary>
		/// Retrieves a list of all notes for an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrderNotes( orderId);
		///   var orderNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> GetOrderNotesClient(string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderNoteUrl.GetOrderNotesUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a specific order note.
		/// </summary>
		/// <param name="noteId">Unique identifier of the order note to retrieve.</param>
		/// <param name="orderId">Unique identifier of the order associated with the note.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrderNote( orderId,  noteId,  responseFields);
		///   var orderNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> GetOrderNoteClient(string orderId, string noteId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderNoteUrl.GetOrderNoteUrl(orderId, noteId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new merchant note for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to add a note.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="orderNote">The alphanumeric text contained in the note. The maximum length is 256 characters.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrderNote( orderNote,  orderId,  responseFields);
		///   var orderNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> CreateOrderNoteClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderNoteUrl.CreateOrderNoteUrl(orderId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>(orderNote);
			return mozuClient;

		}

		/// <summary>
		/// Updates a specific note for an order.
		/// </summary>
		/// <param name="noteId">Unique identifier of the order note.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="orderNote">The content of the order note. The maximum length is 256 characters.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrderNote( orderNote,  orderId,  noteId,  responseFields);
		///   var orderNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> UpdateOrderNoteClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, string orderId, string noteId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderNoteUrl.UpdateOrderNoteUrl(orderId, noteId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>(orderNote);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the specified order note.
		/// </summary>
		/// <param name="noteId">Unique identifier of the order note to delete.</param>
		/// <param name="orderId">Unique identifier of the order associated with the note.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOrderNote( orderId,  noteId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteOrderNoteClient(string orderId, string noteId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderNoteUrl.DeleteOrderNoteUrl(orderId, noteId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


