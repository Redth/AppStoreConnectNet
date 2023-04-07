# AppStoreConnect.Net.Api.BundleIdsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BundleIdsAppGetToOneRelated**](BundleIdsApi.md#bundleidsappgettoonerelated) | **GET** /v1/bundleIds/{id}/app |  |
| [**BundleIdsBundleIdCapabilitiesGetToManyRelated**](BundleIdsApi.md#bundleidsbundleidcapabilitiesgettomanyrelated) | **GET** /v1/bundleIds/{id}/bundleIdCapabilities |  |
| [**BundleIdsCreateInstance**](BundleIdsApi.md#bundleidscreateinstance) | **POST** /v1/bundleIds |  |
| [**BundleIdsDeleteInstance**](BundleIdsApi.md#bundleidsdeleteinstance) | **DELETE** /v1/bundleIds/{id} |  |
| [**BundleIdsGetCollection**](BundleIdsApi.md#bundleidsgetcollection) | **GET** /v1/bundleIds |  |
| [**BundleIdsGetInstance**](BundleIdsApi.md#bundleidsgetinstance) | **GET** /v1/bundleIds/{id} |  |
| [**BundleIdsProfilesGetToManyRelated**](BundleIdsApi.md#bundleidsprofilesgettomanyrelated) | **GET** /v1/bundleIds/{id}/profiles |  |
| [**BundleIdsUpdateInstance**](BundleIdsApi.md#bundleidsupdateinstance) | **PATCH** /v1/bundleIds/{id} |  |

<a name="bundleidsappgettoonerelated"></a>
# **BundleIdsAppGetToOneRelated**
> AppResponse BundleIdsAppGetToOneRelated (string id, List<string>? fieldsApps = null)



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
    public class BundleIdsAppGetToOneRelatedExample
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
            var apiInstance = new BundleIdsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 

            try
            {
                AppResponse result = apiInstance.BundleIdsAppGetToOneRelated(id, fieldsApps);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdsApi.BundleIdsAppGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdsAppGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppResponse> response = apiInstance.BundleIdsAppGetToOneRelatedWithHttpInfo(id, fieldsApps);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdsApi.BundleIdsAppGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |

### Return type

[**AppResponse**](AppResponse.md)

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
| **200** | Single App |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bundleidsbundleidcapabilitiesgettomanyrelated"></a>
# **BundleIdsBundleIdCapabilitiesGetToManyRelated**
> BundleIdCapabilitiesResponse BundleIdsBundleIdCapabilitiesGetToManyRelated (string id, List<string>? fieldsBundleIdCapabilities = null, int? limit = null)



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
    public class BundleIdsBundleIdCapabilitiesGetToManyRelatedExample
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
            var apiInstance = new BundleIdsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBundleIdCapabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIdCapabilities (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BundleIdCapabilitiesResponse result = apiInstance.BundleIdsBundleIdCapabilitiesGetToManyRelated(id, fieldsBundleIdCapabilities, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdsApi.BundleIdsBundleIdCapabilitiesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdsBundleIdCapabilitiesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BundleIdCapabilitiesResponse> response = apiInstance.BundleIdsBundleIdCapabilitiesGetToManyRelatedWithHttpInfo(id, fieldsBundleIdCapabilities, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdsApi.BundleIdsBundleIdCapabilitiesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBundleIdCapabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIdCapabilities | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BundleIdCapabilitiesResponse**](BundleIdCapabilitiesResponse.md)

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
| **200** | List of BundleIdCapabilities |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bundleidscreateinstance"></a>
# **BundleIdsCreateInstance**
> BundleIdResponse BundleIdsCreateInstance (BundleIdCreateRequest bundleIdCreateRequest)



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
    public class BundleIdsCreateInstanceExample
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
            var apiInstance = new BundleIdsApi(httpClient, config, httpClientHandler);
            var bundleIdCreateRequest = new BundleIdCreateRequest(); // BundleIdCreateRequest | BundleId representation

            try
            {
                BundleIdResponse result = apiInstance.BundleIdsCreateInstance(bundleIdCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdsApi.BundleIdsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BundleIdResponse> response = apiInstance.BundleIdsCreateInstanceWithHttpInfo(bundleIdCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdsApi.BundleIdsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bundleIdCreateRequest** | [**BundleIdCreateRequest**](BundleIdCreateRequest.md) | BundleId representation |  |

### Return type

[**BundleIdResponse**](BundleIdResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **201** | Single BundleId |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bundleidsdeleteinstance"></a>
# **BundleIdsDeleteInstance**
> void BundleIdsDeleteInstance (string id)



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
    public class BundleIdsDeleteInstanceExample
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
            var apiInstance = new BundleIdsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.BundleIdsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdsApi.BundleIdsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BundleIdsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdsApi.BundleIdsDeleteInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

void (empty response body)

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
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bundleidsgetcollection"></a>
# **BundleIdsGetCollection**
> BundleIdsResponse BundleIdsGetCollection (List<string>? filterIdentifier = null, List<string>? filterName = null, List<string>? filterPlatform = null, List<string>? filterSeedId = null, List<string>? filterId = null, List<string>? sort = null, List<string>? fieldsBundleIds = null, int? limit = null, List<string>? include = null, List<string>? fieldsBundleIdCapabilities = null, List<string>? fieldsProfiles = null, List<string>? fieldsApps = null, int? limitBundleIdCapabilities = null, int? limitProfiles = null)



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
    public class BundleIdsGetCollectionExample
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
            var apiInstance = new BundleIdsApi(httpClient, config, httpClientHandler);
            var filterIdentifier = new List<string>?(); // List<string>? | filter by attribute 'identifier' (optional) 
            var filterName = new List<string>?(); // List<string>? | filter by attribute 'name' (optional) 
            var filterPlatform = new List<string>?(); // List<string>? | filter by attribute 'platform' (optional) 
            var filterSeedId = new List<string>?(); // List<string>? | filter by attribute 'seedId' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsBundleIds = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIds (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsBundleIdCapabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIdCapabilities (optional) 
            var fieldsProfiles = new List<string>?(); // List<string>? | the fields to include for returned resources of type profiles (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var limitBundleIdCapabilities = 56;  // int? | maximum number of related bundleIdCapabilities returned (when they are included) (optional) 
            var limitProfiles = 56;  // int? | maximum number of related profiles returned (when they are included) (optional) 

            try
            {
                BundleIdsResponse result = apiInstance.BundleIdsGetCollection(filterIdentifier, filterName, filterPlatform, filterSeedId, filterId, sort, fieldsBundleIds, limit, include, fieldsBundleIdCapabilities, fieldsProfiles, fieldsApps, limitBundleIdCapabilities, limitProfiles);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdsApi.BundleIdsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BundleIdsResponse> response = apiInstance.BundleIdsGetCollectionWithHttpInfo(filterIdentifier, filterName, filterPlatform, filterSeedId, filterId, sort, fieldsBundleIds, limit, include, fieldsBundleIdCapabilities, fieldsProfiles, fieldsApps, limitBundleIdCapabilities, limitProfiles);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdsApi.BundleIdsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterIdentifier** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;identifier&#39; | [optional]  |
| **filterName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;name&#39; | [optional]  |
| **filterPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platform&#39; | [optional]  |
| **filterSeedId** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;seedId&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsBundleIds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIds | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsBundleIdCapabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIdCapabilities | [optional]  |
| **fieldsProfiles** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type profiles | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **limitBundleIdCapabilities** | **int?** | maximum number of related bundleIdCapabilities returned (when they are included) | [optional]  |
| **limitProfiles** | **int?** | maximum number of related profiles returned (when they are included) | [optional]  |

### Return type

[**BundleIdsResponse**](BundleIdsResponse.md)

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
| **200** | List of BundleIds |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bundleidsgetinstance"></a>
# **BundleIdsGetInstance**
> BundleIdResponse BundleIdsGetInstance (string id, List<string>? fieldsBundleIds = null, List<string>? include = null, List<string>? fieldsBundleIdCapabilities = null, List<string>? fieldsProfiles = null, List<string>? fieldsApps = null, int? limitBundleIdCapabilities = null, int? limitProfiles = null)



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
    public class BundleIdsGetInstanceExample
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
            var apiInstance = new BundleIdsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBundleIds = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIds (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsBundleIdCapabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIdCapabilities (optional) 
            var fieldsProfiles = new List<string>?(); // List<string>? | the fields to include for returned resources of type profiles (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var limitBundleIdCapabilities = 56;  // int? | maximum number of related bundleIdCapabilities returned (when they are included) (optional) 
            var limitProfiles = 56;  // int? | maximum number of related profiles returned (when they are included) (optional) 

            try
            {
                BundleIdResponse result = apiInstance.BundleIdsGetInstance(id, fieldsBundleIds, include, fieldsBundleIdCapabilities, fieldsProfiles, fieldsApps, limitBundleIdCapabilities, limitProfiles);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdsApi.BundleIdsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BundleIdResponse> response = apiInstance.BundleIdsGetInstanceWithHttpInfo(id, fieldsBundleIds, include, fieldsBundleIdCapabilities, fieldsProfiles, fieldsApps, limitBundleIdCapabilities, limitProfiles);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdsApi.BundleIdsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBundleIds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIds | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsBundleIdCapabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIdCapabilities | [optional]  |
| **fieldsProfiles** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type profiles | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **limitBundleIdCapabilities** | **int?** | maximum number of related bundleIdCapabilities returned (when they are included) | [optional]  |
| **limitProfiles** | **int?** | maximum number of related profiles returned (when they are included) | [optional]  |

### Return type

[**BundleIdResponse**](BundleIdResponse.md)

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
| **200** | Single BundleId |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bundleidsprofilesgettomanyrelated"></a>
# **BundleIdsProfilesGetToManyRelated**
> ProfilesResponse BundleIdsProfilesGetToManyRelated (string id, List<string>? fieldsProfiles = null, int? limit = null)



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
    public class BundleIdsProfilesGetToManyRelatedExample
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
            var apiInstance = new BundleIdsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsProfiles = new List<string>?(); // List<string>? | the fields to include for returned resources of type profiles (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                ProfilesResponse result = apiInstance.BundleIdsProfilesGetToManyRelated(id, fieldsProfiles, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdsApi.BundleIdsProfilesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdsProfilesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfilesResponse> response = apiInstance.BundleIdsProfilesGetToManyRelatedWithHttpInfo(id, fieldsProfiles, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdsApi.BundleIdsProfilesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsProfiles** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type profiles | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**ProfilesResponse**](ProfilesResponse.md)

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
| **200** | List of Profiles |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bundleidsupdateinstance"></a>
# **BundleIdsUpdateInstance**
> BundleIdResponse BundleIdsUpdateInstance (string id, BundleIdUpdateRequest bundleIdUpdateRequest)



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
    public class BundleIdsUpdateInstanceExample
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
            var apiInstance = new BundleIdsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var bundleIdUpdateRequest = new BundleIdUpdateRequest(); // BundleIdUpdateRequest | BundleId representation

            try
            {
                BundleIdResponse result = apiInstance.BundleIdsUpdateInstance(id, bundleIdUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BundleIdsApi.BundleIdsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BundleIdsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BundleIdResponse> response = apiInstance.BundleIdsUpdateInstanceWithHttpInfo(id, bundleIdUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BundleIdsApi.BundleIdsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **bundleIdUpdateRequest** | [**BundleIdUpdateRequest**](BundleIdUpdateRequest.md) | BundleId representation |  |

### Return type

[**BundleIdResponse**](BundleIdResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single BundleId |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

