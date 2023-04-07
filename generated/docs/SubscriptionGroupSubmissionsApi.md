# AppStoreConnect.Net.Api.SubscriptionGroupSubmissionsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionGroupSubmissionsCreateInstance**](SubscriptionGroupSubmissionsApi.md#subscriptiongroupsubmissionscreateinstance) | **POST** /v1/subscriptionGroupSubmissions |  |

<a name="subscriptiongroupsubmissionscreateinstance"></a>
# **SubscriptionGroupSubmissionsCreateInstance**
> SubscriptionGroupSubmissionResponse SubscriptionGroupSubmissionsCreateInstance (SubscriptionGroupSubmissionCreateRequest subscriptionGroupSubmissionCreateRequest)



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
    public class SubscriptionGroupSubmissionsCreateInstanceExample
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
            var apiInstance = new SubscriptionGroupSubmissionsApi(httpClient, config, httpClientHandler);
            var subscriptionGroupSubmissionCreateRequest = new SubscriptionGroupSubmissionCreateRequest(); // SubscriptionGroupSubmissionCreateRequest | SubscriptionGroupSubmission representation

            try
            {
                SubscriptionGroupSubmissionResponse result = apiInstance.SubscriptionGroupSubmissionsCreateInstance(subscriptionGroupSubmissionCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionGroupSubmissionsApi.SubscriptionGroupSubmissionsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGroupSubmissionsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SubscriptionGroupSubmissionResponse> response = apiInstance.SubscriptionGroupSubmissionsCreateInstanceWithHttpInfo(subscriptionGroupSubmissionCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionGroupSubmissionsApi.SubscriptionGroupSubmissionsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionGroupSubmissionCreateRequest** | [**SubscriptionGroupSubmissionCreateRequest**](SubscriptionGroupSubmissionCreateRequest.md) | SubscriptionGroupSubmission representation |  |

### Return type

[**SubscriptionGroupSubmissionResponse**](SubscriptionGroupSubmissionResponse.md)

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
| **201** | Single SubscriptionGroupSubmission |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

