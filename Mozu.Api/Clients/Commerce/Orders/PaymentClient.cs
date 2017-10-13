
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

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the Payments subresource to manage payment transactions for orders. Each transaction performed for an order represents an individual payment. For example, if an order totals $75.00 but the shopper has a $50.00 gift certificate, both the gift certificate transaction and the credit card transaction for the remaining $25.00 are recorded as payments for the order.
	/// </summary>
	public partial class PaymentClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayments( orderId,  responseFields);
		///   var paymentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> GetPaymentsClient(string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.GetPaymentsUrl(orderId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailablePaymentActions( orderId,  paymentId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailablePaymentActionsClient(string orderId, string paymentId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.GetAvailablePaymentActionsUrl(orderId, paymentId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.Payment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayment( orderId,  paymentId,  responseFields);
		///   var paymentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> GetPaymentClient(string orderId, string paymentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.GetPaymentUrl(orderId, paymentId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="action">Properties of the payment action performed for an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformPaymentAction( action,  orderId,  paymentId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformPaymentActionClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, string paymentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.PerformPaymentActionUrl(orderId, paymentId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="action">Properties of the payment action performed for an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePaymentAction( action,  orderId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreatePaymentActionClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.CreatePaymentActionUrl(orderId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			return mozuClient;

		}


	}

}


