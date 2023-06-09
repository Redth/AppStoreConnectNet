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
    ///  Class for testing ProfilesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProfilesApiTests : IDisposable
    {
        private ProfilesApi instance;

        public ProfilesApiTests()
        {
            instance = new ProfilesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProfilesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProfilesApi
            //Assert.IsType<ProfilesApi>(instance);
        }

        /// <summary>
        /// Test ProfilesBundleIdGetToOneRelated
        /// </summary>
        [Fact]
        public void ProfilesBundleIdGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsBundleIds = null;
            //var response = instance.ProfilesBundleIdGetToOneRelated(id, fieldsBundleIds);
            //Assert.IsType<BundleIdResponse>(response);
        }

        /// <summary>
        /// Test ProfilesCertificatesGetToManyRelated
        /// </summary>
        [Fact]
        public void ProfilesCertificatesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsCertificates = null;
            //int? limit = null;
            //var response = instance.ProfilesCertificatesGetToManyRelated(id, fieldsCertificates, limit);
            //Assert.IsType<CertificatesResponse>(response);
        }

        /// <summary>
        /// Test ProfilesCreateInstance
        /// </summary>
        [Fact]
        public void ProfilesCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProfileCreateRequest profileCreateRequest = null;
            //var response = instance.ProfilesCreateInstance(profileCreateRequest);
            //Assert.IsType<ProfileResponse>(response);
        }

        /// <summary>
        /// Test ProfilesDeleteInstance
        /// </summary>
        [Fact]
        public void ProfilesDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ProfilesDeleteInstance(id);
        }

        /// <summary>
        /// Test ProfilesDevicesGetToManyRelated
        /// </summary>
        [Fact]
        public void ProfilesDevicesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsDevices = null;
            //int? limit = null;
            //var response = instance.ProfilesDevicesGetToManyRelated(id, fieldsDevices, limit);
            //Assert.IsType<DevicesResponse>(response);
        }

        /// <summary>
        /// Test ProfilesGetCollection
        /// </summary>
        [Fact]
        public void ProfilesGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? filterName = null;
            //List<string>? filterProfileState = null;
            //List<string>? filterProfileType = null;
            //List<string>? filterId = null;
            //List<string>? sort = null;
            //List<string>? fieldsProfiles = null;
            //int? limit = null;
            //List<string>? include = null;
            //List<string>? fieldsCertificates = null;
            //List<string>? fieldsDevices = null;
            //List<string>? fieldsBundleIds = null;
            //int? limitCertificates = null;
            //int? limitDevices = null;
            //var response = instance.ProfilesGetCollection(filterName, filterProfileState, filterProfileType, filterId, sort, fieldsProfiles, limit, include, fieldsCertificates, fieldsDevices, fieldsBundleIds, limitCertificates, limitDevices);
            //Assert.IsType<ProfilesResponse>(response);
        }

        /// <summary>
        /// Test ProfilesGetInstance
        /// </summary>
        [Fact]
        public void ProfilesGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsProfiles = null;
            //List<string>? include = null;
            //List<string>? fieldsCertificates = null;
            //List<string>? fieldsDevices = null;
            //List<string>? fieldsBundleIds = null;
            //int? limitCertificates = null;
            //int? limitDevices = null;
            //var response = instance.ProfilesGetInstance(id, fieldsProfiles, include, fieldsCertificates, fieldsDevices, fieldsBundleIds, limitCertificates, limitDevices);
            //Assert.IsType<ProfileResponse>(response);
        }
    }
}
