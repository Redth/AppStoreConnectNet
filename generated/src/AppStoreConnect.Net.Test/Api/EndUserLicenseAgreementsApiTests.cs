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
    ///  Class for testing EndUserLicenseAgreementsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EndUserLicenseAgreementsApiTests : IDisposable
    {
        private EndUserLicenseAgreementsApi instance;

        public EndUserLicenseAgreementsApiTests()
        {
            instance = new EndUserLicenseAgreementsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EndUserLicenseAgreementsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EndUserLicenseAgreementsApi
            //Assert.IsType<EndUserLicenseAgreementsApi>(instance);
        }

        /// <summary>
        /// Test EndUserLicenseAgreementsCreateInstance
        /// </summary>
        [Fact]
        public void EndUserLicenseAgreementsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EndUserLicenseAgreementCreateRequest endUserLicenseAgreementCreateRequest = null;
            //var response = instance.EndUserLicenseAgreementsCreateInstance(endUserLicenseAgreementCreateRequest);
            //Assert.IsType<EndUserLicenseAgreementResponse>(response);
        }

        /// <summary>
        /// Test EndUserLicenseAgreementsDeleteInstance
        /// </summary>
        [Fact]
        public void EndUserLicenseAgreementsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.EndUserLicenseAgreementsDeleteInstance(id);
        }

        /// <summary>
        /// Test EndUserLicenseAgreementsGetInstance
        /// </summary>
        [Fact]
        public void EndUserLicenseAgreementsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsEndUserLicenseAgreements = null;
            //List<string>? include = null;
            //List<string>? fieldsTerritories = null;
            //int? limitTerritories = null;
            //var response = instance.EndUserLicenseAgreementsGetInstance(id, fieldsEndUserLicenseAgreements, include, fieldsTerritories, limitTerritories);
            //Assert.IsType<EndUserLicenseAgreementResponse>(response);
        }

        /// <summary>
        /// Test EndUserLicenseAgreementsTerritoriesGetToManyRelated
        /// </summary>
        [Fact]
        public void EndUserLicenseAgreementsTerritoriesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsTerritories = null;
            //int? limit = null;
            //var response = instance.EndUserLicenseAgreementsTerritoriesGetToManyRelated(id, fieldsTerritories, limit);
            //Assert.IsType<TerritoriesResponse>(response);
        }

        /// <summary>
        /// Test EndUserLicenseAgreementsUpdateInstance
        /// </summary>
        [Fact]
        public void EndUserLicenseAgreementsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //EndUserLicenseAgreementUpdateRequest endUserLicenseAgreementUpdateRequest = null;
            //var response = instance.EndUserLicenseAgreementsUpdateInstance(id, endUserLicenseAgreementUpdateRequest);
            //Assert.IsType<EndUserLicenseAgreementResponse>(response);
        }
    }
}