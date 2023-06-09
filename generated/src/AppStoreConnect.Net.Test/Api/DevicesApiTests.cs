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
    ///  Class for testing DevicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DevicesApiTests : IDisposable
    {
        private DevicesApi instance;

        public DevicesApiTests()
        {
            instance = new DevicesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DevicesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DevicesApi
            //Assert.IsType<DevicesApi>(instance);
        }

        /// <summary>
        /// Test DevicesCreateInstance
        /// </summary>
        [Fact]
        public void DevicesCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeviceCreateRequest deviceCreateRequest = null;
            //var response = instance.DevicesCreateInstance(deviceCreateRequest);
            //Assert.IsType<DeviceResponse>(response);
        }

        /// <summary>
        /// Test DevicesGetCollection
        /// </summary>
        [Fact]
        public void DevicesGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? filterName = null;
            //List<string>? filterPlatform = null;
            //List<string>? filterStatus = null;
            //List<string>? filterUdid = null;
            //List<string>? filterId = null;
            //List<string>? sort = null;
            //List<string>? fieldsDevices = null;
            //int? limit = null;
            //var response = instance.DevicesGetCollection(filterName, filterPlatform, filterStatus, filterUdid, filterId, sort, fieldsDevices, limit);
            //Assert.IsType<DevicesResponse>(response);
        }

        /// <summary>
        /// Test DevicesGetInstance
        /// </summary>
        [Fact]
        public void DevicesGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsDevices = null;
            //var response = instance.DevicesGetInstance(id, fieldsDevices);
            //Assert.IsType<DeviceResponse>(response);
        }

        /// <summary>
        /// Test DevicesUpdateInstance
        /// </summary>
        [Fact]
        public void DevicesUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DeviceUpdateRequest deviceUpdateRequest = null;
            //var response = instance.DevicesUpdateInstance(id, deviceUpdateRequest);
            //Assert.IsType<DeviceResponse>(response);
        }
    }
}
