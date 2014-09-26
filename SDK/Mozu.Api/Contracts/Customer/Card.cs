
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Customer
{
		///
		///	Properties of a credit card used to submit payment for an order.
		///
		public class Card
		{
			///
			///The masked credit card number part returned from the payment gateway.
			///
			public string CardNumberPart { get; set; }

			///
			///The type of credit card, such as Visa or Amex.
			///
			public string CardType { get; set; }

			///
			///Unique identifier of the customer account contact associated with the credit card.
			///
			public int ContactId { get; set; }

			///
			///The two-digit month the credit card expires.
			///
			public short ExpireMonth { get; set; }

			///
			///The four-digit year the credit card expires.
			///
			public short ExpireYear { get; set; }

			///
			///Unique ID of the credit card for the customer account. This identifier is separate from the credit card number.
			///
			public string Id { get; set; }

			///
			///The name printed on the credit card.
			///
			public string NameOnCard { get; set; }

		}

}