
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

namespace Mozu.Api.Resources.Commerce.Shipping.Admin.Profiles
{
	/// <summary>
	/// Use the ShippingInclusionRules sub-resource to manage your shipping inclusion rules that are associated with a specific shipping profile.
	/// </summary>
	public partial class ShippingInclusionRuleResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ShippingInclusionRuleResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ShippingInclusionRuleResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ShippingInclusionRuleResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var shippinginclusionrule = new ShippingInclusionRule();
		///   var shippingInclusionRule = await shippinginclusionrule.GetShippingInclusionRuleAsync( profilecode,  id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule> GetShippingInclusionRuleAsync(string profilecode, string id, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingInclusionRuleClient.GetShippingInclusionRuleClient( profilecode,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var shippinginclusionrule = new ShippingInclusionRule();
		///   var shippingInclusionRuleCollection = await shippinginclusionrule.GetShippingInclusionRulesAsync( profilecode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRuleCollection> GetShippingInclusionRulesAsync(string profilecode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingInclusionRuleClient.GetShippingInclusionRulesClient( profilecode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="rule">The details of the new shipping inclusion rule.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var shippinginclusionrule = new ShippingInclusionRule();
		///   var shippingInclusionRule = await shippinginclusionrule.CreateShippingInclusionRuleAsync( rule,  profilecode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule> CreateShippingInclusionRuleAsync(Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule rule, string profilecode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingInclusionRuleClient.CreateShippingInclusionRuleClient( rule,  profilecode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="rule">The updated details of the shipping inclusion rule.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var shippinginclusionrule = new ShippingInclusionRule();
		///   var shippingInclusionRule = await shippinginclusionrule.UpdateShippingInclusionRuleAsync( rule,  profilecode,  id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule> UpdateShippingInclusionRuleAsync(Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule rule, string profilecode, string id, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingInclusionRule> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingInclusionRuleClient.UpdateShippingInclusionRuleClient( rule,  profilecode,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="profilecode">The unique, user-defined code of the profile with which the shipping inclusion rule is associated.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var shippinginclusionrule = new ShippingInclusionRule();
		///   await shippinginclusionrule.DeleteShippingInclusionRuleAsync( profilecode,  id);
		/// </code>
		/// </example>
		public virtual async Task DeleteShippingInclusionRuleAsync(string profilecode, string id, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingInclusionRuleClient.DeleteShippingInclusionRuleClient( profilecode,  id);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


