# AppStoreConnect.Net.Api.ScmProvidersApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ScmProvidersGetCollection**](ScmProvidersApi.md#scmprovidersgetcollection) | **GET** /v1/scmProviders |  |
| [**ScmProvidersGetInstance**](ScmProvidersApi.md#scmprovidersgetinstance) | **GET** /v1/scmProviders/{id} |  |
| [**ScmProvidersRepositoriesGetToManyRelated**](ScmProvidersApi.md#scmprovidersrepositoriesgettomanyrelated) | **GET** /v1/scmProviders/{id}/repositories |  |

<a name="scmprovidersgetcollection"></a>
# **ScmProvidersGetCollection**
> ScmProvidersResponse ScmProvidersGetCollection (List<string>? fieldsScmProviders = null, int? limit = null, List<string>? fieldsScmRepositories = null)



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
    public class ScmProvidersGetCollectionExample
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
            var apiInstance = new ScmProvidersApi(httpClient, config, httpClientHandler);
            var fieldsScmProviders = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmProviders (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 

            try
            {
                ScmProvidersResponse result = apiInstance.ScmProvidersGetCollection(fieldsScmProviders, limit, fieldsScmRepositories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScmProvidersApi.ScmProvidersGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScmProvidersGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ScmProvidersResponse> response = apiInstance.ScmProvidersGetCollectionWithHttpInfo(fieldsScmProviders, limit, fieldsScmRepositories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScmProvidersApi.ScmProvidersGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fieldsScmProviders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmProviders | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |

### Return type

[**ScmProvidersResponse**](ScmProvidersResponse.md)

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
| **200** | List of ScmProviders |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scmprovidersgetinstance"></a>
# **ScmProvidersGetInstance**
> ScmProviderResponse ScmProvidersGetInstance (string id, List<string>? fieldsScmProviders = null, List<string>? fieldsScmRepositories = null)



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
    public class ScmProvidersGetInstanceExample
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
            var apiInstance = new ScmProvidersApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsScmProviders = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmProviders (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 

            try
            {
                ScmProviderResponse result = apiInstance.ScmProvidersGetInstance(id, fieldsScmProviders, fieldsScmRepositories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScmProvidersApi.ScmProvidersGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScmProvidersGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ScmProviderResponse> response = apiInstance.ScmProvidersGetInstanceWithHttpInfo(id, fieldsScmProviders, fieldsScmRepositories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScmProvidersApi.ScmProvidersGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsScmProviders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmProviders | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |

### Return type

[**ScmProviderResponse**](ScmProviderResponse.md)

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
| **200** | Single ScmProvider |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scmprovidersrepositoriesgettomanyrelated"></a>
# **ScmProvidersRepositoriesGetToManyRelated**
> ScmRepositoriesResponse ScmProvidersRepositoriesGetToManyRelated (string id, List<string>? filterId = null, List<string>? fieldsScmGitReferences = null, List<string>? fieldsScmProviders = null, List<string>? fieldsScmRepositories = null, int? limit = null, List<string>? include = null)



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
    public class ScmProvidersRepositoriesGetToManyRelatedExample
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
            var apiInstance = new ScmProvidersApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsScmGitReferences = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmGitReferences (optional) 
            var fieldsScmProviders = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmProviders (optional) 
            var fieldsScmRepositories = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmRepositories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                ScmRepositoriesResponse result = apiInstance.ScmProvidersRepositoriesGetToManyRelated(id, filterId, fieldsScmGitReferences, fieldsScmProviders, fieldsScmRepositories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScmProvidersApi.ScmProvidersRepositoriesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScmProvidersRepositoriesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ScmRepositoriesResponse> response = apiInstance.ScmProvidersRepositoriesGetToManyRelatedWithHttpInfo(id, filterId, fieldsScmGitReferences, fieldsScmProviders, fieldsScmRepositories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScmProvidersApi.ScmProvidersRepositoriesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsScmGitReferences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmGitReferences | [optional]  |
| **fieldsScmProviders** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmProviders | [optional]  |
| **fieldsScmRepositories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmRepositories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**ScmRepositoriesResponse**](ScmRepositoriesResponse.md)

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
| **200** | List of ScmRepositories |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

