
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
		///	The authentication information associated with a customer account. The data includes the account properties such as the name, username, authorization access, and email address, the required password to match, and indicates if the account was imported from a third party resource. 
		///
		public class CustomerAccountAndAuthInfo
		{
			///
			///The unique identifier of the customer account.
			///
			public CustomerAccount Account { get; set; }

			///
			///Mozu.Customer.Contracts.CustomerAccountAndAuthInfo externalPassword ApiTypeMember DOCUMENT_HERE 
			///
			public string ExternalPassword { get; set; }

			///
			///Indicates if this object/data was imported from an outside source such as a data import or synchronization via an app or service. If true, this data was originally imported into Mozu and accessible through your store database. Examples of imported objects/data include orders and customer accounts.
			///
			public bool IsImport { get; set; }

			///
			///The saved password for the customer account. 
			///
			public string Password { get; set; }

		}

}