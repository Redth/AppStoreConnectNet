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
    ///  Class for testing AppCategoriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppCategoriesApiTests : IDisposable
    {
        private AppCategoriesApi instance;

        public AppCategoriesApiTests()
        {
            instance = new AppCategoriesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppCategoriesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppCategoriesApi
            //Assert.IsType<AppCategoriesApi>(instance);
        }

        /// <summary>
        /// Test AppCategoriesGetCollection
        /// </summary>
        [Fact]
        public void AppCategoriesGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? filterPlatforms = null;
            //bool? existsParent = null;
            //List<string>? fieldsAppCategories = null;
            //int? limit = null;
            //List<string>? include = null;
            //int? limitSubcategories = null;
            //var response = instance.AppCategoriesGetCollection(filterPlatforms, existsParent, fieldsAppCategories, limit, include, limitSubcategories);
            //Assert.IsType<AppCategoriesResponse>(response);
        }

        /// <summary>
        /// Test AppCategoriesGetInstance
        /// </summary>
        [Fact]
        public void AppCategoriesGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppCategories = null;
            //List<string>? include = null;
            //int? limitSubcategories = null;
            //var response = instance.AppCategoriesGetInstance(id, fieldsAppCategories, include, limitSubcategories);
            //Assert.IsType<AppCategoryResponse>(response);
        }

        /// <summary>
        /// Test AppCategoriesParentGetToOneRelated
        /// </summary>
        [Fact]
        public void AppCategoriesParentGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppCategories = null;
            //var response = instance.AppCategoriesParentGetToOneRelated(id, fieldsAppCategories);
            //Assert.IsType<AppCategoryResponse>(response);
        }

        /// <summary>
        /// Test AppCategoriesSubcategoriesGetToManyRelated
        /// </summary>
        [Fact]
        public void AppCategoriesSubcategoriesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAppCategories = null;
            //int? limit = null;
            //var response = instance.AppCategoriesSubcategoriesGetToManyRelated(id, fieldsAppCategories, limit);
            //Assert.IsType<AppCategoriesResponse>(response);
        }
    }
}
