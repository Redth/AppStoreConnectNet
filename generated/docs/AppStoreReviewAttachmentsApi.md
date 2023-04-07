# AppStoreConnect.Net.Api.AppStoreReviewAttachmentsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppStoreReviewAttachmentsCreateInstance**](AppStoreReviewAttachmentsApi.md#appstorereviewattachmentscreateinstance) | **POST** /v1/appStoreReviewAttachments |  |
| [**AppStoreReviewAttachmentsDeleteInstance**](AppStoreReviewAttachmentsApi.md#appstorereviewattachmentsdeleteinstance) | **DELETE** /v1/appStoreReviewAttachments/{id} |  |
| [**AppStoreReviewAttachmentsGetInstance**](AppStoreReviewAttachmentsApi.md#appstorereviewattachmentsgetinstance) | **GET** /v1/appStoreReviewAttachments/{id} |  |
| [**AppStoreReviewAttachmentsUpdateInstance**](AppStoreReviewAttachmentsApi.md#appstorereviewattachmentsupdateinstance) | **PATCH** /v1/appStoreReviewAttachments/{id} |  |

<a name="appstorereviewattachmentscreateinstance"></a>
# **AppStoreReviewAttachmentsCreateInstance**
> AppStoreReviewAttachmentResponse AppStoreReviewAttachmentsCreateInstance (AppStoreReviewAttachmentCreateRequest appStoreReviewAttachmentCreateRequest)



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
    public class AppStoreReviewAttachmentsCreateInstanceExample
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
            var apiInstance = new AppStoreReviewAttachmentsApi(httpClient, config, httpClientHandler);
            var appStoreReviewAttachmentCreateRequest = new AppStoreReviewAttachmentCreateRequest(); // AppStoreReviewAttachmentCreateRequest | AppStoreReviewAttachment representation

            try
            {
                AppStoreReviewAttachmentResponse result = apiInstance.AppStoreReviewAttachmentsCreateInstance(appStoreReviewAttachmentCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreReviewAttachmentsApi.AppStoreReviewAttachmentsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreReviewAttachmentsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreReviewAttachmentResponse> response = apiInstance.AppStoreReviewAttachmentsCreateInstanceWithHttpInfo(appStoreReviewAttachmentCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreReviewAttachmentsApi.AppStoreReviewAttachmentsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appStoreReviewAttachmentCreateRequest** | [**AppStoreReviewAttachmentCreateRequest**](AppStoreReviewAttachmentCreateRequest.md) | AppStoreReviewAttachment representation |  |

### Return type

[**AppStoreReviewAttachmentResponse**](AppStoreReviewAttachmentResponse.md)

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
| **201** | Single AppStoreReviewAttachment |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstorereviewattachmentsdeleteinstance"></a>
# **AppStoreReviewAttachmentsDeleteInstance**
> void AppStoreReviewAttachmentsDeleteInstance (string id)



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
    public class AppStoreReviewAttachmentsDeleteInstanceExample
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
            var apiInstance = new AppStoreReviewAttachmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppStoreReviewAttachmentsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreReviewAttachmentsApi.AppStoreReviewAttachmentsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreReviewAttachmentsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppStoreReviewAttachmentsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreReviewAttachmentsApi.AppStoreReviewAttachmentsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="appstorereviewattachmentsgetinstance"></a>
# **AppStoreReviewAttachmentsGetInstance**
> AppStoreReviewAttachmentResponse AppStoreReviewAttachmentsGetInstance (string id, List<string>? fieldsAppStoreReviewAttachments = null, List<string>? include = null)



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
    public class AppStoreReviewAttachmentsGetInstanceExample
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
            var apiInstance = new AppStoreReviewAttachmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreReviewAttachments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewAttachments (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppStoreReviewAttachmentResponse result = apiInstance.AppStoreReviewAttachmentsGetInstance(id, fieldsAppStoreReviewAttachments, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreReviewAttachmentsApi.AppStoreReviewAttachmentsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreReviewAttachmentsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreReviewAttachmentResponse> response = apiInstance.AppStoreReviewAttachmentsGetInstanceWithHttpInfo(id, fieldsAppStoreReviewAttachments, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreReviewAttachmentsApi.AppStoreReviewAttachmentsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreReviewAttachments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewAttachments | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppStoreReviewAttachmentResponse**](AppStoreReviewAttachmentResponse.md)

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
| **200** | Single AppStoreReviewAttachment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstorereviewattachmentsupdateinstance"></a>
# **AppStoreReviewAttachmentsUpdateInstance**
> AppStoreReviewAttachmentResponse AppStoreReviewAttachmentsUpdateInstance (string id, AppStoreReviewAttachmentUpdateRequest appStoreReviewAttachmentUpdateRequest)



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
    public class AppStoreReviewAttachmentsUpdateInstanceExample
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
            var apiInstance = new AppStoreReviewAttachmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appStoreReviewAttachmentUpdateRequest = new AppStoreReviewAttachmentUpdateRequest(); // AppStoreReviewAttachmentUpdateRequest | AppStoreReviewAttachment representation

            try
            {
                AppStoreReviewAttachmentResponse result = apiInstance.AppStoreReviewAttachmentsUpdateInstance(id, appStoreReviewAttachmentUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreReviewAttachmentsApi.AppStoreReviewAttachmentsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreReviewAttachmentsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreReviewAttachmentResponse> response = apiInstance.AppStoreReviewAttachmentsUpdateInstanceWithHttpInfo(id, appStoreReviewAttachmentUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreReviewAttachmentsApi.AppStoreReviewAttachmentsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appStoreReviewAttachmentUpdateRequest** | [**AppStoreReviewAttachmentUpdateRequest**](AppStoreReviewAttachmentUpdateRequest.md) | AppStoreReviewAttachment representation |  |

### Return type

[**AppStoreReviewAttachmentResponse**](AppStoreReviewAttachmentResponse.md)

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
| **200** | Single AppStoreReviewAttachment |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

