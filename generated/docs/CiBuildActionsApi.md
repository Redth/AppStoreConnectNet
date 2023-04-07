# AppStoreConnect.Net.Api.CiBuildActionsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CiBuildActionsArtifactsGetToManyRelated**](CiBuildActionsApi.md#cibuildactionsartifactsgettomanyrelated) | **GET** /v1/ciBuildActions/{id}/artifacts |  |
| [**CiBuildActionsBuildRunGetToOneRelated**](CiBuildActionsApi.md#cibuildactionsbuildrungettoonerelated) | **GET** /v1/ciBuildActions/{id}/buildRun |  |
| [**CiBuildActionsGetInstance**](CiBuildActionsApi.md#cibuildactionsgetinstance) | **GET** /v1/ciBuildActions/{id} |  |
| [**CiBuildActionsIssuesGetToManyRelated**](CiBuildActionsApi.md#cibuildactionsissuesgettomanyrelated) | **GET** /v1/ciBuildActions/{id}/issues |  |
| [**CiBuildActionsTestResultsGetToManyRelated**](CiBuildActionsApi.md#cibuildactionstestresultsgettomanyrelated) | **GET** /v1/ciBuildActions/{id}/testResults |  |

<a name="cibuildactionsartifactsgettomanyrelated"></a>
# **CiBuildActionsArtifactsGetToManyRelated**
> CiArtifactsResponse CiBuildActionsArtifactsGetToManyRelated (string id, List<string>? fieldsCiArtifacts = null, int? limit = null)



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
    public class CiBuildActionsArtifactsGetToManyRelatedExample
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
            var apiInstance = new CiBuildActionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiArtifacts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciArtifacts (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                CiArtifactsResponse result = apiInstance.CiBuildActionsArtifactsGetToManyRelated(id, fieldsCiArtifacts, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsArtifactsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiBuildActionsArtifactsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiArtifactsResponse> response = apiInstance.CiBuildActionsArtifactsGetToManyRelatedWithHttpInfo(id, fieldsCiArtifacts, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsArtifactsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiArtifacts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciArtifacts | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**CiArtifactsResponse**](CiArtifactsResponse.md)

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
| **200** | List of CiArtifacts |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cibuildactionsbuildrungettoonerelated"></a>
# **CiBuildActionsBuildRunGetToOneRelated**
> CiBuildRunResponse CiBuildActionsBuildRunGetToOneRelated (string id, List<string>? fieldsScmGitReferences = null, List<string>? fieldsCiBuildRuns = null, List<string>? fieldsCiWorkflows = null, List<string>? fieldsScmPullRequests = null, List<string>? fieldsCiProducts = null, List<string>? fieldsBuilds = null, int? limitBuilds = null, List<string>? include = null)



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
    public class CiBuildActionsBuildRunGetToOneRelatedExample
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
            var apiInstance = new CiBuildActionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsScmGitReferences = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmGitReferences (optional) 
            var fieldsCiBuildRuns = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciBuildRuns (optional) 
            var fieldsCiWorkflows = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciWorkflows (optional) 
            var fieldsScmPullRequests = new List<string>?(); // List<string>? | the fields to include for returned resources of type scmPullRequests (optional) 
            var fieldsCiProducts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciProducts (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var limitBuilds = 56;  // int? | maximum number of related builds returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                CiBuildRunResponse result = apiInstance.CiBuildActionsBuildRunGetToOneRelated(id, fieldsScmGitReferences, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsScmPullRequests, fieldsCiProducts, fieldsBuilds, limitBuilds, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsBuildRunGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiBuildActionsBuildRunGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiBuildRunResponse> response = apiInstance.CiBuildActionsBuildRunGetToOneRelatedWithHttpInfo(id, fieldsScmGitReferences, fieldsCiBuildRuns, fieldsCiWorkflows, fieldsScmPullRequests, fieldsCiProducts, fieldsBuilds, limitBuilds, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsBuildRunGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsScmGitReferences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmGitReferences | [optional]  |
| **fieldsCiBuildRuns** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciBuildRuns | [optional]  |
| **fieldsCiWorkflows** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciWorkflows | [optional]  |
| **fieldsScmPullRequests** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type scmPullRequests | [optional]  |
| **fieldsCiProducts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciProducts | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **limitBuilds** | **int?** | maximum number of related builds returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**CiBuildRunResponse**](CiBuildRunResponse.md)

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
| **200** | Single CiBuildRun |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cibuildactionsgetinstance"></a>
# **CiBuildActionsGetInstance**
> CiBuildActionResponse CiBuildActionsGetInstance (string id, List<string>? fieldsCiBuildActions = null, List<string>? include = null, List<string>? fieldsCiIssues = null, List<string>? fieldsCiBuildRuns = null, List<string>? fieldsCiTestResults = null, List<string>? fieldsCiArtifacts = null)



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
    public class CiBuildActionsGetInstanceExample
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
            var apiInstance = new CiBuildActionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiBuildActions = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciBuildActions (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsCiIssues = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciIssues (optional) 
            var fieldsCiBuildRuns = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciBuildRuns (optional) 
            var fieldsCiTestResults = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciTestResults (optional) 
            var fieldsCiArtifacts = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciArtifacts (optional) 

            try
            {
                CiBuildActionResponse result = apiInstance.CiBuildActionsGetInstance(id, fieldsCiBuildActions, include, fieldsCiIssues, fieldsCiBuildRuns, fieldsCiTestResults, fieldsCiArtifacts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiBuildActionsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiBuildActionResponse> response = apiInstance.CiBuildActionsGetInstanceWithHttpInfo(id, fieldsCiBuildActions, include, fieldsCiIssues, fieldsCiBuildRuns, fieldsCiTestResults, fieldsCiArtifacts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiBuildActions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciBuildActions | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsCiIssues** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciIssues | [optional]  |
| **fieldsCiBuildRuns** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciBuildRuns | [optional]  |
| **fieldsCiTestResults** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciTestResults | [optional]  |
| **fieldsCiArtifacts** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciArtifacts | [optional]  |

### Return type

[**CiBuildActionResponse**](CiBuildActionResponse.md)

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
| **200** | Single CiBuildAction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cibuildactionsissuesgettomanyrelated"></a>
# **CiBuildActionsIssuesGetToManyRelated**
> CiIssuesResponse CiBuildActionsIssuesGetToManyRelated (string id, List<string>? fieldsCiIssues = null, int? limit = null)



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
    public class CiBuildActionsIssuesGetToManyRelatedExample
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
            var apiInstance = new CiBuildActionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiIssues = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciIssues (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                CiIssuesResponse result = apiInstance.CiBuildActionsIssuesGetToManyRelated(id, fieldsCiIssues, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsIssuesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiBuildActionsIssuesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiIssuesResponse> response = apiInstance.CiBuildActionsIssuesGetToManyRelatedWithHttpInfo(id, fieldsCiIssues, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsIssuesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiIssues** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciIssues | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**CiIssuesResponse**](CiIssuesResponse.md)

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
| **200** | List of CiIssues |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cibuildactionstestresultsgettomanyrelated"></a>
# **CiBuildActionsTestResultsGetToManyRelated**
> CiTestResultsResponse CiBuildActionsTestResultsGetToManyRelated (string id, List<string>? fieldsCiTestResults = null, int? limit = null)



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
    public class CiBuildActionsTestResultsGetToManyRelatedExample
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
            var apiInstance = new CiBuildActionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCiTestResults = new List<string>?(); // List<string>? | the fields to include for returned resources of type ciTestResults (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                CiTestResultsResponse result = apiInstance.CiBuildActionsTestResultsGetToManyRelated(id, fieldsCiTestResults, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsTestResultsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CiBuildActionsTestResultsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CiTestResultsResponse> response = apiInstance.CiBuildActionsTestResultsGetToManyRelatedWithHttpInfo(id, fieldsCiTestResults, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CiBuildActionsApi.CiBuildActionsTestResultsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCiTestResults** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ciTestResults | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**CiTestResultsResponse**](CiTestResultsResponse.md)

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
| **200** | List of CiTestResults |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

