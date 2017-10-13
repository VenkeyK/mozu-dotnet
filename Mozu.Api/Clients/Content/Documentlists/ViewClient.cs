
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

namespace Mozu.Api.Clients.Content.Documentlists
{
	/// <summary>
	/// Properties and content for views within a site/tenant. Views provide the schema, formatting, and associated content and entities for displaying content within a site/tenant.
	/// </summary>
	public partial class ViewClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetViewDocuments( documentListName,  viewName,  filter,  sortBy,  pageSize,  startIndex,  includeInactive,  responseFields);
		///   var documentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> GetViewDocumentsClient(string documentListName, string viewName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, bool? includeInactive =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.ViewUrl.GetViewDocumentsUrl(documentListName, viewName, filter, sortBy, pageSize, startIndex, includeInactive, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


