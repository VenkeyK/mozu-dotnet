
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Couponsets
{
	/// <summary>
	/// Use the Coupons subresource to manage coupons within manual coupon sets.
	/// </summary>
	public partial class CouponResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CouponResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CouponResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CouponResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="couponSetCode"></param>
		/// <param name="includeCounts"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Coupon"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var coupon = new Coupon();
		///   var coupon = await coupon.GetCouponAsync( couponSetCode,  couponCode,  includeCounts,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Coupon> GetCouponAsync(string couponSetCode, string couponCode, bool? includeCounts =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Coupon> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.GetCouponClient( couponSetCode,  couponCode,  includeCounts,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponSetCode"></param>
		/// <param name="filter"></param>
		/// <param name="includeCounts"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.CouponCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var coupon = new Coupon();
		///   var couponCollection = await coupon.GetCouponsAsync( couponSetCode,  startIndex,  pageSize,  sortBy,  filter,  includeCounts,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.CouponCollection> GetCouponsAsync(string couponSetCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, bool? includeCounts =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.GetCouponsClient( couponSetCode,  startIndex,  pageSize,  sortBy,  filter,  includeCounts,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponSetCode"></param>
		/// <param name="coupons"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var coupon = new Coupon();
		///   await coupon.AddCouponsAsync( coupons,  couponSetCode);
		/// </code>
		/// </example>
		public virtual async Task AddCouponsAsync(List<Mozu.Api.Contracts.ProductAdmin.Coupon> coupons, string couponSetCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.AddCouponsClient( coupons,  couponSetCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponSetCode"></param>
		/// <param name="couponCodes"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var coupon = new Coupon();
		///   await coupon.DeleteCouponsAsync( couponCodes,  couponSetCode);
		/// </code>
		/// </example>
		public virtual async Task DeleteCouponsAsync(List<string> couponCodes, string couponSetCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.DeleteCouponsClient( couponCodes,  couponSetCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="couponSetCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var coupon = new Coupon();
		///   await coupon.DeleteCouponAsync( couponSetCode,  couponCode);
		/// </code>
		/// </example>
		public virtual async Task DeleteCouponAsync(string couponSetCode, string couponCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.DeleteCouponClient( couponSetCode,  couponCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


