
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
		///	Contains a capture request
		///
		public class CaptureRequest
		{
			///
			///Contains information not in the object allowing flexibility.
			///
			public object AdditionalData { get; set; }

			///
			///The amount to capture.
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
			///The customer information for the shopper.
			///
			public CustomerInformation Shopper { get; set; }

		}

}