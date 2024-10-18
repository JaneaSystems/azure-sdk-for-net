// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// InstanceFailoverGroup.
/// </summary>
public partial class InstanceFailoverGroup : ProvisionableResource
{
    /// <summary>
    /// The name of the failover group.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// List of managed instance pairs in the failover group.
    /// </summary>
    public BicepList<ManagedInstancePairInfo> ManagedInstancePairs { get => _managedInstancePairs; set => _managedInstancePairs.Assign(value); }
    private readonly BicepList<ManagedInstancePairInfo> _managedInstancePairs;

    /// <summary>
    /// Partner region information for the failover group.
    /// </summary>
    public BicepList<PartnerRegionInfo> PartnerRegions { get => _partnerRegions; set => _partnerRegions.Assign(value); }
    private readonly BicepList<PartnerRegionInfo> _partnerRegions;

    /// <summary>
    /// Failover policy of the read-only endpoint for the failover group.
    /// </summary>
    public BicepValue<ReadOnlyEndpointFailoverPolicy> ReadOnlyEndpointFailoverPolicy { get => _readOnlyEndpointFailoverPolicy; set => _readOnlyEndpointFailoverPolicy.Assign(value); }
    private readonly BicepValue<ReadOnlyEndpointFailoverPolicy> _readOnlyEndpointFailoverPolicy;

    /// <summary>
    /// Read-write endpoint of the failover group instance.
    /// </summary>
    public BicepValue<InstanceFailoverGroupReadWriteEndpoint> ReadWriteEndpoint { get => _readWriteEndpoint; set => _readWriteEndpoint.Assign(value); }
    private readonly BicepValue<InstanceFailoverGroupReadWriteEndpoint> _readWriteEndpoint;

    /// <summary>
    /// Type of the geo-secondary instance. Set &apos;Standby&apos; if the
    /// instance is used as a DR option only.
    /// </summary>
    public BicepValue<GeoSecondaryInstanceType> SecondaryType { get => _secondaryType; set => _secondaryType.Assign(value); }
    private readonly BicepValue<GeoSecondaryInstanceType> _secondaryType;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Local replication role of the failover group instance.
    /// </summary>
    public BicepValue<InstanceFailoverGroupReplicationRole> ReplicationRole { get => _replicationRole; }
    private readonly BicepValue<InstanceFailoverGroupReplicationRole> _replicationRole;

    /// <summary>
    /// Replication state of the failover group instance.
    /// </summary>
    public BicepValue<string> ReplicationState { get => _replicationState; }
    private readonly BicepValue<string> _replicationState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new InstanceFailoverGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the InstanceFailoverGroup resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the InstanceFailoverGroup.</param>
    public InstanceFailoverGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/locations/instanceFailoverGroups", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _managedInstancePairs = BicepList<ManagedInstancePairInfo>.DefineProperty(this, "ManagedInstancePairs", ["properties", "managedInstancePairs"]);
        _partnerRegions = BicepList<PartnerRegionInfo>.DefineProperty(this, "PartnerRegions", ["properties", "partnerRegions"]);
        _readOnlyEndpointFailoverPolicy = BicepValue<ReadOnlyEndpointFailoverPolicy>.DefineProperty(this, "ReadOnlyEndpointFailoverPolicy", ["properties", "readOnlyEndpoint", "failoverPolicy"]);
        _readWriteEndpoint = BicepValue<InstanceFailoverGroupReadWriteEndpoint>.DefineProperty(this, "ReadWriteEndpoint", ["properties", "readWriteEndpoint"]);
        _secondaryType = BicepValue<GeoSecondaryInstanceType>.DefineProperty(this, "SecondaryType", ["properties", "secondaryType"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _replicationRole = BicepValue<InstanceFailoverGroupReplicationRole>.DefineProperty(this, "ReplicationRole", ["properties", "replicationRole"], isOutput: true);
        _replicationState = BicepValue<string>.DefineProperty(this, "ReplicationState", ["properties", "replicationState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported InstanceFailoverGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing InstanceFailoverGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the InstanceFailoverGroup resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the InstanceFailoverGroup.</param>
    /// <returns>The existing InstanceFailoverGroup resource.</returns>
    public static InstanceFailoverGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
