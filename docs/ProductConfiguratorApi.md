# product-configurator.Api.ProductConfiguratorApi

All URIs are relative to *https://product-configurator.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductConfiguratorGetProperty**](ProductConfiguratorApi.md#productconfiguratorgetproperty) | **GET** /v1/{tenantId}/property/{propertyId} |  |
| [**ProductConfiguratorListPropertiesByConfiguration**](ProductConfiguratorApi.md#productconfiguratorlistpropertiesbyconfiguration) | **POST** /v1/{tenantId}/configurator/{configuratorId}/page-size/{pageSize}/properties |  |

<a id="productconfiguratorgetproperty"></a>
# **ProductConfiguratorGetProperty**
> ProductconfiguratorpropertyEntity ProductConfiguratorGetProperty (string tenantId, string propertyId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorGetPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            var apiInstance = new ProductConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var propertyId = "propertyId_example";  // string | 

            try
            {
                ProductconfiguratorpropertyEntity result = apiInstance.ProductConfiguratorGetProperty(tenantId, propertyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductConfiguratorApi.ProductConfiguratorGetProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorGetPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProductconfiguratorpropertyEntity> response = apiInstance.ProductConfiguratorGetPropertyWithHttpInfo(tenantId, propertyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductConfiguratorApi.ProductConfiguratorGetPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **propertyId** | **string** |  |  |

### Return type

[**ProductconfiguratorpropertyEntity**](ProductconfiguratorpropertyEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorlistpropertiesbyconfiguration"></a>
# **ProductConfiguratorListPropertiesByConfiguration**
> PropertyListPropertiesByConfigurationResponse ProductConfiguratorListPropertiesByConfiguration (string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorListPropertiesByConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            var apiInstance = new ProductConfiguratorApi(config);
            var tenantId = "tenantId_example";  // string | 
            var configuratorId = "configuratorId_example";  // string | 
            var pageSize = "pageSize_example";  // string | 
            var body = new ProductConfiguratorListPropertiesByConfigurationRequest(); // ProductConfiguratorListPropertiesByConfigurationRequest | 

            try
            {
                PropertyListPropertiesByConfigurationResponse result = apiInstance.ProductConfiguratorListPropertiesByConfiguration(tenantId, configuratorId, pageSize, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductConfiguratorApi.ProductConfiguratorListPropertiesByConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorListPropertiesByConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PropertyListPropertiesByConfigurationResponse> response = apiInstance.ProductConfiguratorListPropertiesByConfigurationWithHttpInfo(tenantId, configuratorId, pageSize, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductConfiguratorApi.ProductConfiguratorListPropertiesByConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **configuratorId** | **string** |  |  |
| **pageSize** | **string** |  |  |
| **body** | [**ProductConfiguratorListPropertiesByConfigurationRequest**](ProductConfiguratorListPropertiesByConfigurationRequest.md) |  |  |

### Return type

[**PropertyListPropertiesByConfigurationResponse**](PropertyListPropertiesByConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

