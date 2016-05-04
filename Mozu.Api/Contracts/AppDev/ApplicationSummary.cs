
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.AppDev
{
		///
		///	Mozu.AppDev.Contracts.ApplicationSummary ApiType DOCUMENT_HERE 
		///
		public class ApplicationSummary
		{
			///
			///Unique identifier of an app available in your Mozu tenant or within Mozu Dev Center. This ID is unique across all apps installed, initialized, and enabled in the Mozu Admin and those in development through the Dev Center Console.
			///
			public string AppId { get; set; }

			///
			///The AppKey is a runtime type.
			///
			public string AppKey { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary applicationId ApiTypeMember DOCUMENT_HERE 
			///
			public int ApplicationId { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary applicationNamespace ApiTypeMember DOCUMENT_HERE 
			///
			public string ApplicationNamespace { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary applicationStatusId ApiTypeMember DOCUMENT_HERE 
			///
			public int ApplicationStatusId { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary applicationStatusName ApiTypeMember DOCUMENT_HERE 
			///
			public string ApplicationStatusName { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary applicationTypeId ApiTypeMember DOCUMENT_HERE 
			///
			public int ApplicationTypeId { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary applicationVersion ApiTypeMember DOCUMENT_HERE 
			///
			public AppVersion ApplicationVersion { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary appSchemeVersion ApiTypeMember DOCUMENT_HERE 
			///
			public byte AppSchemeVersion { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary hasVersions ApiTypeMember DOCUMENT_HERE 
			///
			public bool HasVersions { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///The AppKey is a runtime type. This only applies for themes that inherit from another theme.
			///
			public string ParentAppKey { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary parentName ApiTypeMember DOCUMENT_HERE 
			///
			public string ParentName { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary releasePackageId ApiTypeMember DOCUMENT_HERE 
			///
			public int ReleasePackageId { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary releasePackageName ApiTypeMember DOCUMENT_HERE 
			///
			public string ReleasePackageName { get; set; }

			///
			///Mozu.AppDev.Contracts.ApplicationSummary updateAvailable ApiTypeMember DOCUMENT_HERE 
			///
			public bool UpdateAvailable { get; set; }

			///
			///The AppKey is a runtime type. This only applies for themes that inherit from another theme. It shows the most current update available.
			///
			public string UpdateParentAppKey { get; set; }

		}

}