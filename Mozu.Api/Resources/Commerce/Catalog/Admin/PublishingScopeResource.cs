
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Product Publishing resource to publish or discard pending changes to product definitions in the master catalog.
	/// </summary>
	public partial class PublishingScopeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public PublishingScopeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public PublishingScopeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PublishingScopeResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public PublishingScopeResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves the details of a single PublishSet.
		/// </summary>
		/// <param name="publishSetCode">The unique identifier of the publish set.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PublishSet"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   var publishSet = publishingscope.GetPublishSet( publishSetCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PublishSet GetPublishSet(string publishSetCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PublishSet> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.GetPublishSetClient( publishSetCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a single PublishSet.
		/// </summary>
		/// <param name="publishSetCode">The unique identifier of the publish set.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PublishSet"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   var publishSet = await publishingscope.GetPublishSetAsync( publishSetCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PublishSet> GetPublishSetAsync(string publishSetCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PublishSet> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.GetPublishSetClient( publishSetCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of PublishSets including the product counts.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PublishSetCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   var publishSetCollection = publishingscope.GetPublishSets( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PublishSetCollection GetPublishSets(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PublishSetCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.GetPublishSetsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of PublishSets including the product counts.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PublishSetCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   var publishSetCollection = await publishingscope.GetPublishSetsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PublishSetCollection> GetPublishSetsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PublishSetCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.GetPublishSetsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the draft version of product changes for each product code specified in the request.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Describes the scope of the product publishing update, which can include individual product codes or all pending changes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.DiscardDrafts(_dataViewMode,  publishScope);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DiscardDrafts(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.DiscardDraftsClient(_dataViewMode,  publishScope);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the draft version of product changes for each product code specified in the request.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Describes the scope of the product publishing update, which can include individual product codes or all pending changes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   await publishingscope.DiscardDraftsAsync(_dataViewMode,  publishScope);
		/// </code>
		/// </example>
		public virtual async Task DiscardDraftsAsync(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.DiscardDraftsClient(_dataViewMode,  publishScope);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Publishes the draft version of product changes for each product code specified in the request, and changes the product publish state to "live".
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Describes the scope of the product publishing update, which can include individual product codes or all pending changes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.PublishDrafts(_dataViewMode,  publishScope);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void PublishDrafts(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.PublishDraftsClient(_dataViewMode,  publishScope);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Publishes the draft version of product changes for each product code specified in the request, and changes the product publish state to "live".
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Describes the scope of the product publishing update, which can include individual product codes or all pending changes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   await publishingscope.PublishDraftsAsync(_dataViewMode,  publishScope);
		/// </code>
		/// </example>
		public virtual async Task PublishDraftsAsync(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.PublishDraftsClient(_dataViewMode,  publishScope);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Assigns a product draft to a specified publish set.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishSet">Mozu.ProductAdmin.Contracts.PublishSet ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PublishSet"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   var publishSet = publishingscope.AssignProductsToPublishSet( publishSet,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PublishSet AssignProductsToPublishSet(Mozu.Api.Contracts.ProductAdmin.PublishSet publishSet, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PublishSet> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.AssignProductsToPublishSetClient( publishSet,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Assigns a product draft to a specified publish set.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishSet">Mozu.ProductAdmin.Contracts.PublishSet ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PublishSet"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   var publishSet = await publishingscope.AssignProductsToPublishSetAsync( publishSet,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PublishSet> AssignProductsToPublishSetAsync(Mozu.Api.Contracts.ProductAdmin.PublishSet publishSet, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PublishSet> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.AssignProductsToPublishSetClient( publishSet,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes all details about a PublishSet from the product service. If the discardDrafts param is true, it also deletes the product drafts.
		/// </summary>
		/// <param name="discardDrafts">Specifies whether to discard all the drafts assigned to the publish set when the publish set is deleted.</param>
		/// <param name="publishSetCode">The unique identifier of the publish set.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.DeletePublishSet( publishSetCode,  discardDrafts);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeletePublishSet(string publishSetCode, bool? discardDrafts =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.DeletePublishSetClient( publishSetCode,  discardDrafts);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Removes all details about a PublishSet from the product service. If the discardDrafts param is true, it also deletes the product drafts.
		/// </summary>
		/// <param name="discardDrafts">Specifies whether to discard all the drafts assigned to the publish set when the publish set is deleted.</param>
		/// <param name="publishSetCode">The unique identifier of the publish set.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   await publishingscope.DeletePublishSetAsync( publishSetCode,  discardDrafts);
		/// </code>
		/// </example>
		public virtual async Task DeletePublishSetAsync(string publishSetCode, bool? discardDrafts =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.DeletePublishSetClient( publishSetCode,  discardDrafts);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


