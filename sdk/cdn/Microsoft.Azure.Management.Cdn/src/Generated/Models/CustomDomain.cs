// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Friendly domain name mapping to the endpoint hostname that the customer
    /// provides for branding purposes, e.g. www.contoso.com.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CustomDomain : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        public CustomDomain()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        /// <param name="hostName">The host name of the custom domain. Must be
        /// a domain name.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="resourceState">Resource status of the custom domain.
        /// Possible values include: 'Creating', 'Active', 'Deleting'</param>
        /// <param name="customHttpsProvisioningState">Provisioning status of
        /// Custom Https of the custom domain. Possible values include:
        /// 'Enabling', 'Enabled', 'Disabling', 'Disabled', 'Failed'</param>
        /// <param name="customHttpsProvisioningSubstate">Provisioning substate
        /// shows the progress of custom HTTPS enabling/disabling process step
        /// by step. Possible values include:
        /// 'SubmittingDomainControlValidationRequest',
        /// 'PendingDomainControlValidationREquestApproval',
        /// 'DomainControlValidationRequestApproved',
        /// 'DomainControlValidationRequestRejected',
        /// 'DomainControlValidationRequestTimedOut', 'IssuingCertificate',
        /// 'DeployingCertificate', 'CertificateDeployed',
        /// 'DeletingCertificate', 'CertificateDeleted'</param>
        /// <param name="validationData">Special validation or data may be
        /// required when delivering CDN to some regions due to local
        /// compliance reasons. E.g. ICP license number of a custom domain is
        /// required to deliver content in China.</param>
        /// <param name="provisioningState">Provisioning status of the custom
        /// domain.</param>
        public CustomDomain(string hostName, string id = default(string), string name = default(string), string type = default(string), string resourceState = default(string), string customHttpsProvisioningState = default(string), string customHttpsProvisioningSubstate = default(string), string validationData = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            HostName = hostName;
            ResourceState = resourceState;
            CustomHttpsProvisioningState = customHttpsProvisioningState;
            CustomHttpsProvisioningSubstate = customHttpsProvisioningSubstate;
            ValidationData = validationData;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the host name of the custom domain. Must be a domain
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets resource status of the custom domain. Possible values include:
        /// 'Creating', 'Active', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets provisioning status of Custom Https of the custom domain.
        /// Possible values include: 'Enabling', 'Enabled', 'Disabling',
        /// 'Disabled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.customHttpsProvisioningState")]
        public string CustomHttpsProvisioningState { get; private set; }

        /// <summary>
        /// Gets provisioning substate shows the progress of custom HTTPS
        /// enabling/disabling process step by step. Possible values include:
        /// 'SubmittingDomainControlValidationRequest',
        /// 'PendingDomainControlValidationREquestApproval',
        /// 'DomainControlValidationRequestApproved',
        /// 'DomainControlValidationRequestRejected',
        /// 'DomainControlValidationRequestTimedOut', 'IssuingCertificate',
        /// 'DeployingCertificate', 'CertificateDeployed',
        /// 'DeletingCertificate', 'CertificateDeleted'
        /// </summary>
        [JsonProperty(PropertyName = "properties.customHttpsProvisioningSubstate")]
        public string CustomHttpsProvisioningSubstate { get; private set; }

        /// <summary>
        /// Gets or sets special validation or data may be required when
        /// delivering CDN to some regions due to local compliance reasons.
        /// E.g. ICP license number of a custom domain is required to deliver
        /// content in China.
        /// </summary>
        [JsonProperty(PropertyName = "properties.validationData")]
        public string ValidationData { get; set; }

        /// <summary>
        /// Gets provisioning status of the custom domain.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
        }
    }
}
