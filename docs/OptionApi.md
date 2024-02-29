# product-configurator.Api.OptionApi

All URIs are relative to *https://product-configurator.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductConfiguratorBulkCreateOptions**](OptionApi.md#productconfiguratorbulkcreateoptions) | **POST** /v1/{tenantId}/step/{stepId}/option/create/bulk | Bulk Create Options |
| [**ProductConfiguratorBulkDeleteOptions**](OptionApi.md#productconfiguratorbulkdeleteoptions) | **POST** /v1/{tenantId}/option/delete/bulk | Bulk Delete Options |
| [**ProductConfiguratorBulkUpdateOptions**](OptionApi.md#productconfiguratorbulkupdateoptions) | **PUT** /v1/{tenantId}/option/bulk | Bulk Update Options |
| [**ProductConfiguratorCopyOption**](OptionApi.md#productconfiguratorcopyoption) | **POST** /v1/{tenantId}/option/{sourceOptionId}/copy | Copy Option |
| [**ProductConfiguratorCreateOption**](OptionApi.md#productconfiguratorcreateoption) | **POST** /v1/{tenantId}/step/{stepId}/option/create | Create Option |
| [**ProductConfiguratorDeleteOption**](OptionApi.md#productconfiguratordeleteoption) | **DELETE** /v1/{tenantId}/option/{optionId} | Delete Option |
| [**ProductConfiguratorListOptions**](OptionApi.md#productconfiguratorlistoptions) | **POST** /v1/{tenantId}/step/{stepId}/page-size/{pageSize}/options | List Options |
| [**ProductConfiguratorUpdateOption**](OptionApi.md#productconfiguratorupdateoption) | **PUT** /v1/{tenantId}/option/{optionId} | Update Option |

<a id="productconfiguratorbulkcreateoptions"></a>
# **ProductConfiguratorBulkCreateOptions**
> ProductconfiguratoroptionBulkCreateResponse ProductConfiguratorBulkCreateOptions (string tenantId, string stepId, ProductConfiguratorBulkCreateOptionsRequest body)

Bulk Create Options

Add multiple options to an existing step simultaneously. Submit a POST request with the necessary option details in the body to efficiently expand the configuration possibilities in bulk. Streamline large-scale option management effortlessly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorBulkCreateOptionsExample
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

            var apiInstance = new OptionApi(config);
            var tenantId = "tenantId_example";  // string | 
            var stepId = "stepId_example";  // string | 
            var body = new ProductConfiguratorBulkCreateOptionsRequest(); // ProductConfiguratorBulkCreateOptionsRequest | 

            try
            {
                // Bulk Create Options
                ProductconfiguratoroptionBulkCreateResponse result = apiInstance.ProductConfiguratorBulkCreateOptions(tenantId, stepId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptionApi.ProductConfiguratorBulkCreateOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorBulkCreateOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Create Options
    ApiResponse<ProductconfiguratoroptionBulkCreateResponse> response = apiInstance.ProductConfiguratorBulkCreateOptionsWithHttpInfo(tenantId, stepId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OptionApi.ProductConfiguratorBulkCreateOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **stepId** | **string** |  |  |
| **body** | [**ProductConfiguratorBulkCreateOptionsRequest**](ProductConfiguratorBulkCreateOptionsRequest.md) |  |  |

### Return type

[**ProductconfiguratoroptionBulkCreateResponse**](ProductconfiguratoroptionBulkCreateResponse.md)

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

<a id="productconfiguratorbulkdeleteoptions"></a>
# **ProductConfiguratorBulkDeleteOptions**
> Object ProductConfiguratorBulkDeleteOptions (string tenantId, ProductConfiguratorBulkDeleteOptionsRequest body)

Bulk Delete Options

Efficiently remove multiple options from configurations using a bulk delete operation. Specify the tenant ID and submit a POST request with the list of option IDs in the body for streamlined option management.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorBulkDeleteOptionsExample
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

            var apiInstance = new OptionApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new ProductConfiguratorBulkDeleteOptionsRequest(); // ProductConfiguratorBulkDeleteOptionsRequest | 

            try
            {
                // Bulk Delete Options
                Object result = apiInstance.ProductConfiguratorBulkDeleteOptions(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptionApi.ProductConfiguratorBulkDeleteOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorBulkDeleteOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Delete Options
    ApiResponse<Object> response = apiInstance.ProductConfiguratorBulkDeleteOptionsWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OptionApi.ProductConfiguratorBulkDeleteOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**ProductConfiguratorBulkDeleteOptionsRequest**](ProductConfiguratorBulkDeleteOptionsRequest.md) |  |  |

### Return type

**Object**

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

<a id="productconfiguratorbulkupdateoptions"></a>
# **ProductConfiguratorBulkUpdateOptions**
> ProductconfiguratoroptionBulkUpdateResponse ProductConfiguratorBulkUpdateOptions (string tenantId, ProductConfiguratorBulkUpdateOptionsRequest body)

Bulk Update Options

Effortlessly update multiple options. Specify the tenant ID and submit a PUT request with the updated option details in the body. Streamline the customization of a multitude of options in one go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorBulkUpdateOptionsExample
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

            var apiInstance = new OptionApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new ProductConfiguratorBulkUpdateOptionsRequest(); // ProductConfiguratorBulkUpdateOptionsRequest | 

            try
            {
                // Bulk Update Options
                ProductconfiguratoroptionBulkUpdateResponse result = apiInstance.ProductConfiguratorBulkUpdateOptions(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptionApi.ProductConfiguratorBulkUpdateOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorBulkUpdateOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Update Options
    ApiResponse<ProductconfiguratoroptionBulkUpdateResponse> response = apiInstance.ProductConfiguratorBulkUpdateOptionsWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OptionApi.ProductConfiguratorBulkUpdateOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**ProductConfiguratorBulkUpdateOptionsRequest**](ProductConfiguratorBulkUpdateOptionsRequest.md) |  |  |

### Return type

[**ProductconfiguratoroptionBulkUpdateResponse**](ProductconfiguratoroptionBulkUpdateResponse.md)

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

<a id="productconfiguratorcopyoption"></a>
# **ProductConfiguratorCopyOption**
> ProductconfiguratoroptionEntity ProductConfiguratorCopyOption (string tenantId, string sourceOptionId, ProductConfiguratorCopyOptionRequest body)

Copy Option

Duplicate an existing option from the source to a specified tenant. Utilize a POST request with an empty body to initiate the copy process, creating a new option based on the source configuration. Streamline option replication effortlessly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorCopyOptionExample
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

            var apiInstance = new OptionApi(config);
            var tenantId = "tenantId_example";  // string | 
            var sourceOptionId = "sourceOptionId_example";  // string | 
            var body = new ProductConfiguratorCopyOptionRequest(); // ProductConfiguratorCopyOptionRequest | 

            try
            {
                // Copy Option
                ProductconfiguratoroptionEntity result = apiInstance.ProductConfiguratorCopyOption(tenantId, sourceOptionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptionApi.ProductConfiguratorCopyOption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCopyOptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy Option
    ApiResponse<ProductconfiguratoroptionEntity> response = apiInstance.ProductConfiguratorCopyOptionWithHttpInfo(tenantId, sourceOptionId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OptionApi.ProductConfiguratorCopyOptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **sourceOptionId** | **string** |  |  |
| **body** | [**ProductConfiguratorCopyOptionRequest**](ProductConfiguratorCopyOptionRequest.md) |  |  |

### Return type

[**ProductconfiguratoroptionEntity**](ProductconfiguratoroptionEntity.md)

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

<a id="productconfiguratorcreateoption"></a>
# **ProductConfiguratorCreateOption**
> ProductconfiguratoroptionEntity ProductConfiguratorCreateOption (string tenantId, string stepId, ProductConfiguratorCreateOptionRequest body)

Create Option

Integrate a new option into an existing step by specifying the tenant and step IDs. Use a POST request with the required option details in the body for seamless customization and expansion of product configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorCreateOptionExample
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

            var apiInstance = new OptionApi(config);
            var tenantId = "tenantId_example";  // string | 
            var stepId = "stepId_example";  // string | 
            var body = new ProductConfiguratorCreateOptionRequest(); // ProductConfiguratorCreateOptionRequest | 

            try
            {
                // Create Option
                ProductconfiguratoroptionEntity result = apiInstance.ProductConfiguratorCreateOption(tenantId, stepId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptionApi.ProductConfiguratorCreateOption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCreateOptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Option
    ApiResponse<ProductconfiguratoroptionEntity> response = apiInstance.ProductConfiguratorCreateOptionWithHttpInfo(tenantId, stepId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OptionApi.ProductConfiguratorCreateOptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **stepId** | **string** |  |  |
| **body** | [**ProductConfiguratorCreateOptionRequest**](ProductConfiguratorCreateOptionRequest.md) |  |  |

### Return type

[**ProductconfiguratoroptionEntity**](ProductconfiguratoroptionEntity.md)

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

<a id="productconfiguratordeleteoption"></a>
# **ProductConfiguratorDeleteOption**
> Object ProductConfiguratorDeleteOption (string tenantId, string optionId)

Delete Option

Remove a specific option by specifying the tenant and option IDs. Ensure precision in option management with a straightforward DELETE request, simplifying the elimination of unwanted configuration choices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorDeleteOptionExample
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

            var apiInstance = new OptionApi(config);
            var tenantId = "tenantId_example";  // string | 
            var optionId = "optionId_example";  // string | 

            try
            {
                // Delete Option
                Object result = apiInstance.ProductConfiguratorDeleteOption(tenantId, optionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptionApi.ProductConfiguratorDeleteOption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorDeleteOptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Option
    ApiResponse<Object> response = apiInstance.ProductConfiguratorDeleteOptionWithHttpInfo(tenantId, optionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OptionApi.ProductConfiguratorDeleteOptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **optionId** | **string** |  |  |

### Return type

**Object**

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [APIAuthorization](../README.md#APIAuthorization)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a id="productconfiguratorlistoptions"></a>
# **ProductConfiguratorListOptions**
> OptionListOptionsResponse ProductConfiguratorListOptions (string tenantId, string stepId, long pageSize, ProductConfiguratorListPropertiesRequest body)

List Options

Retrieve a list of options for a specific step based on tenant and step IDs. Customize results by specifying page size for efficient pagination. Submit an empty body to get all options associated with the step.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorListOptionsExample
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

            var apiInstance = new OptionApi(config);
            var tenantId = "tenantId_example";  // string | 
            var stepId = "stepId_example";  // string | 
            var pageSize = 789L;  // long | 
            var body = new ProductConfiguratorListPropertiesRequest(); // ProductConfiguratorListPropertiesRequest | 

            try
            {
                // List Options
                OptionListOptionsResponse result = apiInstance.ProductConfiguratorListOptions(tenantId, stepId, pageSize, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptionApi.ProductConfiguratorListOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorListOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Options
    ApiResponse<OptionListOptionsResponse> response = apiInstance.ProductConfiguratorListOptionsWithHttpInfo(tenantId, stepId, pageSize, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OptionApi.ProductConfiguratorListOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **stepId** | **string** |  |  |
| **pageSize** | **long** |  |  |
| **body** | [**ProductConfiguratorListPropertiesRequest**](ProductConfiguratorListPropertiesRequest.md) |  |  |

### Return type

[**OptionListOptionsResponse**](OptionListOptionsResponse.md)

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

<a id="productconfiguratorupdateoption"></a>
# **ProductConfiguratorUpdateOption**
> ProductconfiguratoroptionEntity ProductConfiguratorUpdateOption (string tenantId, string optionId, ProductConfiguratorUpdateOptionRequest body)

Update Option

Modify an existing option by specifying the tenant and option IDs. Utilize a PUT request with updated option details in the body for seamless customization and fine-tuning of your product configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using product-configurator.Api;
using product-configurator.Client;
using product-configurator.Model;

namespace Example
{
    public class ProductConfiguratorUpdateOptionExample
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

            var apiInstance = new OptionApi(config);
            var tenantId = "tenantId_example";  // string | 
            var optionId = "optionId_example";  // string | 
            var body = new ProductConfiguratorUpdateOptionRequest(); // ProductConfiguratorUpdateOptionRequest | 

            try
            {
                // Update Option
                ProductconfiguratoroptionEntity result = apiInstance.ProductConfiguratorUpdateOption(tenantId, optionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OptionApi.ProductConfiguratorUpdateOption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorUpdateOptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Option
    ApiResponse<ProductconfiguratoroptionEntity> response = apiInstance.ProductConfiguratorUpdateOptionWithHttpInfo(tenantId, optionId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OptionApi.ProductConfiguratorUpdateOptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **optionId** | **string** |  |  |
| **body** | [**ProductConfiguratorUpdateOptionRequest**](ProductConfiguratorUpdateOptionRequest.md) |  |  |

### Return type

[**ProductconfiguratoroptionEntity**](ProductconfiguratoroptionEntity.md)

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

