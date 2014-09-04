
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Event.Push.Subscriptions
{
	public partial class EventDeliverySummaryUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDeliveryAttemptSummary
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDeliveryAttemptSummaryUrl(int? id, string subscriptionId)
		{
			var url = "/api/event/push/subscriptions/{subscriptionId}/deliveryattempts/{id}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "subscriptionId", subscriptionId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDeliveryAttemptSummaries
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <param name="subscriptionId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDeliveryAttemptSummariesUrl(string filter, int? pageSize, string sortBy, int? startIndex, string subscriptionId)
		{
			var url = "/api/event/push/subscriptions/{subscriptionId}/deliveryattempts?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			mozuUrl.FormatUrl( "subscriptionId", subscriptionId);
			return mozuUrl;
		}

								
	}
}
