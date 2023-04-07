# AppStoreConnect.Net.Api.BetaTesterInvitationsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BetaTesterInvitationsCreateInstance**](BetaTesterInvitationsApi.md#betatesterinvitationscreateinstance) | **POST** /v1/betaTesterInvitations |  |

<a name="betatesterinvitationscreateinstance"></a>
# **BetaTesterInvitationsCreateInstance**
> BetaTesterInvitationResponse BetaTesterInvitationsCreateInstance (BetaTesterInvitationCreateRequest betaTesterInvitationCreateRequest)



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
    public class BetaTesterInvitationsCreateInstanceExample
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
            var apiInstance = new BetaTesterInvitationsApi(httpClient, config, httpClientHandler);
            var betaTesterInvitationCreateRequest = new BetaTesterInvitationCreateRequest(); // BetaTesterInvitationCreateRequest | BetaTesterInvitation representation

            try
            {
                BetaTesterInvitationResponse result = apiInstance.BetaTesterInvitationsCreateInstance(betaTesterInvitationCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BetaTesterInvitationsApi.BetaTesterInvitationsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaTesterInvitationsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaTesterInvitationResponse> response = apiInstance.BetaTesterInvitationsCreateInstanceWithHttpInfo(betaTesterInvitationCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BetaTesterInvitationsApi.BetaTesterInvitationsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **betaTesterInvitationCreateRequest** | [**BetaTesterInvitationCreateRequest**](BetaTesterInvitationCreateRequest.md) | BetaTesterInvitation representation |  |

### Return type

[**BetaTesterInvitationResponse**](BetaTesterInvitationResponse.md)

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
| **201** | Single BetaTesterInvitation |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

