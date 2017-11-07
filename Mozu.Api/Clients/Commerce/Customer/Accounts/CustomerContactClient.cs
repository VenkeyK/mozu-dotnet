
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

namespace Mozu.Api.Clients.Commerce.Customer.Accounts
{
	/// <summary>
	/// Merchants and customers can create, view, update, and delete a contact for a customer account. A customer account may have multiple contacts for billing and shipping addresses.
	/// </summary>
	public partial class CustomerContactClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="contactId">Unique identifer of the customer account contact being updated.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountContact( accountId,  contactId,  responseFields);
		///   var customerContactClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> GetAccountContactClient(int accountId, int contactId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.GetAccountContactUrl(accountId, contactId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContact>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContactCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountContacts( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var customerContactCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection> GetAccountContactsClient(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.GetAccountContactsUrl(accountId, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="contact">Contact information, including the contact's name, address, phone numbers, email addresses, and company (if supplied). Also indicates whether this is a billing, shipping, or billing and shipping contact.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountContact( contact,  accountId,  responseFields);
		///   var customerContactClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> AddAccountContactClient(Mozu.Api.Contracts.Customer.CustomerContact contact, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.AddAccountContactUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContact>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerContact>(contact);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="contactId">Unique identifer of the customer account contact being updated.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="contact">Contact information, including the contact's name, address, phone numbers, email addresses, and company (if supplied). Also indicates whether this is a billing, shipping, or billing and shipping contact.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccountContact( contact,  accountId,  contactId,  responseFields);
		///   var customerContactClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> UpdateAccountContactClient(Mozu.Api.Contracts.Customer.CustomerContact contact, int accountId, int contactId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.UpdateAccountContactUrl(accountId, contactId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContact>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerContact>(contact);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="contactList"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContactCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountContactList( contactList,  accountId,  responseFields);
		///   var customerContactCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection> AddAccountContactListClient(List<Mozu.Api.Contracts.Customer.CustomerContact> contactList, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.AddAccountContactListUrl(accountId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.Customer.CustomerContact>>(contactList);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="contactId">Unique identifer of the customer account contact being updated.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAccountContact( accountId,  contactId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAccountContactClient(int accountId, int contactId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.DeleteAccountContactUrl(accountId, contactId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


