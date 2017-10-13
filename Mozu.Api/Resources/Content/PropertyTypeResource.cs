
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

namespace Mozu.Api.Resources.Content
{
	/// <summary>
	/// Use the property types subresource to manage content properties.
	/// </summary>
	public partial class PropertyTypeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public PropertyTypeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public PropertyTypeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PropertyTypeResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public PropertyTypeResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.PropertyTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var propertytype = new PropertyType();
		///   var propertyTypeCollection = await propertytype.GetPropertyTypesAsync(_dataViewMode,  pageSize,  startIndex,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.PropertyTypeCollection> GetPropertyTypesAsync(int? pageSize =  null, int? startIndex =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.PropertyTypeCollection> response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.GetPropertyTypesClient(_dataViewMode,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="propertyTypeName">The name of the property type.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.PropertyType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var propertytype = new PropertyType();
		///   var propertyType = await propertytype.GetPropertyTypeAsync(_dataViewMode,  propertyTypeName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.PropertyType> GetPropertyTypeAsync(string propertyTypeName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.PropertyType> response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.GetPropertyTypeClient(_dataViewMode,  propertyTypeName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="propertyType">Property type available for content. Property types are like templates that can be reused.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.PropertyType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var propertytype = new PropertyType();
		///   var propertyType = await propertytype.CreatePropertyTypeAsync( propertyType,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.PropertyType> CreatePropertyTypeAsync(Mozu.Api.Contracts.Content.PropertyType propertyType, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.PropertyType> response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.CreatePropertyTypeClient( propertyType,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="propertyTypeName">The name of the property type.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="propertyType">Property type available for content. Property types are like templates that can be reused.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.PropertyType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var propertytype = new PropertyType();
		///   var propertyType = await propertytype.UpdatePropertyTypeAsync(_dataViewMode,  propertyType,  propertyTypeName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.PropertyType> UpdatePropertyTypeAsync(Mozu.Api.Contracts.Content.PropertyType propertyType, string propertyTypeName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.PropertyType> response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.UpdatePropertyTypeClient(_dataViewMode,  propertyType,  propertyTypeName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="propertyTypeName">The name of the property type.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var propertytype = new PropertyType();
		///   await propertytype.DeletePropertyTypeAsync(_dataViewMode,  propertyTypeName);
		/// </code>
		/// </example>
		public virtual async Task DeletePropertyTypeAsync(string propertyTypeName, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.DeletePropertyTypeClient(_dataViewMode,  propertyTypeName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


