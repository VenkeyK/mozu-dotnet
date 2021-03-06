
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


namespace Mozu.Api.Contracts.Core
{
		///
		///	Properties of an application's behavior.
		///
		public class Behavior
		{
			public int CategoryId { get; set; }

			public int Id { get; set; }

			public bool IsPrivate { get; set; }

			public string Name { get; set; }

			public List<int> RequiresBehaviorIds { get; set; }

			///
			///Provides a list of system roles for a specified behavior.
			///
			public List<string> SystemRoles { get; set; }

			public List<string> ValidUserTypes { get; set; }

		}

}