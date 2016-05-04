
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
		///	The product attribute details common between all attribute types - properties, options, and extras.
		///
		public class AttributeDetail
		{
			///
			///Indicates whether the attribute should be able to be used in filters, facets, and sorting on the public storefront.
			///
			public bool AllowFilteringAndSortingInStorefront { get; set; }

			///
			///The data type of the source product property, typically of type Bool, DateTime, Number, or String.
			///
			public string DataType { get; set; }

			///
			///Unique sequence of the attribute for its data type.
			///
			public int DataTypeSequence { get; set; }

			///
			///The localized description in text for the object, displayed per the locale code. For example, descriptions are used for product descriptions, attributes, and pre-authorization transaction types.
			///
			public string Description { get; set; }

			///
			///Defines the intended display of this attribute in the storefront. Options include Drop Down, Image Picker, and Radio Buttons.
			///
			public string DisplayIntention { get; set; }

			///
			///The type of input selection used to define a value for the attribute, including Yes/No, Date, DateTime, List, TextBox, or TextArea.
			///
			public string InputType { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///Indicates if the attribute value is searchable on the public storefront.
			///
			public bool SearchableInStorefront { get; set; }

			///
			///Indicates what kind of values search queries and returns. If true, the system indexes the display value of string attributes instead of the canonical value for searching. Always use the canonical value for filtering. This does not apply for non-string attributes.
			///
			public bool SearchDisplayValue { get; set; }

			///
			///The usage type of the product attribute, which is property, option, or extra.
			///
			public string UsageType { get; set; }

			///
			///Properties used when validating a value entered for an object, including extensible attributes, products attributes, and database entries.
			///
			public AttributeValidation Validation { get; set; }

			///
			///An attribute value type is either predefined vocabulary by the admin during attribute set up or user-defined with an appropriate type (AdminEntered or ShopperEntered depending on the user). These types are used by products and attributes. The difference between predefined values versus manually entered values is such that the first choice is a set of options to choose from. AdminEntered and ShopperEntered are values that are entered rather than system-supplied and are not stored in the database, but captured during a live commerce operations such as during an order.
			///
			public string ValueType { get; set; }

		}

}