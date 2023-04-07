# AppStoreConnect.Net.Api.BuildBundlesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BuildBundlesAppClipDomainCacheStatusGetToOneRelated**](BuildBundlesApi.md#buildbundlesappclipdomaincachestatusgettoonerelated) | **GET** /v1/buildBundles/{id}/appClipDomainCacheStatus |  |
| [**BuildBundlesAppClipDomainDebugStatusGetToOneRelated**](BuildBundlesApi.md#buildbundlesappclipdomaindebugstatusgettoonerelated) | **GET** /v1/buildBundles/{id}/appClipDomainDebugStatus |  |
| [**BuildBundlesBetaAppClipInvocationsGetToManyRelated**](BuildBundlesApi.md#buildbundlesbetaappclipinvocationsgettomanyrelated) | **GET** /v1/buildBundles/{id}/betaAppClipInvocations |  |
| [**BuildBundlesBuildBundleFileSizesGetToManyRelated**](BuildBundlesApi.md#buildbundlesbuildbundlefilesizesgettomanyrelated) | **GET** /v1/buildBundles/{id}/buildBundleFileSizes |  |

<a name="buildbundlesappclipdomaincachestatusgettoonerelated"></a>
# **BuildBundlesAppClipDomainCacheStatusGetToOneRelated**
> AppClipDomainStatusResponse BuildBundlesAppClipDomainCacheStatusGetToOneRelated (string id, List<string>? fieldsAppClipDomainStatuses = null)



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
    public class BuildBundlesAppClipDomainCacheStatusGetToOneRelatedExample
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
            var apiInstance = new BuildBundlesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipDomainStatuses = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDomainStatuses (optional) 

            try
            {
                AppClipDomainStatusResponse result = apiInstance.BuildBundlesAppClipDomainCacheStatusGetToOneRelated(id, fieldsAppClipDomainStatuses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildBundlesApi.BuildBundlesAppClipDomainCacheStatusGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildBundlesAppClipDomainCacheStatusGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDomainStatusResponse> response = apiInstance.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedWithHttpInfo(id, fieldsAppClipDomainStatuses);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildBundlesApi.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipDomainStatuses** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDomainStatuses | [optional]  |

### Return type

[**AppClipDomainStatusResponse**](AppClipDomainStatusResponse.md)

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
| **200** | Single AppClipDomainStatus |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildbundlesappclipdomaindebugstatusgettoonerelated"></a>
# **BuildBundlesAppClipDomainDebugStatusGetToOneRelated**
> AppClipDomainStatusResponse BuildBundlesAppClipDomainDebugStatusGetToOneRelated (string id, List<string>? fieldsAppClipDomainStatuses = null)



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
    public class BuildBundlesAppClipDomainDebugStatusGetToOneRelatedExample
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
            var apiInstance = new BuildBundlesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipDomainStatuses = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDomainStatuses (optional) 

            try
            {
                AppClipDomainStatusResponse result = apiInstance.BuildBundlesAppClipDomainDebugStatusGetToOneRelated(id, fieldsAppClipDomainStatuses);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildBundlesApi.BuildBundlesAppClipDomainDebugStatusGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildBundlesAppClipDomainDebugStatusGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDomainStatusResponse> response = apiInstance.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedWithHttpInfo(id, fieldsAppClipDomainStatuses);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildBundlesApi.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipDomainStatuses** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDomainStatuses | [optional]  |

### Return type

[**AppClipDomainStatusResponse**](AppClipDomainStatusResponse.md)

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
| **200** | Single AppClipDomainStatus |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildbundlesbetaappclipinvocationsgettomanyrelated"></a>
# **BuildBundlesBetaAppClipInvocationsGetToManyRelated**
> BetaAppClipInvocationsResponse BuildBundlesBetaAppClipInvocationsGetToManyRelated (string id, List<string>? fieldsBetaAppClipInvocations = null, List<string>? fieldsBetaAppClipInvocationLocalizations = null, int? limit = null, int? limitBetaAppClipInvocationLocalizations = null, List<string>? include = null)



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
    public class BuildBundlesBetaAppClipInvocationsGetToManyRelatedExample
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
            var apiInstance = new BuildBundlesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaAppClipInvocations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppClipInvocations (optional) 
            var fieldsBetaAppClipInvocationLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppClipInvocationLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitBetaAppClipInvocationLocalizations = 56;  // int? | maximum number of related betaAppClipInvocationLocalizations returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                BetaAppClipInvocationsResponse result = apiInstance.BuildBundlesBetaAppClipInvocationsGetToManyRelated(id, fieldsBetaAppClipInvocations, fieldsBetaAppClipInvocationLocalizations, limit, limitBetaAppClipInvocationLocalizations, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildBundlesApi.BuildBundlesBetaAppClipInvocationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildBundlesBetaAppClipInvocationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppClipInvocationsResponse> response = apiInstance.BuildBundlesBetaAppClipInvocationsGetToManyRelatedWithHttpInfo(id, fieldsBetaAppClipInvocations, fieldsBetaAppClipInvocationLocalizations, limit, limitBetaAppClipInvocationLocalizations, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildBundlesApi.BuildBundlesBetaAppClipInvocationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaAppClipInvocations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppClipInvocations | [optional]  |
| **fieldsBetaAppClipInvocationLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppClipInvocationLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitBetaAppClipInvocationLocalizations** | **int?** | maximum number of related betaAppClipInvocationLocalizations returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**BetaAppClipInvocationsResponse**](BetaAppClipInvocationsResponse.md)

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
| **200** | List of BetaAppClipInvocations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildbundlesbuildbundlefilesizesgettomanyrelated"></a>
# **BuildBundlesBuildBundleFileSizesGetToManyRelated**
> BuildBundleFileSizesResponse BuildBundlesBuildBundleFileSizesGetToManyRelated (string id, List<string>? fieldsBuildBundleFileSizes = null, int? limit = null)



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
    public class BuildBundlesBuildBundleFileSizesGetToManyRelatedExample
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
            var apiInstance = new BuildBundlesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBuildBundleFileSizes = new List<string>?(); // List<string>? | the fields to include for returned resources of type buildBundleFileSizes (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BuildBundleFileSizesResponse result = apiInstance.BuildBundlesBuildBundleFileSizesGetToManyRelated(id, fieldsBuildBundleFileSizes, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildBundlesApi.BuildBundlesBuildBundleFileSizesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildBundlesBuildBundleFileSizesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildBundleFileSizesResponse> response = apiInstance.BuildBundlesBuildBundleFileSizesGetToManyRelatedWithHttpInfo(id, fieldsBuildBundleFileSizes, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildBundlesApi.BuildBundlesBuildBundleFileSizesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBuildBundleFileSizes** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type buildBundleFileSizes | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BuildBundleFileSizesResponse**](BuildBundleFileSizesResponse.md)

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
| **200** | List of BuildBundleFileSizes |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

