
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Resources.Event.Push.Subscriptions
{
	/// <summary>
	/// 
	/// </summary>
	public partial class EventDeliverySummaryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public EventDeliverySummaryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public EventDeliverySummaryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new EventDeliverySummaryResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// This operation method is the external/public event entity used specifically in pull/poll event scenarios.
		/// </summary>
		/// <param name="id">This parameter is the unique identifer for an event attempt delivery summary.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="subscriptionId">This operation paramenter is the unique identifer for a subscription.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Event.EventDeliverySummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var eventdeliverysummary = new EventDeliverySummary();
		///   var eventDeliverySummary = eventdeliverysummary.GetDeliveryAttemptSummary( subscriptionId,  id,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Event.EventDeliverySummary GetDeliveryAttemptSummary(string subscriptionId, int? id =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventDeliverySummary> response;
			var client = Mozu.Api.Clients.Event.Push.Subscriptions.EventDeliverySummaryClient.GetDeliveryAttemptSummaryClient( subscriptionId,  id,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Event.EventDeliverySummary> GetDeliveryAttemptSummaryAsync(string subscriptionId, int? id =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventDeliverySummary> response;
			var client = Mozu.Api.Clients.Event.Push.Subscriptions.EventDeliverySummaryClient.GetDeliveryAttemptSummaryClient( subscriptionId,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="subscriptionId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Event.EventDeliverySummaryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var eventdeliverysummary = new EventDeliverySummary();
		///   var eventDeliverySummaryCollection = eventdeliverysummary.GetDeliveryAttemptSummaries( subscriptionId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Event.EventDeliverySummaryCollection GetDeliveryAttemptSummaries(string subscriptionId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventDeliverySummaryCollection> response;
			var client = Mozu.Api.Clients.Event.Push.Subscriptions.EventDeliverySummaryClient.GetDeliveryAttemptSummariesClient( subscriptionId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Event.EventDeliverySummaryCollection> GetDeliveryAttemptSummariesAsync(string subscriptionId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventDeliverySummaryCollection> response;
			var client = Mozu.Api.Clients.Event.Push.Subscriptions.EventDeliverySummaryClient.GetDeliveryAttemptSummariesClient( subscriptionId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


