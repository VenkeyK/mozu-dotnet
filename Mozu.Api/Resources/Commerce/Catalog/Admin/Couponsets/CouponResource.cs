
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Couponsets
{
	/// <summary>
	/// 
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
		///   var coupon = coupon.GetCoupon( couponSetCode,  couponCode,  includeCounts,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Coupon GetCoupon(string couponSetCode, string couponCode, bool? includeCounts =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Coupon> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.GetCouponClient( couponSetCode,  couponCode,  includeCounts,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

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
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Coupon> GetCouponAsync(string couponSetCode, string couponCode, bool? includeCounts =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Coupon> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.GetCouponClient( couponSetCode,  couponCode,  includeCounts,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
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
		///   var couponCollection = coupon.GetCoupons( couponSetCode,  startIndex,  pageSize,  sortBy,  filter,  includeCounts,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.CouponCollection GetCoupons(string couponSetCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, bool? includeCounts =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.GetCouponsClient( couponSetCode,  startIndex,  pageSize,  sortBy,  filter,  includeCounts,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

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
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.CouponCollection> GetCouponsAsync(string couponSetCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, bool? includeCounts =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.GetCouponsClient( couponSetCode,  startIndex,  pageSize,  sortBy,  filter,  includeCounts,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
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
		///   coupon.AddCoupons( coupons,  couponSetCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void AddCoupons(List<Mozu.Api.Contracts.ProductAdmin.Coupon> coupons, string couponSetCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.AddCouponsClient( coupons,  couponSetCode);
			client.WithContext(_apiContext);
			response = client.Execute();

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
		public virtual async Task AddCouponsAsync(List<Mozu.Api.Contracts.ProductAdmin.Coupon> coupons, string couponSetCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.AddCouponsClient( coupons,  couponSetCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

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
		///   coupon.DeleteCoupons( couponCodes,  couponSetCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteCoupons(List<string> couponCodes, string couponSetCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.DeleteCouponsClient( couponCodes,  couponSetCode);
			client.WithContext(_apiContext);
			response = client.Execute();

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
		public virtual async Task DeleteCouponsAsync(List<string> couponCodes, string couponSetCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.DeleteCouponsClient( couponCodes,  couponSetCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

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
		///   coupon.DeleteCoupon( couponSetCode,  couponCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteCoupon(string couponSetCode, string couponCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.DeleteCouponClient( couponSetCode,  couponCode);
			client.WithContext(_apiContext);
			response = client.Execute();

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
		public virtual async Task DeleteCouponAsync(string couponSetCode, string couponCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Couponsets.CouponClient.DeleteCouponClient( couponSetCode,  couponCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


