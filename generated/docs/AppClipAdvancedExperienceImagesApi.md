# AppStoreConnect.Net.Api.AppClipAdvancedExperienceImagesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppClipAdvancedExperienceImagesCreateInstance**](AppClipAdvancedExperienceImagesApi.md#appclipadvancedexperienceimagescreateinstance) | **POST** /v1/appClipAdvancedExperienceImages |  |
| [**AppClipAdvancedExperienceImagesGetInstance**](AppClipAdvancedExperienceImagesApi.md#appclipadvancedexperienceimagesgetinstance) | **GET** /v1/appClipAdvancedExperienceImages/{id} |  |
| [**AppClipAdvancedExperienceImagesUpdateInstance**](AppClipAdvancedExperienceImagesApi.md#appclipadvancedexperienceimagesupdateinstance) | **PATCH** /v1/appClipAdvancedExperienceImages/{id} |  |

<a name="appclipadvancedexperienceimagescreateinstance"></a>
# **AppClipAdvancedExperienceImagesCreateInstance**
> AppClipAdvancedExperienceImageResponse AppClipAdvancedExperienceImagesCreateInstance (AppClipAdvancedExperienceImageCreateRequest appClipAdvancedExperienceImageCreateRequest)



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
    public class AppClipAdvancedExperienceImagesCreateInstanceExample
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
            var apiInstance = new AppClipAdvancedExperienceImagesApi(httpClient, config, httpClientHandler);
            var appClipAdvancedExperienceImageCreateRequest = new AppClipAdvancedExperienceImageCreateRequest(); // AppClipAdvancedExperienceImageCreateRequest | AppClipAdvancedExperienceImage representation

            try
            {
                AppClipAdvancedExperienceImageResponse result = apiInstance.AppClipAdvancedExperienceImagesCreateInstance(appClipAdvancedExperienceImageCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAdvancedExperienceImagesApi.AppClipAdvancedExperienceImagesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAdvancedExperienceImagesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAdvancedExperienceImageResponse> response = apiInstance.AppClipAdvancedExperienceImagesCreateInstanceWithHttpInfo(appClipAdvancedExperienceImageCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAdvancedExperienceImagesApi.AppClipAdvancedExperienceImagesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appClipAdvancedExperienceImageCreateRequest** | [**AppClipAdvancedExperienceImageCreateRequest**](AppClipAdvancedExperienceImageCreateRequest.md) | AppClipAdvancedExperienceImage representation |  |

### Return type

[**AppClipAdvancedExperienceImageResponse**](AppClipAdvancedExperienceImageResponse.md)

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
| **201** | Single AppClipAdvancedExperienceImage |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipadvancedexperienceimagesgetinstance"></a>
# **AppClipAdvancedExperienceImagesGetInstance**
> AppClipAdvancedExperienceImageResponse AppClipAdvancedExperienceImagesGetInstance (string id, List<string>? fieldsAppClipAdvancedExperienceImages = null)



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
    public class AppClipAdvancedExperienceImagesGetInstanceExample
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
            var apiInstance = new AppClipAdvancedExperienceImagesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipAdvancedExperienceImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAdvancedExperienceImages (optional) 

            try
            {
                AppClipAdvancedExperienceImageResponse result = apiInstance.AppClipAdvancedExperienceImagesGetInstance(id, fieldsAppClipAdvancedExperienceImages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAdvancedExperienceImagesApi.AppClipAdvancedExperienceImagesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAdvancedExperienceImagesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAdvancedExperienceImageResponse> response = apiInstance.AppClipAdvancedExperienceImagesGetInstanceWithHttpInfo(id, fieldsAppClipAdvancedExperienceImages);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAdvancedExperienceImagesApi.AppClipAdvancedExperienceImagesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipAdvancedExperienceImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAdvancedExperienceImages | [optional]  |

### Return type

[**AppClipAdvancedExperienceImageResponse**](AppClipAdvancedExperienceImageResponse.md)

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
| **200** | Single AppClipAdvancedExperienceImage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appclipadvancedexperienceimagesupdateinstance"></a>
# **AppClipAdvancedExperienceImagesUpdateInstance**
> AppClipAdvancedExperienceImageResponse AppClipAdvancedExperienceImagesUpdateInstance (string id, AppClipAdvancedExperienceImageUpdateRequest appClipAdvancedExperienceImageUpdateRequest)



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
    public class AppClipAdvancedExperienceImagesUpdateInstanceExample
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
            var apiInstance = new AppClipAdvancedExperienceImagesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appClipAdvancedExperienceImageUpdateRequest = new AppClipAdvancedExperienceImageUpdateRequest(); // AppClipAdvancedExperienceImageUpdateRequest | AppClipAdvancedExperienceImage representation

            try
            {
                AppClipAdvancedExperienceImageResponse result = apiInstance.AppClipAdvancedExperienceImagesUpdateInstance(id, appClipAdvancedExperienceImageUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppClipAdvancedExperienceImagesApi.AppClipAdvancedExperienceImagesUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppClipAdvancedExperienceImagesUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipAdvancedExperienceImageResponse> response = apiInstance.AppClipAdvancedExperienceImagesUpdateInstanceWithHttpInfo(id, appClipAdvancedExperienceImageUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppClipAdvancedExperienceImagesApi.AppClipAdvancedExperienceImagesUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appClipAdvancedExperienceImageUpdateRequest** | [**AppClipAdvancedExperienceImageUpdateRequest**](AppClipAdvancedExperienceImageUpdateRequest.md) | AppClipAdvancedExperienceImage representation |  |

### Return type

[**AppClipAdvancedExperienceImageResponse**](AppClipAdvancedExperienceImageResponse.md)

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
| **200** | Single AppClipAdvancedExperienceImage |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

