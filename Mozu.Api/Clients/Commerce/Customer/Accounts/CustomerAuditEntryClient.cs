
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
	/// Use the Audit Log resource to retrieve audit logs for customer accounts.
	/// </summary>
	public partial class CustomerAuditEntryClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAuditEntryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountAuditLog( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var customerAuditEntryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAuditEntryCollection> GetAccountAuditLogClient(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAuditEntryUrl.GetAccountAuditLogUrl(accountId, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAuditEntryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


