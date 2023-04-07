# AppStoreConnect.Net.Api.CiXcodeVersionsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CiXcodeVersionsGetCollection**](CiXcodeVersionsApi.md#cixcodeversionsgetcollection) | **GET** /v1/ciXcodeVersions |  |
| [**CiXcodeVersionsGetInstance**](CiXcodeVersionsApi.md#cixcodeversionsgetinstance) | **GET** /v1/ciXcodeVersions/{id} |  |
| [**CiXcodeVersionsMacOsVersionsGetToManyRelated**](CiXcodeVersionsApi.md#cixcodeversionsmacosversionsgettomanyrelated) | **GET** /v1/ciXcodeVersions/{id}/macOsVersions |  |

<a name="cixcodeversionsgetcollection"></a>
# **CiXcodeVersionsGetCollection**
> CiXcodeVersionsResponse CiXcodeVersionsGetCollection (List<string>? fieldsCiXcodeVersions = null, int? limit = null, List<string>? include = null, List<string>? fieldsCiMacOsVersions = null, int? limitMacOsVersions = null)



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
    public class CiXcodeVersionsGetCollectionExample
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
            var apiInstance = new CiXcodeVersionsApi(httpClient, config, httpClientHandler);
            var fieldsCiXcodeVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciXcodeVersions (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsCiMacOsVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciMacOsVersions (optional) 
            var limitMacOsVersions = 56;  // int? | maximum number of related macOsVersions returned (when they are included) (optional) 

            try
            {
                CiXcodeVersionsResponse result = apiInstance.CiXcodeVersionsGetCollection(fieldsCiXcodeVersions, limit, include, fieldsCiMacOsVersions, limitMacOsVersions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiXcodeVersionsApi.CiXcodeVersionsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiXcodeVersionsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiXcodeVersionsResponse> response = apiInstance.CiXcodeVersionsGetCollectionWithHttpInfo(fieldsCiXcodeVersions, limit, include, fieldsCiMacOsVersions, limitMacOsVersions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiXcodeVersionsApi.CiXcodeVersionsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fieldsCiXcodeVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciXcodeVersions | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsCiMacOsVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciMacOsVersions | [optional]  |
| **limitMacOsVersions** | **int?** | maximum number of related macOsVersions returned (when they are included) | [optional]  |

### Return type

[**CiXcodeVersionsResponse**](CiXcodeVersionsResponse.md)

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
| **200** | List of CiXcodeVersions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cixcodeversionsgetinstance"></a>
# **CiXcodeVersionsGetInstance**
> CiXcodeVersionResponse CiXcodeVersionsGetInstance (string id, List<string>? fieldsCiXcodeVersions = null, List<string>? include = null, List<string>? fieldsCiMacOsVersions = null, int? limitMacOsVersions = null)



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
    public class CiXcodeVersionsGetInstanceExample
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
            var apiInstance = new CiXcodeVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiXcodeVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciXcodeVersions (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsCiMacOsVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciMacOsVersions (optional) 
            var limitMacOsVersions = 56;  // int? | maximum number of related macOsVersions returned (when they are included) (optional) 

            try
            {
                CiXcodeVersionResponse result = apiInstance.CiXcodeVersionsGetInstance(id, fieldsCiXcodeVersions, include, fieldsCiMacOsVersions, limitMacOsVersions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiXcodeVersionsApi.CiXcodeVersionsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiXcodeVersionsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiXcodeVersionResponse> response = apiInstance.CiXcodeVersionsGetInstanceWithHttpInfo(id, fieldsCiXcodeVersions, include, fieldsCiMacOsVersions, limitMacOsVersions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiXcodeVersionsApi.CiXcodeVersionsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiXcodeVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciXcodeVersions | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsCiMacOsVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciMacOsVersions | [optional]  |
| **limitMacOsVersions** | **int?** | maximum number of related macOsVersions returned (when they are included) | [optional]  |

### Return type

[**CiXcodeVersionResponse**](CiXcodeVersionResponse.md)

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
| **200** | Single CiXcodeVersion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cixcodeversionsmacosversionsgettomanyrelated"></a>
# **CiXcodeVersionsMacOsVersionsGetToManyRelated**
> CiMacOsVersionsResponse CiXcodeVersionsMacOsVersionsGetToManyRelated (string id, List<string>? fieldsCiXcodeVersions = null, List<string>? fieldsCiMacOsVersions = null, int? limit = null, int? limitXcodeVersions = null, List<string>? include = null)



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
    public class CiXcodeVersionsMacOsVersionsGetToManyRelatedExample
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
            var apiInstance = new CiXcodeVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiXcodeVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciXcodeVersions (optional) 
            var fieldsCiMacOsVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciMacOsVersions (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var limitXcodeVersions = 56;  // int? | maximum number of related xcodeVersions returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                CiMacOsVersionsResponse result = apiInstance.CiXcodeVersionsMacOsVersionsGetToManyRelated(id, fieldsCiXcodeVersions, fieldsCiMacOsVersions, limit, limitXcodeVersions, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiXcodeVersionsApi.CiXcodeVersionsMacOsVersionsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiXcodeVersionsMacOsVersionsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiMacOsVersionsResponse> response = apiInstance.CiXcodeVersionsMacOsVersionsGetToManyRelatedWithHttpInfo(id, fieldsCiXcodeVersions, fieldsCiMacOsVersions, limit, limitXcodeVersions, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiXcodeVersionsApi.CiXcodeVersionsMacOsVersionsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiXcodeVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciXcodeVersions | [optional]  |
| **fieldsCiMacOsVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciMacOsVersions | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **limitXcodeVersions** | **int?** | maximum number of related xcodeVersions returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**CiMacOsVersionsResponse**](CiMacOsVersionsResponse.md)

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
| **200** | List of CiMacOsVersions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

