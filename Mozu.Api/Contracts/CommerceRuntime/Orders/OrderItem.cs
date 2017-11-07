
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.CommerceRuntime.Discounts;
using Mozu.Api.Contracts.CommerceRuntime.Products;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Orders
{
		///
		///	The details associated with a specific item in an order.
		///
		public class OrderItem
		{
			///
			///The adjusted subtotal of the line item, including all manual adjustments, discounts, shipping charges and discounts, and duty or any other additional line item fees.
			///
			public decimal? AdjustedLineItemSubtotal { get; set; }

			public AuditInfo AuditInfo { get; set; }

			///
			///Custom data for a given vendor set within the commerce process.
			///
			public JObject Data { get; set; }

			///
			///destinationId ApiType DOCUMENT_HERE 
			///
			public string DestinationId { get; set; }

			public decimal? DiscountedTotal { get; set; }

			public decimal? DiscountTotal { get; set; }

			///
			///Duty or Tariff for this item
			///
			public decimal? DutyAmount { get; set; }

			public decimal? ExtendedTotal { get; set; }

			public decimal? FeeTotal { get; set; }

			public string FulfillmentLocationCode { get; set; }

			public string FulfillmentMethod { get; set; }

			///
			///The combined price for all handling costs calculated together for shipped orders, not for digital or in-store pickup. This includes all handling costs per the product line items and options, excluding taxes and discounts. 
			///
			public decimal? HandlingAmount { get; set; }

			public string Id { get; set; }

			public bool? IsRecurring { get; set; }

			public bool? IsTaxable { get; set; }

			public decimal? ItemTaxTotal { get; set; }

			///
			///The line id assigned to the order item. Visible only in the Admin, this is set from the Admin or in CommerceRuntime when a cart is converted to an order.
			///
			public int? LineId { get; set; }

			public string LocaleCode { get; set; }

			public string OriginalCartItemId { get; set; }

			public Product Product { get; set; }

			///
			///The applicable product discount for an associated cart, order, or wish list. 
			///
			public AppliedLineItemProductDiscount ProductDiscount { get; set; }

			public List<AppliedLineItemProductDiscount> ProductDiscounts { get; set; }

			///
			///purchaseLocation ApiType DOCUMENT_HERE 
			///
			public string PurchaseLocation { get; set; }

			public int Quantity { get; set; }

			///
			///The total shipping amount for the line item before discounts and adjustments.
			///
			public decimal? ShippingAmountBeforeDiscountsAndAdjustments { get; set; }

			public List<AppliedLineItemShippingDiscount> ShippingDiscounts { get; set; }

			public decimal? ShippingTaxTotal { get; set; }

			public decimal? ShippingTotal { get; set; }

			public decimal? Subtotal { get; set; }

			public decimal? TaxableTotal { get; set; }

			///
			///Leverage this property within a [tax Arc.js action](https://www.mozu.com/docs/arcjs/commerce-catalog-storefront-tax/commerce-catalog-storefront-tax.htm) to supplement the tax information for this item or object with custom JSON data.
			///
			public JObject TaxData { get; set; }

			public decimal? Total { get; set; }

			///
			///The total charge for the line item without any weighted order level shipping and handling charges.
			///
			public decimal? TotalWithoutWeightedShippingAndHandling { get; set; }

			///
			///The total charge for the line item with all weighted order level shipping and handling charges.
			///
			public decimal? TotalWithWeightedShippingAndHandling { get; set; }

			public CommerceUnitPrice UnitPrice { get; set; }

			///
			///The total weighted order level manual adjustment amount.
			///
			public decimal? WeightedOrderAdjustment { get; set; }

			///
			///The total weighted order level discount amount.
			///
			public decimal? WeightedOrderDiscount { get; set; }

			///
			///The total weighted order level duty charges.
			///
			public decimal? WeightedOrderDuty { get; set; }

			///
			///The weighted order handling adjustment.
			///
			public decimal? WeightedOrderHandlingAdjustment { get; set; }

			///
			///The total weighted order level handling fee amount.
			///
			public decimal? WeightedOrderHandlingFee { get; set; }

			///
			///The total weighted order handling fee discount amount.
			///
			public decimal? WeightedOrderHandlingFeeDiscount { get; set; }

			///
			///The total weighted order level handling fee tax amount.
			///
			public decimal? WeightedOrderHandlingFeeTax { get; set; }

			///
			///The total weighted order level shipping charge.
			///
			public decimal? WeightedOrderShipping { get; set; }

			///
			///The total weighted order level shipping discount amount.
			///
			public decimal? WeightedOrderShippingDiscount { get; set; }

			///
			///The total weighted order level shipping manual adjustment amount.
			///
			public decimal? WeightedOrderShippingManualAdjustment { get; set; }

			///
			///The total weighted order level shipping tax amount.
			///
			public decimal? WeightedOrderShippingTax { get; set; }

			///
			///The total weighted order level tax amount.
			///
			public decimal? WeightedOrderTax { get; set; }

		}

}