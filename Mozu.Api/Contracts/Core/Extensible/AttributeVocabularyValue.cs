
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Core.Extensible
{
		///
		///	Properties of a vocabulary value defined for an extensible attribute.
		///
		public class AttributeVocabularyValue
		{
			public AttributeValueLocalizedContent Content { get; set; }

			///
			///Indicates if the object is hidden or breaks inheritance, primarily used by facets, products, and attribute vocabulary values. For example, if true, the attribute vocabulary value does not appear in the list when defining a value for an attribute.
			///
			public bool? IsHidden { get; set; }

			public int? Sequence { get; set; }

			public string Value { get; set; }

		}

}