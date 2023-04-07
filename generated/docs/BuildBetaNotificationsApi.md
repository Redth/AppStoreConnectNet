# AppStoreConnect.Net.Api.BuildBetaNotificationsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BuildBetaNotificationsCreateInstance**](BuildBetaNotificationsApi.md#buildbetanotificationscreateinstance) | **POST** /v1/buildBetaNotifications |  |

<a name="buildbetanotificationscreateinstance"></a>
# **BuildBetaNotificationsCreateInstance**
> BuildBetaNotificationResponse BuildBetaNotificationsCreateInstance (BuildBetaNotificationCreateRequest buildBetaNotificationCreateRequest)



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
    public class BuildBetaNotificationsCreateInstanceExample
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
            var apiInstance = new BuildBetaNotificationsApi(httpClient, config, httpClientHandler);
            var buildBetaNotificationCreateRequest = new BuildBetaNotificationCreateRequest(); // BuildBetaNotificationCreateRequest | BuildBetaNotification representation

            try
            {
                BuildBetaNotificationResponse result = apiInstance.BuildBetaNotificationsCreateInstance(buildBetaNotificationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildBetaNotificationsApi.BuildBetaNotificationsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildBetaNotificationsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildBetaNotificationResponse> response = apiInstance.BuildBetaNotificationsCreateInstanceWithHttpInfo(buildBetaNotificationCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildBetaNotificationsApi.BuildBetaNotificationsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **buildBetaNotificationCreateRequest** | [**BuildBetaNotificationCreateRequest**](BuildBetaNotificationCreateRequest.md) | BuildBetaNotification representation |  |

### Return type

[**BuildBetaNotificationResponse**](BuildBetaNotificationResponse.md)

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
| **201** | Single BuildBetaNotification |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

