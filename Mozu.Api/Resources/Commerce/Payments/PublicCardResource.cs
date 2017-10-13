
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

namespace Mozu.Api.Resources.Commerce.Payments
{
	/// <summary>
	/// commerce/payments/cards related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class PublicCardResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PublicCardResource() 
		{
			_apiContext = null;
		}
		 public PublicCardResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PublicCardResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PublicCardResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="request">Mozu.PaymentService.Contracts.PublicCard ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PaymentService.Response.SyncResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   var syncResponse = await publiccard.CreateAsync( request,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> CreateAsync(Mozu.Api.Contracts.PaymentService.PublicCard request, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.CreateClient( request,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cardId">Unique identifier of the card associated with the customer account billing contact.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="request">Mozu.PaymentService.Contracts.PublicCard ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PaymentService.Response.SyncResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   var syncResponse = await publiccard.UpdateAsync( request,  cardId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> UpdateAsync(Mozu.Api.Contracts.PaymentService.PublicCard request, string cardId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.UpdateClient( request,  cardId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cardId">Unique identifier of the card associated with the customer account billing contact.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publiccard = new PublicCard();
		///   await publiccard.DeleteAsync( cardId);
		/// </code>
		/// </example>
		public virtual async Task DeleteAsync(string cardId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Payments.PublicCardClient.DeleteClient( cardId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


