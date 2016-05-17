
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

namespace Mozu.Api.Clients.Commerce.Customer.Accounts
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CustomerPurchaseOrderAccountClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCustomerPurchaseOrderAccount( accountId,  responseFields);
		///   var customerPurchaseOrderAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> GetCustomerPurchaseOrderAccountClient(int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountUrl.GetCustomerPurchaseOrderAccountUrl(accountId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCustomerPurchaseOrderTransactions( accountId,  startIndex,  pageSize,  sortBy,  responseFields);
		///   var purchaseOrderTransactionCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection> GetCustomerPurchaseOrderTransactionsClient(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountUrl.GetCustomerPurchaseOrderTransactionsUrl(accountId, startIndex, pageSize, sortBy, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.PurchaseOrderTransactionInternalCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCustomerPurchaseOrderTransactionsInternal( accountId,  startIndex,  pageSize,  sortBy,  responseFields);
		///   var purchaseOrderTransactionInternalCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionInternalCollection> GetCustomerPurchaseOrderTransactionsInternalClient(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountUrl.GetCustomerPurchaseOrderTransactionsInternalUrl(accountId, startIndex, pageSize, sortBy, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionInternalCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="responseFields"></param>
		/// <param name="customerPurchaseOrderAccount"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateCustomerPurchaseOrderAccount( customerPurchaseOrderAccount,  accountId,  responseFields);
		///   var customerPurchaseOrderAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> CreateCustomerPurchaseOrderAccountClient(Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount customerPurchaseOrderAccount, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountUrl.CreateCustomerPurchaseOrderAccountUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount>(customerPurchaseOrderAccount);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="responseFields"></param>
		/// <param name="purchaseOrderTransaction"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.PurchaseOrderTransaction"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePurchaseOrderTransaction( purchaseOrderTransaction,  accountId,  responseFields);
		///   var purchaseOrderTransactionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransaction> CreatePurchaseOrderTransactionClient(Mozu.Api.Contracts.Customer.PurchaseOrderTransaction purchaseOrderTransaction, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountUrl.CreatePurchaseOrderTransactionUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransaction>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.PurchaseOrderTransaction>(purchaseOrderTransaction);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="responseFields"></param>
		/// <param name="purchaseOrderTransactionInternal"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.PurchaseOrderTransactionInternal"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePurchaseOrderTransactionInternal( purchaseOrderTransactionInternal,  accountId,  responseFields);
		///   var purchaseOrderTransactionInternalClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionInternal> CreatePurchaseOrderTransactionInternalClient(Mozu.Api.Contracts.Customer.PurchaseOrderTransactionInternal purchaseOrderTransactionInternal, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountUrl.CreatePurchaseOrderTransactionInternalUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionInternal>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionInternal>(purchaseOrderTransactionInternal);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="responseFields"></param>
		/// <param name="customerPurchaseOrderAccount"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCustomerPurchaseOrderAccount( customerPurchaseOrderAccount,  accountId,  responseFields);
		///   var customerPurchaseOrderAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> UpdateCustomerPurchaseOrderAccountClient(Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount customerPurchaseOrderAccount, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountUrl.UpdateCustomerPurchaseOrderAccountUrl(accountId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount>(customerPurchaseOrderAccount);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCustomerPurchaseOrderAccount( accountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCustomerPurchaseOrderAccountClient(int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountUrl.DeleteCustomerPurchaseOrderAccountUrl(accountId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


