
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.PaymentService.Extensibility.V1
{
		///
		///	Contains an authorization request
		///
		public class GatewayAuthorizationRequest
		{
			///
			///Contains information not in the object allowing flexibility.
			///
			public object AdditionalData { get; set; }

			///
			///Contains the amount to authorize.
			///
			public decimal Amount { get; set; }

			///
			///The api version of the call.
			///
			public string ApiVersion { get; set; }

			///
			///CardInformation object containing the card information.
			///
			public CardInformation Card { get; set; }

			///
			///The AdapterContext information.
			///
			public AdapterContext Context { get; set; }

			///
			///The method name being called on the connector.
			///
			public string MethodName { get; set; }

			///
			///Indicates whether the request is pre-auth or not.
			///
			public bool PreAuth { get; set; }

			///
			///Indicates whether the request is recurring or not.
			///
			public string RecurringType { get; set; }

			///
			///The CustomerInformation for the shopper.
			///
			public CustomerInformation Shopper { get; set; }

		}

}