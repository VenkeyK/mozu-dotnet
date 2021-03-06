
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Discounts
{
	/// <summary>
	/// Retrieves and modifies the products, categories, and shipping methods eligible for discounts in the form of a fixed dollar amount, percentage off a product price, or free shipping.
	/// </summary>
	public partial class DiscountTargetResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public DiscountTargetResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public DiscountTargetResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new DiscountTargetResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public DiscountTargetResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountTarget"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discounttarget = new DiscountTarget();
		///   var discountTarget = await discounttarget.GetDiscountTargetAsync(_dataViewMode,  discountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> GetDiscountTargetAsync(int discountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.GetDiscountTargetClient(_dataViewMode,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="discountTarget">Properties of the target to which the discount applies, such as the type of discount and which products, categories, or shipping methods are eligible for the discount and the properties of this discount target.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountTarget"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discounttarget = new DiscountTarget();
		///   var discountTarget = await discounttarget.UpdateDiscountTargetAsync( discountTarget,  discountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> UpdateDiscountTargetAsync(Mozu.Api.Contracts.ProductAdmin.DiscountTarget discountTarget, int discountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.UpdateDiscountTargetClient( discountTarget,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


