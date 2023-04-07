# AppStoreConnect.Net.Api.ReviewSubmissionsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReviewSubmissionsCreateInstance**](ReviewSubmissionsApi.md#reviewsubmissionscreateinstance) | **POST** /v1/reviewSubmissions |  |
| [**ReviewSubmissionsGetCollection**](ReviewSubmissionsApi.md#reviewsubmissionsgetcollection) | **GET** /v1/reviewSubmissions |  |
| [**ReviewSubmissionsGetInstance**](ReviewSubmissionsApi.md#reviewsubmissionsgetinstance) | **GET** /v1/reviewSubmissions/{id} |  |
| [**ReviewSubmissionsItemsGetToManyRelated**](ReviewSubmissionsApi.md#reviewsubmissionsitemsgettomanyrelated) | **GET** /v1/reviewSubmissions/{id}/items |  |
| [**ReviewSubmissionsUpdateInstance**](ReviewSubmissionsApi.md#reviewsubmissionsupdateinstance) | **PATCH** /v1/reviewSubmissions/{id} |  |

<a name="reviewsubmissionscreateinstance"></a>
# **ReviewSubmissionsCreateInstance**
> ReviewSubmissionResponse ReviewSubmissionsCreateInstance (ReviewSubmissionCreateRequest reviewSubmissionCreateRequest)



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
    public class ReviewSubmissionsCreateInstanceExample
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
            var apiInstance = new ReviewSubmissionsApi(httpClient, config, httpClientHandler);
            var reviewSubmissionCreateRequest = new ReviewSubmissionCreateRequest(); // ReviewSubmissionCreateRequest | ReviewSubmission representation

            try
            {
                ReviewSubmissionResponse result = apiInstance.ReviewSubmissionsCreateInstance(reviewSubmissionCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewSubmissionsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReviewSubmissionResponse> response = apiInstance.ReviewSubmissionsCreateInstanceWithHttpInfo(reviewSubmissionCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reviewSubmissionCreateRequest** | [**ReviewSubmissionCreateRequest**](ReviewSubmissionCreateRequest.md) | ReviewSubmission representation |  |

### Return type

[**ReviewSubmissionResponse**](ReviewSubmissionResponse.md)

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
| **201** | Single ReviewSubmission |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reviewsubmissionsgetcollection"></a>
# **ReviewSubmissionsGetCollection**
> ReviewSubmissionsResponse ReviewSubmissionsGetCollection (List<string> filterApp, List<string>? filterPlatform = null, List<string>? filterState = null, List<string>? fieldsReviewSubmissions = null, int? limit = null, List<string>? include = null, List<string>? fieldsReviewSubmissionItems = null, int? limitItems = null)



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
    public class ReviewSubmissionsGetCollectionExample
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
            var apiInstance = new ReviewSubmissionsApi(httpClient, config, httpClientHandler);
            var filterApp = new List<string>(); // List<string> | filter by id(s) of related 'app'
            var filterPlatform = new List<string>?(); // List<string>? | filter by attribute 'platform' (optional) 
            var filterState = new List<string>?(); // List<string>? | filter by attribute 'state' (optional) 
            var fieldsReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissions (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsReviewSubmissionItems = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissionItems (optional) 
            var limitItems = 56;  // int? | maximum number of related items returned (when they are included) (optional) 

            try
            {
                ReviewSubmissionsResponse result = apiInstance.ReviewSubmissionsGetCollection(filterApp, filterPlatform, filterState, fieldsReviewSubmissions, limit, include, fieldsReviewSubmissionItems, limitItems);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewSubmissionsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReviewSubmissionsResponse> response = apiInstance.ReviewSubmissionsGetCollectionWithHttpInfo(filterApp, filterPlatform, filterState, fieldsReviewSubmissions, limit, include, fieldsReviewSubmissionItems, limitItems);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterApp** | [**List&lt;string&gt;**](string.md) | filter by id(s) of related &#39;app&#39; |  |
| **filterPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platform&#39; | [optional]  |
| **filterState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;state&#39; | [optional]  |
| **fieldsReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissions | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsReviewSubmissionItems** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissionItems | [optional]  |
| **limitItems** | **int?** | maximum number of related items returned (when they are included) | [optional]  |

### Return type

[**ReviewSubmissionsResponse**](ReviewSubmissionsResponse.md)

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
| **200** | List of ReviewSubmissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reviewsubmissionsgetinstance"></a>
# **ReviewSubmissionsGetInstance**
> ReviewSubmissionResponse ReviewSubmissionsGetInstance (string id, List<string>? fieldsReviewSubmissions = null, List<string>? include = null, List<string>? fieldsReviewSubmissionItems = null, int? limitItems = null)



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
    public class ReviewSubmissionsGetInstanceExample
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
            var apiInstance = new ReviewSubmissionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissions (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsReviewSubmissionItems = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissionItems (optional) 
            var limitItems = 56;  // int? | maximum number of related items returned (when they are included) (optional) 

            try
            {
                ReviewSubmissionResponse result = apiInstance.ReviewSubmissionsGetInstance(id, fieldsReviewSubmissions, include, fieldsReviewSubmissionItems, limitItems);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewSubmissionsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReviewSubmissionResponse> response = apiInstance.ReviewSubmissionsGetInstanceWithHttpInfo(id, fieldsReviewSubmissions, include, fieldsReviewSubmissionItems, limitItems);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissions | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsReviewSubmissionItems** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissionItems | [optional]  |
| **limitItems** | **int?** | maximum number of related items returned (when they are included) | [optional]  |

### Return type

[**ReviewSubmissionResponse**](ReviewSubmissionResponse.md)

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
| **200** | Single ReviewSubmission |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reviewsubmissionsitemsgettomanyrelated"></a>
# **ReviewSubmissionsItemsGetToManyRelated**
> ReviewSubmissionItemsResponse ReviewSubmissionsItemsGetToManyRelated (string id, List<string>? fieldsAppStoreVersionExperiments = null, List<string>? fieldsReviewSubmissionItems = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppCustomProductPageVersions = null, List<string>? fieldsAppEvents = null, int? limit = null, List<string>? include = null)



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
    public class ReviewSubmissionsItemsGetToManyRelatedExample
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
            var apiInstance = new ReviewSubmissionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreVersionExperiments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperiments (optional) 
            var fieldsReviewSubmissionItems = new List<string>?(); // List<string>? | the fields to include for returned resources of type reviewSubmissionItems (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppCustomProductPageVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCustomProductPageVersions (optional) 
            var fieldsAppEvents = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEvents (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                ReviewSubmissionItemsResponse result = apiInstance.ReviewSubmissionsItemsGetToManyRelated(id, fieldsAppStoreVersionExperiments, fieldsReviewSubmissionItems, fieldsAppStoreVersions, fieldsAppCustomProductPageVersions, fieldsAppEvents, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsItemsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewSubmissionsItemsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReviewSubmissionItemsResponse> response = apiInstance.ReviewSubmissionsItemsGetToManyRelatedWithHttpInfo(id, fieldsAppStoreVersionExperiments, fieldsReviewSubmissionItems, fieldsAppStoreVersions, fieldsAppCustomProductPageVersions, fieldsAppEvents, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsItemsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreVersionExperiments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperiments | [optional]  |
| **fieldsReviewSubmissionItems** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type reviewSubmissionItems | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppCustomProductPageVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCustomProductPageVersions | [optional]  |
| **fieldsAppEvents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEvents | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**ReviewSubmissionItemsResponse**](ReviewSubmissionItemsResponse.md)

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
| **200** | List of ReviewSubmissionItems |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reviewsubmissionsupdateinstance"></a>
# **ReviewSubmissionsUpdateInstance**
> ReviewSubmissionResponse ReviewSubmissionsUpdateInstance (string id, ReviewSubmissionUpdateRequest reviewSubmissionUpdateRequest)



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
    public class ReviewSubmissionsUpdateInstanceExample
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
            var apiInstance = new ReviewSubmissionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var reviewSubmissionUpdateRequest = new ReviewSubmissionUpdateRequest(); // ReviewSubmissionUpdateRequest | ReviewSubmission representation

            try
            {
                ReviewSubmissionResponse result = apiInstance.ReviewSubmissionsUpdateInstance(id, reviewSubmissionUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewSubmissionsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReviewSubmissionResponse> response = apiInstance.ReviewSubmissionsUpdateInstanceWithHttpInfo(id, reviewSubmissionUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewSubmissionsApi.ReviewSubmissionsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **reviewSubmissionUpdateRequest** | [**ReviewSubmissionUpdateRequest**](ReviewSubmissionUpdateRequest.md) | ReviewSubmission representation |  |

### Return type

[**ReviewSubmissionResponse**](ReviewSubmissionResponse.md)

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
| **200** | Single ReviewSubmission |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

