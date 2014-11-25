
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
		///	Properties of an event the system creates each time a create, read, update, or delete operation is performed.
		///
		public class Event
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The unique identifier of the catalog of products used by a site.
			///
			public int? CatalogId { get; set; }

			///
			///The unique identifier of the API request associated with the event action, which might contain multiple actions.
			///
			public string CorrelationId { get; set; }

			///
			///The unique identifier of the entity that caused the event. For example, if the event is "product.created", the entity ID value represents the product code of the product that was created.
			///
			public string EntityId { get; set; }

			public List<EventExtendedProperty> ExtendedProperties { get; set; }

			///
			///The unique identifier of the event.
			///
			public string Id { get; set; }

			///
			///If true, the event record was generated as a test request for an application.
			///
			public bool? IsTest { get; set; }

			///
			///The unique identifier of the master catalog associated with the entity.
			///
			public int? MasterCatalogId { get; set; }

			public int? SiteId { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int? TenantId { get; set; }

			///
			///The type of event that was performed, such as "product.created" or "category.deleted".
			///
			public string Topic { get; set; }

		}

}