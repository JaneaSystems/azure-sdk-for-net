// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Configuration properties for apps environment to join a Virtual Network.
/// </summary>
public partial class ContainerAppVnetConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// Boolean indicating the environment only has an internal load balancer.
    /// These environments do not have a public static IP resource. They must
    /// provide infrastructureSubnetId if enabling this property.
    /// </summary>
    public BicepValue<bool> IsInternal { get => _isInternal; set => _isInternal.Assign(value); }
    private readonly BicepValue<bool> _isInternal;

    /// <summary>
    /// Resource ID of a subnet for infrastructure components. Must not overlap
    /// with any other provided IP ranges.
    /// </summary>
    public BicepValue<ResourceIdentifier> InfrastructureSubnetId { get => _infrastructureSubnetId; set => _infrastructureSubnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _infrastructureSubnetId;

    /// <summary>
    /// CIDR notation IP range assigned to the Docker bridge, network. Must not
    /// overlap with any other provided IP ranges.
    /// </summary>
    public BicepValue<string> DockerBridgeCidr { get => _dockerBridgeCidr; set => _dockerBridgeCidr.Assign(value); }
    private readonly BicepValue<string> _dockerBridgeCidr;

    /// <summary>
    /// IP range in CIDR notation that can be reserved for environment
    /// infrastructure IP addresses. Must not overlap with any other provided
    /// IP ranges.
    /// </summary>
    public BicepValue<string> PlatformReservedCidr { get => _platformReservedCidr; set => _platformReservedCidr.Assign(value); }
    private readonly BicepValue<string> _platformReservedCidr;

    /// <summary>
    /// An IP address from the IP range defined by platformReservedCidr that
    /// will be reserved for the internal DNS server.
    /// </summary>
    public BicepValue<string> PlatformReservedDnsIP { get => _platformReservedDnsIP; set => _platformReservedDnsIP.Assign(value); }
    private readonly BicepValue<string> _platformReservedDnsIP;

    /// <summary>
    /// Creates a new ContainerAppVnetConfiguration.
    /// </summary>
    public ContainerAppVnetConfiguration()
    {
        _isInternal = BicepValue<bool>.DefineProperty(this, "IsInternal", ["internal"]);
        _infrastructureSubnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "InfrastructureSubnetId", ["infrastructureSubnetId"]);
        _dockerBridgeCidr = BicepValue<string>.DefineProperty(this, "DockerBridgeCidr", ["dockerBridgeCidr"]);
        _platformReservedCidr = BicepValue<string>.DefineProperty(this, "PlatformReservedCidr", ["platformReservedCidr"]);
        _platformReservedDnsIP = BicepValue<string>.DefineProperty(this, "PlatformReservedDnsIP", ["platformReservedDnsIP"]);
    }
}
