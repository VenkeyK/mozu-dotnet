
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
		///	Properties of a value for a product property.
		///
		public class ProductPropertyValue
		{
			public AttributeVocabularyValue AttributeVocabularyValueDetail { get; set; }

			public ProductPropertyValueLocalizedContent Content { get; set; }

			///
			///The localized content associated with the object.
			///
			public List<ProductPropertyValueLocalizedContent> LocalizedContent { get; set; }

			public object Value { get; set; }

		}

}