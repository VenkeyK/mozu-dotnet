
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

using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Contracts.CommerceRuntime.Fulfillment;
using Mozu.Api.Contracts.CommerceRuntime.Payments;

namespace Mozu.Api.Contracts.CommerceRuntime.Returns
{
		///
		///	Properties of a return of one or more previously fulfilled items.
		///
		public class Return
		{
			///
			///The actions a user can perform for the return at this time.
			///
			public List<string> AvailableActions { get; set; }

			///
			///The code that identifies the channel associated with the return, which is typically the same channel associated with the order.
			///
			public string ChannelCode { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///Unique identifier of the customer account associated with the return.
			///
			public int? CustomerAccountId { get; set; }

			///
			///String that describes the customer interaction used to return an item. Possible values are Website, Store, Call, and Unknown.
			///
			public string CustomerInteractionType { get; set; }

			///
			///Unique identifier of the return.
			///
			public string Id { get; set; }

			///
			///The code that uniquely identifies the location where items were returned.
			///
			public string LocationCode { get; set; }

			///
			///The total value of the return to the merchant for accounting purposes. This total represents the combined product loss and shipping loss associated with the return.
			///
			public decimal? LossTotal { get; set; }

			///
			///If this return is associated with a previously completed order, the unique identifier of the original order.
			///
			public string OriginalOrderId { get; set; }

			///
			///The total tax amount levied on the product loss amount.
			///
			public decimal? ProductLossTaxTotal { get; set; }

			///
			///The total value of the product returned to the merchant for accounting purposes, calculated by multiplying the cost of the item by its quantity returned.
			///
			public decimal? ProductLossTotal { get; set; }

			///
			///If a refund action was performed for this return, the total amount refunded to the shopper. The refund amount can differ from the sum of the price of the returned items.
			///
			public decimal? RefundAmount { get; set; }

			///
			///A merchant-specific identifier used to sequentially order returns.
			///
			public int? ReturnNumber { get; set; }

			///
			///Unique identifier for the order created as a result of the return. If the return results in shipping a replacement item, the order includes shipment information for the replaced items. If the return results in a refund, the order includes payment transactions to credit the shopper.
			///
			public string ReturnOrderId { get; set; }

			///
			///The type of return, which is "Refund" or "Replace".
			///
			public string ReturnType { get; set; }

			///
			///The date by which a shopper must ship items associated with a return in an "awaiting items" state to the merchant.
			///
			public DateTime? RmaDeadline { get; set; }

			///
			///The total tax amount levied on the shipping loss amount.
			///
			public decimal? ShippingLossTaxTotal { get; set; }

			///
			///The total value of shipping the returned product to the merchant for accounting purposes, calculated by multiplying the shipping cost of the item by its quantity returned.
			///
			public decimal? ShippingLossTotal { get; set; }

			///
			///Unique identifier of the site.
			///
			public int? SiteId { get; set; }

			///
			///Current status of the return, such as "ReturnAuthorized".
			///
			public string Status { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int? TenantId { get; set; }

			///
			///Unique identifier of the user responsible for the return. Read only and supplied by the original order.
			///
			public string UserId { get; set; }

			///
			///The unique identifier of the customer visit associated with the return transaction.
			///
			public string VisitId { get; set; }

			///
			///Unique identifier of the web session in which the return was created or last modified, which is system-supplied and read only.
			///
			public string WebSessionId { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			public List<ChangeMessage> ChangeMessages { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<ReturnItem> Items { get; set; }

			///
			///Collection of merchant-supplied notes entered for the return.
			///
			public List<OrderNote> Notes { get; set; }

			///
			///List of packages associated with a replacement order for a return.
			///
			public List<Package> Packages { get; set; }

			///
			///Array list of payments associated with this return, if applicable.
			///
			public List<Payment> Payments { get; set; }

		}

}