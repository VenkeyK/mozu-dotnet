
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


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of a specific product variation.
		///
		public class ProductVariation
		{
			///
			///The difference between the base weight for a product and this variation of the product, which can be a positive or negative decimal value.
			///
			public decimal? DeltaWeight { get; set; }

			///
			///Describes the types of fulfillment that are supported for this product variation. A variation can support direct ship, in-store pickup, or both. Supported fulfillment types are defined at the master catalog level. Client administrators cannot override the supported fulfillment types at the catalog level.
			///
			public List<string> FulfillmentTypesSupported { get; set; }

			///
			///If true, this variation of this product is marked available for sale.
			///
			public bool? IsActive { get; set; }

			///
			///If true, the production variation is no longer available for sale. For example, if a client stops selling all "small" shirts, all product variations with the "small" option are set to IsOrphan. System-supplied and read only.
			///
			public bool? IsOrphan { get; set; }

			///
			///The universal product code associated with the product variation. The UPC of a product is unique across all sales channels.
			///
			public string Upc { get; set; }

			///
			///If true, one or more product variations are configured for the specified product code.
			///
			public bool? VariationExists { get; set; }

			///
			///System-generated key that represents the attribute values that uniquely identify a specific product variation.
			///
			public string Variationkey { get; set; }

			///
			///Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.
			///
			public string VariationProductCode { get; set; }

			///
			///The difference between the base price for the product and this variation of the product, which can be a positive or negative decimal value. For example, if the base price for a t-shirt product is $10, but the XL variation should cost $12, the DeltaPrice value should be "2". However, if the XS variation should only cost $8, the DeltaPrice value should be "-2".
			///
			public ProductVariationDeltaPrice DeltaPrice { get; set; }

			public List<ProductVariationDeltaPrice> LocalizedDeltaPrice { get; set; }

			///
			///Wrapper for the list of option attributes configured for the product variation.
			///
			public List<ProductVariationOption> Options { get; set; }

			///
			///Supplier-defined properties assigned for the product variation.
			///
			public ProductSupplierInfo SupplierInfo { get; set; }

		}

}