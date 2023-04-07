# AppStoreConnect.Net.Api.FinanceReportsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FinanceReportsGetCollection**](FinanceReportsApi.md#financereportsgetcollection) | **GET** /v1/financeReports |  |

<a name="financereportsgetcollection"></a>
# **FinanceReportsGetCollection**
> FileParameter FinanceReportsGetCollection (List<string> filterRegionCode, List<string> filterReportDate, List<string> filterReportType, List<string> filterVendorNumber)



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
    public class FinanceReportsGetCollectionExample
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
            var apiInstance = new FinanceReportsApi(httpClient, config, httpClientHandler);
            var filterRegionCode = new List<string>(); // List<string> | filter by attribute 'regionCode'
            var filterReportDate = new List<string>(); // List<string> | filter by attribute 'reportDate'
            var filterReportType = new List<string>(); // List<string> | filter by attribute 'reportType'
            var filterVendorNumber = new List<string>(); // List<string> | filter by attribute 'vendorNumber'

            try
            {
                FileParameter result = apiInstance.FinanceReportsGetCollection(filterRegionCode, filterReportDate, filterReportType, filterVendorNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinanceReportsApi.FinanceReportsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinanceReportsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileParameter> response = apiInstance.FinanceReportsGetCollectionWithHttpInfo(filterRegionCode, filterReportDate, filterReportType, filterVendorNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinanceReportsApi.FinanceReportsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterRegionCode** | [**List&lt;string&gt;**](string.md) | filter by attribute &#39;regionCode&#39; |  |
| **filterReportDate** | [**List&lt;string&gt;**](string.md) | filter by attribute &#39;reportDate&#39; |  |
| **filterReportType** | [**List&lt;string&gt;**](string.md) | filter by attribute &#39;reportType&#39; |  |
| **filterVendorNumber** | [**List&lt;string&gt;**](string.md) | filter by attribute &#39;vendorNumber&#39; |  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/a-gzip


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **403** | Forbidden error |  -  |
| **200** | List of FinanceReports |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

