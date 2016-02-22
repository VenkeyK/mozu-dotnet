
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


namespace Mozu.Api.Contracts.ShippingRuntime
{
		public class ProductSummary
		{
			public List<Category> Categories { get; set; }

			public List<ProductOption> Options { get; set; }

			///
			///Price (unit price * quantity)
			///
			public string ProductCode { get; set; }

			///
			///Product name/description
			///
			public string ProductType { get; set; }

			public List<ProductProperty> Properties { get; set; }

			///
			///The specified quantity of objects and items. This property is used for numerous object types including products, options, components within a product bundle, cart and order items, returned items, shipping line items, items in a digital product. and items associated with types and reservations.
			///
			public ItemMeasurements UnitMeasurements { get; set; }

		}

}