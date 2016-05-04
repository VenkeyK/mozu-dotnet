
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Core
{
		///
		///	Address information to supply for a contact.
		///
		public class Address
		{
			///
			///Physical or mailing address line one. Usually includes the street number and street name or it could be a P.O. Box. Max length: 200.
			///
			public string Address1 { get; set; }

			///
			///Physical or mailing address line two. Usually supplements the main street address with apartment, floor, suite, building, or unit information. Max length: 200.
			///
			public string Address2 { get; set; }

			///
			///Physical or mailing address line three. Max length: 200.
			///
			public string Address3 { get; set; }

			///
			///Physical or mailing address line four. Max length: 200.
			///
			public string Address4 { get; set; }

			///
			///The type of address, which is commercial or residential.
			///
			public string AddressType { get; set; }

			///
			///City or town for the physical or mailing address. The maximum character length is 100.
			///
			public string CityOrTown { get; set; }

			///
			///The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.
			///
			public string CountryCode { get; set; }

			///
			///Indicates if the address has been validated. If true, the address has been verified by an address validation service.
			///
			public bool? IsValidated { get; set; }

			///
			///The postal or zip code for the address. For example, a USPS-approved ZIP code standard is ZIP+4: 12345-6789. The maximum character length is 100.
			///
			public string PostalOrZipCode { get; set; }

			///
			///The two-letter geographic code representing the state for the physical or mailing address. This is currently limited to the US.
			///
			public string StateOrProvince { get; set; }

		}

}