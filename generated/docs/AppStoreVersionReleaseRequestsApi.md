# AppStoreConnect.Net.Api.AppStoreVersionReleaseRequestsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppStoreVersionReleaseRequestsCreateInstance**](AppStoreVersionReleaseRequestsApi.md#appstoreversionreleaserequestscreateinstance) | **POST** /v1/appStoreVersionReleaseRequests |  |

<a name="appstoreversionreleaserequestscreateinstance"></a>
# **AppStoreVersionReleaseRequestsCreateInstance**
> AppStoreVersionReleaseRequestResponse AppStoreVersionReleaseRequestsCreateInstance (AppStoreVersionReleaseRequestCreateRequest appStoreVersionReleaseRequestCreateRequest)



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
    public class AppStoreVersionReleaseRequestsCreateInstanceExample
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
            var apiInstance = new AppStoreVersionReleaseRequestsApi(httpClient, config, httpClientHandler);
            var appStoreVersionReleaseRequestCreateRequest = new AppStoreVersionReleaseRequestCreateRequest(); // AppStoreVersionReleaseRequestCreateRequest | AppStoreVersionReleaseRequest representation

            try
            {
                AppStoreVersionReleaseRequestResponse result = apiInstance.AppStoreVersionReleaseRequestsCreateInstance(appStoreVersionReleaseRequestCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionReleaseRequestsApi.AppStoreVersionReleaseRequestsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionReleaseRequestsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionReleaseRequestResponse> response = apiInstance.AppStoreVersionReleaseRequestsCreateInstanceWithHttpInfo(appStoreVersionReleaseRequestCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionReleaseRequestsApi.AppStoreVersionReleaseRequestsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appStoreVersionReleaseRequestCreateRequest** | [**AppStoreVersionReleaseRequestCreateRequest**](AppStoreVersionReleaseRequestCreateRequest.md) | AppStoreVersionReleaseRequest representation |  |

### Return type

[**AppStoreVersionReleaseRequestResponse**](AppStoreVersionReleaseRequestResponse.md)

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
| **201** | Single AppStoreVersionReleaseRequest |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

