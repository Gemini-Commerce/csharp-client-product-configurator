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
using OpenAPIDateConverter = product-configurator.Client.OpenAPIDateConverter;

namespace product-configurator.Model
{
    /// <summary>
    /// ProductconfiguratorstepUpdatePayload
    /// </summary>
    [DataContract(Name = "productconfiguratorstepUpdatePayload")]
    public partial class ProductconfiguratorstepUpdatePayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductconfiguratorstepUpdatePayload" /> class.
        /// </summary>
        /// <param name="label">label.</param>
        /// <param name="description">description.</param>
        /// <param name="position">position.</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="subjectToStepId">subjectToStepId.</param>
        /// <param name="hasMultipleSelection">hasMultipleSelection.</param>
        /// <param name="optionsHaveQuantity">optionsHaveQuantity.</param>
        public ProductconfiguratorstepUpdatePayload(LocalisationLocalizedText label = default(LocalisationLocalizedText), LocalisationLocalizedText description = default(LocalisationLocalizedText), string position = default(string), bool isRequired = default(bool), string subjectToStepId = default(string), bool hasMultipleSelection = default(bool), bool optionsHaveQuantity = default(bool))
        {
            this.Label = label;
            this.Description = description;
            this.Position = position;
            this.IsRequired = isRequired;
            this.SubjectToStepId = subjectToStepId;
            this.HasMultipleSelection = hasMultipleSelection;
            this.OptionsHaveQuantity = optionsHaveQuantity;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public LocalisationLocalizedText Label { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public LocalisationLocalizedText Description { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name = "isRequired", EmitDefaultValue = true)]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets SubjectToStepId
        /// </summary>
        [DataMember(Name = "subjectToStepId", EmitDefaultValue = false)]
        public string SubjectToStepId { get; set; }

        /// <summary>
        /// Gets or Sets HasMultipleSelection
        /// </summary>
        [DataMember(Name = "hasMultipleSelection", EmitDefaultValue = true)]
        public bool HasMultipleSelection { get; set; }

        /// <summary>
        /// Gets or Sets OptionsHaveQuantity
        /// </summary>
        [DataMember(Name = "optionsHaveQuantity", EmitDefaultValue = true)]
        public bool OptionsHaveQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductconfiguratorstepUpdatePayload {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  SubjectToStepId: ").Append(SubjectToStepId).Append("\n");
            sb.Append("  HasMultipleSelection: ").Append(HasMultipleSelection).Append("\n");
            sb.Append("  OptionsHaveQuantity: ").Append(OptionsHaveQuantity).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}