# product-configurator.Api.PropertyApi

All URIs are relative to *https://product-configurator.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductConfiguratorBulkCreateProperties**](PropertyApi.md#productconfiguratorbulkcreateproperties) | **POST** /v1/{tenantId}/property/create/bulk | Bulk Create Properties |
| [**ProductConfiguratorBulkUpdateProperties**](PropertyApi.md#productconfiguratorbulkupdateproperties) | **PUT** /v1/{tenantId}/properties/bulk | Bulk Update Properties |
| [**ProductConfiguratorCreateProperty**](PropertyApi.md#productconfiguratorcreateproperty) | **POST** /v1/{tenantId}/property/create | Create Property |
| [**ProductConfiguratorListProperties**](PropertyApi.md#productconfiguratorlistproperties) | **POST** /v1/{tenantId}/matrix/{matrixId}/page-size/{pageSize}/properties | List Properties |
| [**ProductConfiguratorUpdateProperty**](PropertyApi.md#productconfiguratorupdateproperty) | **PUT** /v1/{tenantId}/property/{propertyId} | Update Property |

<a id="productconfiguratorbulkcreateproperties"></a>
# **ProductConfiguratorBulkCreateProperties**
> ProductconfiguratorpropertyBulkCreateResponse ProductConfiguratorBulkCreateProperties (string tenantId, ProductConfiguratorBulkCreatePropertiesRequest body)

Bulk Create Properties

Efficiently add multiple properties to configurations with a bulk create operation. Specify the tenant ID and submit a POST request with the necessary property details in the body for streamlined property management.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorBulkCreatePropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: APIAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PropertyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new ProductConfiguratorBulkCreatePropertiesRequest(); // ProductConfiguratorBulkCreatePropertiesRequest | 

            try
            {
                // Bulk Create Properties
                ProductconfiguratorpropertyBulkCreateResponse result = apiInstance.ProductConfiguratorBulkCreateProperties(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyApi.ProductConfiguratorBulkCreateProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorBulkCreatePropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Create Properties
    ApiResponse<ProductconfiguratorpropertyBulkCreateResponse> response = apiInstance.ProductConfiguratorBulkCreatePropertiesWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyApi.ProductConfiguratorBulkCreatePropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**ProductConfiguratorBulkCreatePropertiesRequest**](ProductConfiguratorBulkCreatePropertiesRequest.md) |  |  |

### Return type

[**ProductconfiguratorpropertyBulkCreateResponse**](ProductconfiguratorpropertyBulkCreateResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorbulkupdateproperties"></a>
# **ProductConfiguratorBulkUpdateProperties**
> ProductconfiguratorpropertyBulkUpdateResponse ProductConfiguratorBulkUpdateProperties (string tenantId, ProductConfiguratorBulkUpdatePropertiesRequest body)

Bulk Update Properties

Effortlessly update multiple properties. Specify the tenant ID and submit a PUT request with the updated property details in the body. Streamline the customization of a multitude of properties in one go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorBulkUpdatePropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: APIAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PropertyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new ProductConfiguratorBulkUpdatePropertiesRequest(); // ProductConfiguratorBulkUpdatePropertiesRequest | 

            try
            {
                // Bulk Update Properties
                ProductconfiguratorpropertyBulkUpdateResponse result = apiInstance.ProductConfiguratorBulkUpdateProperties(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyApi.ProductConfiguratorBulkUpdateProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorBulkUpdatePropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Update Properties
    ApiResponse<ProductconfiguratorpropertyBulkUpdateResponse> response = apiInstance.ProductConfiguratorBulkUpdatePropertiesWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyApi.ProductConfiguratorBulkUpdatePropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**ProductConfiguratorBulkUpdatePropertiesRequest**](ProductConfiguratorBulkUpdatePropertiesRequest.md) |  |  |

### Return type

[**ProductconfiguratorpropertyBulkUpdateResponse**](ProductconfiguratorpropertyBulkUpdateResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorcreateproperty"></a>
# **ProductConfiguratorCreateProperty**
> ProductconfiguratorpropertyEntity ProductConfiguratorCreateProperty (string tenantId, ProductConfiguratorCreatePropertyRequest body)

Create Property

Integrate a new property into configurations by specifying the tenant ID. Use a POST request with the required property details in the body for seamless customization and expansion of product configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorCreatePropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: APIAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PropertyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new ProductConfiguratorCreatePropertyRequest(); // ProductConfiguratorCreatePropertyRequest | 

            try
            {
                // Create Property
                ProductconfiguratorpropertyEntity result = apiInstance.ProductConfiguratorCreateProperty(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyApi.ProductConfiguratorCreateProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCreatePropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Property
    ApiResponse<ProductconfiguratorpropertyEntity> response = apiInstance.ProductConfiguratorCreatePropertyWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyApi.ProductConfiguratorCreatePropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**ProductConfiguratorCreatePropertyRequest**](ProductConfiguratorCreatePropertyRequest.md) |  |  |

### Return type

[**ProductconfiguratorpropertyEntity**](ProductconfiguratorpropertyEntity.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorlistproperties"></a>
# **ProductConfiguratorListProperties**
> PropertyListPropertiesResponse ProductConfiguratorListProperties (string tenantId, string matrixId, string pageSize, ProductConfiguratorListPropertiesRequest body)

List Properties

Retrieve a list of properties for a specific matrix based on tenant and matrix IDs. Customize results by specifying page size for efficient pagination. Submit an empty body to get all properties associated with the matrix.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorListPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: APIAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PropertyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var matrixId = "matrixId_example";  // string | 
            var pageSize = "pageSize_example";  // string | 
            var body = new ProductConfiguratorListPropertiesRequest(); // ProductConfiguratorListPropertiesRequest | 

            try
            {
                // List Properties
                PropertyListPropertiesResponse result = apiInstance.ProductConfiguratorListProperties(tenantId, matrixId, pageSize, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyApi.ProductConfiguratorListProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorListPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Properties
    ApiResponse<PropertyListPropertiesResponse> response = apiInstance.ProductConfiguratorListPropertiesWithHttpInfo(tenantId, matrixId, pageSize, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyApi.ProductConfiguratorListPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **matrixId** | **string** |  |  |
| **pageSize** | **string** |  |  |
| **body** | [**ProductConfiguratorListPropertiesRequest**](ProductConfiguratorListPropertiesRequest.md) |  |  |

### Return type

[**PropertyListPropertiesResponse**](PropertyListPropertiesResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productconfiguratorupdateproperty"></a>
# **ProductConfiguratorUpdateProperty**
> ProductconfiguratorpropertyEntity ProductConfiguratorUpdateProperty (string tenantId, string propertyId, ProductConfiguratorUpdatePropertyRequest body)

Update Property

Modify an existing property by specifying the tenant and property IDs. Utilize a PUT request with updated property details in the body for seamless customization and fine-tuning of your product configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorUpdatePropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://product-configurator.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: APIAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PropertyApi(config);
            var tenantId = "tenantId_example";  // string | 
            var propertyId = "propertyId_example";  // string | 
            var body = new ProductConfiguratorUpdatePropertyRequest(); // ProductConfiguratorUpdatePropertyRequest | 

            try
            {
                // Update Property
                ProductconfiguratorpropertyEntity result = apiInstance.ProductConfiguratorUpdateProperty(tenantId, propertyId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyApi.ProductConfiguratorUpdateProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorUpdatePropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Property
    ApiResponse<ProductconfiguratorpropertyEntity> response = apiInstance.ProductConfiguratorUpdatePropertyWithHttpInfo(tenantId, propertyId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PropertyApi.ProductConfiguratorUpdatePropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **propertyId** | **string** |  |  |
| **body** | [**ProductConfiguratorUpdatePropertyRequest**](ProductConfiguratorUpdatePropertyRequest.md) |  |  |

### Return type

[**ProductconfiguratorpropertyEntity**](ProductconfiguratorpropertyEntity.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request or Limit Exceeded |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

