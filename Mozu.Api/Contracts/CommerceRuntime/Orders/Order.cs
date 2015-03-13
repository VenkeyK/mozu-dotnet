
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

using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.CommerceRuntime.Discounts;
using Mozu.Api.Contracts.CommerceRuntime.Fulfillment;
using Mozu.Api.Contracts.CommerceRuntime.Payments;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Orders
{
		///
		///	Properties of an order, including its components.
		///
		public class Order
		{
			///
			///The date and time the order was accepted by the tenant.
			///
			public DateTime? AcceptedDate { get; set; }

			///
			///Indicates if the customer account is opted to receive marketing materials. If true, the customer account is opted in for receiving the content. 
			///
			public bool? AcceptsMarketing { get; set; }

			///
			///Properties of an ad-hoc price adjustment for an order.
			///
			public Adjustment Adjustment { get; set; }

			///
			///The amount of the order the shopper can receive in the event of a return. This amount represents the amount captured at the time the order was submitted, not when the order was returned.
			///
			public decimal AmountAvailableForRefund { get; set; }

			///
			///The total amount of the order not currently associated with a payment. The shopper must create one or more payments to satisfy this amount before the order can be fully paid.
			///
			public decimal AmountRemainingForPayment { get; set; }

			///
			///Collection of attributes that may be paged list or a list, depending on the usage per object and API type. 
			///
			public List<OrderAttribute> Attributes { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Available actions you can complete for an order. These actions may differ depending on the status of the order, such as actions required to enter a payment, return of a package, and fulfillment of a shipment.
			///
			public List<string> AvailableActions { get; set; }

			///
			///Properties for the customer's billing information associated with an order or specific payment.
			///
			public BillingInfo BillingInfo { get; set; }

			///
			///Date when the order was cancelled. System-supplied and read-only.
			///
			public DateTime? CancelledDate { get; set; }

			///
			///Collection (list or paged) of change messages logged for each modification made by a shopper to their carts, wishlists, orders, package, payment, pickup, and returns. Change log messages are system-supplied based on shopper actions and read only.
			///
			public List<ChangeMessage> ChangeMessages { get; set; }

			///
			///Code that identifies the channel associated with the site for the shopper's created shopping cart, order, and return.
			///
			public string ChannelCode { get; set; }

			///
			///Date when the order was closed. Closed order is an order that has been processed and the items shipped. System-supplied and read-only.
			///
			public DateTime? ClosedDate { get; set; }

			///
			///Array list of coupon codes associated with a shopping cart and the associated order. These codes are entered by a shopper when proceeding to checkout. 
			///
			public List<string> CouponCodes { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///Unique identifer of the customer account. This ID is used to associate numerous types of data and object with the customer account, including orders, returns, wish lists, and in-store credit.
			///
			public int? CustomerAccountId { get; set; }

			///
			///The type of customer interaction used to create this shopping cart. Possible values are Website, Call, Store, or Unknown.
			///
			public string CustomerInteractionType { get; set; }

			///
			///The tax identification number (TIN) of the customer who submitted the order. If the customer who submitted the order has a customer account defined for the tenant, the system sets this value when the order is submitted.
			///
			public string CustomerTaxId { get; set; }

			public List<KeyValue> Data { get; set; }

			///
			///Specifies the fulfillment of digital packages associated with this order.
			///
			public List<DigitalPackage> DigitalPackages { get; set; }

			///
			///The aggregate total for all items in the cart, including costs associated with shopper-defined options or extras and any applied discounts.
			///
			public decimal? DiscountedSubtotal { get; set; }

			///
			///The subtotal of the cart, order, and wishlist items, including any applied discount calculations. Wishlist subtotals may change depending on the length of time, available discounts, and stock amounts of products at the time of review by shoppers.
			///
			public decimal? DiscountedTotal { get; set; }

			///
			///Estimated amount of discounts applied to all items in the carts and orders. System-supplied and read-only. This value will be available at the wish list, cart item, order item, and wish list item level at a later time.
			///
			public decimal? DiscountTotal { get; set; }

			///
			///The email address of the specified user or the email address associated with the specified entity.
			///
			public string Email { get; set; }

			///
			///Date and time in UTC format when a discount, credit, wish list, or cart expires. An expired discount no longer can be redeemed. An expired wish list is no longer available. An expired credit can no longer be redeemed for a purchase. Acart becomes inactive and expired based on a system-calculated interval. For example, if an anonymous shopper has 14 days of inactivity, the cart is considered abandoned after that period of inactivity. System-supplied and read-only.
			///
			public DateTime? ExpirationDate { get; set; }

			public List<ExtendedProperty> ExtendedProperties { get; set; }

			///
			///Unique identifier used by an external program to identify a Mozu order, customer account, or wish list.
			///
			public string ExternalId { get; set; }

			///
			///The monetary sum of all fees incurred in the cart, order, line item in a cart, or line item in an order. This value is not calculated for wish lists at this time.
			///
			public decimal? FeeTotal { get; set; }

			///
			///Properties of the information required to fulfill the cart, order, or wish list. Shoppers can fulfill ordered items by using in-store pickup or direct shipping.
			///
			public FulfillmentInfo FulfillmentInfo { get; set; }

			///
			///The current fulfillment status of the order, which is "Fulfilled," "NotFulfilled," or "PartiallyFulfilled." The order is considered fulfilled when all packages are shipped or all pickups are picked up.
			///
			public string FulfillmentStatus { get; set; }

			///
			///The combined price for all handling costs calculated together for shipped orders, not for digital or in-store pickup. This includes all handling costs per the product line items and options, excluding taxes and discounts. 
			///
			public decimal? HandlingAmount { get; set; }

			///
			///The list of historically-applied handling discounts.  The active one will have IsExcluded == false
			///
			public List<AppliedDiscount> HandlingDiscounts { get; set; }

			///
			///Handling fees for the Order as well as OrderItems (e.g. if the Order has a $5 handling fee and an OrderItem has a $2 handling fee per item quantity then the value in this property would be $9)
			///
			public decimal? HandlingSubTotal { get; set; }

			///
			///Calculated total tax amount for handling costs if the cart/order is subject to sales tax. 
			///
			public decimal? HandlingTaxTotal { get; set; }

			///
			///This total represents the handling amount value with any applied discounts.
			///
			public decimal? HandlingTotal { get; set; }

			///
			///If true, the order has a draft that may include one or more uncommitted changes to the order or its components.
			///
			public bool? HasDraft { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///The date and time an order or wish list is imported into Mozu. This is not the date and time it was created in the external application. 
			///
			public DateTime? ImportDate { get; set; }

			///
			///The list of invalid coupons the shopper attempted to enter for the cart or order. These coupons may no longer be valid or incorrectly entered.
			///
			public List<InvalidCoupon> InvalidCoupons { get; set; }

			///
			///A captured and stored IP address. IP addresses are stored for the origin location of submitted orders and the tenant domain.
			///
			public string IpAddress { get; set; }

			///
			///If true, this version of the order is a draft that might contain uncommitted changes.
			///
			public bool? IsDraft { get; set; }

			///
			///If true, the shopper can return any of the items in this order to the tenant.
			///
			public bool IsEligibleForReturns { get; set; }

			///
			///Indicates if this object/data was imported from an outside source such as a data import or synchronization via an app or service. If true, this data was originally imported into Mozu and accessible through your store database. Examples of imported objects/data include orders and customer accounts.
			///
			public bool? IsImport { get; set; }

			///
			///If true, the order is exempt from applied sales tax.
			///
			public bool? IsTaxExempt { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<OrderItem> Items { get; set; }

			///
			///The total amount of calculated tax for items, used by carts, orders, and wish lists.
			///
			public decimal? ItemTaxTotal { get; set; }

			///
			///The date in UTC Date/Time when the items in the cart were last validated against the site's product catalog. System-supplied and read-only.
			///
			public DateTime? LastValidationDate { get; set; }

			///
			///The unique, user-defined code that identifies a location. This location can be the location where the order was entered, location for newly in-stock products, and where products are returned.
			///
			public string LocationCode { get; set; }

			///
			///Paged list collection of note content for objects including customers, orders, and returns. 
			///
			public List<OrderNote> Notes { get; set; }

			///
			///List of order-level discounts projected to apply to the cart at checkout or order.
			///
			public List<AppliedDiscount> OrderDiscounts { get; set; }

			///
			///The order number that displays on the storefront which differs from the order ID.
			///
			public int? OrderNumber { get; set; }

			///
			///Identifier of the cart prior to the customer proceeding to checkout.
			///
			public string OriginalCartId { get; set; }

			///
			///Array list of physical packages shipped for a specified order.
			///
			public List<Package> Packages { get; set; }

			///
			///If this Order has a parent Order, the parent Order ID is recorded here.
			///
			public string ParentOrderId { get; set; }

			///
			///If this order was created to fulfill an item replacement as part of a return merchandise authorization (RMA), the unique identifier of the return.
			///
			public string ParentReturnId { get; set; }

			///
			///Wrapper for a collection of payments associated with an order or return. An order can include a number of payments until the full total is covered. 
			///
			public List<Payment> Payments { get; set; }

			///
			///Status of the payment for the specified order.
			///
			public string PaymentStatus { get; set; }

			///
			///Array list of the in-store pickups defined for the order.
			///
			public List<Pickup> Pickups { get; set; }

			///
			///Status of any returns associated with this order after it was completed.
			///
			public string ReturnStatus { get; set; }

			///
			///Array list of the shipments defined to fulfill items in this order using the direct ship fulfillment method.
			///
			public List<Shipment> Shipments { get; set; }

			///
			///Properties of an ad-hoc price adjustment made for an order.
			///
			public Adjustment ShippingAdjustment { get; set; }

			///
			///List of shipping discounts projected to apply to carts, orders, and wish lists and items at checkout.
			///
			public List<ShippingDiscount> ShippingDiscounts { get; set; }

			///
			///The shipping subtotal amount calculated without any applied discounts for line item and entire amounts of carts and orders. This property is not calculated for wish lists at this time.
			///
			public decimal? ShippingSubTotal { get; set; }

			///
			///The total amount of tax incurred on the shipping charges in the cart and order. This property is not calculated at this time for wish lists.
			///
			public decimal? ShippingTaxTotal { get; set; }

			///
			///The calculated total shipping amount estimated for carts or orders, including tax. This amount is not calculated for wish lists at this time.
			///
			public decimal? ShippingTotal { get; set; }

			///
			///A paged list collection of shopper notes for the order.
			///
			public ShopperNotes ShopperNotes { get; set; }

			///
			///Unique identifier of the site.
			///
			public int? SiteId { get; set; }

			///
			///The device from which the order originated in the case of offline orders.
			///
			public string SourceDevice { get; set; }

			///
			///The current status of an object. This status is specific to the object including payment (New, Authorized, Captured, Declined, Failed, Voided, Credited, CheckRequested, or RolledBack), discount (Active, Scheduled, or Expired), returns (ReturnAuthorized), tenant, package (Fulfilled or NotFulfilled), application, master and product catalogs, orders (Pending, Submitted, Processing, Pending Review, Closed, or Canceled), and order validation results (Pass, Fail, Error, or Review).
			///
			public string Status { get; set; }

			///
			///The date and time the order was submitted. System-supplied and read-only.
			///
			public DateTime? SubmittedDate { get; set; }

			///
			///Estimated amount of the cart or order without sales tax, shipping costs, and other fees. This amount is not calculated for wish lists at this time.
			///
			public decimal? Subtotal { get; set; }

			///
			///The total monetary sum of sales tax estimated for a cart or order.
			///
			public decimal? TaxTotal { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int? TenantId { get; set; }

			///
			///Total is used to indicate the monetary, estimated total amount of the cart or order, including items, sales tax, shipping costs, and other fees. Totals are not estimated for wish lists at this time.
			///
			public decimal? Total { get; set; }

			///
			///The total amount collected to date for the order.
			///
			public decimal TotalCollected { get; set; }

			///
			///This specifies the order type. This means, was this order placed online or offline? Online means shopper created the order at checkout, offline means the order was a phone order.
			///
			public string Type { get; set; }

			///
			///Response returned by an order validation capability application.
			///
			public List<OrderValidationResult> ValidationResults { get; set; }

			///
			///The current version number of the order, wish list, document list, or document type list.
			///
			public string Version { get; set; }

			///
			///Unique identifier of the customer visit in which the cart was created or last modified.
			///
			public string VisitId { get; set; }

			///
			///Unique identifier of the web session in which the cart, order, return, or wish list was created or last modified.
			///
			public string WebSessionId { get; set; }

		}

}