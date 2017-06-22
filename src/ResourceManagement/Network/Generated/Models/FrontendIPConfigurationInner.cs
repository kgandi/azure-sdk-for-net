// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Frontend IP address of the load balancer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FrontendIPConfigurationInner : Microsoft.Azure.Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the FrontendIPConfigurationInner
        /// class.
        /// </summary>
        public FrontendIPConfigurationInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FrontendIPConfigurationInner
        /// class.
        /// </summary>
        /// <param name="inboundNatRules">Read only. Inbound rules URIs that
        /// use this frontend IP.</param>
        /// <param name="inboundNatPools">Read only. Inbound pools URIs that
        /// use this frontend IP.</param>
        /// <param name="outboundNatRules">Read only. Outbound rules URIs that
        /// use this frontend IP.</param>
        /// <param name="loadBalancingRules">Gets load balancing rules URIs
        /// that use this frontend IP.</param>
        /// <param name="privateIPAddress">The private IP address of the IP
        /// configuration.</param>
        /// <param name="privateIPAllocationMethod">The Private IP allocation
        /// method. Possible values are: 'Static' and 'Dynamic'. Possible
        /// values include: 'Static', 'Dynamic'</param>
        /// <param name="subnet">The reference of the subnet resource.</param>
        /// <param name="publicIPAddress">The reference of the Public IP
        /// resource.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public FrontendIPConfigurationInner(string id = default(string), IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource> inboundNatRules = default(IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource>), IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource> inboundNatPools = default(IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource>), IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource> outboundNatRules = default(IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource>), IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource> loadBalancingRules = default(IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource>), string privateIPAddress = default(string), string privateIPAllocationMethod = default(string), Microsoft.Azure.Management.ResourceManager.Fluent.SubResource subnet = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource), Microsoft.Azure.Management.ResourceManager.Fluent.SubResource publicIPAddress = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundNatRules = outboundNatRules;
            LoadBalancingRules = loadBalancingRules;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets read only. Inbound rules URIs that use this frontend IP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatRules")]
        public IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource> InboundNatRules { get; private set; }

        /// <summary>
        /// Gets read only. Inbound pools URIs that use this frontend IP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatPools")]
        public IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource> InboundNatPools { get; private set; }

        /// <summary>
        /// Gets read only. Outbound rules URIs that use this frontend IP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundNatRules")]
        public IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource> OutboundNatRules { get; private set; }

        /// <summary>
        /// Gets load balancing rules URIs that use this frontend IP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<Microsoft.Azure.Management.ResourceManager.Fluent.SubResource> LoadBalancingRules { get; private set; }

        /// <summary>
        /// Gets or sets the private IP address of the IP configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the Private IP allocation method. Possible values are:
        /// 'Static' and 'Dynamic'. Possible values include: 'Static',
        /// 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the reference of the subnet resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets the reference of the Public IP resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
