
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
			return new DiscountTargetResource(_apiContext.CloneWith(contextModification));
		}

		public DiscountTargetResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves the discount target, that is which products, categories, or shipping methods are eligible for the discount.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountTarget"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discounttarget = new DiscountTarget();
		///   var discountTarget = discounttarget.GetDiscountTarget(_dataViewMode,  discountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.DiscountTarget GetDiscountTarget(int discountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.GetDiscountTargetClient(_dataViewMode,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> GetDiscountTargetAsync(int discountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.GetDiscountTargetClient(_dataViewMode,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Modifies properties of the discount target, for example, the dollar amount, or precentage off the price.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="discountTarget">Properties of the discount target to modify. Required properties: Target.Type. Any unspecified properties are set to null and boolean variables to false.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountTarget"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discounttarget = new DiscountTarget();
		///   var discountTarget = discounttarget.UpdateDiscountTarget( discountTarget,  discountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.DiscountTarget UpdateDiscountTarget(Mozu.Api.Contracts.ProductAdmin.DiscountTarget discountTarget, int discountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.UpdateDiscountTargetClient( discountTarget,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> UpdateDiscountTargetAsync(Mozu.Api.Contracts.ProductAdmin.DiscountTarget discountTarget, int discountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.UpdateDiscountTargetClient( discountTarget,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}

