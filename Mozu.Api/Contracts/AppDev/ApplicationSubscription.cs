
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


namespace Mozu.Api.Contracts.AppDev
{
		///
		///	This property is not exposed in documentation.
		///
		public class ApplicationSubscription
		{
			///
			///The End Point where the event information will be sent to when the event is fired.
			///
			public string ApplicationEndPoint { get; set; }

			///
			///The unique identifier of an ApplicationVersionEvent record.
			///
			public int ApplicationSubscriptionId { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSubscription events ApiTypeMember DOCUMENT_HERE 
			///
			public List<Event> Events { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSubscription noCallback ApiTypeMember DOCUMENT_HERE 
			///
			public bool NoCallback { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSubscription packageId ApiTypeMember DOCUMENT_HERE 
			///
			public int PackageId { get; set; }

		}

}