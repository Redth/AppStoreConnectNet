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
    ///  Class for testing BetaAppClipInvocationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BetaAppClipInvocationsApiTests : IDisposable
    {
        private BetaAppClipInvocationsApi instance;

        public BetaAppClipInvocationsApiTests()
        {
            instance = new BetaAppClipInvocationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BetaAppClipInvocationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BetaAppClipInvocationsApi
            //Assert.IsType<BetaAppClipInvocationsApi>(instance);
        }

        /// <summary>
        /// Test BetaAppClipInvocationsCreateInstance
        /// </summary>
        [Fact]
        public void BetaAppClipInvocationsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BetaAppClipInvocationCreateRequest betaAppClipInvocationCreateRequest = null;
            //var response = instance.BetaAppClipInvocationsCreateInstance(betaAppClipInvocationCreateRequest);
            //Assert.IsType<BetaAppClipInvocationResponse>(response);
        }

        /// <summary>
        /// Test BetaAppClipInvocationsDeleteInstance
        /// </summary>
        [Fact]
        public void BetaAppClipInvocationsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.BetaAppClipInvocationsDeleteInstance(id);
        }

        /// <summary>
        /// Test BetaAppClipInvocationsGetInstance
        /// </summary>
        [Fact]
        public void BetaAppClipInvocationsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBetaAppClipInvocations = null;
            //List<string>? include = null;
            //int? limitBetaAppClipInvocationLocalizations = null;
            //var response = instance.BetaAppClipInvocationsGetInstance(id, fieldsBetaAppClipInvocations, include, limitBetaAppClipInvocationLocalizations);
            //Assert.IsType<BetaAppClipInvocationResponse>(response);
        }

        /// <summary>
        /// Test BetaAppClipInvocationsUpdateInstance
        /// </summary>
        [Fact]
        public void BetaAppClipInvocationsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //BetaAppClipInvocationUpdateRequest betaAppClipInvocationUpdateRequest = null;
            //var response = instance.BetaAppClipInvocationsUpdateInstance(id, betaAppClipInvocationUpdateRequest);
            //Assert.IsType<BetaAppClipInvocationResponse>(response);
        }
    }
}