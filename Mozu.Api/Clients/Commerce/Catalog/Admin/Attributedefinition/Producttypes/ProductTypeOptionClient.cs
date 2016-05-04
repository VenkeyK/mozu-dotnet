
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes
{
	/// <summary>
	/// Use the Options subresource to define how an option attribute is used for a specific product type. Product attribute definitions are unique for each associated product type.
	/// </summary>
	public partial class ProductTypeOptionClient 	{
		
		/// <summary>
		/// Retrieves a list of option product attributes defined for the specified product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOptions(dataViewMode,  productTypeId);
		///   var attributeInProductTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> GetOptionsClient(DataViewMode dataViewMode, int productTypeId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeOptionUrl.GetOptionsUrl(productTypeId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of an option attribute defined for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOption(dataViewMode,  productTypeId,  attributeFQN,  responseFields);
		///   var attributeInProductTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> GetOptionClient(DataViewMode dataViewMode, int productTypeId, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeOptionUrl.GetOptionUrl(productTypeId, attributeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Assigns an option attribute to the product type based on the information supplied in the request.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">Properties of an attribute definition associated with a specific product type. When an attribute is applied to a product type, each product of that type maintains the same set of attributes.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddOption(dataViewMode,  attributeInProductType,  productTypeId,  responseFields);
		///   var attributeInProductTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> AddOptionClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeOptionUrl.AddOptionUrl(productTypeId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>(attributeInProductType)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates an option attribute definition for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">Properties of an attribute definition associated with a specific product type. When an attribute is applied to a product type, each product of that type maintains the same set of attributes.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOption(dataViewMode,  attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
		///   var attributeInProductTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> UpdateOptionClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeOptionUrl.UpdateOptionUrl(productTypeId, attributeFQN, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>(attributeInProductType)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Removes an option attribute definition for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOption(dataViewMode,  productTypeId,  attributeFQN);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteOptionClient(DataViewMode dataViewMode, int productTypeId, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeOptionUrl.DeleteOptionUrl(productTypeId, attributeFQN);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


