
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
using System.Threading;

namespace Mozu.Api.Resources.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Segments resource to manage the segments that enable a client to manage groups of customers and target discounts for these segments. After a customer segment is defined, you can associate any number of customer accounts with it.
	/// </summary>
	public partial class CustomerSegmentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerSegmentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerSegmentResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerSegmentResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegmentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegmentCollection = await customersegment.GetSegmentsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerSegmentCollection> GetSegmentsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegmentCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.GetSegmentsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = await customersegment.GetSegmentAsync( id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerSegment> GetSegmentAsync(int id, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.GetSegmentClient( id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="segment">The Customer Segment object includes properties of a defined customer segment used to group customer accounts.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = await customersegment.AddSegmentAsync( segment,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerSegment> AddSegmentAsync(Mozu.Api.Contracts.Customer.CustomerSegment segment, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.AddSegmentClient( segment,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="accountIds">List of customer account IDs to add to the customer segment specified in the request.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   await customersegment.AddSegmentAccountsAsync( accountIds,  id);
		/// </code>
		/// </example>
		public virtual async Task AddSegmentAccountsAsync(List<int> accountIds, int id, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.AddSegmentAccountsClient( accountIds,  id);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="segment">The Customer Segment object includes properties of a defined customer segment used to group customer accounts.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   var customerSegment = await customersegment.UpdateSegmentAsync( segment,  id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerSegment> UpdateSegmentAsync(Mozu.Api.Contracts.Customer.CustomerSegment segment, int id, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.UpdateSegmentClient( segment,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   await customersegment.DeleteSegmentAsync( id);
		/// </code>
		/// </example>
		public virtual async Task DeleteSegmentAsync(int id, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.DeleteSegmentClient( id);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customersegment = new CustomerSegment();
		///   await customersegment.RemoveSegmentAccountAsync( id,  accountId);
		/// </code>
		/// </example>
		public virtual async Task RemoveSegmentAccountAsync(int id, int accountId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerSegmentClient.RemoveSegmentAccountClient( id,  accountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


