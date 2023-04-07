# AppStoreConnect.Net.Api.AppInfosApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppInfosAgeRatingDeclarationGetToOneRelated**](AppInfosApi.md#appinfosageratingdeclarationgettoonerelated) | **GET** /v1/appInfos/{id}/ageRatingDeclaration |  |
| [**AppInfosAppInfoLocalizationsGetToManyRelated**](AppInfosApi.md#appinfosappinfolocalizationsgettomanyrelated) | **GET** /v1/appInfos/{id}/appInfoLocalizations |  |
| [**AppInfosGetInstance**](AppInfosApi.md#appinfosgetinstance) | **GET** /v1/appInfos/{id} |  |
| [**AppInfosPrimaryCategoryGetToOneRelated**](AppInfosApi.md#appinfosprimarycategorygettoonerelated) | **GET** /v1/appInfos/{id}/primaryCategory |  |
| [**AppInfosPrimarySubcategoryOneGetToOneRelated**](AppInfosApi.md#appinfosprimarysubcategoryonegettoonerelated) | **GET** /v1/appInfos/{id}/primarySubcategoryOne |  |
| [**AppInfosPrimarySubcategoryTwoGetToOneRelated**](AppInfosApi.md#appinfosprimarysubcategorytwogettoonerelated) | **GET** /v1/appInfos/{id}/primarySubcategoryTwo |  |
| [**AppInfosSecondaryCategoryGetToOneRelated**](AppInfosApi.md#appinfossecondarycategorygettoonerelated) | **GET** /v1/appInfos/{id}/secondaryCategory |  |
| [**AppInfosSecondarySubcategoryOneGetToOneRelated**](AppInfosApi.md#appinfossecondarysubcategoryonegettoonerelated) | **GET** /v1/appInfos/{id}/secondarySubcategoryOne |  |
| [**AppInfosSecondarySubcategoryTwoGetToOneRelated**](AppInfosApi.md#appinfossecondarysubcategorytwogettoonerelated) | **GET** /v1/appInfos/{id}/secondarySubcategoryTwo |  |
| [**AppInfosUpdateInstance**](AppInfosApi.md#appinfosupdateinstance) | **PATCH** /v1/appInfos/{id} |  |

<a name="appinfosageratingdeclarationgettoonerelated"></a>
# **AppInfosAgeRatingDeclarationGetToOneRelated**
> AgeRatingDeclarationResponse AppInfosAgeRatingDeclarationGetToOneRelated (string id, List<string>? fieldsAgeRatingDeclarations = null)



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
    public class AppInfosAgeRatingDeclarationGetToOneRelatedExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAgeRatingDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type ageRatingDeclarations (optional) 

            try
            {
                AgeRatingDeclarationResponse result = apiInstance.AppInfosAgeRatingDeclarationGetToOneRelated(id, fieldsAgeRatingDeclarations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosAgeRatingDeclarationGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosAgeRatingDeclarationGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgeRatingDeclarationResponse> response = apiInstance.AppInfosAgeRatingDeclarationGetToOneRelatedWithHttpInfo(id, fieldsAgeRatingDeclarations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosAgeRatingDeclarationGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAgeRatingDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ageRatingDeclarations | [optional]  |

### Return type

[**AgeRatingDeclarationResponse**](AgeRatingDeclarationResponse.md)

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
| **200** | Single AgeRatingDeclaration |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfosappinfolocalizationsgettomanyrelated"></a>
# **AppInfosAppInfoLocalizationsGetToManyRelated**
> AppInfoLocalizationsResponse AppInfosAppInfoLocalizationsGetToManyRelated (string id, List<string>? filterLocale = null, List<string>? fieldsAppInfos = null, List<string>? fieldsAppInfoLocalizations = null, int? limit = null, List<string>? include = null)



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
    public class AppInfosAppInfoLocalizationsGetToManyRelatedExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterLocale = new List<string>?(); // List<string>? | filter by attribute 'locale' (optional) 
            var fieldsAppInfos = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfos (optional) 
            var fieldsAppInfoLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfoLocalizations (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppInfoLocalizationsResponse result = apiInstance.AppInfosAppInfoLocalizationsGetToManyRelated(id, filterLocale, fieldsAppInfos, fieldsAppInfoLocalizations, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosAppInfoLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosAppInfoLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppInfoLocalizationsResponse> response = apiInstance.AppInfosAppInfoLocalizationsGetToManyRelatedWithHttpInfo(id, filterLocale, fieldsAppInfos, fieldsAppInfoLocalizations, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosAppInfoLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterLocale** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;locale&#39; | [optional]  |
| **fieldsAppInfos** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfos | [optional]  |
| **fieldsAppInfoLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfoLocalizations | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppInfoLocalizationsResponse**](AppInfoLocalizationsResponse.md)

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
| **200** | List of AppInfoLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfosgetinstance"></a>
# **AppInfosGetInstance**
> AppInfoResponse AppInfosGetInstance (string id, List<string>? fieldsAppInfos = null, List<string>? include = null, List<string>? fieldsAgeRatingDeclarations = null, List<string>? fieldsAppInfoLocalizations = null, List<string>? fieldsAppCategories = null, int? limitAppInfoLocalizations = null)



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
    public class AppInfosGetInstanceExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppInfos = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfos (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsAgeRatingDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type ageRatingDeclarations (optional) 
            var fieldsAppInfoLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appInfoLocalizations (optional) 
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limitAppInfoLocalizations = 56;  // int? | maximum number of related appInfoLocalizations returned (when they are included) (optional) 

            try
            {
                AppInfoResponse result = apiInstance.AppInfosGetInstance(id, fieldsAppInfos, include, fieldsAgeRatingDeclarations, fieldsAppInfoLocalizations, fieldsAppCategories, limitAppInfoLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppInfoResponse> response = apiInstance.AppInfosGetInstanceWithHttpInfo(id, fieldsAppInfos, include, fieldsAgeRatingDeclarations, fieldsAppInfoLocalizations, fieldsAppCategories, limitAppInfoLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppInfos** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfos | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsAgeRatingDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ageRatingDeclarations | [optional]  |
| **fieldsAppInfoLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appInfoLocalizations | [optional]  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limitAppInfoLocalizations** | **int?** | maximum number of related appInfoLocalizations returned (when they are included) | [optional]  |

### Return type

[**AppInfoResponse**](AppInfoResponse.md)

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
| **200** | Single AppInfo |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfosprimarycategorygettoonerelated"></a>
# **AppInfosPrimaryCategoryGetToOneRelated**
> AppCategoryResponse AppInfosPrimaryCategoryGetToOneRelated (string id, List<string>? fieldsAppCategories = null, int? limitSubcategories = null, List<string>? include = null)



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
    public class AppInfosPrimaryCategoryGetToOneRelatedExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limitSubcategories = 56;  // int? | maximum number of related subcategories returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppCategoryResponse result = apiInstance.AppInfosPrimaryCategoryGetToOneRelated(id, fieldsAppCategories, limitSubcategories, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosPrimaryCategoryGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosPrimaryCategoryGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoryResponse> response = apiInstance.AppInfosPrimaryCategoryGetToOneRelatedWithHttpInfo(id, fieldsAppCategories, limitSubcategories, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosPrimaryCategoryGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limitSubcategories** | **int?** | maximum number of related subcategories returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppCategoryResponse**](AppCategoryResponse.md)

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
| **200** | Single AppCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfosprimarysubcategoryonegettoonerelated"></a>
# **AppInfosPrimarySubcategoryOneGetToOneRelated**
> AppCategoryResponse AppInfosPrimarySubcategoryOneGetToOneRelated (string id, List<string>? fieldsAppCategories = null, int? limitSubcategories = null, List<string>? include = null)



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
    public class AppInfosPrimarySubcategoryOneGetToOneRelatedExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limitSubcategories = 56;  // int? | maximum number of related subcategories returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppCategoryResponse result = apiInstance.AppInfosPrimarySubcategoryOneGetToOneRelated(id, fieldsAppCategories, limitSubcategories, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosPrimarySubcategoryOneGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosPrimarySubcategoryOneGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoryResponse> response = apiInstance.AppInfosPrimarySubcategoryOneGetToOneRelatedWithHttpInfo(id, fieldsAppCategories, limitSubcategories, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosPrimarySubcategoryOneGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limitSubcategories** | **int?** | maximum number of related subcategories returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppCategoryResponse**](AppCategoryResponse.md)

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
| **200** | Single AppCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfosprimarysubcategorytwogettoonerelated"></a>
# **AppInfosPrimarySubcategoryTwoGetToOneRelated**
> AppCategoryResponse AppInfosPrimarySubcategoryTwoGetToOneRelated (string id, List<string>? fieldsAppCategories = null, int? limitSubcategories = null, List<string>? include = null)



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
    public class AppInfosPrimarySubcategoryTwoGetToOneRelatedExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limitSubcategories = 56;  // int? | maximum number of related subcategories returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppCategoryResponse result = apiInstance.AppInfosPrimarySubcategoryTwoGetToOneRelated(id, fieldsAppCategories, limitSubcategories, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosPrimarySubcategoryTwoGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosPrimarySubcategoryTwoGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoryResponse> response = apiInstance.AppInfosPrimarySubcategoryTwoGetToOneRelatedWithHttpInfo(id, fieldsAppCategories, limitSubcategories, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosPrimarySubcategoryTwoGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limitSubcategories** | **int?** | maximum number of related subcategories returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppCategoryResponse**](AppCategoryResponse.md)

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
| **200** | Single AppCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfossecondarycategorygettoonerelated"></a>
# **AppInfosSecondaryCategoryGetToOneRelated**
> AppCategoryResponse AppInfosSecondaryCategoryGetToOneRelated (string id, List<string>? fieldsAppCategories = null, int? limitSubcategories = null, List<string>? include = null)



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
    public class AppInfosSecondaryCategoryGetToOneRelatedExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limitSubcategories = 56;  // int? | maximum number of related subcategories returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppCategoryResponse result = apiInstance.AppInfosSecondaryCategoryGetToOneRelated(id, fieldsAppCategories, limitSubcategories, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosSecondaryCategoryGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosSecondaryCategoryGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoryResponse> response = apiInstance.AppInfosSecondaryCategoryGetToOneRelatedWithHttpInfo(id, fieldsAppCategories, limitSubcategories, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosSecondaryCategoryGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limitSubcategories** | **int?** | maximum number of related subcategories returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppCategoryResponse**](AppCategoryResponse.md)

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
| **200** | Single AppCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfossecondarysubcategoryonegettoonerelated"></a>
# **AppInfosSecondarySubcategoryOneGetToOneRelated**
> AppCategoryResponse AppInfosSecondarySubcategoryOneGetToOneRelated (string id, List<string>? fieldsAppCategories = null, int? limitSubcategories = null, List<string>? include = null)



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
    public class AppInfosSecondarySubcategoryOneGetToOneRelatedExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limitSubcategories = 56;  // int? | maximum number of related subcategories returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppCategoryResponse result = apiInstance.AppInfosSecondarySubcategoryOneGetToOneRelated(id, fieldsAppCategories, limitSubcategories, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosSecondarySubcategoryOneGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosSecondarySubcategoryOneGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoryResponse> response = apiInstance.AppInfosSecondarySubcategoryOneGetToOneRelatedWithHttpInfo(id, fieldsAppCategories, limitSubcategories, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosSecondarySubcategoryOneGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limitSubcategories** | **int?** | maximum number of related subcategories returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppCategoryResponse**](AppCategoryResponse.md)

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
| **200** | Single AppCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfossecondarysubcategorytwogettoonerelated"></a>
# **AppInfosSecondarySubcategoryTwoGetToOneRelated**
> AppCategoryResponse AppInfosSecondarySubcategoryTwoGetToOneRelated (string id, List<string>? fieldsAppCategories = null, int? limitSubcategories = null, List<string>? include = null)



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
    public class AppInfosSecondarySubcategoryTwoGetToOneRelatedExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppCategories = new List<string>?(); // List<string>? | the fields to include for returned resources of type appCategories (optional) 
            var limitSubcategories = 56;  // int? | maximum number of related subcategories returned (when they are included) (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppCategoryResponse result = apiInstance.AppInfosSecondarySubcategoryTwoGetToOneRelated(id, fieldsAppCategories, limitSubcategories, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosSecondarySubcategoryTwoGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosSecondarySubcategoryTwoGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppCategoryResponse> response = apiInstance.AppInfosSecondarySubcategoryTwoGetToOneRelatedWithHttpInfo(id, fieldsAppCategories, limitSubcategories, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosSecondarySubcategoryTwoGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppCategories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appCategories | [optional]  |
| **limitSubcategories** | **int?** | maximum number of related subcategories returned (when they are included) | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppCategoryResponse**](AppCategoryResponse.md)

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
| **200** | Single AppCategory |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appinfosupdateinstance"></a>
# **AppInfosUpdateInstance**
> AppInfoResponse AppInfosUpdateInstance (string id, AppInfoUpdateRequest appInfoUpdateRequest)



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
    public class AppInfosUpdateInstanceExample
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
            var apiInstance = new AppInfosApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appInfoUpdateRequest = new AppInfoUpdateRequest(); // AppInfoUpdateRequest | AppInfo representation

            try
            {
                AppInfoResponse result = apiInstance.AppInfosUpdateInstance(id, appInfoUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppInfosApi.AppInfosUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppInfosUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppInfoResponse> response = apiInstance.AppInfosUpdateInstanceWithHttpInfo(id, appInfoUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppInfosApi.AppInfosUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appInfoUpdateRequest** | [**AppInfoUpdateRequest**](AppInfoUpdateRequest.md) | AppInfo representation |  |

### Return type

[**AppInfoResponse**](AppInfoResponse.md)

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
| **200** | Single AppInfo |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

