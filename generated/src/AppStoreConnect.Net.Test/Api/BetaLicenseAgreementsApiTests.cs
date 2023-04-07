/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using AppStoreConnect.Client;
using AppStoreConnect.Api;
// uncomment below to import models
//using AppStoreConnect.Model;

namespace AppStoreConnect.Test.Api
{
    /// <summary>
    ///  Class for testing BetaLicenseAgreementsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BetaLicenseAgreementsApiTests : IDisposable
    {
        private BetaLicenseAgreementsApi instance;

        public BetaLicenseAgreementsApiTests()
        {
            instance = new BetaLicenseAgreementsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BetaLicenseAgreementsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BetaLicenseAgreementsApi
            //Assert.IsType<BetaLicenseAgreementsApi>(instance);
        }

        /// <summary>
        /// Test BetaLicenseAgreementsAppGetToOneRelated
        /// </summary>
        [Fact]
        public void BetaLicenseAgreementsAppGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsApps = null;
            //var response = instance.BetaLicenseAgreementsAppGetToOneRelated(id, fieldsApps);
            //Assert.IsType<AppResponse>(response);
        }

        /// <summary>
        /// Test BetaLicenseAgreementsGetCollection
        /// </summary>
        [Fact]
        public void BetaLicenseAgreementsGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? filterApp = null;
            //List<string>? fieldsBetaLicenseAgreements = null;
            //int? limit = null;
            //List<string>? include = null;
            //List<string>? fieldsApps = null;
            //var response = instance.BetaLicenseAgreementsGetCollection(filterApp, fieldsBetaLicenseAgreements, limit, include, fieldsApps);
            //Assert.IsType<BetaLicenseAgreementsResponse>(response);
        }

        /// <summary>
        /// Test BetaLicenseAgreementsGetInstance
        /// </summary>
        [Fact]
        public void BetaLicenseAgreementsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBetaLicenseAgreements = null;
            //List<string>? include = null;
            //List<string>? fieldsApps = null;
            //var response = instance.BetaLicenseAgreementsGetInstance(id, fieldsBetaLicenseAgreements, include, fieldsApps);
            //Assert.IsType<BetaLicenseAgreementResponse>(response);
        }

        /// <summary>
        /// Test BetaLicenseAgreementsUpdateInstance
        /// </summary>
        [Fact]
        public void BetaLicenseAgreementsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //BetaLicenseAgreementUpdateRequest betaLicenseAgreementUpdateRequest = null;
            //var response = instance.BetaLicenseAgreementsUpdateInstance(id, betaLicenseAgreementUpdateRequest);
            //Assert.IsType<BetaLicenseAgreementResponse>(response);
        }
    }
}
