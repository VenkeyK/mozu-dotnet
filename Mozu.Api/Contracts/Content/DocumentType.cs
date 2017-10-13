
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Content
{
		///
		///	The type of documents used in the CMS such as "web_page" or "template" or "image_url".
		///
		public class DocumentType
		{
			///
			///The administrator name associated with the object/data.
			///
			public string AdminName { get; set; }

			///
			///Fully qualified name of the document type. 
			///
			public string DocumentTypeFQN { get; set; }

			///
			///The package of document lists and content documents to be installed.
			///
			public string InstallationPackage { get; set; }

			///
			///Metadata content for entities, used by document lists, document type lists, document type, views, entity lists, and list views.
			///
			public JObject Metadata { get; set; }

			public string Name { get; set; }

			///
			///The namespace for the accessible APIs and source capabilities in the core of  APIs.
			///
			public string Namespace { get; set; }

			///
			///Collection of property attributes defined for the object. Properties are associated to all objects within , including documents, products, and product types.
			///
			public List<Property> Properties { get; set; }

			///
			///The current version number of the order, wish list, document list, or document type list.
			///
			public string Version { get; set; }

		}

}