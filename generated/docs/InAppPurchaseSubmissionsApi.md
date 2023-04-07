# AppStoreConnect.Net.Api.InAppPurchaseSubmissionsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InAppPurchaseSubmissionsCreateInstance**](InAppPurchaseSubmissionsApi.md#inapppurchasesubmissionscreateinstance) | **POST** /v1/inAppPurchaseSubmissions |  |

<a name="inapppurchasesubmissionscreateinstance"></a>
# **InAppPurchaseSubmissionsCreateInstance**
> InAppPurchaseSubmissionResponse InAppPurchaseSubmissionsCreateInstance (InAppPurchaseSubmissionCreateRequest inAppPurchaseSubmissionCreateRequest)



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
    public class InAppPurchaseSubmissionsCreateInstanceExample
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
            var apiInstance = new InAppPurchaseSubmissionsApi(httpClient, config, httpClientHandler);
            var inAppPurchaseSubmissionCreateRequest = new InAppPurchaseSubmissionCreateRequest(); // InAppPurchaseSubmissionCreateRequest | InAppPurchaseSubmission representation

            try
            {
                InAppPurchaseSubmissionResponse result = apiInstance.InAppPurchaseSubmissionsCreateInstance(inAppPurchaseSubmissionCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchaseSubmissionsApi.InAppPurchaseSubmissionsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchaseSubmissionsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseSubmissionResponse> response = apiInstance.InAppPurchaseSubmissionsCreateInstanceWithHttpInfo(inAppPurchaseSubmissionCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchaseSubmissionsApi.InAppPurchaseSubmissionsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inAppPurchaseSubmissionCreateRequest** | [**InAppPurchaseSubmissionCreateRequest**](InAppPurchaseSubmissionCreateRequest.md) | InAppPurchaseSubmission representation |  |

### Return type

[**InAppPurchaseSubmissionResponse**](InAppPurchaseSubmissionResponse.md)

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
| **201** | Single InAppPurchaseSubmission |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

