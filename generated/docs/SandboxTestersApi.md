# AppStoreConnect.Net.Api.SandboxTestersApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SandboxTestersGetCollection**](SandboxTestersApi.md#sandboxtestersgetcollection) | **GET** /v2/sandboxTesters |  |
| [**SandboxTestersUpdateInstance**](SandboxTestersApi.md#sandboxtestersupdateinstance) | **PATCH** /v2/sandboxTesters/{id} |  |

<a name="sandboxtestersgetcollection"></a>
# **SandboxTestersGetCollection**
> SandboxTestersV2Response SandboxTestersGetCollection (List<string>? fieldsSandboxTesters = null, int? limit = null)



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
    public class SandboxTestersGetCollectionExample
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
            var apiInstance = new SandboxTestersApi(httpClient, config, httpClientHandler);
            var fieldsSandboxTesters = new List<string>?(); // List<string>? | the fields to include for returned resources of type sandboxTesters (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                SandboxTestersV2Response result = apiInstance.SandboxTestersGetCollection(fieldsSandboxTesters, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxTestersApi.SandboxTestersGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SandboxTestersGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SandboxTestersV2Response> response = apiInstance.SandboxTestersGetCollectionWithHttpInfo(fieldsSandboxTesters, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SandboxTestersApi.SandboxTestersGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fieldsSandboxTesters** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type sandboxTesters | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**SandboxTestersV2Response**](SandboxTestersV2Response.md)

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
| **200** | List of SandboxTesters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sandboxtestersupdateinstance"></a>
# **SandboxTestersUpdateInstance**
> SandboxTesterV2Response SandboxTestersUpdateInstance (string id, SandboxTesterV2UpdateRequest sandboxTesterV2UpdateRequest)



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
    public class SandboxTestersUpdateInstanceExample
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
            var apiInstance = new SandboxTestersApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var sandboxTesterV2UpdateRequest = new SandboxTesterV2UpdateRequest(); // SandboxTesterV2UpdateRequest | SandboxTester representation

            try
            {
                SandboxTesterV2Response result = apiInstance.SandboxTestersUpdateInstance(id, sandboxTesterV2UpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SandboxTestersApi.SandboxTestersUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SandboxTestersUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SandboxTesterV2Response> response = apiInstance.SandboxTestersUpdateInstanceWithHttpInfo(id, sandboxTesterV2UpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SandboxTestersApi.SandboxTestersUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **sandboxTesterV2UpdateRequest** | [**SandboxTesterV2UpdateRequest**](SandboxTesterV2UpdateRequest.md) | SandboxTester representation |  |

### Return type

[**SandboxTesterV2Response**](SandboxTesterV2Response.md)

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
| **200** | Single SandboxTester |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

