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
    ///  Class for testing SubscriptionLocalizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SubscriptionLocalizationsApiTests : IDisposable
    {
        private SubscriptionLocalizationsApi instance;

        public SubscriptionLocalizationsApiTests()
        {
            instance = new SubscriptionLocalizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SubscriptionLocalizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SubscriptionLocalizationsApi
            //Assert.IsType<SubscriptionLocalizationsApi>(instance);
        }

        /// <summary>
        /// Test SubscriptionLocalizationsCreateInstance
        /// </summary>
        [Fact]
        public void SubscriptionLocalizationsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubscriptionLocalizationCreateRequest subscriptionLocalizationCreateRequest = null;
            //var response = instance.SubscriptionLocalizationsCreateInstance(subscriptionLocalizationCreateRequest);
            //Assert.IsType<SubscriptionLocalizationResponse>(response);
        }

        /// <summary>
        /// Test SubscriptionLocalizationsDeleteInstance
        /// </summary>
        [Fact]
        public void SubscriptionLocalizationsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.SubscriptionLocalizationsDeleteInstance(id);
        }

        /// <summary>
        /// Test SubscriptionLocalizationsGetInstance
        /// </summary>
        [Fact]
        public void SubscriptionLocalizationsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsSubscriptionLocalizations = null;
            //List<string>? include = null;
            //var response = instance.SubscriptionLocalizationsGetInstance(id, fieldsSubscriptionLocalizations, include);
            //Assert.IsType<SubscriptionLocalizationResponse>(response);
        }

        /// <summary>
        /// Test SubscriptionLocalizationsUpdateInstance
        /// </summary>
        [Fact]
        public void SubscriptionLocalizationsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //SubscriptionLocalizationUpdateRequest subscriptionLocalizationUpdateRequest = null;
            //var response = instance.SubscriptionLocalizationsUpdateInstance(id, subscriptionLocalizationUpdateRequest);
            //Assert.IsType<SubscriptionLocalizationResponse>(response);
        }
    }
}
