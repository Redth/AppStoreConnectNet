# AppStoreConnect.Net.Api.AppStoreReviewDetailsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelated**](AppStoreReviewDetailsApi.md#appstorereviewdetailsappstorereviewattachmentsgettomanyrelated) | **GET** /v1/appStoreReviewDetails/{id}/appStoreReviewAttachments |  |
| [**AppStoreReviewDetailsCreateInstance**](AppStoreReviewDetailsApi.md#appstorereviewdetailscreateinstance) | **POST** /v1/appStoreReviewDetails |  |
| [**AppStoreReviewDetailsGetInstance**](AppStoreReviewDetailsApi.md#appstorereviewdetailsgetinstance) | **GET** /v1/appStoreReviewDetails/{id} |  |
| [**AppStoreReviewDetailsUpdateInstance**](AppStoreReviewDetailsApi.md#appstorereviewdetailsupdateinstance) | **PATCH** /v1/appStoreReviewDetails/{id} |  |

<a name="appstorereviewdetailsappstorereviewattachmentsgettomanyrelated"></a>
# **AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelated**
> AppStoreReviewAttachmentsResponse AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelated (string id, List<string>? fieldsAppStoreReviewDetails = null, List<string>? fieldsAppStoreReviewAttachments = null, int? limit = null, List<string>? include = null)



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
    public class AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedExample
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
            var apiInstance = new AppStoreReviewDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewDetails (optional) 
            var fieldsAppStoreReviewAttachments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewAttachments (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppStoreReviewAttachmentsResponse result = apiInstance.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelated(id, fieldsAppStoreReviewDetails, fieldsAppStoreReviewAttachments, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreReviewDetailsApi.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreReviewAttachmentsResponse> response = apiInstance.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedWithHttpInfo(id, fieldsAppStoreReviewDetails, fieldsAppStoreReviewAttachments, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreReviewDetailsApi.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewDetails | [optional]  |
| **fieldsAppStoreReviewAttachments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewAttachments | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppStoreReviewAttachmentsResponse**](AppStoreReviewAttachmentsResponse.md)

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
| **200** | List of AppStoreReviewAttachments |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstorereviewdetailscreateinstance"></a>
# **AppStoreReviewDetailsCreateInstance**
> AppStoreReviewDetailResponse AppStoreReviewDetailsCreateInstance (AppStoreReviewDetailCreateRequest appStoreReviewDetailCreateRequest)



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
    public class AppStoreReviewDetailsCreateInstanceExample
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
            var apiInstance = new AppStoreReviewDetailsApi(httpClient, config, httpClientHandler);
            var appStoreReviewDetailCreateRequest = new AppStoreReviewDetailCreateRequest(); // AppStoreReviewDetailCreateRequest | AppStoreReviewDetail representation

            try
            {
                AppStoreReviewDetailResponse result = apiInstance.AppStoreReviewDetailsCreateInstance(appStoreReviewDetailCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreReviewDetailsApi.AppStoreReviewDetailsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreReviewDetailsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreReviewDetailResponse> response = apiInstance.AppStoreReviewDetailsCreateInstanceWithHttpInfo(appStoreReviewDetailCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreReviewDetailsApi.AppStoreReviewDetailsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appStoreReviewDetailCreateRequest** | [**AppStoreReviewDetailCreateRequest**](AppStoreReviewDetailCreateRequest.md) | AppStoreReviewDetail representation |  |

### Return type

[**AppStoreReviewDetailResponse**](AppStoreReviewDetailResponse.md)

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
| **201** | Single AppStoreReviewDetail |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstorereviewdetailsgetinstance"></a>
# **AppStoreReviewDetailsGetInstance**
> AppStoreReviewDetailResponse AppStoreReviewDetailsGetInstance (string id, List<string>? fieldsAppStoreReviewDetails = null, List<string>? include = null, List<string>? fieldsAppStoreReviewAttachments = null, int? limitAppStoreReviewAttachments = null)



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
    public class AppStoreReviewDetailsGetInstanceExample
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
            var apiInstance = new AppStoreReviewDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewDetails (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAppStoreReviewAttachments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewAttachments (optional) 
            var limitAppStoreReviewAttachments = 56;  // int? | maximum number of related appStoreReviewAttachments returned (when they are included) (optional) 

            try
            {
                AppStoreReviewDetailResponse result = apiInstance.AppStoreReviewDetailsGetInstance(id, fieldsAppStoreReviewDetails, include, fieldsAppStoreReviewAttachments, limitAppStoreReviewAttachments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreReviewDetailsApi.AppStoreReviewDetailsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreReviewDetailsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreReviewDetailResponse> response = apiInstance.AppStoreReviewDetailsGetInstanceWithHttpInfo(id, fieldsAppStoreReviewDetails, include, fieldsAppStoreReviewAttachments, limitAppStoreReviewAttachments);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreReviewDetailsApi.AppStoreReviewDetailsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewDetails | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAppStoreReviewAttachments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewAttachments | [optional]  |
| **limitAppStoreReviewAttachments** | **int?** | maximum number of related appStoreReviewAttachments returned (when they are included) | [optional]  |

### Return type

[**AppStoreReviewDetailResponse**](AppStoreReviewDetailResponse.md)

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
| **200** | Single AppStoreReviewDetail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appstorereviewdetailsupdateinstance"></a>
# **AppStoreReviewDetailsUpdateInstance**
> AppStoreReviewDetailResponse AppStoreReviewDetailsUpdateInstance (string id, AppStoreReviewDetailUpdateRequest appStoreReviewDetailUpdateRequest)



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
    public class AppStoreReviewDetailsUpdateInstanceExample
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
            var apiInstance = new AppStoreReviewDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appStoreReviewDetailUpdateRequest = new AppStoreReviewDetailUpdateRequest(); // AppStoreReviewDetailUpdateRequest | AppStoreReviewDetail representation

            try
            {
                AppStoreReviewDetailResponse result = apiInstance.AppStoreReviewDetailsUpdateInstance(id, appStoreReviewDetailUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreReviewDetailsApi.AppStoreReviewDetailsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreReviewDetailsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreReviewDetailResponse> response = apiInstance.AppStoreReviewDetailsUpdateInstanceWithHttpInfo(id, appStoreReviewDetailUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreReviewDetailsApi.AppStoreReviewDetailsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appStoreReviewDetailUpdateRequest** | [**AppStoreReviewDetailUpdateRequest**](AppStoreReviewDetailUpdateRequest.md) | AppStoreReviewDetail representation |  |

### Return type

[**AppStoreReviewDetailResponse**](AppStoreReviewDetailResponse.md)

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
| **200** | Single AppStoreReviewDetail |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

