
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

using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.SiteSettings.General.General;
using Mozu.Api.Contracts.SiteSettings.General.General.Routing;

namespace Mozu.Api.Contracts.SiteSettings.General
{
		///
		///	General settings used on the storefront site.
		///
		public class GeneralSettings
		{
			public bool? AllowInvalidAddresses { get; set; }

			public AuditInfo AuditInfo { get; set; }

			///
			///An email address to blind carbon copy anytime an automatic email is sent from  to a shopper.
			///
			public string BccEmailAddress { get; set; }

			///
			///Set of settings to deal with site caching.
			///
			public CacheSettings CacheSettings { get; set; }

			///
			///Custom override of the default subdomain for CDN-hosted content. For example, for SEO reasons you may prefer that the subdomain for your CDN content be  instead of the default subdomain, which might be something like .
			///
			public string CustomCdnHostName { get; set; }

			///
			///Site-level settings for custom routing, which allows you to use your own custom URL patterns for common  pages.
			///
			public CustomRouteSettings CustomRoutes { get; set; }

			///
			///Set this property to  to disable automatically sending order confirmation emails after an order is submitted. If you enable this property, order confirmation emails are triggered only by the  API operation or a Resend Order Confirmation Email event (which can be triggered by an  user).
			///
			public EmailTransactionSettings EmailTransactionsOnlyOnRequest { get; set; }

			///
			///A collection of overrides that allow you to apply unique email settings to the email template(s) of your choice.
			///
			public List<EmailTypeSetting> EmailTypes { get; set; }

			public string FavIconMobilePath { get; set; }

			public string FavIconPath { get; set; }

			public string GoogleAnalyticsCode { get; set; }

			public bool? IsAddressValidationEnabled { get; set; }

			public bool? IsGoogleAnalyticsEcommerceEnabled { get; set; }

			public bool? IsGoogleAnalyticsEnabled { get; set; }

			public bool IsMozuWebSite { get; set; }

			///
			///True if the site supports [shipping to multiple addresses](https://www.mozu.com/docs/Guides/orders/multi-ship.htm) within one order.
			///
			public bool? IsMultishipEnabled { get; set; }

			public bool? IsWishlistCreationEnabled { get; set; }

			public string LogoPath { get; set; }

			public string LogoText { get; set; }

			///
			///Assigns an image to render in place of broken images and unspecified product images (and unspecified category images, if your theme developer has enabled category images). Specified by the name or ID of the CMS image within .
			///
			public string MissingImageSubstitute { get; set; }

			public string MobileTheme { get; set; }

			public string ReplyToEmailAddress { get; set; }

			public string SenderEmailAddress { get; set; }

			///
			///An alternate name for the sender email. For example, if your sender email is , you might want to use an alias of .
			///
			public string SenderEmailAlias { get; set; }

			public string SiteTimeFormat { get; set; }

			public string SiteTimeZone { get; set; }

			///
			///Supressed emails. Setting any of these to 'true' will block  from sending that email and an event will be published instead.
			///
			public EmailTransactionSettings SupressedEmailTransactions { get; set; }

			///
			///The name of the theme to use when viewing the website on a mobile device.
			///
			public string TabletTheme { get; set; }

			public List<TaxableTerritory> TaxableTerritories { get; set; }

			public int? TemplateSiteId { get; set; }

			public string Theme { get; set; }

			///
			///A collection of authorizations that control access to viewing the pending and live sites.
			///
			public ViewAuthorizations ViewAuthorizations { get; set; }

			public string WebsiteName { get; set; }

		}

}