# AppStoreConnect.Net.Api.InAppPurchaseAppStoreReviewScreenshotsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InAppPurchaseAppStoreReviewScreenshotsCreateInstance**](InAppPurchaseAppStoreReviewScreenshotsApi.md#inapppurchaseappstorereviewscreenshotscreateinstance) | **POST** /v1/inAppPurchaseAppStoreReviewScreenshots |  |
| [**InAppPurchaseAppStoreReviewScreenshotsDeleteInstance**](InAppPurchaseAppStoreReviewScreenshotsApi.md#inapppurchaseappstorereviewscreenshotsdeleteinstance) | **DELETE** /v1/inAppPurchaseAppStoreReviewScreenshots/{id} |  |
| [**InAppPurchaseAppStoreReviewScreenshotsGetInstance**](InAppPurchaseAppStoreReviewScreenshotsApi.md#inapppurchaseappstorereviewscreenshotsgetinstance) | **GET** /v1/inAppPurchaseAppStoreReviewScreenshots/{id} |  |
| [**InAppPurchaseAppStoreReviewScreenshotsUpdateInstance**](InAppPurchaseAppStoreReviewScreenshotsApi.md#inapppurchaseappstorereviewscreenshotsupdateinstance) | **PATCH** /v1/inAppPurchaseAppStoreReviewScreenshots/{id} |  |

<a name="inapppurchaseappstorereviewscreenshotscreateinstance"></a>
# **InAppPurchaseAppStoreReviewScreenshotsCreateInstance**
> InAppPurchaseAppStoreReviewScreenshotResponse InAppPurchaseAppStoreReviewScreenshotsCreateInstance (InAppPurchaseAppStoreReviewScreenshotCreateRequest inAppPurchaseAppStoreReviewScreenshotCreateRequest)



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
    public class InAppPurchaseAppStoreReviewScreenshotsCreateInstanceExample
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
            var apiInstance = new InAppPurchaseAppStoreReviewScreenshotsApi(httpClient, config, httpClientHandler);
            var inAppPurchaseAppStoreReviewScreenshotCreateRequest = new InAppPurchaseAppStoreReviewScreenshotCreateRequest(); // InAppPurchaseAppStoreReviewScreenshotCreateRequest | InAppPurchaseAppStoreReviewScreenshot representation

            try
            {
                InAppPurchaseAppStoreReviewScreenshotResponse result = apiInstance.InAppPurchaseAppStoreReviewScreenshotsCreateInstance(inAppPurchaseAppStoreReviewScreenshotCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchaseAppStoreReviewScreenshotsApi.InAppPurchaseAppStoreReviewScreenshotsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchaseAppStoreReviewScreenshotsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseAppStoreReviewScreenshotResponse> response = apiInstance.InAppPurchaseAppStoreReviewScreenshotsCreateInstanceWithHttpInfo(inAppPurchaseAppStoreReviewScreenshotCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchaseAppStoreReviewScreenshotsApi.InAppPurchaseAppStoreReviewScreenshotsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inAppPurchaseAppStoreReviewScreenshotCreateRequest** | [**InAppPurchaseAppStoreReviewScreenshotCreateRequest**](InAppPurchaseAppStoreReviewScreenshotCreateRequest.md) | InAppPurchaseAppStoreReviewScreenshot representation |  |

### Return type

[**InAppPurchaseAppStoreReviewScreenshotResponse**](InAppPurchaseAppStoreReviewScreenshotResponse.md)

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
| **201** | Single InAppPurchaseAppStoreReviewScreenshot |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inapppurchaseappstorereviewscreenshotsdeleteinstance"></a>
# **InAppPurchaseAppStoreReviewScreenshotsDeleteInstance**
> void InAppPurchaseAppStoreReviewScreenshotsDeleteInstance (string id)



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
    public class InAppPurchaseAppStoreReviewScreenshotsDeleteInstanceExample
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
            var apiInstance = new InAppPurchaseAppStoreReviewScreenshotsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.InAppPurchaseAppStoreReviewScreenshotsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchaseAppStoreReviewScreenshotsApi.InAppPurchaseAppStoreReviewScreenshotsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchaseAppStoreReviewScreenshotsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.InAppPurchaseAppStoreReviewScreenshotsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchaseAppStoreReviewScreenshotsApi.InAppPurchaseAppStoreReviewScreenshotsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="inapppurchaseappstorereviewscreenshotsgetinstance"></a>
# **InAppPurchaseAppStoreReviewScreenshotsGetInstance**
> InAppPurchaseAppStoreReviewScreenshotResponse InAppPurchaseAppStoreReviewScreenshotsGetInstance (string id, List<string>? fieldsInAppPurchaseAppStoreReviewScreenshots = null, List<string>? include = null)



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
    public class InAppPurchaseAppStoreReviewScreenshotsGetInstanceExample
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
            var apiInstance = new InAppPurchaseAppStoreReviewScreenshotsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchaseAppStoreReviewScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseAppStoreReviewScreenshots (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchaseAppStoreReviewScreenshotResponse result = apiInstance.InAppPurchaseAppStoreReviewScreenshotsGetInstance(id, fieldsInAppPurchaseAppStoreReviewScreenshots, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchaseAppStoreReviewScreenshotsApi.InAppPurchaseAppStoreReviewScreenshotsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchaseAppStoreReviewScreenshotsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseAppStoreReviewScreenshotResponse> response = apiInstance.InAppPurchaseAppStoreReviewScreenshotsGetInstanceWithHttpInfo(id, fieldsInAppPurchaseAppStoreReviewScreenshots, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchaseAppStoreReviewScreenshotsApi.InAppPurchaseAppStoreReviewScreenshotsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchaseAppStoreReviewScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseAppStoreReviewScreenshots | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchaseAppStoreReviewScreenshotResponse**](InAppPurchaseAppStoreReviewScreenshotResponse.md)

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
| **200** | Single InAppPurchaseAppStoreReviewScreenshot |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inapppurchaseappstorereviewscreenshotsupdateinstance"></a>
# **InAppPurchaseAppStoreReviewScreenshotsUpdateInstance**
> InAppPurchaseAppStoreReviewScreenshotResponse InAppPurchaseAppStoreReviewScreenshotsUpdateInstance (string id, InAppPurchaseAppStoreReviewScreenshotUpdateRequest inAppPurchaseAppStoreReviewScreenshotUpdateRequest)



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
    public class InAppPurchaseAppStoreReviewScreenshotsUpdateInstanceExample
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
            var apiInstance = new InAppPurchaseAppStoreReviewScreenshotsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var inAppPurchaseAppStoreReviewScreenshotUpdateRequest = new InAppPurchaseAppStoreReviewScreenshotUpdateRequest(); // InAppPurchaseAppStoreReviewScreenshotUpdateRequest | InAppPurchaseAppStoreReviewScreenshot representation

            try
            {
                InAppPurchaseAppStoreReviewScreenshotResponse result = apiInstance.InAppPurchaseAppStoreReviewScreenshotsUpdateInstance(id, inAppPurchaseAppStoreReviewScreenshotUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchaseAppStoreReviewScreenshotsApi.InAppPurchaseAppStoreReviewScreenshotsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchaseAppStoreReviewScreenshotsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseAppStoreReviewScreenshotResponse> response = apiInstance.InAppPurchaseAppStoreReviewScreenshotsUpdateInstanceWithHttpInfo(id, inAppPurchaseAppStoreReviewScreenshotUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchaseAppStoreReviewScreenshotsApi.InAppPurchaseAppStoreReviewScreenshotsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **inAppPurchaseAppStoreReviewScreenshotUpdateRequest** | [**InAppPurchaseAppStoreReviewScreenshotUpdateRequest**](InAppPurchaseAppStoreReviewScreenshotUpdateRequest.md) | InAppPurchaseAppStoreReviewScreenshot representation |  |

### Return type

[**InAppPurchaseAppStoreReviewScreenshotResponse**](InAppPurchaseAppStoreReviewScreenshotResponse.md)

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
| **200** | Single InAppPurchaseAppStoreReviewScreenshot |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

