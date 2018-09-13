
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Storefront
{
	public partial class ProductUrl 
	{

		/// <summary>
        /// Get Resource Url for GetProducts
        /// </summary>
        /// <param name="cursorMark">In your first deep paged request, set this parameter to . Then, in all subsequent requests, set this parameter to the subsequent values of  that's returned in each response to continue paging through the results. Continue this pattern until  is null, which signifies the end of the paged results.</param>
        /// <param name="defaultSort"></param>
        /// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
        /// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="responseOptions">Options you can specify for the response. This parameter is null by default.You can primarily use this parameter to return volume price band information in product details, which you can then display on category pages and search results depanding on your theme configuration. To return volume price band information, set this parameter to .</param>
        /// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductsUrl(string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseOptions =  null, string cursorMark =  null, string defaultSort =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/?filter={filter}&startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&responseOptions={responseOptions}&cursorMark={cursorMark}&defaultSort={defaultSort}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "cursorMark", cursorMark);
			mozuUrl.FormatUrl( "defaultSort", defaultSort);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "responseOptions", responseOptions);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductInventory
        /// </summary>
        /// <param name="locationCodes">Array of location codes for which to retrieve product inventory information.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInventoryUrl(string productCode, string locationCodes =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/locationinventory?locationCodes={locationCodes}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCodes", locationCodes);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProduct
        /// </summary>
        /// <param name="acceptVariantProductCode">Specifies whether to accept a product variant's code as the .When you set this parameter to , you can pass in a product variant's code in the GetProduct call to retrieve the product variant details that are associated with the base product.</param>
        /// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="purchaseLocation">The location where the order item(s) was purchased.</param>
        /// <param name="quantity">The number of cart items in the shopper's active cart.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
        /// <param name="supressOutOfStock404">Specifies whether to supress the 404 error when the product is out of stock.</param>
        /// <param name="variationProductCode">Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductUrl(string productCode, string variationProductCode =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, bool? supressOutOfStock404 =  null, int? quantity =  null, bool? acceptVariantProductCode =  null, string purchaseLocation =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}?variationProductCode={variationProductCode}&allowInactive={allowInactive}&skipInventoryCheck={skipInventoryCheck}&supressOutOfStock404={supressOutOfStock404}&quantity={quantity}&acceptVariantProductCode={acceptVariantProductCode}&purchaseLocation={purchaseLocation}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "acceptVariantProductCode", acceptVariantProductCode);
			mozuUrl.FormatUrl( "allowInactive", allowInactive);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "purchaseLocation", purchaseLocation);
			mozuUrl.FormatUrl( "quantity", quantity);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			mozuUrl.FormatUrl( "supressOutOfStock404", supressOutOfStock404);
			mozuUrl.FormatUrl( "variationProductCode", variationProductCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductForIndexing
        /// </summary>
        /// <param name="lastModifiedDate">The date when the product was last updated.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="productVersion">The product version.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductForIndexingUrl(string productCode, long? productVersion =  null, DateTime? lastModifiedDate =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/indexing/{productCode}?productVersion={productVersion}&lastModifiedDate={lastModifiedDate}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "lastModifiedDate", lastModifiedDate);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "productVersion", productVersion);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for ConfiguredProduct
        /// </summary>
        /// <param name="includeOptionDetails">If true, the response returns details about the product. If false, returns a product summary such as the product name, price, and sale price.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="purchaseLocation">The location where the order item(s) was purchased.</param>
        /// <param name="quantity">The number of cart items in the shopper's active cart.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ConfiguredProductUrl(string productCode, bool? includeOptionDetails =  null, bool? skipInventoryCheck =  null, int? quantity =  null, string purchaseLocation =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/configure?includeOptionDetails={includeOptionDetails}&skipInventoryCheck={skipInventoryCheck}&quantity={quantity}&purchaseLocation={purchaseLocation}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "includeOptionDetails", includeOptionDetails);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "purchaseLocation", purchaseLocation);
			mozuUrl.FormatUrl( "quantity", quantity);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ValidateProduct
        /// </summary>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="purchaseLocation">The location where the order item(s) was purchased.</param>
        /// <param name="quantity">The number of cart items in the shopper's active cart.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="skipDefaults">Normally, product validation applies default extras to products that do not have options specified. If , product validation does not apply default extras to products.</param>
        /// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ValidateProductUrl(string productCode, bool? skipInventoryCheck =  null, int? quantity =  null, bool? skipDefaults =  null, string purchaseLocation =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/validate?skipInventoryCheck={skipInventoryCheck}&quantity={quantity}&skipDefaults={skipDefaults}&purchaseLocation={purchaseLocation}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "purchaseLocation", purchaseLocation);
			mozuUrl.FormatUrl( "quantity", quantity);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "skipDefaults", skipDefaults);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ValidateDiscounts
        /// </summary>
        /// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
        /// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
        /// <param name="variationProductCode">Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ValidateDiscountsUrl(string productCode, string variationProductCode =  null, int? customerAccountId =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/validateDiscounts?variationProductCode={variationProductCode}&customerAccountId={customerAccountId}&allowInactive={allowInactive}&skipInventoryCheck={skipInventoryCheck}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "allowInactive", allowInactive);
			mozuUrl.FormatUrl( "customerAccountId", customerAccountId);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			mozuUrl.FormatUrl( "variationProductCode", variationProductCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductCosts
        /// </summary>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductCostsUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/costs?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductInventories
        /// </summary>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInventoriesUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/locationinventory?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						
	}
}

