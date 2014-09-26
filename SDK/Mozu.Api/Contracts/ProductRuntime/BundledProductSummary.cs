
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	System-supplied and read only information for component products in a product bundle.
		///
		public class BundledProductSummary
		{
			///
			///When the goodsType is DigitalCredit this value is populated to indicate the value of the credit. This is used to create store credit in the fulfillment of gift cards.
			///
			public decimal? CreditValue { get; set; }

			///
			///This is the goods type of the product. Possible values are “Physical,” and “DigitalCredit”. This comes from the productType of the product. Products are defaulted to a Physical goodsType. Gift cards have a goodsType of DigitalCredit.
			///
			public string GoodsType { get; set; }

			///
			///If true, the component product of the bundle should not ship in a package with the rest of the product bundle, and should ship in a package by itself. System-supplied and read only.
			///
			public bool? IsPackagedStandAlone { get; set; }

			///
			///BundledProducts result from a static bundle or are dynamically added as a result of the shopper selecting products as extras. When the bundled item is dynamic, it includes the attribute's fully qualified name of the extra that it came from. When optionAttributeFQN is null, the bundled item was statically defined, when not null, the item came from an extra selection.
			///
			public string OptionAttributeFQN { get; set; }

			///
			///Properties of a value associated with a product option attribute.
			///
			public object OptionValue { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			///
			///The read-only name of the component in the bundled product.
			///
			public string ProductName { get; set; }

			///
			///The short description defined for the component in a bundled product. System-supplied and read only.
			///
			public string ProductShortDescription { get; set; }

			public string ProductType { get; set; }

			///
			///The quantity of a component product in its product bundle.
			///
			public int Quantity { get; set; }

			///
			///This contains the inventory information about bundled products. If it manages stock, it specifies what the out of stock behavior is.
			///
			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///Dimensions of the packaged product.
			///
			public PackageMeasurements Measurements { get; set; }

		}

}