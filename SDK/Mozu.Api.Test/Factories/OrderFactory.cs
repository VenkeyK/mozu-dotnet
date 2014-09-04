//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use the Orders resource to manage all components of order processing, payment, and fulfillment.
	/// </summary>
	public partial class OrderFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves a list of orders according to any specified filter criteria and sort options.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.GetOrders(handler : handler,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  filter :  filter,  q :  q,  qLimit :  qLimit,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<OrderCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection GetOrders(ServiceClientMessageHandler handler, 
 		 int? startIndex = null, int? pageSize = null, string sortBy = null, string filter = null, string q = null, int? qLimit = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.GetOrdersClient(
				 startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  filter :  filter,  q :  q,  qLimit :  qLimit,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Retrieves the actions available to perform for an order based on its current status.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.GetAvailableActions(handler : handler,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<string>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<string> GetAvailableActions(ServiceClientMessageHandler handler, 
 		 string orderId, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.GetAvailableActionsClient(
				 orderId :  orderId		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Retrieves an order for the purpose of splitting it into multiple taxable orders in order to fulfill the order in multiple locations.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.GetTaxableOrders(handler : handler,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<TaxableOrder>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder> GetTaxableOrders(ServiceClientMessageHandler handler, 
 		 string orderId, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.GetTaxableOrdersClient(
				 orderId :  orderId		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Retrieves the details of an order specified by the order ID.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.GetOrder(handler : handler,  orderId :  orderId,  draft :  draft,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order GetOrder(ServiceClientMessageHandler handler, 
 		 string orderId, bool? draft = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.GetOrderClient(
				 orderId :  orderId,  draft :  draft,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Creates a new order from an existing cart when the customer chooses to proceed to checkout.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.CreateOrderFromCart(handler : handler,  cartId :  cartId,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderFromCart(ServiceClientMessageHandler handler, 
 		 string cartId, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.Created, HttpStatusCode successCode = HttpStatusCode.Created)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderFromCartClient(
				 cartId :  cartId,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Creates a new order for no-cart quick-ordering scenarios.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.CreateOrder(handler : handler,  order :  order,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrder(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.Created, HttpStatusCode successCode = HttpStatusCode.Created)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderClient(
				 order :  order,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Perform the specified action for an order. The actions you can perform depend on the current status of the order.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.PerformOrderAction(handler : handler,  action :  action,  orderId :  orderId,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order PerformOrderAction(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.PerformOrderActionClient(
				 action :  action,  orderId :  orderId,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Update the properties of a discount applied to an order.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.UpdateOrderDiscount(handler : handler,  discount :  discount,  orderId :  orderId,  discountId :  discountId,  updateMode :  updateMode,  version :  version,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderDiscount(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, int discountId, string updateMode = null, string version = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderDiscountClient(
				 discount :  discount,  orderId :  orderId,  discountId :  discountId,  updateMode :  updateMode,  version :  version,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Deletes the current draft version of the order, which also deletes any uncommitted changes made to the order in draft mode.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.DeleteOrderDraft(handler : handler,  orderId :  orderId,  version :  version,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<void/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteOrderDraft(ServiceClientMessageHandler handler, 
 		string orderId, string version = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.NoContent, HttpStatusCode successCode = HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.DeleteOrderDraftClient(
				 orderId :  orderId,  version :  version		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
			}
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Updates the user ID of the shopper who placed the order to the current user.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.ChangeOrderUserId(handler : handler,  orderId :  orderId,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order ChangeOrderUserId(ServiceClientMessageHandler handler, 
 		 string orderId, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.ChangeOrderUserIdClient(
				 orderId :  orderId,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Updates the specified order when additional order information, such as shipping or billing information, is modified during the checkout process.
		/// <example> 
		///  <code> 
		/// var result = OrderFactory.UpdateOrder(handler : handler,  order :  order,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrder(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string orderId, string updateMode = null, string version = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderClient(
				 order :  order,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

