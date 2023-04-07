# AppStoreConnect.Net.Api.SubscriptionAppStoreReviewScreenshotsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionAppStoreReviewScreenshotsCreateInstance**](SubscriptionAppStoreReviewScreenshotsApi.md#subscriptionappstorereviewscreenshotscreateinstance) | **POST** /v1/subscriptionAppStoreReviewScreenshots |  |
| [**SubscriptionAppStoreReviewScreenshotsDeleteInstance**](SubscriptionAppStoreReviewScreenshotsApi.md#subscriptionappstorereviewscreenshotsdeleteinstance) | **DELETE** /v1/subscriptionAppStoreReviewScreenshots/{id} |  |
| [**SubscriptionAppStoreReviewScreenshotsGetInstance**](SubscriptionAppStoreReviewScreenshotsApi.md#subscriptionappstorereviewscreenshotsgetinstance) | **GET** /v1/subscriptionAppStoreReviewScreenshots/{id} |  |
| [**SubscriptionAppStoreReviewScreenshotsUpdateInstance**](SubscriptionAppStoreReviewScreenshotsApi.md#subscriptionappstorereviewscreenshotsupdateinstance) | **PATCH** /v1/subscriptionAppStoreReviewScreenshots/{id} |  |

<a name="subscriptionappstorereviewscreenshotscreateinstance"></a>
# **SubscriptionAppStoreReviewScreenshotsCreateInstance**
> SubscriptionAppStoreReviewScreenshotResponse SubscriptionAppStoreReviewScreenshotsCreateInstance (SubscriptionAppStoreReviewScreenshotCreateRequest subscriptionAppStoreReviewScreenshotCreateRequest)



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
    public class SubscriptionAppStoreReviewScreenshotsCreateInstanceExample
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
            var apiInstance = new SubscriptionAppStoreReviewScreenshotsApi(httpClient, config, httpClientHandler);
            var subscriptionAppStoreReviewScreenshotCreateRequest = new SubscriptionAppStoreReviewScreenshotCreateRequest(); // SubscriptionAppStoreReviewScreenshotCreateRequest | SubscriptionAppStoreReviewScreenshot representation

            try
            {
                SubscriptionAppStoreReviewScreenshotResponse result = apiInstance.SubscriptionAppStoreReviewScreenshotsCreateInstance(subscriptionAppStoreReviewScreenshotCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionAppStoreReviewScreenshotsApi.SubscriptionAppStoreReviewScreenshotsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionAppStoreReviewScreenshotsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionAppStoreReviewScreenshotResponse> response = apiInstance.SubscriptionAppStoreReviewScreenshotsCreateInstanceWithHttpInfo(subscriptionAppStoreReviewScreenshotCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionAppStoreReviewScreenshotsApi.SubscriptionAppStoreReviewScreenshotsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionAppStoreReviewScreenshotCreateRequest** | [**SubscriptionAppStoreReviewScreenshotCreateRequest**](SubscriptionAppStoreReviewScreenshotCreateRequest.md) | SubscriptionAppStoreReviewScreenshot representation |  |

### Return type

[**SubscriptionAppStoreReviewScreenshotResponse**](SubscriptionAppStoreReviewScreenshotResponse.md)

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
| **201** | Single SubscriptionAppStoreReviewScreenshot |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionappstorereviewscreenshotsdeleteinstance"></a>
# **SubscriptionAppStoreReviewScreenshotsDeleteInstance**
> void SubscriptionAppStoreReviewScreenshotsDeleteInstance (string id)



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
    public class SubscriptionAppStoreReviewScreenshotsDeleteInstanceExample
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
            var apiInstance = new SubscriptionAppStoreReviewScreenshotsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.SubscriptionAppStoreReviewScreenshotsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionAppStoreReviewScreenshotsApi.SubscriptionAppStoreReviewScreenshotsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionAppStoreReviewScreenshotsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SubscriptionAppStoreReviewScreenshotsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionAppStoreReviewScreenshotsApi.SubscriptionAppStoreReviewScreenshotsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="subscriptionappstorereviewscreenshotsgetinstance"></a>
# **SubscriptionAppStoreReviewScreenshotsGetInstance**
> SubscriptionAppStoreReviewScreenshotResponse SubscriptionAppStoreReviewScreenshotsGetInstance (string id, List<string>? fieldsSubscriptionAppStoreReviewScreenshots = null, List<string>? include = null)



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
    public class SubscriptionAppStoreReviewScreenshotsGetInstanceExample
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
            var apiInstance = new SubscriptionAppStoreReviewScreenshotsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsSubscriptionAppStoreReviewScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptionAppStoreReviewScreenshots (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                SubscriptionAppStoreReviewScreenshotResponse result = apiInstance.SubscriptionAppStoreReviewScreenshotsGetInstance(id, fieldsSubscriptionAppStoreReviewScreenshots, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionAppStoreReviewScreenshotsApi.SubscriptionAppStoreReviewScreenshotsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionAppStoreReviewScreenshotsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionAppStoreReviewScreenshotResponse> response = apiInstance.SubscriptionAppStoreReviewScreenshotsGetInstanceWithHttpInfo(id, fieldsSubscriptionAppStoreReviewScreenshots, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionAppStoreReviewScreenshotsApi.SubscriptionAppStoreReviewScreenshotsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsSubscriptionAppStoreReviewScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptionAppStoreReviewScreenshots | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**SubscriptionAppStoreReviewScreenshotResponse**](SubscriptionAppStoreReviewScreenshotResponse.md)

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
| **200** | Single SubscriptionAppStoreReviewScreenshot |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionappstorereviewscreenshotsupdateinstance"></a>
# **SubscriptionAppStoreReviewScreenshotsUpdateInstance**
> SubscriptionAppStoreReviewScreenshotResponse SubscriptionAppStoreReviewScreenshotsUpdateInstance (string id, SubscriptionAppStoreReviewScreenshotUpdateRequest subscriptionAppStoreReviewScreenshotUpdateRequest)



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
    public class SubscriptionAppStoreReviewScreenshotsUpdateInstanceExample
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
            var apiInstance = new SubscriptionAppStoreReviewScreenshotsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var subscriptionAppStoreReviewScreenshotUpdateRequest = new SubscriptionAppStoreReviewScreenshotUpdateRequest(); // SubscriptionAppStoreReviewScreenshotUpdateRequest | SubscriptionAppStoreReviewScreenshot representation

            try
            {
                SubscriptionAppStoreReviewScreenshotResponse result = apiInstance.SubscriptionAppStoreReviewScreenshotsUpdateInstance(id, subscriptionAppStoreReviewScreenshotUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionAppStoreReviewScreenshotsApi.SubscriptionAppStoreReviewScreenshotsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionAppStoreReviewScreenshotsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionAppStoreReviewScreenshotResponse> response = apiInstance.SubscriptionAppStoreReviewScreenshotsUpdateInstanceWithHttpInfo(id, subscriptionAppStoreReviewScreenshotUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionAppStoreReviewScreenshotsApi.SubscriptionAppStoreReviewScreenshotsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **subscriptionAppStoreReviewScreenshotUpdateRequest** | [**SubscriptionAppStoreReviewScreenshotUpdateRequest**](SubscriptionAppStoreReviewScreenshotUpdateRequest.md) | SubscriptionAppStoreReviewScreenshot representation |  |

### Return type

[**SubscriptionAppStoreReviewScreenshotResponse**](SubscriptionAppStoreReviewScreenshotResponse.md)

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
| **200** | Single SubscriptionAppStoreReviewScreenshot |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

