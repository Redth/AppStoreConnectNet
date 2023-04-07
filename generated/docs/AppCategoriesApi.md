# AppStoreConnect.Net.Api.AppCategoriesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppCategoriesGetCollection**](AppCategoriesApi.md#appcategoriesgetcollection) | **GET** /v1/appCategories |  |
| [**AppCategoriesGetInstance**](AppCategoriesApi.md#appcategoriesgetinstance) | **GET** /v1/appCategories/{id} |  |
| [**AppCategoriesParentGetToOneRelated**](AppCategoriesApi.md#appcategoriesparentgettoonerelated) | **GET** /v1/appCategories/{id}/parent |  |
| [**AppCategoriesSubcategoriesGetToManyRelated**](AppCategoriesApi.md#appcategoriessubcategoriesgettomanyrelated) | **GET** /v1/appCategories/{id}/subcategories |  |

<a name="appcategoriesgetcollection"></a>
# **AppCategoriesGetCollection**
> AppCategoriesResponse AppCategoriesGetCollection (List<string>? filterPlatforms = null, bool? existsParent = null, List<string>? fieldsAppCategories = null, int? limit = null, List<string>? include = null, int? limitSubcategories = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class AppCategoriesGetCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AppCategoriesApi(httpClient, config, httpClientHandler);
            var filterPlatforms = new List<string>?(); // List<string>? | filter by attribute 'platforms' (optional) 
            var existsParent = true;  // bool? | filter by existence or non-existence of related 'parent' (optional) 
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitSubcategories = 56;  // int? | maximum number of related subcategories returned (when they are included) (optional) 

            try
            {
                AppCategoriesResponse result = apiInstance.AppCategoriesGetCollection(filterPlatforms, existsParent, fieldsAppCategories, limit, include, limitSubcategories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCategoriesApi.AppCategoriesGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCategoriesGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoriesResponse> response = apiInstance.AppCategoriesGetCollectionWithHttpInfo(filterPlatforms, existsParent, fieldsAppCategories, limit, include, limitSubcategories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCategoriesApi.AppCategoriesGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterPlatforms** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platforms&#39; | [optional]  |
| **existsParent** | **bool?** | filter by existence or non-existence of related &#39;parent&#39; | [optional]  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitSubcategories** | **int?** | maximum number of related subcategories returned (when they are included) | [optional]  |

### Return type

[**AppCategoriesResponse**](AppCategoriesResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **200** | List of AppCategories |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcategoriesgetinstance"></a>
# **AppCategoriesGetInstance**
> AppCategoryResponse AppCategoriesGetInstance (string id, List<string>? fieldsAppCategories = null, List<string>? include = null, int? limitSubcategories = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class AppCategoriesGetInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AppCategoriesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitSubcategories = 56;  // int? | maximum number of related subcategories returned (when they are included) (optional) 

            try
            {
                AppCategoryResponse result = apiInstance.AppCategoriesGetInstance(id, fieldsAppCategories, include, limitSubcategories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCategoriesApi.AppCategoriesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCategoriesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoryResponse> response = apiInstance.AppCategoriesGetInstanceWithHttpInfo(id, fieldsAppCategories, include, limitSubcategories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCategoriesApi.AppCategoriesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitSubcategories** | **int?** | maximum number of related subcategories returned (when they are included) | [optional]  |

### Return type

[**AppCategoryResponse**](AppCategoryResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single AppCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcategoriesparentgettoonerelated"></a>
# **AppCategoriesParentGetToOneRelated**
> AppCategoryResponse AppCategoriesParentGetToOneRelated (string id, List<string>? fieldsAppCategories = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class AppCategoriesParentGetToOneRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AppCategoriesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 

            try
            {
                AppCategoryResponse result = apiInstance.AppCategoriesParentGetToOneRelated(id, fieldsAppCategories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCategoriesApi.AppCategoriesParentGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCategoriesParentGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoryResponse> response = apiInstance.AppCategoriesParentGetToOneRelatedWithHttpInfo(id, fieldsAppCategories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCategoriesApi.AppCategoriesParentGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |

### Return type

[**AppCategoryResponse**](AppCategoryResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single AppCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcategoriessubcategoriesgettomanyrelated"></a>
# **AppCategoriesSubcategoriesGetToManyRelated**
> AppCategoriesResponse AppCategoriesSubcategoriesGetToManyRelated (string id, List<string>? fieldsAppCategories = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class AppCategoriesSubcategoriesGetToManyRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AppCategoriesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                AppCategoriesResponse result = apiInstance.AppCategoriesSubcategoriesGetToManyRelated(id, fieldsAppCategories, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppCategoriesApi.AppCategoriesSubcategoriesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppCategoriesSubcategoriesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoriesResponse> response = apiInstance.AppCategoriesSubcategoriesGetToManyRelatedWithHttpInfo(id, fieldsAppCategories, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppCategoriesApi.AppCategoriesSubcategoriesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**AppCategoriesResponse**](AppCategoriesResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of AppCategories |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

