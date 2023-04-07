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
    ///  Class for testing InAppPurchaseContentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InAppPurchaseContentsApiTests : IDisposable
    {
        private InAppPurchaseContentsApi instance;

        public InAppPurchaseContentsApiTests()
        {
            instance = new InAppPurchaseContentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InAppPurchaseContentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InAppPurchaseContentsApi
            //Assert.IsType<InAppPurchaseContentsApi>(instance);
        }

        /// <summary>
        /// Test InAppPurchaseContentsGetInstance
        /// </summary>
        [Fact]
        public void InAppPurchaseContentsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsInAppPurchaseContents = null;
            //List<string>? include = null;
            //var response = instance.InAppPurchaseContentsGetInstance(id, fieldsInAppPurchaseContents, include);
            //Assert.IsType<InAppPurchaseContentResponse>(response);
        }
    }
}