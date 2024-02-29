/*
 * Product Configurator Service
 *
 * ## Introduction  This comprehensive guide will equip you with the knowledge to integrate and leverage our Product Configurator Service in your applications.  ## Quick Start  Get up and running in no time! Follow these steps to kickstart your integration:  1. **Authentication:** Obtain your integration JWT to authenticate your requests. 2. **Client Libraries:** Explore our GitHub repositories to grab client libraries in your preferred programming language. 3. **API Overview:** Familiarize yourself with our RESTful API using the OpenAPI specification.  ## Integration  ### API Overview  Our RESTful API is the gateway to unlocking the full potential of Product Configurator. Check out the detailed [API Reference](/docs/category/configurator) for a granular understanding of each endpoint and request/response format.  ### Client Libraries  To expedite your integration process, we provide client libraries for various programming languages. Find the one that suits your stack in our [GitHub repositories](https://github.com/Gemini-Commerce).  ### Authentication  Security is paramount. Learn how to authenticate your requests using JWT. This ensures a secure and reliable connection between your application and Product Configurator.  ## Configuration Management  ### Configurator Lifecycle  Understand the lifecycle of configurators, from draft to active and deleted. This flexibility allows you to manage configurations at your own pace.  ### Steps and Options  Configure product steps with ease and define options effortlessly. Explore the power of dependencies to create dynamic and intuitive configurations.  ### Matrices  Delve into matrices—your secret weapon. Explore price and weight matrices, and learn how configured steps influence properties and pricing.  ### Price Management  Unleash dynamic pricing with our versatile price matrices. From fixed prices to incremental structures, adapt to diverse pricing models effortlessly.  ## Security  Your data is in safe hands. Discover how Product Configurator ensures security through JWT authentication, safeguarding your sensitive information.  ## Backward Compatibility  Stay ahead of the curve. Learn about our versioning strategy, providing backward compatibility while allowing our service to evolve seamlessly.  ## Developer Support  Have questions? Need assistance? Write to us at [info@gemini-commerce.com](mailto:info@gemini-commerce.com) and we will get back to you.
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using product-configurator.Client;
using product-configurator.Client.Auth;
using product-configurator.Model;

namespace product-configurator.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductConfiguratorApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="propertyId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductconfiguratorpropertyEntity</returns>
        ProductconfiguratorpropertyEntity ProductConfiguratorGetProperty(string tenantId, string propertyId, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="propertyId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductconfiguratorpropertyEntity</returns>
        ApiResponse<ProductconfiguratorpropertyEntity> ProductConfiguratorGetPropertyWithHttpInfo(string tenantId, string propertyId, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="configuratorId"></param>
        /// <param name="pageSize"></param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PropertyListPropertiesByConfigurationResponse</returns>
        PropertyListPropertiesByConfigurationResponse ProductConfiguratorListPropertiesByConfiguration(string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="configuratorId"></param>
        /// <param name="pageSize"></param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PropertyListPropertiesByConfigurationResponse</returns>
        ApiResponse<PropertyListPropertiesByConfigurationResponse> ProductConfiguratorListPropertiesByConfigurationWithHttpInfo(string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductConfiguratorApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="propertyId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductconfiguratorpropertyEntity</returns>
        System.Threading.Tasks.Task<ProductconfiguratorpropertyEntity> ProductConfiguratorGetPropertyAsync(string tenantId, string propertyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="propertyId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductconfiguratorpropertyEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductconfiguratorpropertyEntity>> ProductConfiguratorGetPropertyWithHttpInfoAsync(string tenantId, string propertyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="configuratorId"></param>
        /// <param name="pageSize"></param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PropertyListPropertiesByConfigurationResponse</returns>
        System.Threading.Tasks.Task<PropertyListPropertiesByConfigurationResponse> ProductConfiguratorListPropertiesByConfigurationAsync(string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="configuratorId"></param>
        /// <param name="pageSize"></param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PropertyListPropertiesByConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertyListPropertiesByConfigurationResponse>> ProductConfiguratorListPropertiesByConfigurationWithHttpInfoAsync(string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductConfiguratorApi : IProductConfiguratorApiSync, IProductConfiguratorApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProductConfiguratorApi : IProductConfiguratorApi
    {
        private product-configurator.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductConfiguratorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductConfiguratorApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductConfiguratorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductConfiguratorApi(string basePath)
        {
            this.Configuration = product-configurator.Client.Configuration.MergeConfigurations(
                product-configurator.Client.GlobalConfiguration.Instance,
                new product-configurator.Client.Configuration { BasePath = basePath }
            );
            this.Client = new product-configurator.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new product-configurator.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = product-configurator.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductConfiguratorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductConfiguratorApi(product-configurator.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = product-configurator.Client.Configuration.MergeConfigurations(
                product-configurator.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new product-configurator.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new product-configurator.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = product-configurator.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductConfiguratorApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProductConfiguratorApi(product-configurator.Client.ISynchronousClient client, product-configurator.Client.IAsynchronousClient asyncClient, product-configurator.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = product-configurator.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public product-configurator.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public product-configurator.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public product-configurator.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public product-configurator.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="propertyId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductconfiguratorpropertyEntity</returns>
        public ProductconfiguratorpropertyEntity ProductConfiguratorGetProperty(string tenantId, string propertyId, int operationIndex = 0)
        {
            product-configurator.Client.ApiResponse<ProductconfiguratorpropertyEntity> localVarResponse = ProductConfiguratorGetPropertyWithHttpInfo(tenantId, propertyId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="propertyId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductconfiguratorpropertyEntity</returns>
        public product-configurator.Client.ApiResponse<ProductconfiguratorpropertyEntity> ProductConfiguratorGetPropertyWithHttpInfo(string tenantId, string propertyId, int operationIndex = 0)
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'tenantId' when calling ProductConfiguratorApi->ProductConfiguratorGetProperty");
            }

            // verify the required parameter 'propertyId' is set
            if (propertyId == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'propertyId' when calling ProductConfiguratorApi->ProductConfiguratorGetProperty");
            }

            product-configurator.Client.RequestOptions localVarRequestOptions = new product-configurator.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = product-configurator.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = product-configurator.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tenantId", product-configurator.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            localVarRequestOptions.PathParameters.Add("propertyId", product-configurator.Client.ClientUtils.ParameterToString(propertyId)); // path parameter

            localVarRequestOptions.Operation = "ProductConfiguratorApi.ProductConfiguratorGetProperty";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<ProductconfiguratorpropertyEntity>("/v1/{tenantId}/property/{propertyId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ProductConfiguratorGetProperty", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="propertyId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductconfiguratorpropertyEntity</returns>
        public async System.Threading.Tasks.Task<ProductconfiguratorpropertyEntity> ProductConfiguratorGetPropertyAsync(string tenantId, string propertyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            product-configurator.Client.ApiResponse<ProductconfiguratorpropertyEntity> localVarResponse = await ProductConfiguratorGetPropertyWithHttpInfoAsync(tenantId, propertyId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="propertyId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductconfiguratorpropertyEntity)</returns>
        public async System.Threading.Tasks.Task<product-configurator.Client.ApiResponse<ProductconfiguratorpropertyEntity>> ProductConfiguratorGetPropertyWithHttpInfoAsync(string tenantId, string propertyId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'tenantId' when calling ProductConfiguratorApi->ProductConfiguratorGetProperty");
            }

            // verify the required parameter 'propertyId' is set
            if (propertyId == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'propertyId' when calling ProductConfiguratorApi->ProductConfiguratorGetProperty");
            }


            product-configurator.Client.RequestOptions localVarRequestOptions = new product-configurator.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = product-configurator.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = product-configurator.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tenantId", product-configurator.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            localVarRequestOptions.PathParameters.Add("propertyId", product-configurator.Client.ClientUtils.ParameterToString(propertyId)); // path parameter

            localVarRequestOptions.Operation = "ProductConfiguratorApi.ProductConfiguratorGetProperty";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ProductconfiguratorpropertyEntity>("/v1/{tenantId}/property/{propertyId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ProductConfiguratorGetProperty", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="configuratorId"></param>
        /// <param name="pageSize"></param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PropertyListPropertiesByConfigurationResponse</returns>
        public PropertyListPropertiesByConfigurationResponse ProductConfiguratorListPropertiesByConfiguration(string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body, int operationIndex = 0)
        {
            product-configurator.Client.ApiResponse<PropertyListPropertiesByConfigurationResponse> localVarResponse = ProductConfiguratorListPropertiesByConfigurationWithHttpInfo(tenantId, configuratorId, pageSize, body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="configuratorId"></param>
        /// <param name="pageSize"></param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PropertyListPropertiesByConfigurationResponse</returns>
        public product-configurator.Client.ApiResponse<PropertyListPropertiesByConfigurationResponse> ProductConfiguratorListPropertiesByConfigurationWithHttpInfo(string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'tenantId' when calling ProductConfiguratorApi->ProductConfiguratorListPropertiesByConfiguration");
            }

            // verify the required parameter 'configuratorId' is set
            if (configuratorId == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'configuratorId' when calling ProductConfiguratorApi->ProductConfiguratorListPropertiesByConfiguration");
            }

            // verify the required parameter 'pageSize' is set
            if (pageSize == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'pageSize' when calling ProductConfiguratorApi->ProductConfiguratorListPropertiesByConfiguration");
            }

            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'body' when calling ProductConfiguratorApi->ProductConfiguratorListPropertiesByConfiguration");
            }

            product-configurator.Client.RequestOptions localVarRequestOptions = new product-configurator.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = product-configurator.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = product-configurator.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tenantId", product-configurator.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            localVarRequestOptions.PathParameters.Add("configuratorId", product-configurator.Client.ClientUtils.ParameterToString(configuratorId)); // path parameter
            localVarRequestOptions.PathParameters.Add("pageSize", product-configurator.Client.ClientUtils.ParameterToString(pageSize)); // path parameter
            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "ProductConfiguratorApi.ProductConfiguratorListPropertiesByConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<PropertyListPropertiesByConfigurationResponse>("/v1/{tenantId}/configurator/{configuratorId}/page-size/{pageSize}/properties", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ProductConfiguratorListPropertiesByConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="configuratorId"></param>
        /// <param name="pageSize"></param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PropertyListPropertiesByConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<PropertyListPropertiesByConfigurationResponse> ProductConfiguratorListPropertiesByConfigurationAsync(string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            product-configurator.Client.ApiResponse<PropertyListPropertiesByConfigurationResponse> localVarResponse = await ProductConfiguratorListPropertiesByConfigurationWithHttpInfoAsync(tenantId, configuratorId, pageSize, body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="product-configurator.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantId"></param>
        /// <param name="configuratorId"></param>
        /// <param name="pageSize"></param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PropertyListPropertiesByConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<product-configurator.Client.ApiResponse<PropertyListPropertiesByConfigurationResponse>> ProductConfiguratorListPropertiesByConfigurationWithHttpInfoAsync(string tenantId, string configuratorId, string pageSize, ProductConfiguratorListPropertiesByConfigurationRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tenantId' is set
            if (tenantId == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'tenantId' when calling ProductConfiguratorApi->ProductConfiguratorListPropertiesByConfiguration");
            }

            // verify the required parameter 'configuratorId' is set
            if (configuratorId == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'configuratorId' when calling ProductConfiguratorApi->ProductConfiguratorListPropertiesByConfiguration");
            }

            // verify the required parameter 'pageSize' is set
            if (pageSize == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'pageSize' when calling ProductConfiguratorApi->ProductConfiguratorListPropertiesByConfiguration");
            }

            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new product-configurator.Client.ApiException(400, "Missing required parameter 'body' when calling ProductConfiguratorApi->ProductConfiguratorListPropertiesByConfiguration");
            }


            product-configurator.Client.RequestOptions localVarRequestOptions = new product-configurator.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = product-configurator.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = product-configurator.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tenantId", product-configurator.Client.ClientUtils.ParameterToString(tenantId)); // path parameter
            localVarRequestOptions.PathParameters.Add("configuratorId", product-configurator.Client.ClientUtils.ParameterToString(configuratorId)); // path parameter
            localVarRequestOptions.PathParameters.Add("pageSize", product-configurator.Client.ClientUtils.ParameterToString(pageSize)); // path parameter
            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "ProductConfiguratorApi.ProductConfiguratorListPropertiesByConfiguration";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<PropertyListPropertiesByConfigurationResponse>("/v1/{tenantId}/configurator/{configuratorId}/page-size/{pageSize}/properties", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ProductConfiguratorListPropertiesByConfiguration", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
