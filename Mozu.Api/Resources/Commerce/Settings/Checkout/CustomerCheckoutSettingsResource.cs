
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

namespace Mozu.Api.Resources.Commerce.Settings.Checkout
{
	/// <summary>
	/// Use the Customer Checkout Settings resource to define login settings that apply when shoppers proceed to checkout.
	/// </summary>
	public partial class CustomerCheckoutSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerCheckoutSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerCheckoutSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerCheckoutSettingsResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercheckoutsettings = new CustomerCheckoutSettings();
		///   var customerCheckoutSettings = await customercheckoutsettings.GetCustomerCheckoutSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> GetCustomerCheckoutSettingsAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.CustomerCheckoutSettingsClient.GetCustomerCheckoutSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="customerCheckoutSettings">The properties of the customer checkout settings such as whether shoppers must be logged in.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercheckoutsettings = new CustomerCheckoutSettings();
		///   var customerCheckoutSettings = await customercheckoutsettings.UpdateCustomerCheckoutSettingsAsync( customerCheckoutSettings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> UpdateCustomerCheckoutSettingsAsync(Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings customerCheckoutSettings, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.CustomerCheckoutSettingsClient.UpdateCustomerCheckoutSettingsClient( customerCheckoutSettings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


