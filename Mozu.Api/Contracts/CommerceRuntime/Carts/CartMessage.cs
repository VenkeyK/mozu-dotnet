
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

using Mozu.Api.Contracts.CommerceRuntime.Products;

namespace Mozu.Api.Contracts.CommerceRuntime.Carts
{
		///
		///	Mozu.CommerceRuntime.Contracts.Carts.CartMessage ApiType DOCUMENT_HERE 
		///
		public class CartMessage
		{
			///
			///The text of the change message, such as "This product is no longer available." System-supplied and read-only.
			///
			public string Message { get; set; }

			///
			///Mozu.CommerceRuntime.Contracts.Carts.CartMessage messageType ApiTypeMember DOCUMENT_HERE 
			///
			public string MessageType { get; set; }

			///
			///Mozu.CommerceRuntime.Contracts.Carts.CartMessage productsRemoved ApiTypeMember DOCUMENT_HERE 
			///
			public List<Product> ProductsRemoved { get; set; }

		}

}