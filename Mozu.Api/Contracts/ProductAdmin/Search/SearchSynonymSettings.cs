
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin.Search
{
		///
		///	Settings for search synonyms for search results.
		///
		public class SearchSynonymSettings
		{
			///
			///Indicates if synonyms should be expanded.
			///
			public bool ExpandSynonyms { get; set; }

			///
			///Sets the boost for the words actually sent in the query.
			///
			public decimal MainPartBoost { get; set; }

			///
			///matchOnAnyTerm ApiType DOCUMENT_HERE 
			///
			public bool? MatchOnAnyTerm { get; set; }

			///
			///phraseBoost ApiType DOCUMENT_HERE 
			///
			public int? PhraseBoost { get; set; }

			///
			///Boosts the synonyms to affect rankings for search results.
			///
			public decimal SynonymPartBoost { get; set; }

		}

}