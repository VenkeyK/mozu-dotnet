
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Customer.Accounts
{
	public partial class CardUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="cardId">Unique identifier of the card associated with the customer account billing contact.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountCardUrl(int accountId, string cardId, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards/{cardId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "cardId", cardId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAccountCards
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountCardsUrl(int accountId, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddAccountCardUrl(int accountId, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="cardId">Unique identifier of the credit card.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateAccountCardUrl(int accountId, string cardId, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards/{cardId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "cardId", cardId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="cardId">Unique identifier of the credit card to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteAccountCardUrl(int accountId, string cardId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards/{cardId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "cardId", cardId);
			return mozuUrl;
		}

		
	}
}

