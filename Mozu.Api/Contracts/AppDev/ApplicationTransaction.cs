
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.AppDev
{
		public class ApplicationTransaction
		{
			public int? ApplicationEntitlementId { get; set; }

			public int ApplicationId { get; set; }

			public int ApplicationTransactionId { get; set; }

			public string IsoCurrencyCode { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public int LocaleCode { get; set; }

			public string OrderNumber { get; set; }

			public int? SiteId { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int TenantId { get; set; }

			public DateTime TransactionDate { get; set; }

			public decimal TransactionPrice { get; set; }

			public decimal TransactionTax { get; set; }

			public decimal TransactionTotal { get; set; }

		}

}