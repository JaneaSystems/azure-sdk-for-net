// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Cosmos DB SQL container resource object.
/// </summary>
public partial class CosmosDBSqlContainerResourceInfo : ProvisionableConstruct
{
    /// <summary>
    /// Name of the Cosmos DB SQL container.
    /// </summary>
    public BicepValue<string> ContainerName { get => _containerName; set => _containerName.Assign(value); }
    private readonly BicepValue<string> _containerName;

    /// <summary>
    /// The configuration of the indexing policy. By default, the indexing is
    /// automatic for all document paths within the container.
    /// </summary>
    public BicepValue<CosmosDBIndexingPolicy> IndexingPolicy { get => _indexingPolicy; set => _indexingPolicy.Assign(value); }
    private readonly BicepValue<CosmosDBIndexingPolicy> _indexingPolicy;

    /// <summary>
    /// The configuration of the partition key to be used for partitioning data
    /// into multiple partitions.
    /// </summary>
    public BicepValue<CosmosDBContainerPartitionKey> PartitionKey { get => _partitionKey; set => _partitionKey.Assign(value); }
    private readonly BicepValue<CosmosDBContainerPartitionKey> _partitionKey;

    /// <summary>
    /// Default time to live.
    /// </summary>
    public BicepValue<int> DefaultTtl { get => _defaultTtl; set => _defaultTtl.Assign(value); }
    private readonly BicepValue<int> _defaultTtl;

    /// <summary>
    /// List of unique keys on that enforces uniqueness constraint on documents
    /// in the collection in the Azure Cosmos DB service.
    /// </summary>
    public BicepList<CosmosDBUniqueKey> UniqueKeys { get => _uniqueKeys; set => _uniqueKeys.Assign(value); }
    private readonly BicepList<CosmosDBUniqueKey> _uniqueKeys;

    /// <summary>
    /// The conflict resolution policy for the container.
    /// </summary>
    public BicepValue<ConflictResolutionPolicy> ConflictResolutionPolicy { get => _conflictResolutionPolicy; set => _conflictResolutionPolicy.Assign(value); }
    private readonly BicepValue<ConflictResolutionPolicy> _conflictResolutionPolicy;

    /// <summary>
    /// The client encryption policy for the container.
    /// </summary>
    public BicepValue<CosmosDBClientEncryptionPolicy> ClientEncryptionPolicy { get => _clientEncryptionPolicy; set => _clientEncryptionPolicy.Assign(value); }
    private readonly BicepValue<CosmosDBClientEncryptionPolicy> _clientEncryptionPolicy;

    /// <summary>
    /// Analytical TTL.
    /// </summary>
    public BicepValue<long> AnalyticalStorageTtl { get => _analyticalStorageTtl; set => _analyticalStorageTtl.Assign(value); }
    private readonly BicepValue<long> _analyticalStorageTtl;

    /// <summary>
    /// Parameters to indicate the information about the restore.
    /// </summary>
    public BicepValue<ResourceRestoreParameters> RestoreParameters { get => _restoreParameters; set => _restoreParameters.Assign(value); }
    private readonly BicepValue<ResourceRestoreParameters> _restoreParameters;

    /// <summary>
    /// Enum to indicate the mode of resource creation.
    /// </summary>
    public BicepValue<CosmosDBAccountCreateMode> CreateMode { get => _createMode; set => _createMode.Assign(value); }
    private readonly BicepValue<CosmosDBAccountCreateMode> _createMode;

    /// <summary>
    /// The configuration for defining Materialized Views. This must be
    /// specified only for creating a Materialized View container.
    /// </summary>
    public BicepValue<MaterializedViewDefinition> MaterializedViewDefinition { get => _materializedViewDefinition; set => _materializedViewDefinition.Assign(value); }
    private readonly BicepValue<MaterializedViewDefinition> _materializedViewDefinition;

    /// <summary>
    /// List of computed properties.
    /// </summary>
    public BicepList<ComputedProperty> ComputedProperties { get => _computedProperties; set => _computedProperties.Assign(value); }
    private readonly BicepList<ComputedProperty> _computedProperties;

    /// <summary>
    /// Creates a new CosmosDBSqlContainerResourceInfo.
    /// </summary>
    public CosmosDBSqlContainerResourceInfo()
    {
        _containerName = BicepValue<string>.DefineProperty(this, "ContainerName", ["id"]);
        _indexingPolicy = BicepValue<CosmosDBIndexingPolicy>.DefineProperty(this, "IndexingPolicy", ["indexingPolicy"]);
        _partitionKey = BicepValue<CosmosDBContainerPartitionKey>.DefineProperty(this, "PartitionKey", ["partitionKey"]);
        _defaultTtl = BicepValue<int>.DefineProperty(this, "DefaultTtl", ["defaultTtl"]);
        _uniqueKeys = BicepList<CosmosDBUniqueKey>.DefineProperty(this, "UniqueKeys", ["uniqueKeyPolicy", "uniqueKeys"]);
        _conflictResolutionPolicy = BicepValue<ConflictResolutionPolicy>.DefineProperty(this, "ConflictResolutionPolicy", ["conflictResolutionPolicy"]);
        _clientEncryptionPolicy = BicepValue<CosmosDBClientEncryptionPolicy>.DefineProperty(this, "ClientEncryptionPolicy", ["clientEncryptionPolicy"]);
        _analyticalStorageTtl = BicepValue<long>.DefineProperty(this, "AnalyticalStorageTtl", ["analyticalStorageTtl"]);
        _restoreParameters = BicepValue<ResourceRestoreParameters>.DefineProperty(this, "RestoreParameters", ["restoreParameters"]);
        _createMode = BicepValue<CosmosDBAccountCreateMode>.DefineProperty(this, "CreateMode", ["createMode"]);
        _materializedViewDefinition = BicepValue<MaterializedViewDefinition>.DefineProperty(this, "MaterializedViewDefinition", ["materializedViewDefinition"]);
        _computedProperties = BicepList<ComputedProperty>.DefineProperty(this, "ComputedProperties", ["computedProperties"]);
    }
}
