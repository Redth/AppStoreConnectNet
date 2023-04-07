# AppStoreConnect.Net.Api.AppClipAppStoreReviewDetailsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppClipAppStoreReviewDetailsCreateInstance**](AppClipAppStoreReviewDetailsApi.md#appclipappstorereviewdetailscreateinstance) | **POST** /v1/appClipAppStoreReviewDetails |  |
| [**AppClipAppStoreReviewDetailsGetInstance**](AppClipAppStoreReviewDetailsApi.md#appclipappstorereviewdetailsgetinstance) | **GET** /v1/appClipAppStoreReviewDetails/{id} |  |
| [**AppClipAppStoreReviewDetailsUpdateInstance**](AppClipAppStoreReviewDetailsApi.md#appclipappstorereviewdetailsupdateinstance) | **PATCH** /v1/appClipAppStoreReviewDetails/{id} |  |

<a name="appclipappstorereviewdetailscreateinstance"></a>
# **AppClipAppStoreReviewDetailsCreateInstance**
> AppClipAppStoreReviewDetailResponse AppClipAppStoreReviewDetailsCreateInstance (AppClipAppStoreReviewDetailCreateRequest appClipAppStoreReviewDetailCreateRequest)



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
    public class AppClipAppStoreReviewDetailsCreateInstanceExample
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
            var apiInstance = new AppClipAppStoreReviewDetailsApi(httpClient, config, httpClientHandler);
            var appClipAppStoreReviewDetailCreateRequest = new AppClipAppStoreReviewDetailCreateRequest(); // AppClipAppStoreReviewDetailCreateRequest | AppClipAppStoreReviewDetail representation

            try
            {
                AppClipAppStoreReviewDetailResponse result = apiInstance.AppClipAppStoreReviewDetailsCreateInstance(appClipAppStoreReviewDetailCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAppStoreReviewDetailsApi.AppClipAppStoreReviewDetailsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAppStoreReviewDetailsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAppStoreReviewDetailResponse> response = apiInstance.AppClipAppStoreReviewDetailsCreateInstanceWithHttpInfo(appClipAppStoreReviewDetailCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAppStoreReviewDetailsApi.AppClipAppStoreReviewDetailsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appClipAppStoreReviewDetailCreateRequest** | [**AppClipAppStoreReviewDetailCreateRequest**](AppClipAppStoreReviewDetailCreateRequest.md) | AppClipAppStoreReviewDetail representation |  |

### Return type

[**AppClipAppStoreReviewDetailResponse**](AppClipAppStoreReviewDetailResponse.md)

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
| **201** | Single AppClipAppStoreReviewDetail |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipappstorereviewdetailsgetinstance"></a>
# **AppClipAppStoreReviewDetailsGetInstance**
> AppClipAppStoreReviewDetailResponse AppClipAppStoreReviewDetailsGetInstance (string id, List<string>? fieldsAppClipAppStoreReviewDetails = null, List<string>? include = null)



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
    public class AppClipAppStoreReviewDetailsGetInstanceExample
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
            var apiInstance = new AppClipAppStoreReviewDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAppStoreReviewDetails (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppClipAppStoreReviewDetailResponse result = apiInstance.AppClipAppStoreReviewDetailsGetInstance(id, fieldsAppClipAppStoreReviewDetails, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAppStoreReviewDetailsApi.AppClipAppStoreReviewDetailsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAppStoreReviewDetailsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAppStoreReviewDetailResponse> response = apiInstance.AppClipAppStoreReviewDetailsGetInstanceWithHttpInfo(id, fieldsAppClipAppStoreReviewDetails, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAppStoreReviewDetailsApi.AppClipAppStoreReviewDetailsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAppStoreReviewDetails | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppClipAppStoreReviewDetailResponse**](AppClipAppStoreReviewDetailResponse.md)

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
| **200** | Single AppClipAppStoreReviewDetail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipappstorereviewdetailsupdateinstance"></a>
# **AppClipAppStoreReviewDetailsUpdateInstance**
> AppClipAppStoreReviewDetailResponse AppClipAppStoreReviewDetailsUpdateInstance (string id, AppClipAppStoreReviewDetailUpdateRequest appClipAppStoreReviewDetailUpdateRequest)



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
    public class AppClipAppStoreReviewDetailsUpdateInstanceExample
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
            var apiInstance = new AppClipAppStoreReviewDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appClipAppStoreReviewDetailUpdateRequest = new AppClipAppStoreReviewDetailUpdateRequest(); // AppClipAppStoreReviewDetailUpdateRequest | AppClipAppStoreReviewDetail representation

            try
            {
                AppClipAppStoreReviewDetailResponse result = apiInstance.AppClipAppStoreReviewDetailsUpdateInstance(id, appClipAppStoreReviewDetailUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAppStoreReviewDetailsApi.AppClipAppStoreReviewDetailsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAppStoreReviewDetailsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAppStoreReviewDetailResponse> response = apiInstance.AppClipAppStoreReviewDetailsUpdateInstanceWithHttpInfo(id, appClipAppStoreReviewDetailUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAppStoreReviewDetailsApi.AppClipAppStoreReviewDetailsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appClipAppStoreReviewDetailUpdateRequest** | [**AppClipAppStoreReviewDetailUpdateRequest**](AppClipAppStoreReviewDetailUpdateRequest.md) | AppClipAppStoreReviewDetail representation |  |

### Return type

[**AppClipAppStoreReviewDetailResponse**](AppClipAppStoreReviewDetailResponse.md)

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
| **200** | Single AppClipAppStoreReviewDetail |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

