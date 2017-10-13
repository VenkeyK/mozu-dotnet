
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

namespace Mozu.Api.Resources.Platform.Applications
{
	/// <summary>
	/// Use the Authetickets for applications resource to manage authentication tickets for your apps.
	/// </summary>
	public partial class AuthTicketResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AuthTicketResource() 
		{
			_apiContext = null;
		}
		 public AuthTicketResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AuthTicketResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AuthTicketResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="appAuthInfo">The information required to authenticate third party applications against the  API.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   var authTicket = await authticket.AuthenticateAppAsync( appAuthInfo,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AppDev.AuthTicket> AuthenticateAppAsync(Mozu.Api.Contracts.AppDev.AppAuthInfo appAuthInfo, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.AuthenticateAppClient( appAuthInfo,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="authTicketRequest">Properties of the authentication ticket refresh requests, which includes the refresh token string.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   var authTicket = await authticket.RefreshAppAuthTicketAsync( authTicketRequest,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AppDev.AuthTicket> RefreshAppAuthTicketAsync(Mozu.Api.Contracts.AppDev.AuthTicketRequest authTicketRequest, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.RefreshAppAuthTicketClient( authTicketRequest,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="refreshToken">Alphanumeric string used for access tokens. This token refreshes access for accounts by generating a new developer or application account authentication ticket after an access token expires.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   await authticket.DeleteAppAuthTicketAsync( refreshToken);
		/// </code>
		/// </example>
		public virtual async Task DeleteAppAuthTicketAsync(string refreshToken, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.DeleteAppAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


