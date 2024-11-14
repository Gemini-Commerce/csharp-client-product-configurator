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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = productconfigurator.Client.OpenAPIDateConverter;

namespace productconfigurator.Model
{
    /// <summary>
    /// ProductConfiguratorGetAvailableConfiguration2Request
    /// </summary>
    [DataContract(Name = "ProductConfigurator_GetAvailableConfiguration2_request")]
    public partial class ProductConfiguratorGetAvailableConfiguration2Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductConfiguratorGetAvailableConfiguration2Request" /> class.
        /// </summary>
        /// <param name="selections">selections.</param>
        /// <param name="propertyFilters">propertyFilters.</param>
        /// <param name="configuratorId">configuratorId.</param>
        public ProductConfiguratorGetAvailableConfiguration2Request(List<ProductconfiguratorconfigurationSelection> selections = default(List<ProductconfiguratorconfigurationSelection>), List<ConfigurationPropertyFilter> propertyFilters = default(List<ConfigurationPropertyFilter>), string configuratorId = default(string))
        {
            this.Selections = selections;
            this.PropertyFilters = propertyFilters;
            this.ConfiguratorId = configuratorId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Selections
        /// </summary>
        [DataMember(Name = "selections", EmitDefaultValue = false)]
        public List<ProductconfiguratorconfigurationSelection> Selections { get; set; }

        /// <summary>
        /// Gets or Sets PropertyFilters
        /// </summary>
        [DataMember(Name = "propertyFilters", EmitDefaultValue = false)]
        public List<ConfigurationPropertyFilter> PropertyFilters { get; set; }

        /// <summary>
        /// Gets or Sets ConfiguratorId
        /// </summary>
        [DataMember(Name = "configuratorId", EmitDefaultValue = false)]
        public string ConfiguratorId { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductConfiguratorGetAvailableConfiguration2Request {\n");
            sb.Append("  Selections: ").Append(Selections).Append("\n");
            sb.Append("  PropertyFilters: ").Append(PropertyFilters).Append("\n");
            sb.Append("  ConfiguratorId: ").Append(ConfiguratorId).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
