# AppStoreConnect.Net.Api.ProfilesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProfilesBundleIdGetToOneRelated**](ProfilesApi.md#profilesbundleidgettoonerelated) | **GET** /v1/profiles/{id}/bundleId |  |
| [**ProfilesCertificatesGetToManyRelated**](ProfilesApi.md#profilescertificatesgettomanyrelated) | **GET** /v1/profiles/{id}/certificates |  |
| [**ProfilesCreateInstance**](ProfilesApi.md#profilescreateinstance) | **POST** /v1/profiles |  |
| [**ProfilesDeleteInstance**](ProfilesApi.md#profilesdeleteinstance) | **DELETE** /v1/profiles/{id} |  |
| [**ProfilesDevicesGetToManyRelated**](ProfilesApi.md#profilesdevicesgettomanyrelated) | **GET** /v1/profiles/{id}/devices |  |
| [**ProfilesGetCollection**](ProfilesApi.md#profilesgetcollection) | **GET** /v1/profiles |  |
| [**ProfilesGetInstance**](ProfilesApi.md#profilesgetinstance) | **GET** /v1/profiles/{id} |  |

<a name="profilesbundleidgettoonerelated"></a>
# **ProfilesBundleIdGetToOneRelated**
> BundleIdResponse ProfilesBundleIdGetToOneRelated (string id, List<string>? fieldsBundleIds = null)



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
    public class ProfilesBundleIdGetToOneRelatedExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBundleIds = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIds (optional) 

            try
            {
                BundleIdResponse result = apiInstance.ProfilesBundleIdGetToOneRelated(id, fieldsBundleIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesBundleIdGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfilesBundleIdGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BundleIdResponse> response = apiInstance.ProfilesBundleIdGetToOneRelatedWithHttpInfo(id, fieldsBundleIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.ProfilesBundleIdGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBundleIds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIds | [optional]  |

### Return type

[**BundleIdResponse**](BundleIdResponse.md)

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
| **200** | Single BundleId |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilescertificatesgettomanyrelated"></a>
# **ProfilesCertificatesGetToManyRelated**
> CertificatesResponse ProfilesCertificatesGetToManyRelated (string id, List<string>? fieldsCertificates = null, int? limit = null)



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
    public class ProfilesCertificatesGetToManyRelatedExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsCertificates = new List<string>?(); // List<string>? | the fields to include for returned resources of type certificates (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                CertificatesResponse result = apiInstance.ProfilesCertificatesGetToManyRelated(id, fieldsCertificates, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesCertificatesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfilesCertificatesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CertificatesResponse> response = apiInstance.ProfilesCertificatesGetToManyRelatedWithHttpInfo(id, fieldsCertificates, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.ProfilesCertificatesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsCertificates** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type certificates | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**CertificatesResponse**](CertificatesResponse.md)

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
| **200** | List of Certificates |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilescreateinstance"></a>
# **ProfilesCreateInstance**
> ProfileResponse ProfilesCreateInstance (ProfileCreateRequest profileCreateRequest)



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
    public class ProfilesCreateInstanceExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var profileCreateRequest = new ProfileCreateRequest(); // ProfileCreateRequest | Profile representation

            try
            {
                ProfileResponse result = apiInstance.ProfilesCreateInstance(profileCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfilesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfileResponse> response = apiInstance.ProfilesCreateInstanceWithHttpInfo(profileCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.ProfilesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileCreateRequest** | [**ProfileCreateRequest**](ProfileCreateRequest.md) | Profile representation |  |

### Return type

[**ProfileResponse**](ProfileResponse.md)

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
| **201** | Single Profile |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesdeleteinstance"></a>
# **ProfilesDeleteInstance**
> void ProfilesDeleteInstance (string id)



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
    public class ProfilesDeleteInstanceExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.ProfilesDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfilesDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ProfilesDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.ProfilesDeleteInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

void (empty response body)

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
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesdevicesgettomanyrelated"></a>
# **ProfilesDevicesGetToManyRelated**
> DevicesResponse ProfilesDevicesGetToManyRelated (string id, List<string>? fieldsDevices = null, int? limit = null)



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
    public class ProfilesDevicesGetToManyRelatedExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsDevices = new List<string>?(); // List<string>? | the fields to include for returned resources of type devices (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                DevicesResponse result = apiInstance.ProfilesDevicesGetToManyRelated(id, fieldsDevices, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesDevicesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfilesDevicesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DevicesResponse> response = apiInstance.ProfilesDevicesGetToManyRelatedWithHttpInfo(id, fieldsDevices, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.ProfilesDevicesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsDevices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type devices | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**DevicesResponse**](DevicesResponse.md)

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
| **200** | List of Devices |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetcollection"></a>
# **ProfilesGetCollection**
> ProfilesResponse ProfilesGetCollection (List<string>? filterName = null, List<string>? filterProfileState = null, List<string>? filterProfileType = null, List<string>? filterId = null, List<string>? sort = null, List<string>? fieldsProfiles = null, int? limit = null, List<string>? include = null, List<string>? fieldsCertificates = null, List<string>? fieldsDevices = null, List<string>? fieldsBundleIds = null, int? limitCertificates = null, int? limitDevices = null)



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
    public class ProfilesGetCollectionExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var filterName = new List<string>?(); // List<string>? | filter by attribute 'name' (optional) 
            var filterProfileState = new List<string>?(); // List<string>? | filter by attribute 'profileState' (optional) 
            var filterProfileType = new List<string>?(); // List<string>? | filter by attribute 'profileType' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsProfiles = new List<string>?(); // List<string>? | the fields to include for returned resources of type profiles (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsCertificates = new List<string>?(); // List<string>? | the fields to include for returned resources of type certificates (optional) 
            var fieldsDevices = new List<string>?(); // List<string>? | the fields to include for returned resources of type devices (optional) 
            var fieldsBundleIds = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIds (optional) 
            var limitCertificates = 56;  // int? | maximum number of related certificates returned (when they are included) (optional) 
            var limitDevices = 56;  // int? | maximum number of related devices returned (when they are included) (optional) 

            try
            {
                ProfilesResponse result = apiInstance.ProfilesGetCollection(filterName, filterProfileState, filterProfileType, filterId, sort, fieldsProfiles, limit, include, fieldsCertificates, fieldsDevices, fieldsBundleIds, limitCertificates, limitDevices);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfilesGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfilesResponse> response = apiInstance.ProfilesGetCollectionWithHttpInfo(filterName, filterProfileState, filterProfileType, filterId, sort, fieldsProfiles, limit, include, fieldsCertificates, fieldsDevices, fieldsBundleIds, limitCertificates, limitDevices);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.ProfilesGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;name&#39; | [optional]  |
| **filterProfileState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;profileState&#39; | [optional]  |
| **filterProfileType** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;profileType&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsProfiles** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type profiles | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsCertificates** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type certificates | [optional]  |
| **fieldsDevices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type devices | [optional]  |
| **fieldsBundleIds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIds | [optional]  |
| **limitCertificates** | **int?** | maximum number of related certificates returned (when they are included) | [optional]  |
| **limitDevices** | **int?** | maximum number of related devices returned (when they are included) | [optional]  |

### Return type

[**ProfilesResponse**](ProfilesResponse.md)

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
| **200** | List of Profiles |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetinstance"></a>
# **ProfilesGetInstance**
> ProfileResponse ProfilesGetInstance (string id, List<string>? fieldsProfiles = null, List<string>? include = null, List<string>? fieldsCertificates = null, List<string>? fieldsDevices = null, List<string>? fieldsBundleIds = null, int? limitCertificates = null, int? limitDevices = null)



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
    public class ProfilesGetInstanceExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsProfiles = new List<string>?(); // List<string>? | the fields to include for returned resources of type profiles (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var fieldsCertificates = new List<string>?(); // List<string>? | the fields to include for returned resources of type certificates (optional) 
            var fieldsDevices = new List<string>?(); // List<string>? | the fields to include for returned resources of type devices (optional) 
            var fieldsBundleIds = new List<string>?(); // List<string>? | the fields to include for returned resources of type bundleIds (optional) 
            var limitCertificates = 56;  // int? | maximum number of related certificates returned (when they are included) (optional) 
            var limitDevices = 56;  // int? | maximum number of related devices returned (when they are included) (optional) 

            try
            {
                ProfileResponse result = apiInstance.ProfilesGetInstance(id, fieldsProfiles, include, fieldsCertificates, fieldsDevices, fieldsBundleIds, limitCertificates, limitDevices);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfilesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProfileResponse> response = apiInstance.ProfilesGetInstanceWithHttpInfo(id, fieldsProfiles, include, fieldsCertificates, fieldsDevices, fieldsBundleIds, limitCertificates, limitDevices);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.ProfilesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsProfiles** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type profiles | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **fieldsCertificates** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type certificates | [optional]  |
| **fieldsDevices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type devices | [optional]  |
| **fieldsBundleIds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type bundleIds | [optional]  |
| **limitCertificates** | **int?** | maximum number of related certificates returned (when they are included) | [optional]  |
| **limitDevices** | **int?** | maximum number of related devices returned (when they are included) | [optional]  |

### Return type

[**ProfileResponse**](ProfileResponse.md)

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
| **200** | Single Profile |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

