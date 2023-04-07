# AppStoreConnect.Net.Api.ReviewSubmissionItemsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReviewSubmissionItemsCreateInstance**](ReviewSubmissionItemsApi.md#reviewsubmissionitemscreateinstance) | **POST** /v1/reviewSubmissionItems |  |
| [**ReviewSubmissionItemsDeleteInstance**](ReviewSubmissionItemsApi.md#reviewsubmissionitemsdeleteinstance) | **DELETE** /v1/reviewSubmissionItems/{id} |  |
| [**ReviewSubmissionItemsUpdateInstance**](ReviewSubmissionItemsApi.md#reviewsubmissionitemsupdateinstance) | **PATCH** /v1/reviewSubmissionItems/{id} |  |

<a name="reviewsubmissionitemscreateinstance"></a>
# **ReviewSubmissionItemsCreateInstance**
> ReviewSubmissionItemResponse ReviewSubmissionItemsCreateInstance (ReviewSubmissionItemCreateRequest reviewSubmissionItemCreateRequest)



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
    public class ReviewSubmissionItemsCreateInstanceExample
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
            var apiInstance = new ReviewSubmissionItemsApi(httpClient, config, httpClientHandler);
            var reviewSubmissionItemCreateRequest = new ReviewSubmissionItemCreateRequest(); // ReviewSubmissionItemCreateRequest | ReviewSubmissionItem representation

            try
            {
                ReviewSubmissionItemResponse result = apiInstance.ReviewSubmissionItemsCreateInstance(reviewSubmissionItemCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewSubmissionItemsApi.ReviewSubmissionItemsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewSubmissionItemsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReviewSubmissionItemResponse> response = apiInstance.ReviewSubmissionItemsCreateInstanceWithHttpInfo(reviewSubmissionItemCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewSubmissionItemsApi.ReviewSubmissionItemsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reviewSubmissionItemCreateRequest** | [**ReviewSubmissionItemCreateRequest**](ReviewSubmissionItemCreateRequest.md) | ReviewSubmissionItem representation |  |

### Return type

[**ReviewSubmissionItemResponse**](ReviewSubmissionItemResponse.md)

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
| **201** | Single ReviewSubmissionItem |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reviewsubmissionitemsdeleteinstance"></a>
# **ReviewSubmissionItemsDeleteInstance**
> void ReviewSubmissionItemsDeleteInstance (string id)



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
    public class ReviewSubmissionItemsDeleteInstanceExample
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
            var apiInstance = new ReviewSubmissionItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.ReviewSubmissionItemsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewSubmissionItemsApi.ReviewSubmissionItemsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewSubmissionItemsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ReviewSubmissionItemsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewSubmissionItemsApi.ReviewSubmissionItemsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a name="reviewsubmissionitemsupdateinstance"></a>
# **ReviewSubmissionItemsUpdateInstance**
> ReviewSubmissionItemResponse ReviewSubmissionItemsUpdateInstance (string id, ReviewSubmissionItemUpdateRequest reviewSubmissionItemUpdateRequest)



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
    public class ReviewSubmissionItemsUpdateInstanceExample
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
            var apiInstance = new ReviewSubmissionItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var reviewSubmissionItemUpdateRequest = new ReviewSubmissionItemUpdateRequest(); // ReviewSubmissionItemUpdateRequest | ReviewSubmissionItem representation

            try
            {
                ReviewSubmissionItemResponse result = apiInstance.ReviewSubmissionItemsUpdateInstance(id, reviewSubmissionItemUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewSubmissionItemsApi.ReviewSubmissionItemsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewSubmissionItemsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReviewSubmissionItemResponse> response = apiInstance.ReviewSubmissionItemsUpdateInstanceWithHttpInfo(id, reviewSubmissionItemUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewSubmissionItemsApi.ReviewSubmissionItemsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **reviewSubmissionItemUpdateRequest** | [**ReviewSubmissionItemUpdateRequest**](ReviewSubmissionItemUpdateRequest.md) | ReviewSubmissionItem representation |  |

### Return type

[**ReviewSubmissionItemResponse**](ReviewSubmissionItemResponse.md)

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
| **200** | Single ReviewSubmissionItem |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

