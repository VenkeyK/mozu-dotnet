
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

namespace Mozu.Api.Urls.Platform.Applications
{
	public partial class AuthTicketUrl 
	{

				/// <summary>
        /// Get Resource Url for AuthenticateApp
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AuthenticateAppUrl(string responseFields =  null)
		{
			var url = "/api/platform/applications/authtickets/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for RefreshAppAuthTicket
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RefreshAppAuthTicketUrl(string responseFields =  null)
		{
			var url = "/api/platform/applications/authtickets/refresh-ticket?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteAppAuthTicket
        /// </summary>
        /// <param name="refreshToken">Alphanumeric string used for access tokens. This token refreshes access for accounts by generating a new developer or application account authentication ticket after an access token expires.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteAppAuthTicketUrl(string refreshToken)
		{
			var url = "/api/platform/applications/authtickets/{refreshToken}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "refreshToken", refreshToken);
			return mozuUrl;
		}

		
	}
}

