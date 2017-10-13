
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

namespace Mozu.Api.Contracts.SiteSettings.Order
{
		///
		///	Settings that determine how orders are processed and order payments are authorized for the site.
		///
		public class OrderProcessingSettings
		{
			///
			///Abandoned order threshold in minutes indicates the number of minutes until a pending order is considered abandoned.
			///
			public int? AbandonedOrderThresholdInMinutes { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public string PaymentProcessingFlowType { get; set; }

			public bool UseOverridePriceToCalculateDiscounts { get; set; }

		}

}