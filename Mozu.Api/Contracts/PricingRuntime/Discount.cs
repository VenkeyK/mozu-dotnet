
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


namespace Mozu.Api.Contracts.PricingRuntime
{
		///
		///	Name of the discount added and applied to a shopping cart and order for a shopper's purchase.
		///
		public class Discount
		{
			public decimal Amount { get; set; }

			///
			///The type of the discount, either  (meaning the discount amount value represents a percentage off the original price),  (meaning the discount amount value represents a dollar amount off the original price),  (meaning the discount amount value is ignored because the product is free), or  (meaning the discount amount value represents the discounted price of the item).
			///
			public string AmountType { get; set; }

			public DiscountCondition Condition { get; set; }

			public int DiscountId { get; set; }

			public bool? DoesNotApplyToMultiShipToOrders { get; set; }

			public bool DoesNotApplyToProductsWithSalePrice { get; set; }

			public DateTime? ExpirationDate { get; set; }

			///
			///The localizable, shopper-facing description defined for a discount or a storefront message.
			///
			public string FriendlyDescription { get; set; }

			public List<string> IncludedPriceLists { get; set; }

			public decimal? MaxDiscountValuePerRedemption { get; set; }

			public decimal? MaximumDiscountValuePerOrder { get; set; }

			public int? MaximumRedemptionsPerOrder { get; set; }

			public int? MaximumUsesPerUser { get; set; }

			public int? MaxRedemptions { get; set; }

			public string Name { get; set; }

			public int Redemptions { get; set; }

			public bool RequiresAuthenticatedUser { get; set; }

			public string Scope { get; set; }

			public int StackingLayer { get; set; }

			public DiscountTarget Target { get; set; }

			public string Type { get; set; }

		}

}