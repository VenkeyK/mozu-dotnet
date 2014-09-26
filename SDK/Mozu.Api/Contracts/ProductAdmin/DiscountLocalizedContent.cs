
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	The container for the language-specific name of the discount. A container exists for each supported language (LocaleCode). This parameter enables you to display the discount name in multiple languages yet manage it as a single discount internally.
		///
		public class DiscountLocalizedContent
		{
			///
			///The localizable, shopper-facing description defined for the discount.
			///
			public string FriendlyDescription { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///The localizable name of the discount.
			///
			public string Name { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

		}

}