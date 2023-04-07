# AppStoreConnect.Net.Api.SandboxTestersClearPurchaseHistoryRequestApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SandboxTestersClearPurchaseHistoryRequestCreateInstance**](SandboxTestersClearPurchaseHistoryRequestApi.md#sandboxtestersclearpurchasehistoryrequestcreateinstance) | **POST** /v2/sandboxTestersClearPurchaseHistoryRequest |  |

<a name="sandboxtestersclearpurchasehistoryrequestcreateinstance"></a>
# **SandboxTestersClearPurchaseHistoryRequestCreateInstance**
> SandboxTestersClearPurchaseHistoryRequestV2Response SandboxTestersClearPurchaseHistoryRequestCreateInstance (SandboxTestersClearPurchaseHistoryRequestV2CreateRequest sandboxTestersClearPurchaseHistoryRequestV2CreateRequest)



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
    public class SandboxTestersClearPurchaseHistoryRequestCreateInstanceExample
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
            var apiInstance = new SandboxTestersClearPurchaseHistoryRequestApi(httpClient, config, httpClientHandler);
            var sandboxTestersClearPurchaseHistoryRequestV2CreateRequest = new SandboxTestersClearPurchaseHistoryRequestV2CreateRequest(); // SandboxTestersClearPurchaseHistoryRequestV2CreateRequest | SandboxTestersClearPurchaseHistoryRequest representation

            try
            {
                SandboxTestersClearPurchaseHistoryRequestV2Response result = apiInstance.SandboxTestersClearPurchaseHistoryRequestCreateInstance(sandboxTestersClearPurchaseHistoryRequestV2CreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxTestersClearPurchaseHistoryRequestApi.SandboxTestersClearPurchaseHistoryRequestCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SandboxTestersClearPurchaseHistoryRequestCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SandboxTestersClearPurchaseHistoryRequestV2Response> response = apiInstance.SandboxTestersClearPurchaseHistoryRequestCreateInstanceWithHttpInfo(sandboxTestersClearPurchaseHistoryRequestV2CreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SandboxTestersClearPurchaseHistoryRequestApi.SandboxTestersClearPurchaseHistoryRequestCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sandboxTestersClearPurchaseHistoryRequestV2CreateRequest** | [**SandboxTestersClearPurchaseHistoryRequestV2CreateRequest**](SandboxTestersClearPurchaseHistoryRequestV2CreateRequest.md) | SandboxTestersClearPurchaseHistoryRequest representation |  |

### Return type

[**SandboxTestersClearPurchaseHistoryRequestV2Response**](SandboxTestersClearPurchaseHistoryRequestV2Response.md)

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
| **201** | Single SandboxTestersClearPurchaseHistoryRequest |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

