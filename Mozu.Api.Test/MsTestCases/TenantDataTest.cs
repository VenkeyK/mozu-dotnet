﻿using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Resources.Platform;
using Mozu.Api.Test.Factories.Platform;
using Mozu.Api.Test.Factories.Platform.Entitylists;
using Mozu.Api.Test.Helpers;

using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

namespace Mozu.Api.Test.MsTestCases
{
    using System.Threading;

    /// <summary>
    /// Summary description for TenantDataTest
    /// </summary>
    [TestClass]
    public class TenantDataTest : MozuApiTestBase
    {
       

       #region NonTestCaseCode
        private static List<string> productCode1 = new List<string>();
        private static List<int> productTypeId1 = new List<int>();
        private static List<string> attributeFQN1 = new List<string>();

        public TenantDataTest()
        {
        }
       
        #region Initializers

        /// <summary>
        /// This will run once before each test.
        /// </summary>
        [TestInitialize]
        public void TestMethodInit()
        {

            tenantId = Convert.ToInt32(Mozu.Api.Test.Helpers.Environment.GetConfigValueByEnvironment("TenantId"));
            ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage();
            TestBaseTenant = TenantFactory.GetTenant(handler: ApiMsgHandler,tenantId: tenantId);
            masterCatalogId = TestBaseTenant.MasterCatalogs.First().Id;
            catalogId = TestBaseTenant.MasterCatalogs.First().Catalogs.First().Id;

            HttpRequestMessage msg = new HttpRequestMessage();
            msg.Headers.Add(Headers.X_VOL_TENANT, TestBaseTenant.Id.ToString());
            msg.Headers.Add(Headers.X_VOL_TENANT_DOMAIN, TestBaseTenant.Domain);
            msg.Headers.Add(Headers.X_VOL_SITE, TestBaseTenant.Sites[0].Id.ToString());

            ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(msg.Headers);
            productCode1.Clear();
            productTypeId1.Clear();
            attributeFQN1.Clear();
        }

        /// <summary>
        /// Runs once before any test is run.
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize]
        public static void InitializeBeforeRun(TestContext testContext)
        {
            //Call the base class's static initializer.
            MozuApiTestBase.TestClassInitialize(testContext);
        }

        #endregion

        #region CleanupMethods

        /// <summary>
        /// This will run once after each test.
        /// </summary>
        [TestCleanup]
        public void TestMethodCleanup()
        {
            CleanUpData.CleanUpProducts(ApiMsgHandler, productCode1);
            CleanUpData.CleanUpProductTypes(ApiMsgHandler, productTypeId1);
            CleanUpData.CleanUpAttributes(ApiMsgHandler, attributeFQN1);
            //Calls the base class's Test Cleanup
            base.TestCleanup();
        }

        /// <summary>
        /// Runs once after all of the tests have run.
        /// </summary>
        [ClassCleanup]
        public static void TestsCleanup()
        {
            //Calls the Base class's static cleanup.
            MozuApiTestBase.TestClassCleanup();
        }

        #endregion

        #endregion

        [TestMethod]
        public void GetDataTest()
        {
            //var prods = TenantDataFactory.GetDBValue(handler: ApiMsgHandler,dbEntryQuery: "test", expectedCode: 404, successCode:404 );
            var data = SiteDataFactory.GetDBValue(handler: ApiMsgHandler, dbEntryQuery: "test", expectedCode: HttpStatusCode.NotFound, successCode: HttpStatusCode.NotFound);

        }

        [TestMethod]
        public void GetTenantAsyncTest()
        {
            var tenantResource = new TenantResource();
            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(TimeSpan.FromSeconds(3));

            var tenant = tenantResource.GetTenantAsync(8088, ct: cts.Token).Result;
        }


        [TestMethod]
        public void GetEntityList()
        {
            ApiMsgHandler.ApiContext.Locale = "en-US";
            var entityList = EntityFactory.GetEntity(handler: ApiMsgHandler, entityListFullName: "bvavgproductreview@a0842dd", id: "ED-Herald-AmberTortoise", expectedCode: HttpStatusCode.OK,
                successCode: HttpStatusCode.OK);

            entityList = EntityFactory.GetEntity(handler: ApiMsgHandler, entityListFullName: "bvavgproductreview@a0842dd", id: "ED-Herald-AmberTortoise", expectedCode: HttpStatusCode.OK,
               successCode: HttpStatusCode.OK);

            entityList = EntityFactory.GetEntity(handler: ApiMsgHandler, entityListFullName: "bvavgproductreview@a0842dd", id: "GPG-Bul'+b-All", expectedCode: HttpStatusCode.OK,
               successCode: HttpStatusCode.OK);

            ApiMsgHandler.ApiContext.TenantId = 0;
            var countries = ReferenceDataFactory.GetCountries(handler: ApiMsgHandler);
            
            countries = ReferenceDataFactory.GetCountries(handler: ApiMsgHandler);
        }
    }
}
