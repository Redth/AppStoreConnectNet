# AppStoreConnect.Net.Api.BuildsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BuildsAppEncryptionDeclarationGetToOneRelated**](BuildsApi.md#buildsappencryptiondeclarationgettoonerelated) | **GET** /v1/builds/{id}/appEncryptionDeclaration |  |
| [**BuildsAppEncryptionDeclarationGetToOneRelationship**](BuildsApi.md#buildsappencryptiondeclarationgettoonerelationship) | **GET** /v1/builds/{id}/relationships/appEncryptionDeclaration |  |
| [**BuildsAppEncryptionDeclarationUpdateToOneRelationship**](BuildsApi.md#buildsappencryptiondeclarationupdatetoonerelationship) | **PATCH** /v1/builds/{id}/relationships/appEncryptionDeclaration |  |
| [**BuildsAppGetToOneRelated**](BuildsApi.md#buildsappgettoonerelated) | **GET** /v1/builds/{id}/app |  |
| [**BuildsAppStoreVersionGetToOneRelated**](BuildsApi.md#buildsappstoreversiongettoonerelated) | **GET** /v1/builds/{id}/appStoreVersion |  |
| [**BuildsBetaAppReviewSubmissionGetToOneRelated**](BuildsApi.md#buildsbetaappreviewsubmissiongettoonerelated) | **GET** /v1/builds/{id}/betaAppReviewSubmission |  |
| [**BuildsBetaBuildLocalizationsGetToManyRelated**](BuildsApi.md#buildsbetabuildlocalizationsgettomanyrelated) | **GET** /v1/builds/{id}/betaBuildLocalizations |  |
| [**BuildsBetaGroupsCreateToManyRelationship**](BuildsApi.md#buildsbetagroupscreatetomanyrelationship) | **POST** /v1/builds/{id}/relationships/betaGroups |  |
| [**BuildsBetaGroupsDeleteToManyRelationship**](BuildsApi.md#buildsbetagroupsdeletetomanyrelationship) | **DELETE** /v1/builds/{id}/relationships/betaGroups |  |
| [**BuildsBuildBetaDetailGetToOneRelated**](BuildsApi.md#buildsbuildbetadetailgettoonerelated) | **GET** /v1/builds/{id}/buildBetaDetail |  |
| [**BuildsDiagnosticSignaturesGetToManyRelated**](BuildsApi.md#buildsdiagnosticsignaturesgettomanyrelated) | **GET** /v1/builds/{id}/diagnosticSignatures |  |
| [**BuildsGetCollection**](BuildsApi.md#buildsgetcollection) | **GET** /v1/builds |  |
| [**BuildsGetInstance**](BuildsApi.md#buildsgetinstance) | **GET** /v1/builds/{id} |  |
| [**BuildsIconsGetToManyRelated**](BuildsApi.md#buildsiconsgettomanyrelated) | **GET** /v1/builds/{id}/icons |  |
| [**BuildsIndividualTestersCreateToManyRelationship**](BuildsApi.md#buildsindividualtesterscreatetomanyrelationship) | **POST** /v1/builds/{id}/relationships/individualTesters |  |
| [**BuildsIndividualTestersDeleteToManyRelationship**](BuildsApi.md#buildsindividualtestersdeletetomanyrelationship) | **DELETE** /v1/builds/{id}/relationships/individualTesters |  |
| [**BuildsIndividualTestersGetToManyRelated**](BuildsApi.md#buildsindividualtestersgettomanyrelated) | **GET** /v1/builds/{id}/individualTesters |  |
| [**BuildsIndividualTestersGetToManyRelationship**](BuildsApi.md#buildsindividualtestersgettomanyrelationship) | **GET** /v1/builds/{id}/relationships/individualTesters |  |
| [**BuildsPerfPowerMetricsGetToManyRelated**](BuildsApi.md#buildsperfpowermetricsgettomanyrelated) | **GET** /v1/builds/{id}/perfPowerMetrics |  |
| [**BuildsPreReleaseVersionGetToOneRelated**](BuildsApi.md#buildsprereleaseversiongettoonerelated) | **GET** /v1/builds/{id}/preReleaseVersion |  |
| [**BuildsUpdateInstance**](BuildsApi.md#buildsupdateinstance) | **PATCH** /v1/builds/{id} |  |

<a name="buildsappencryptiondeclarationgettoonerelated"></a>
# **BuildsAppEncryptionDeclarationGetToOneRelated**
> AppEncryptionDeclarationResponse BuildsAppEncryptionDeclarationGetToOneRelated (string id, List<string>? fieldsAppEncryptionDeclarations = null)



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
    public class BuildsAppEncryptionDeclarationGetToOneRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppEncryptionDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEncryptionDeclarations (optional) 

            try
            {
                AppEncryptionDeclarationResponse result = apiInstance.BuildsAppEncryptionDeclarationGetToOneRelated(id, fieldsAppEncryptionDeclarations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsAppEncryptionDeclarationGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsAppEncryptionDeclarationGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppEncryptionDeclarationResponse> response = apiInstance.BuildsAppEncryptionDeclarationGetToOneRelatedWithHttpInfo(id, fieldsAppEncryptionDeclarations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsAppEncryptionDeclarationGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppEncryptionDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEncryptionDeclarations | [optional]  |

### Return type

[**AppEncryptionDeclarationResponse**](AppEncryptionDeclarationResponse.md)

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
| **200** | Single AppEncryptionDeclaration |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsappencryptiondeclarationgettoonerelationship"></a>
# **BuildsAppEncryptionDeclarationGetToOneRelationship**
> BuildAppEncryptionDeclarationLinkageResponse BuildsAppEncryptionDeclarationGetToOneRelationship (string id)



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
    public class BuildsAppEncryptionDeclarationGetToOneRelationshipExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                BuildAppEncryptionDeclarationLinkageResponse result = apiInstance.BuildsAppEncryptionDeclarationGetToOneRelationship(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsAppEncryptionDeclarationGetToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsAppEncryptionDeclarationGetToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildAppEncryptionDeclarationLinkageResponse> response = apiInstance.BuildsAppEncryptionDeclarationGetToOneRelationshipWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsAppEncryptionDeclarationGetToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

[**BuildAppEncryptionDeclarationLinkageResponse**](BuildAppEncryptionDeclarationLinkageResponse.md)

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
| **200** | Related linkage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsappencryptiondeclarationupdatetoonerelationship"></a>
# **BuildsAppEncryptionDeclarationUpdateToOneRelationship**
> void BuildsAppEncryptionDeclarationUpdateToOneRelationship (string id, BuildAppEncryptionDeclarationLinkageRequest buildAppEncryptionDeclarationLinkageRequest)



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
    public class BuildsAppEncryptionDeclarationUpdateToOneRelationshipExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var buildAppEncryptionDeclarationLinkageRequest = new BuildAppEncryptionDeclarationLinkageRequest(); // BuildAppEncryptionDeclarationLinkageRequest | Related linkage

            try
            {
                apiInstance.BuildsAppEncryptionDeclarationUpdateToOneRelationship(id, buildAppEncryptionDeclarationLinkageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsAppEncryptionDeclarationUpdateToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsAppEncryptionDeclarationUpdateToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BuildsAppEncryptionDeclarationUpdateToOneRelationshipWithHttpInfo(id, buildAppEncryptionDeclarationLinkageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsAppEncryptionDeclarationUpdateToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **buildAppEncryptionDeclarationLinkageRequest** | [**BuildAppEncryptionDeclarationLinkageRequest**](BuildAppEncryptionDeclarationLinkageRequest.md) | Related linkage |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsappgettoonerelated"></a>
# **BuildsAppGetToOneRelated**
> AppResponse BuildsAppGetToOneRelated (string id, List<string>? fieldsApps = null)



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
    public class BuildsAppGetToOneRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 

            try
            {
                AppResponse result = apiInstance.BuildsAppGetToOneRelated(id, fieldsApps);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsAppGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsAppGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppResponse> response = apiInstance.BuildsAppGetToOneRelatedWithHttpInfo(id, fieldsApps);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsAppGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |

### Return type

[**AppResponse**](AppResponse.md)

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
| **200** | Single App |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsappstoreversiongettoonerelated"></a>
# **BuildsAppStoreVersionGetToOneRelated**
> AppStoreVersionResponse BuildsAppStoreVersionGetToOneRelated (string id, List<string>? fieldsAppStoreVersionExperiments = null, List<string>? fieldsAgeRatingDeclarations = null, List<string>? fieldsAppStoreVersionSubmissions = null, List<string>? fieldsAppStoreReviewDetails = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsApps = null, List<string>? fieldsRoutingAppCoverages = null, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? fieldsAppStoreVersionPhasedReleases = null, List<string>? fieldsBuilds = null, List<string>? fieldsAppStoreVersionLocalizations = null, int? limitAppStoreVersionLocalizations = null, int? limitAppStoreVersionExperiments = null, List<string>? include = null)



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
    public class BuildsAppStoreVersionGetToOneRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreVersionExperiments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperiments (optional) 
            var fieldsAgeRatingDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type ageRatingDeclarations (optional) 
            var fieldsAppStoreVersionSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionSubmissions (optional) 
            var fieldsAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewDetails (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsRoutingAppCoverages = new List<string>?(); // List<string>? | the fields to include for returned resources of type routingAppCoverages (optional) 
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var fieldsAppStoreVersionPhasedReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionPhasedReleases (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var fieldsAppStoreVersionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionLocalizations (optional) 
            var limitAppStoreVersionLocalizations = 56;  // int? | maximum number of related appStoreVersionLocalizations returned (when they are included) (optional) 
            var limitAppStoreVersionExperiments = 56;  // int? | maximum number of related appStoreVersionExperiments returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppStoreVersionResponse result = apiInstance.BuildsAppStoreVersionGetToOneRelated(id, fieldsAppStoreVersionExperiments, fieldsAgeRatingDeclarations, fieldsAppStoreVersionSubmissions, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsApps, fieldsRoutingAppCoverages, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limitAppStoreVersionLocalizations, limitAppStoreVersionExperiments, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsAppStoreVersionGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsAppStoreVersionGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionResponse> response = apiInstance.BuildsAppStoreVersionGetToOneRelatedWithHttpInfo(id, fieldsAppStoreVersionExperiments, fieldsAgeRatingDeclarations, fieldsAppStoreVersionSubmissions, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsApps, fieldsRoutingAppCoverages, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionPhasedReleases, fieldsBuilds, fieldsAppStoreVersionLocalizations, limitAppStoreVersionLocalizations, limitAppStoreVersionExperiments, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsAppStoreVersionGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreVersionExperiments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperiments | [optional]  |
| **fieldsAgeRatingDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ageRatingDeclarations | [optional]  |
| **fieldsAppStoreVersionSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionSubmissions | [optional]  |
| **fieldsAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewDetails | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsRoutingAppCoverages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type routingAppCoverages | [optional]  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **fieldsAppStoreVersionPhasedReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionPhasedReleases | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **fieldsAppStoreVersionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionLocalizations | [optional]  |
| **limitAppStoreVersionLocalizations** | **int?** | maximum number of related appStoreVersionLocalizations returned (when they are included) | [optional]  |
| **limitAppStoreVersionExperiments** | **int?** | maximum number of related appStoreVersionExperiments returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppStoreVersionResponse**](AppStoreVersionResponse.md)

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
| **200** | Single AppStoreVersion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsbetaappreviewsubmissiongettoonerelated"></a>
# **BuildsBetaAppReviewSubmissionGetToOneRelated**
> BetaAppReviewSubmissionResponse BuildsBetaAppReviewSubmissionGetToOneRelated (string id, List<string>? fieldsBetaAppReviewSubmissions = null)



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
    public class BuildsBetaAppReviewSubmissionGetToOneRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaAppReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppReviewSubmissions (optional) 

            try
            {
                BetaAppReviewSubmissionResponse result = apiInstance.BuildsBetaAppReviewSubmissionGetToOneRelated(id, fieldsBetaAppReviewSubmissions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsBetaAppReviewSubmissionGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsBetaAppReviewSubmissionGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaAppReviewSubmissionResponse> response = apiInstance.BuildsBetaAppReviewSubmissionGetToOneRelatedWithHttpInfo(id, fieldsBetaAppReviewSubmissions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsBetaAppReviewSubmissionGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaAppReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppReviewSubmissions | [optional]  |

### Return type

[**BetaAppReviewSubmissionResponse**](BetaAppReviewSubmissionResponse.md)

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
| **200** | Single BetaAppReviewSubmission |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsbetabuildlocalizationsgettomanyrelated"></a>
# **BuildsBetaBuildLocalizationsGetToManyRelated**
> BetaBuildLocalizationsResponse BuildsBetaBuildLocalizationsGetToManyRelated (string id, List<string>? fieldsBetaBuildLocalizations = null, int? limit = null)



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
    public class BuildsBetaBuildLocalizationsGetToManyRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaBuildLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaBuildLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BetaBuildLocalizationsResponse result = apiInstance.BuildsBetaBuildLocalizationsGetToManyRelated(id, fieldsBetaBuildLocalizations, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsBetaBuildLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsBetaBuildLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaBuildLocalizationsResponse> response = apiInstance.BuildsBetaBuildLocalizationsGetToManyRelatedWithHttpInfo(id, fieldsBetaBuildLocalizations, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsBetaBuildLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaBuildLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaBuildLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BetaBuildLocalizationsResponse**](BetaBuildLocalizationsResponse.md)

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
| **200** | List of BetaBuildLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsbetagroupscreatetomanyrelationship"></a>
# **BuildsBetaGroupsCreateToManyRelationship**
> void BuildsBetaGroupsCreateToManyRelationship (string id, BuildBetaGroupsLinkagesRequest buildBetaGroupsLinkagesRequest)



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
    public class BuildsBetaGroupsCreateToManyRelationshipExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var buildBetaGroupsLinkagesRequest = new BuildBetaGroupsLinkagesRequest(); // BuildBetaGroupsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.BuildsBetaGroupsCreateToManyRelationship(id, buildBetaGroupsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsBetaGroupsCreateToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsBetaGroupsCreateToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BuildsBetaGroupsCreateToManyRelationshipWithHttpInfo(id, buildBetaGroupsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsBetaGroupsCreateToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **buildBetaGroupsLinkagesRequest** | [**BuildBetaGroupsLinkagesRequest**](BuildBetaGroupsLinkagesRequest.md) | List of related linkages |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsbetagroupsdeletetomanyrelationship"></a>
# **BuildsBetaGroupsDeleteToManyRelationship**
> void BuildsBetaGroupsDeleteToManyRelationship (string id, BuildBetaGroupsLinkagesRequest buildBetaGroupsLinkagesRequest)



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
    public class BuildsBetaGroupsDeleteToManyRelationshipExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var buildBetaGroupsLinkagesRequest = new BuildBetaGroupsLinkagesRequest(); // BuildBetaGroupsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.BuildsBetaGroupsDeleteToManyRelationship(id, buildBetaGroupsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsBetaGroupsDeleteToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsBetaGroupsDeleteToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BuildsBetaGroupsDeleteToManyRelationshipWithHttpInfo(id, buildBetaGroupsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsBetaGroupsDeleteToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **buildBetaGroupsLinkagesRequest** | [**BuildBetaGroupsLinkagesRequest**](BuildBetaGroupsLinkagesRequest.md) | List of related linkages |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsbuildbetadetailgettoonerelated"></a>
# **BuildsBuildBetaDetailGetToOneRelated**
> BuildBetaDetailResponse BuildsBuildBetaDetailGetToOneRelated (string id, List<string>? fieldsBuildBetaDetails = null)



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
    public class BuildsBuildBetaDetailGetToOneRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBuildBetaDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type buildBetaDetails (optional) 

            try
            {
                BuildBetaDetailResponse result = apiInstance.BuildsBuildBetaDetailGetToOneRelated(id, fieldsBuildBetaDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsBuildBetaDetailGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsBuildBetaDetailGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildBetaDetailResponse> response = apiInstance.BuildsBuildBetaDetailGetToOneRelatedWithHttpInfo(id, fieldsBuildBetaDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsBuildBetaDetailGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBuildBetaDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type buildBetaDetails | [optional]  |

### Return type

[**BuildBetaDetailResponse**](BuildBetaDetailResponse.md)

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
| **200** | Single BuildBetaDetail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsdiagnosticsignaturesgettomanyrelated"></a>
# **BuildsDiagnosticSignaturesGetToManyRelated**
> DiagnosticSignaturesResponse BuildsDiagnosticSignaturesGetToManyRelated (string id, List<string>? filterDiagnosticType = null, List<string>? fieldsDiagnosticSignatures = null, int? limit = null)



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
    public class BuildsDiagnosticSignaturesGetToManyRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterDiagnosticType = new List<string>?(); // List<string>? | filter by attribute 'diagnosticType' (optional) 
            var fieldsDiagnosticSignatures = new List<string>?(); // List<string>? | the fields to include for returned resources of type diagnosticSignatures (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                DiagnosticSignaturesResponse result = apiInstance.BuildsDiagnosticSignaturesGetToManyRelated(id, filterDiagnosticType, fieldsDiagnosticSignatures, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsDiagnosticSignaturesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsDiagnosticSignaturesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagnosticSignaturesResponse> response = apiInstance.BuildsDiagnosticSignaturesGetToManyRelatedWithHttpInfo(id, filterDiagnosticType, fieldsDiagnosticSignatures, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsDiagnosticSignaturesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterDiagnosticType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;diagnosticType&#39; | [optional]  |
| **fieldsDiagnosticSignatures** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type diagnosticSignatures | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**DiagnosticSignaturesResponse**](DiagnosticSignaturesResponse.md)

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
| **200** | List of DiagnosticSignatures |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsgetcollection"></a>
# **BuildsGetCollection**
> BuildsResponse BuildsGetCollection (List<string>? filterBetaAppReviewSubmissionBetaReviewState = null, List<string>? filterBuildAudienceType = null, List<string>? filterExpired = null, List<string>? filterPreReleaseVersionPlatform = null, List<string>? filterPreReleaseVersionVersion = null, List<string>? filterProcessingState = null, List<string>? filterUsesNonExemptEncryption = null, List<string>? filterVersion = null, List<string>? filterApp = null, List<string>? filterAppStoreVersion = null, List<string>? filterBetaGroups = null, List<string>? filterPreReleaseVersion = null, List<string>? filterId = null, List<string>? sort = null, List<string>? fieldsBuilds = null, int? limit = null, List<string>? include = null, List<string>? fieldsDiagnosticSignatures = null, List<string>? fieldsBuildIcons = null, List<string>? fieldsBuildBetaDetails = null, List<string>? fieldsBetaAppReviewSubmissions = null, List<string>? fieldsBetaTesters = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsBetaBuildLocalizations = null, List<string>? fieldsPreReleaseVersions = null, List<string>? fieldsAppEncryptionDeclarations = null, List<string>? fieldsApps = null, List<string>? fieldsPerfPowerMetrics = null, int? limitBetaBuildLocalizations = null, int? limitBetaGroups = null, int? limitBuildBundles = null, int? limitIcons = null, int? limitIndividualTesters = null)



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
    public class BuildsGetCollectionExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var filterBetaAppReviewSubmissionBetaReviewState = new List<string>?(); // List<string>? | filter by attribute 'betaAppReviewSubmission.betaReviewState' (optional) 
            var filterBuildAudienceType = new List<string>?(); // List<string>? | filter by attribute 'buildAudienceType' (optional) 
            var filterExpired = new List<string>?(); // List<string>? | filter by attribute 'expired' (optional) 
            var filterPreReleaseVersionPlatform = new List<string>?(); // List<string>? | filter by attribute 'preReleaseVersion.platform' (optional) 
            var filterPreReleaseVersionVersion = new List<string>?(); // List<string>? | filter by attribute 'preReleaseVersion.version' (optional) 
            var filterProcessingState = new List<string>?(); // List<string>? | filter by attribute 'processingState' (optional) 
            var filterUsesNonExemptEncryption = new List<string>?(); // List<string>? | filter by attribute 'usesNonExemptEncryption' (optional) 
            var filterVersion = new List<string>?(); // List<string>? | filter by attribute 'version' (optional) 
            var filterApp = new List<string>?(); // List<string>? | filter by id(s) of related 'app' (optional) 
            var filterAppStoreVersion = new List<string>?(); // List<string>? | filter by id(s) of related 'appStoreVersion' (optional) 
            var filterBetaGroups = new List<string>?(); // List<string>? | filter by id(s) of related 'betaGroups' (optional) 
            var filterPreReleaseVersion = new List<string>?(); // List<string>? | filter by id(s) of related 'preReleaseVersion' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsDiagnosticSignatures = new List<string>?(); // List<string>? | the fields to include for returned resources of type diagnosticSignatures (optional) 
            var fieldsBuildIcons = new List<string>?(); // List<string>? | the fields to include for returned resources of type buildIcons (optional) 
            var fieldsBuildBetaDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type buildBetaDetails (optional) 
            var fieldsBetaAppReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppReviewSubmissions (optional) 
            var fieldsBetaTesters = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaTesters (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsBetaBuildLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaBuildLocalizations (optional) 
            var fieldsPreReleaseVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type preReleaseVersions (optional) 
            var fieldsAppEncryptionDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEncryptionDeclarations (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsPerfPowerMetrics = new List<string>?(); // List<string>? | the fields to include for returned resources of type perfPowerMetrics (optional) 
            var limitBetaBuildLocalizations = 56;  // int? | maximum number of related betaBuildLocalizations returned (when they are included) (optional) 
            var limitBetaGroups = 56;  // int? | maximum number of related betaGroups returned (when they are included) (optional) 
            var limitBuildBundles = 56;  // int? | maximum number of related buildBundles returned (when they are included) (optional) 
            var limitIcons = 56;  // int? | maximum number of related icons returned (when they are included) (optional) 
            var limitIndividualTesters = 56;  // int? | maximum number of related individualTesters returned (when they are included) (optional) 

            try
            {
                BuildsResponse result = apiInstance.BuildsGetCollection(filterBetaAppReviewSubmissionBetaReviewState, filterBuildAudienceType, filterExpired, filterPreReleaseVersionPlatform, filterPreReleaseVersionVersion, filterProcessingState, filterUsesNonExemptEncryption, filterVersion, filterApp, filterAppStoreVersion, filterBetaGroups, filterPreReleaseVersion, filterId, sort, fieldsBuilds, limit, include, fieldsDiagnosticSignatures, fieldsBuildIcons, fieldsBuildBetaDetails, fieldsBetaAppReviewSubmissions, fieldsBetaTesters, fieldsAppStoreVersions, fieldsBetaBuildLocalizations, fieldsPreReleaseVersions, fieldsAppEncryptionDeclarations, fieldsApps, fieldsPerfPowerMetrics, limitBetaBuildLocalizations, limitBetaGroups, limitBuildBundles, limitIcons, limitIndividualTesters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildsResponse> response = apiInstance.BuildsGetCollectionWithHttpInfo(filterBetaAppReviewSubmissionBetaReviewState, filterBuildAudienceType, filterExpired, filterPreReleaseVersionPlatform, filterPreReleaseVersionVersion, filterProcessingState, filterUsesNonExemptEncryption, filterVersion, filterApp, filterAppStoreVersion, filterBetaGroups, filterPreReleaseVersion, filterId, sort, fieldsBuilds, limit, include, fieldsDiagnosticSignatures, fieldsBuildIcons, fieldsBuildBetaDetails, fieldsBetaAppReviewSubmissions, fieldsBetaTesters, fieldsAppStoreVersions, fieldsBetaBuildLocalizations, fieldsPreReleaseVersions, fieldsAppEncryptionDeclarations, fieldsApps, fieldsPerfPowerMetrics, limitBetaBuildLocalizations, limitBetaGroups, limitBuildBundles, limitIcons, limitIndividualTesters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterBetaAppReviewSubmissionBetaReviewState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;betaAppReviewSubmission.betaReviewState&#39; | [optional]  |
| **filterBuildAudienceType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;buildAudienceType&#39; | [optional]  |
| **filterExpired** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;expired&#39; | [optional]  |
| **filterPreReleaseVersionPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;preReleaseVersion.platform&#39; | [optional]  |
| **filterPreReleaseVersionVersion** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;preReleaseVersion.version&#39; | [optional]  |
| **filterProcessingState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;processingState&#39; | [optional]  |
| **filterUsesNonExemptEncryption** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;usesNonExemptEncryption&#39; | [optional]  |
| **filterVersion** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;version&#39; | [optional]  |
| **filterApp** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;app&#39; | [optional]  |
| **filterAppStoreVersion** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;appStoreVersion&#39; | [optional]  |
| **filterBetaGroups** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;betaGroups&#39; | [optional]  |
| **filterPreReleaseVersion** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;preReleaseVersion&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsDiagnosticSignatures** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type diagnosticSignatures | [optional]  |
| **fieldsBuildIcons** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type buildIcons | [optional]  |
| **fieldsBuildBetaDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type buildBetaDetails | [optional]  |
| **fieldsBetaAppReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppReviewSubmissions | [optional]  |
| **fieldsBetaTesters** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaTesters | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsBetaBuildLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaBuildLocalizations | [optional]  |
| **fieldsPreReleaseVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type preReleaseVersions | [optional]  |
| **fieldsAppEncryptionDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEncryptionDeclarations | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsPerfPowerMetrics** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type perfPowerMetrics | [optional]  |
| **limitBetaBuildLocalizations** | **int?** | maximum number of related betaBuildLocalizations returned (when they are included) | [optional]  |
| **limitBetaGroups** | **int?** | maximum number of related betaGroups returned (when they are included) | [optional]  |
| **limitBuildBundles** | **int?** | maximum number of related buildBundles returned (when they are included) | [optional]  |
| **limitIcons** | **int?** | maximum number of related icons returned (when they are included) | [optional]  |
| **limitIndividualTesters** | **int?** | maximum number of related individualTesters returned (when they are included) | [optional]  |

### Return type

[**BuildsResponse**](BuildsResponse.md)

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
| **200** | List of Builds |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsgetinstance"></a>
# **BuildsGetInstance**
> BuildResponse BuildsGetInstance (string id, List<string>? fieldsBuilds = null, List<string>? include = null, List<string>? fieldsDiagnosticSignatures = null, List<string>? fieldsBuildIcons = null, List<string>? fieldsBuildBetaDetails = null, List<string>? fieldsBetaAppReviewSubmissions = null, List<string>? fieldsBetaTesters = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsBetaBuildLocalizations = null, List<string>? fieldsPreReleaseVersions = null, List<string>? fieldsAppEncryptionDeclarations = null, List<string>? fieldsApps = null, List<string>? fieldsPerfPowerMetrics = null, int? limitBetaBuildLocalizations = null, int? limitBetaGroups = null, int? limitBuildBundles = null, int? limitIcons = null, int? limitIndividualTesters = null)



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
    public class BuildsGetInstanceExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsDiagnosticSignatures = new List<string>?(); // List<string>? | the fields to include for returned resources of type diagnosticSignatures (optional) 
            var fieldsBuildIcons = new List<string>?(); // List<string>? | the fields to include for returned resources of type buildIcons (optional) 
            var fieldsBuildBetaDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type buildBetaDetails (optional) 
            var fieldsBetaAppReviewSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaAppReviewSubmissions (optional) 
            var fieldsBetaTesters = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaTesters (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsBetaBuildLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaBuildLocalizations (optional) 
            var fieldsPreReleaseVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type preReleaseVersions (optional) 
            var fieldsAppEncryptionDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appEncryptionDeclarations (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsPerfPowerMetrics = new List<string>?(); // List<string>? | the fields to include for returned resources of type perfPowerMetrics (optional) 
            var limitBetaBuildLocalizations = 56;  // int? | maximum number of related betaBuildLocalizations returned (when they are included) (optional) 
            var limitBetaGroups = 56;  // int? | maximum number of related betaGroups returned (when they are included) (optional) 
            var limitBuildBundles = 56;  // int? | maximum number of related buildBundles returned (when they are included) (optional) 
            var limitIcons = 56;  // int? | maximum number of related icons returned (when they are included) (optional) 
            var limitIndividualTesters = 56;  // int? | maximum number of related individualTesters returned (when they are included) (optional) 

            try
            {
                BuildResponse result = apiInstance.BuildsGetInstance(id, fieldsBuilds, include, fieldsDiagnosticSignatures, fieldsBuildIcons, fieldsBuildBetaDetails, fieldsBetaAppReviewSubmissions, fieldsBetaTesters, fieldsAppStoreVersions, fieldsBetaBuildLocalizations, fieldsPreReleaseVersions, fieldsAppEncryptionDeclarations, fieldsApps, fieldsPerfPowerMetrics, limitBetaBuildLocalizations, limitBetaGroups, limitBuildBundles, limitIcons, limitIndividualTesters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildResponse> response = apiInstance.BuildsGetInstanceWithHttpInfo(id, fieldsBuilds, include, fieldsDiagnosticSignatures, fieldsBuildIcons, fieldsBuildBetaDetails, fieldsBetaAppReviewSubmissions, fieldsBetaTesters, fieldsAppStoreVersions, fieldsBetaBuildLocalizations, fieldsPreReleaseVersions, fieldsAppEncryptionDeclarations, fieldsApps, fieldsPerfPowerMetrics, limitBetaBuildLocalizations, limitBetaGroups, limitBuildBundles, limitIcons, limitIndividualTesters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsDiagnosticSignatures** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type diagnosticSignatures | [optional]  |
| **fieldsBuildIcons** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type buildIcons | [optional]  |
| **fieldsBuildBetaDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type buildBetaDetails | [optional]  |
| **fieldsBetaAppReviewSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaAppReviewSubmissions | [optional]  |
| **fieldsBetaTesters** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaTesters | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsBetaBuildLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaBuildLocalizations | [optional]  |
| **fieldsPreReleaseVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type preReleaseVersions | [optional]  |
| **fieldsAppEncryptionDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appEncryptionDeclarations | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsPerfPowerMetrics** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type perfPowerMetrics | [optional]  |
| **limitBetaBuildLocalizations** | **int?** | maximum number of related betaBuildLocalizations returned (when they are included) | [optional]  |
| **limitBetaGroups** | **int?** | maximum number of related betaGroups returned (when they are included) | [optional]  |
| **limitBuildBundles** | **int?** | maximum number of related buildBundles returned (when they are included) | [optional]  |
| **limitIcons** | **int?** | maximum number of related icons returned (when they are included) | [optional]  |
| **limitIndividualTesters** | **int?** | maximum number of related individualTesters returned (when they are included) | [optional]  |

### Return type

[**BuildResponse**](BuildResponse.md)

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
| **200** | Single Build |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsiconsgettomanyrelated"></a>
# **BuildsIconsGetToManyRelated**
> BuildIconsResponse BuildsIconsGetToManyRelated (string id, List<string>? fieldsBuildIcons = null, int? limit = null)



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
    public class BuildsIconsGetToManyRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBuildIcons = new List<string>?(); // List<string>? | the fields to include for returned resources of type buildIcons (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BuildIconsResponse result = apiInstance.BuildsIconsGetToManyRelated(id, fieldsBuildIcons, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsIconsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsIconsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildIconsResponse> response = apiInstance.BuildsIconsGetToManyRelatedWithHttpInfo(id, fieldsBuildIcons, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsIconsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBuildIcons** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type buildIcons | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BuildIconsResponse**](BuildIconsResponse.md)

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
| **200** | List of BuildIcons |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsindividualtesterscreatetomanyrelationship"></a>
# **BuildsIndividualTestersCreateToManyRelationship**
> void BuildsIndividualTestersCreateToManyRelationship (string id, BuildIndividualTestersLinkagesRequest buildIndividualTestersLinkagesRequest)



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
    public class BuildsIndividualTestersCreateToManyRelationshipExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var buildIndividualTestersLinkagesRequest = new BuildIndividualTestersLinkagesRequest(); // BuildIndividualTestersLinkagesRequest | List of related linkages

            try
            {
                apiInstance.BuildsIndividualTestersCreateToManyRelationship(id, buildIndividualTestersLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsIndividualTestersCreateToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsIndividualTestersCreateToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BuildsIndividualTestersCreateToManyRelationshipWithHttpInfo(id, buildIndividualTestersLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsIndividualTestersCreateToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **buildIndividualTestersLinkagesRequest** | [**BuildIndividualTestersLinkagesRequest**](BuildIndividualTestersLinkagesRequest.md) | List of related linkages |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsindividualtestersdeletetomanyrelationship"></a>
# **BuildsIndividualTestersDeleteToManyRelationship**
> void BuildsIndividualTestersDeleteToManyRelationship (string id, BuildIndividualTestersLinkagesRequest buildIndividualTestersLinkagesRequest)



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
    public class BuildsIndividualTestersDeleteToManyRelationshipExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var buildIndividualTestersLinkagesRequest = new BuildIndividualTestersLinkagesRequest(); // BuildIndividualTestersLinkagesRequest | List of related linkages

            try
            {
                apiInstance.BuildsIndividualTestersDeleteToManyRelationship(id, buildIndividualTestersLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsIndividualTestersDeleteToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsIndividualTestersDeleteToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.BuildsIndividualTestersDeleteToManyRelationshipWithHttpInfo(id, buildIndividualTestersLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsIndividualTestersDeleteToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **buildIndividualTestersLinkagesRequest** | [**BuildIndividualTestersLinkagesRequest**](BuildIndividualTestersLinkagesRequest.md) | List of related linkages |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsindividualtestersgettomanyrelated"></a>
# **BuildsIndividualTestersGetToManyRelated**
> BetaTestersResponse BuildsIndividualTestersGetToManyRelated (string id, List<string>? fieldsBetaTesters = null, int? limit = null)



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
    public class BuildsIndividualTestersGetToManyRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBetaTesters = new List<string>?(); // List<string>? | the fields to include for returned resources of type betaTesters (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BetaTestersResponse result = apiInstance.BuildsIndividualTestersGetToManyRelated(id, fieldsBetaTesters, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsIndividualTestersGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsIndividualTestersGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaTestersResponse> response = apiInstance.BuildsIndividualTestersGetToManyRelatedWithHttpInfo(id, fieldsBetaTesters, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsIndividualTestersGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBetaTesters** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type betaTesters | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BetaTestersResponse**](BetaTestersResponse.md)

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
| **200** | List of BetaTesters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsindividualtestersgettomanyrelationship"></a>
# **BuildsIndividualTestersGetToManyRelationship**
> BuildIndividualTestersLinkagesResponse BuildsIndividualTestersGetToManyRelationship (string id, int? limit = null)



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
    public class BuildsIndividualTestersGetToManyRelationshipExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                BuildIndividualTestersLinkagesResponse result = apiInstance.BuildsIndividualTestersGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsIndividualTestersGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsIndividualTestersGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildIndividualTestersLinkagesResponse> response = apiInstance.BuildsIndividualTestersGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsIndividualTestersGetToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**BuildIndividualTestersLinkagesResponse**](BuildIndividualTestersLinkagesResponse.md)

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
| **200** | List of related linkages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsperfpowermetricsgettomanyrelated"></a>
# **BuildsPerfPowerMetricsGetToManyRelated**
> XcodeMetrics BuildsPerfPowerMetricsGetToManyRelated (string id, List<string>? filterDeviceType = null, List<string>? filterMetricType = null, List<string>? filterPlatform = null)



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
    public class BuildsPerfPowerMetricsGetToManyRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterDeviceType = new List<string>?(); // List<string>? | filter by attribute 'deviceType' (optional) 
            var filterMetricType = new List<string>?(); // List<string>? | filter by attribute 'metricType' (optional) 
            var filterPlatform = new List<string>?(); // List<string>? | filter by attribute 'platform' (optional) 

            try
            {
                XcodeMetrics result = apiInstance.BuildsPerfPowerMetricsGetToManyRelated(id, filterDeviceType, filterMetricType, filterPlatform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsPerfPowerMetricsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsPerfPowerMetricsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<XcodeMetrics> response = apiInstance.BuildsPerfPowerMetricsGetToManyRelatedWithHttpInfo(id, filterDeviceType, filterMetricType, filterPlatform);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsPerfPowerMetricsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterDeviceType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;deviceType&#39; | [optional]  |
| **filterMetricType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;metricType&#39; | [optional]  |
| **filterPlatform** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;platform&#39; | [optional]  |

### Return type

[**XcodeMetrics**](XcodeMetrics.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.apple.xcode-metrics+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of PerfPowerMetrics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsprereleaseversiongettoonerelated"></a>
# **BuildsPreReleaseVersionGetToOneRelated**
> PrereleaseVersionResponse BuildsPreReleaseVersionGetToOneRelated (string id, List<string>? fieldsPreReleaseVersions = null)



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
    public class BuildsPreReleaseVersionGetToOneRelatedExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsPreReleaseVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type preReleaseVersions (optional) 

            try
            {
                PrereleaseVersionResponse result = apiInstance.BuildsPreReleaseVersionGetToOneRelated(id, fieldsPreReleaseVersions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsPreReleaseVersionGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsPreReleaseVersionGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrereleaseVersionResponse> response = apiInstance.BuildsPreReleaseVersionGetToOneRelatedWithHttpInfo(id, fieldsPreReleaseVersions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsPreReleaseVersionGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsPreReleaseVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type preReleaseVersions | [optional]  |

### Return type

[**PrereleaseVersionResponse**](PrereleaseVersionResponse.md)

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
| **200** | Single PrereleaseVersion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsupdateinstance"></a>
# **BuildsUpdateInstance**
> BuildResponse BuildsUpdateInstance (string id, BuildUpdateRequest buildUpdateRequest)



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
    public class BuildsUpdateInstanceExample
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
            var apiInstance = new BuildsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var buildUpdateRequest = new BuildUpdateRequest(); // BuildUpdateRequest | Build representation

            try
            {
                BuildResponse result = apiInstance.BuildsUpdateInstance(id, buildUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildsApi.BuildsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildResponse> response = apiInstance.BuildsUpdateInstanceWithHttpInfo(id, buildUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildsApi.BuildsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **buildUpdateRequest** | [**BuildUpdateRequest**](BuildUpdateRequest.md) | Build representation |  |

### Return type

[**BuildResponse**](BuildResponse.md)

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
| **200** | Single Build |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

