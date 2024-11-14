# productconfigurator.Api.StepApi

All URIs are relative to *https://product-configurator.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductConfiguratorBulkCreateSteps**](StepApi.md#productconfiguratorbulkcreatesteps) | **POST** /v1/{tenantId}/configurator/{configuratorId}/step/create/bulk | Bulk Create Steps |
| [**ProductConfiguratorBulkDeleteSteps**](StepApi.md#productconfiguratorbulkdeletesteps) | **POST** /v1/{tenantId}/step/delete/bulk | Bulk Delete Steps |
| [**ProductConfiguratorCopyStep**](StepApi.md#productconfiguratorcopystep) | **POST** /v1/{tenantId}/step/{sourceStepId}/copy | Copy Step |
| [**ProductConfiguratorCreateStep**](StepApi.md#productconfiguratorcreatestep) | **POST** /v1/{tenantId}/configurator/{configuratorId}/step/create | Create Step |
| [**ProductConfiguratorDeleteStep**](StepApi.md#productconfiguratordeletestep) | **DELETE** /v1/{tenantId}/step/{stepId} | Delete Step |
| [**ProductConfiguratorUpdateStep**](StepApi.md#productconfiguratorupdatestep) | **PUT** /v1/{tenantId}/step/{stepId} | Update Step |

<a id="productconfiguratorbulkcreatesteps"></a>
# **ProductConfiguratorBulkCreateSteps**
> ProductconfiguratorstepBulkCreateResponse ProductConfiguratorBulkCreateSteps (string tenantId, string configuratorId, ProductConfiguratorBulkCreateStepsRequest body)

Bulk Create Steps

Add multiple steps to an existing product configurator simultaneously. Submit a POST request with the necessary step details in the body to efficiently extend the configuration process in bulk. Simplify large-scale configuration management effortlessly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorBulkCreateStepsExample
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

            var apiInstance = new StepApi(config);
            var tenantId = "tenantId_example";  // string | 
            var configuratorId = "configuratorId_example";  // string | 
            var body = new ProductConfiguratorBulkCreateStepsRequest(); // ProductConfiguratorBulkCreateStepsRequest | 

            try
            {
                // Bulk Create Steps
                ProductconfiguratorstepBulkCreateResponse result = apiInstance.ProductConfiguratorBulkCreateSteps(tenantId, configuratorId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StepApi.ProductConfiguratorBulkCreateSteps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorBulkCreateStepsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Create Steps
    ApiResponse<ProductconfiguratorstepBulkCreateResponse> response = apiInstance.ProductConfiguratorBulkCreateStepsWithHttpInfo(tenantId, configuratorId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StepApi.ProductConfiguratorBulkCreateStepsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **configuratorId** | **string** |  |  |
| **body** | [**ProductConfiguratorBulkCreateStepsRequest**](ProductConfiguratorBulkCreateStepsRequest.md) |  |  |

### Return type

[**ProductconfiguratorstepBulkCreateResponse**](ProductconfiguratorstepBulkCreateResponse.md)

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

<a id="productconfiguratorbulkdeletesteps"></a>
# **ProductConfiguratorBulkDeleteSteps**
> Object ProductConfiguratorBulkDeleteSteps (string tenantId, ProductConfiguratorBulkDeleteStepsRequest body)

Bulk Delete Steps

Efficiently remove multiple steps from a product configurator using a bulk delete operation. Specify the tenant ID and submit a POST request with the list of step IDs in the body for streamlined configuration management.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorBulkDeleteStepsExample
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

            var apiInstance = new StepApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new ProductConfiguratorBulkDeleteStepsRequest(); // ProductConfiguratorBulkDeleteStepsRequest | 

            try
            {
                // Bulk Delete Steps
                Object result = apiInstance.ProductConfiguratorBulkDeleteSteps(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StepApi.ProductConfiguratorBulkDeleteSteps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorBulkDeleteStepsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Delete Steps
    ApiResponse<Object> response = apiInstance.ProductConfiguratorBulkDeleteStepsWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StepApi.ProductConfiguratorBulkDeleteStepsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**ProductConfiguratorBulkDeleteStepsRequest**](ProductConfiguratorBulkDeleteStepsRequest.md) |  |  |

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

<a id="productconfiguratorcopystep"></a>
# **ProductConfiguratorCopyStep**
> ProductconfiguratorstepEntity ProductConfiguratorCopyStep (string tenantId, string sourceStepId, ProductConfiguratorCopyStepRequest body)

Copy Step

Duplicate an existing step from the source to a specified tenant. Utilize a POST request with an empty body to initiate the copy process, creating a new step based on the source configuration. Streamline step replication effortlessly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorCopyStepExample
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

            var apiInstance = new StepApi(config);
            var tenantId = "tenantId_example";  // string | 
            var sourceStepId = "sourceStepId_example";  // string | 
            var body = new ProductConfiguratorCopyStepRequest(); // ProductConfiguratorCopyStepRequest | 

            try
            {
                // Copy Step
                ProductconfiguratorstepEntity result = apiInstance.ProductConfiguratorCopyStep(tenantId, sourceStepId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StepApi.ProductConfiguratorCopyStep: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCopyStepWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy Step
    ApiResponse<ProductconfiguratorstepEntity> response = apiInstance.ProductConfiguratorCopyStepWithHttpInfo(tenantId, sourceStepId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StepApi.ProductConfiguratorCopyStepWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **sourceStepId** | **string** |  |  |
| **body** | [**ProductConfiguratorCopyStepRequest**](ProductConfiguratorCopyStepRequest.md) |  |  |

### Return type

[**ProductconfiguratorstepEntity**](ProductconfiguratorstepEntity.md)

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

<a id="productconfiguratorcreatestep"></a>
# **ProductConfiguratorCreateStep**
> ProductconfiguratorstepEntity ProductConfiguratorCreateStep (string tenantId, string configuratorId, ProductConfiguratorCreateStepRequest body)

Create Step

Add a new step to an existing product configurator by specifying the tenant and configurator IDs. Utilize a POST request with the required step details in the body to seamlessly extend the configuration process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorCreateStepExample
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

            var apiInstance = new StepApi(config);
            var tenantId = "tenantId_example";  // string | 
            var configuratorId = "configuratorId_example";  // string | 
            var body = new ProductConfiguratorCreateStepRequest(); // ProductConfiguratorCreateStepRequest | 

            try
            {
                // Create Step
                ProductconfiguratorstepEntity result = apiInstance.ProductConfiguratorCreateStep(tenantId, configuratorId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StepApi.ProductConfiguratorCreateStep: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorCreateStepWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Step
    ApiResponse<ProductconfiguratorstepEntity> response = apiInstance.ProductConfiguratorCreateStepWithHttpInfo(tenantId, configuratorId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StepApi.ProductConfiguratorCreateStepWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **configuratorId** | **string** |  |  |
| **body** | [**ProductConfiguratorCreateStepRequest**](ProductConfiguratorCreateStepRequest.md) |  |  |

### Return type

[**ProductconfiguratorstepEntity**](ProductconfiguratorstepEntity.md)

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

<a id="productconfiguratordeletestep"></a>
# **ProductConfiguratorDeleteStep**
> GooglerpcStatus ProductConfiguratorDeleteStep (string tenantId, string stepId)

Delete Step

Remove a step from a product configurator by specifying the tenant and step IDs. Ensure precision in configuration management with a straightforward DELETE request, simplifying the elimination of unwanted steps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorDeleteStepExample
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

            var apiInstance = new StepApi(config);
            var tenantId = "tenantId_example";  // string | 
            var stepId = "stepId_example";  // string | 

            try
            {
                // Delete Step
                GooglerpcStatus result = apiInstance.ProductConfiguratorDeleteStep(tenantId, stepId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StepApi.ProductConfiguratorDeleteStep: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorDeleteStepWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Step
    ApiResponse<GooglerpcStatus> response = apiInstance.ProductConfiguratorDeleteStepWithHttpInfo(tenantId, stepId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StepApi.ProductConfiguratorDeleteStepWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **stepId** | **string** |  |  |

### Return type

[**GooglerpcStatus**](GooglerpcStatus.md)

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

<a id="productconfiguratorupdatestep"></a>
# **ProductConfiguratorUpdateStep**
> ProductconfiguratorstepEntity ProductConfiguratorUpdateStep (string tenantId, string stepId, ProductConfiguratorUpdateStepRequest body)

Update Step

Modify an existing step within a product configurator by specifying the tenant and step IDs. Utilize a PUT request with updated step details in the body for seamless customization and fine-tuning of your product configurations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using productconfigurator.Api;
using productconfigurator.Client;
using productconfigurator.Model;

namespace Example
{
    public class ProductConfiguratorUpdateStepExample
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

            var apiInstance = new StepApi(config);
            var tenantId = "tenantId_example";  // string | 
            var stepId = "stepId_example";  // string | 
            var body = new ProductConfiguratorUpdateStepRequest(); // ProductConfiguratorUpdateStepRequest | 

            try
            {
                // Update Step
                ProductconfiguratorstepEntity result = apiInstance.ProductConfiguratorUpdateStep(tenantId, stepId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StepApi.ProductConfiguratorUpdateStep: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductConfiguratorUpdateStepWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Step
    ApiResponse<ProductconfiguratorstepEntity> response = apiInstance.ProductConfiguratorUpdateStepWithHttpInfo(tenantId, stepId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StepApi.ProductConfiguratorUpdateStepWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **stepId** | **string** |  |  |
| **body** | [**ProductConfiguratorUpdateStepRequest**](ProductConfiguratorUpdateStepRequest.md) |  |  |

### Return type

[**ProductconfiguratorstepEntity**](ProductconfiguratorstepEntity.md)

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

