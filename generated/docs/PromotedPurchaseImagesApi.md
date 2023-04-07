# AppStoreConnect.Net.Api.PromotedPurchaseImagesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PromotedPurchaseImagesCreateInstance**](PromotedPurchaseImagesApi.md#promotedpurchaseimagescreateinstance) | **POST** /v1/promotedPurchaseImages |  |
| [**PromotedPurchaseImagesDeleteInstance**](PromotedPurchaseImagesApi.md#promotedpurchaseimagesdeleteinstance) | **DELETE** /v1/promotedPurchaseImages/{id} |  |
| [**PromotedPurchaseImagesGetInstance**](PromotedPurchaseImagesApi.md#promotedpurchaseimagesgetinstance) | **GET** /v1/promotedPurchaseImages/{id} |  |
| [**PromotedPurchaseImagesUpdateInstance**](PromotedPurchaseImagesApi.md#promotedpurchaseimagesupdateinstance) | **PATCH** /v1/promotedPurchaseImages/{id} |  |

<a name="promotedpurchaseimagescreateinstance"></a>
# **PromotedPurchaseImagesCreateInstance**
> PromotedPurchaseImageResponse PromotedPurchaseImagesCreateInstance (PromotedPurchaseImageCreateRequest promotedPurchaseImageCreateRequest)



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
    public class PromotedPurchaseImagesCreateInstanceExample
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
            var apiInstance = new PromotedPurchaseImagesApi(httpClient, config, httpClientHandler);
            var promotedPurchaseImageCreateRequest = new PromotedPurchaseImageCreateRequest(); // PromotedPurchaseImageCreateRequest | PromotedPurchaseImage representation

            try
            {
                PromotedPurchaseImageResponse result = apiInstance.PromotedPurchaseImagesCreateInstance(promotedPurchaseImageCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotedPurchaseImagesApi.PromotedPurchaseImagesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PromotedPurchaseImagesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PromotedPurchaseImageResponse> response = apiInstance.PromotedPurchaseImagesCreateInstanceWithHttpInfo(promotedPurchaseImageCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotedPurchaseImagesApi.PromotedPurchaseImagesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **promotedPurchaseImageCreateRequest** | [**PromotedPurchaseImageCreateRequest**](PromotedPurchaseImageCreateRequest.md) | PromotedPurchaseImage representation |  |

### Return type

[**PromotedPurchaseImageResponse**](PromotedPurchaseImageResponse.md)

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
| **201** | Single PromotedPurchaseImage |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="promotedpurchaseimagesdeleteinstance"></a>
# **PromotedPurchaseImagesDeleteInstance**
> void PromotedPurchaseImagesDeleteInstance (string id)



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
    public class PromotedPurchaseImagesDeleteInstanceExample
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
            var apiInstance = new PromotedPurchaseImagesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.PromotedPurchaseImagesDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotedPurchaseImagesApi.PromotedPurchaseImagesDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PromotedPurchaseImagesDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PromotedPurchaseImagesDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotedPurchaseImagesApi.PromotedPurchaseImagesDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="promotedpurchaseimagesgetinstance"></a>
# **PromotedPurchaseImagesGetInstance**
> PromotedPurchaseImageResponse PromotedPurchaseImagesGetInstance (string id, List<string>? fieldsPromotedPurchaseImages = null, List<string>? include = null)



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
    public class PromotedPurchaseImagesGetInstanceExample
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
            var apiInstance = new PromotedPurchaseImagesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsPromotedPurchaseImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchaseImages (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                PromotedPurchaseImageResponse result = apiInstance.PromotedPurchaseImagesGetInstance(id, fieldsPromotedPurchaseImages, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotedPurchaseImagesApi.PromotedPurchaseImagesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PromotedPurchaseImagesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PromotedPurchaseImageResponse> response = apiInstance.PromotedPurchaseImagesGetInstanceWithHttpInfo(id, fieldsPromotedPurchaseImages, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotedPurchaseImagesApi.PromotedPurchaseImagesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsPromotedPurchaseImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchaseImages | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**PromotedPurchaseImageResponse**](PromotedPurchaseImageResponse.md)

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
| **200** | Single PromotedPurchaseImage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="promotedpurchaseimagesupdateinstance"></a>
# **PromotedPurchaseImagesUpdateInstance**
> PromotedPurchaseImageResponse PromotedPurchaseImagesUpdateInstance (string id, PromotedPurchaseImageUpdateRequest promotedPurchaseImageUpdateRequest)



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
    public class PromotedPurchaseImagesUpdateInstanceExample
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
            var apiInstance = new PromotedPurchaseImagesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var promotedPurchaseImageUpdateRequest = new PromotedPurchaseImageUpdateRequest(); // PromotedPurchaseImageUpdateRequest | PromotedPurchaseImage representation

            try
            {
                PromotedPurchaseImageResponse result = apiInstance.PromotedPurchaseImagesUpdateInstance(id, promotedPurchaseImageUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotedPurchaseImagesApi.PromotedPurchaseImagesUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PromotedPurchaseImagesUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PromotedPurchaseImageResponse> response = apiInstance.PromotedPurchaseImagesUpdateInstanceWithHttpInfo(id, promotedPurchaseImageUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotedPurchaseImagesApi.PromotedPurchaseImagesUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **promotedPurchaseImageUpdateRequest** | [**PromotedPurchaseImageUpdateRequest**](PromotedPurchaseImageUpdateRequest.md) | PromotedPurchaseImage representation |  |

### Return type

[**PromotedPurchaseImageResponse**](PromotedPurchaseImageResponse.md)

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
| **200** | Single PromotedPurchaseImage |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

