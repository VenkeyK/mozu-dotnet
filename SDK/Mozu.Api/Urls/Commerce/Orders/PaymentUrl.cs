
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

namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class PaymentUrl 
	{

		/// <summary>
        /// Get Resource Url for GetPayments
        /// </summary>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPaymentsUrl(string orderId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/payments/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAvailablePaymentActions
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the payment.</param>
        /// <param name="paymentId">Unique identifer of the payment for which to retrieve available actions.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailablePaymentActionsUrl(string orderId, string paymentId)
		{
			var url = "/api/commerce/orders/{orderId}/payments/{paymentId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "paymentId", paymentId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPayment
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the payment transaction.</param>
        /// <param name="paymentId">Unique identifier of the payment transaction submitted for the order.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPaymentUrl(string orderId, string paymentId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/payments/{paymentId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "paymentId", paymentId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for PerformPaymentAction
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the payment.</param>
        /// <param name="paymentId">Unique identifer of the payment for which to perform the action.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl PerformPaymentActionUrl(string orderId, string paymentId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/payments/{paymentId}/actions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "paymentId", paymentId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for CreatePaymentAction
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for which to apply the payment.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreatePaymentActionUrl(string orderId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/payments/actions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						
	}
}
