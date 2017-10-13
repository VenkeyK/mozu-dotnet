
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

namespace Mozu.Api.Resources.Commerce.Settings
{
	/// <summary>
	/// Use the shipping subresource to manage settings for the site shipping information, such as origin address information, carrier shipping methods, shipping rate providers, and regions available for shipping.
	/// </summary>
	public partial class SiteShippingSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public SiteShippingSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public SiteShippingSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new SiteShippingSettingsResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var siteshippingsettings = new SiteShippingSettings();
		///   var siteShippingSettings = await siteshippingsettings.GetSiteShippingSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingSettings> GetSiteShippingSettingsAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.SiteShippingSettingsClient.GetSiteShippingSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


