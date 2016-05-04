
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Event
{
		///
		///	This specifies if a tenant is associated with a subscription.
		///
		public class SubscribingTenant
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Indicates if the object or feature is active. This indicator is used for subscriptions (at the site or tenant level), customer accounts, products and variations.
			///
			public bool? IsActive { get; set; }

			///
			///This specifies the type of subscribing context, which is derived from the state of the subscription. If any subscribing sites exist; for example, a subscription that is not at the tenant level, then the value will be 'site'.
			///
			public string SubscribingContextLevelType { get; set; }

			///
			///This specifies the subscribing sites.
			///
			public List<SubscribingSite> SubscribingSites { get; set; }

			///
			///Unique identifier for the tenant.
			///
			public int? TenantId { get; set; }

		}

}