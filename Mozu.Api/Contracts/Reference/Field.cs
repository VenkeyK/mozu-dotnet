
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


namespace Mozu.Api.Contracts.Reference
{
		///
		///	A property that is a wrapper for additional properties pertaining to the schema such as the type, label, any associated data, an ID, and the order of the response.
		///
		public class Field
		{
			public List<FieldData> Data { get; set; }

			public int Id { get; set; }

			public string Label { get; set; }

			public int Order { get; set; }

			public string Type { get; set; }

		}

}