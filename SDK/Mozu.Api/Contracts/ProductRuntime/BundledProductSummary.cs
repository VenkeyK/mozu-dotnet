
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
			public decimal? CreditValue { get; set; }

			public string GoodsType { get; set; }

			///
			///If true, the component product of the bundle should not ship in a package with the rest of the product bundle, and should ship in a package by itself. System-supplied and read only.
			///
			public bool? IsPackagedStandAlone { get; set; }

			public string OptionAttributeFQN { get; set; }

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

			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///Dimensions of the packaged product.
			///
			public PackageMeasurements Measurements { get; set; }

		}

}