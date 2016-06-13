
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


namespace Mozu.Api.Contracts.ProductAdmin
{
		public class PriceListEntryCollection
		{
			public List<PriceListEntry> Items { get; set; }

			///
			///The total number of pages of the results divided per the `pageSize`.
			///
			public int PageCount { get; set; }

			///
			///The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.
			///
			public int PageSize { get; set; }

			///
			///When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.
			///
			public int StartIndex { get; set; }

			public int TotalCount { get; set; }

		}

}