// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// PostgreSqlMigration.
/// </summary>
public partial class PostgreSqlMigration : ProvisionableResource
{
    /// <summary>
    /// The name of the migration.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// To trigger cancel for entire migration we need to send this flag as
    /// True.
    /// </summary>
    public BicepValue<PostgreSqlMigrationCancel> Cancel { get => _cancel; set => _cancel.Assign(value); }
    private readonly BicepValue<PostgreSqlMigrationCancel> _cancel;

    /// <summary>
    /// When you want to trigger cancel for specific databases send cancel flag
    /// as True and database names in this array.
    /// </summary>
    public BicepList<string> DbsToCancelMigrationOn { get => _dbsToCancelMigrationOn; set => _dbsToCancelMigrationOn.Assign(value); }
    private readonly BicepList<string> _dbsToCancelMigrationOn;

    /// <summary>
    /// Number of databases to migrate.
    /// </summary>
    public BicepList<string> DbsToMigrate { get => _dbsToMigrate; set => _dbsToMigrate.Assign(value); }
    private readonly BicepList<string> _dbsToMigrate;

    /// <summary>
    /// When you want to trigger cutover for specific databases send
    /// triggerCutover flag as True and database names in this array.
    /// </summary>
    public BicepList<string> DbsToTriggerCutoverOn { get => _dbsToTriggerCutoverOn; set => _dbsToTriggerCutoverOn.Assign(value); }
    private readonly BicepList<string> _dbsToTriggerCutoverOn;

    /// <summary>
    /// There are two types of migration modes Online and Offline.
    /// </summary>
    public BicepValue<PostgreSqlMigrationMode> MigrationMode { get => _migrationMode; set => _migrationMode.Assign(value); }
    private readonly BicepValue<PostgreSqlMigrationMode> _migrationMode;

    /// <summary>
    /// End time in UTC for migration window.
    /// </summary>
    public BicepValue<DateTimeOffset> MigrationWindowEndTimeInUtc { get => _migrationWindowEndTimeInUtc; set => _migrationWindowEndTimeInUtc.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _migrationWindowEndTimeInUtc;

    /// <summary>
    /// Start time in UTC for migration window.
    /// </summary>
    public BicepValue<DateTimeOffset> MigrationWindowStartTimeInUtc { get => _migrationWindowStartTimeInUtc; set => _migrationWindowStartTimeInUtc.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _migrationWindowStartTimeInUtc;

    /// <summary>
    /// Indicates whether the databases on the target server can be
    /// overwritten, if already present. If set to False, the migration
    /// workflow will wait for a confirmation, if it detects that the database
    /// already exists.
    /// </summary>
    public BicepValue<PostgreSqlMigrationOverwriteDbsInTarget> OverwriteDbsInTarget { get => _overwriteDbsInTarget; set => _overwriteDbsInTarget.Assign(value); }
    private readonly BicepValue<PostgreSqlMigrationOverwriteDbsInTarget> _overwriteDbsInTarget;

    /// <summary>
    /// Migration secret parameters.
    /// </summary>
    public BicepValue<PostgreSqlMigrationSecretParameters> SecretParameters { get => _secretParameters; set => _secretParameters.Assign(value); }
    private readonly BicepValue<PostgreSqlMigrationSecretParameters> _secretParameters;

    /// <summary>
    /// Indicates whether to setup LogicalReplicationOnSourceDb, if needed.
    /// </summary>
    public BicepValue<PostgreSqlMigrationLogicalReplicationOnSourceDb> SetupLogicalReplicationOnSourceDbIfNeeded { get => _setupLogicalReplicationOnSourceDbIfNeeded; set => _setupLogicalReplicationOnSourceDbIfNeeded.Assign(value); }
    private readonly BicepValue<PostgreSqlMigrationLogicalReplicationOnSourceDb> _setupLogicalReplicationOnSourceDbIfNeeded;

    /// <summary>
    /// Source server fully qualified domain name or ip. It is a optional
    /// value, if customer provide it, dms will always use it for connection.
    /// </summary>
    public BicepValue<string> SourceDbServerFullyQualifiedDomainName { get => _sourceDbServerFullyQualifiedDomainName; set => _sourceDbServerFullyQualifiedDomainName.Assign(value); }
    private readonly BicepValue<string> _sourceDbServerFullyQualifiedDomainName;

    /// <summary>
    /// ResourceId of the source database server.
    /// </summary>
    public BicepValue<ResourceIdentifier> SourceDbServerResourceId { get => _sourceDbServerResourceId; set => _sourceDbServerResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _sourceDbServerResourceId;

    /// <summary>
    /// Indicates whether the data migration should start right away.
    /// </summary>
    public BicepValue<PostgreSqlMigrationStartDataMigration> StartDataMigration { get => _startDataMigration; set => _startDataMigration.Assign(value); }
    private readonly BicepValue<PostgreSqlMigrationStartDataMigration> _startDataMigration;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Target server fully qualified domain name or ip. It is a optional
    /// value, if customer provide it, dms will always use it for connection.
    /// </summary>
    public BicepValue<string> TargetDbServerFullyQualifiedDomainName { get => _targetDbServerFullyQualifiedDomainName; set => _targetDbServerFullyQualifiedDomainName.Assign(value); }
    private readonly BicepValue<string> _targetDbServerFullyQualifiedDomainName;

    /// <summary>
    /// To trigger cutover for entire migration we need to send this flag as
    /// True.
    /// </summary>
    public BicepValue<PostgreSqlMigrationTriggerCutover> TriggerCutover { get => _triggerCutover; set => _triggerCutover.Assign(value); }
    private readonly BicepValue<PostgreSqlMigrationTriggerCutover> _triggerCutover;

    /// <summary>
    /// Current status of migration.
    /// </summary>
    public BicepValue<PostgreSqlMigrationStatus> CurrentStatus { get => _currentStatus; }
    private readonly BicepValue<PostgreSqlMigrationStatus> _currentStatus;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// ID for migration, a GUID.
    /// </summary>
    public BicepValue<string> MigrationId { get => _migrationId; }
    private readonly BicepValue<string> _migrationId;

    /// <summary>
    /// Metadata of the source database server.
    /// </summary>
    public BicepValue<PostgreSqlServerMetadata> SourceDbServerMetadata { get => _sourceDbServerMetadata; }
    private readonly BicepValue<PostgreSqlServerMetadata> _sourceDbServerMetadata;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Metadata of the target database server.
    /// </summary>
    public BicepValue<PostgreSqlServerMetadata> TargetDbServerMetadata { get => _targetDbServerMetadata; }
    private readonly BicepValue<PostgreSqlServerMetadata> _targetDbServerMetadata;

    /// <summary>
    /// ResourceId of the source database server.
    /// </summary>
    public BicepValue<ResourceIdentifier> TargetDbServerResourceId { get => _targetDbServerResourceId; }
    private readonly BicepValue<ResourceIdentifier> _targetDbServerResourceId;

    /// <summary>
    /// Gets or sets a reference to the parent PostgreSqlFlexibleServer.
    /// </summary>
    public PostgreSqlFlexibleServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<PostgreSqlFlexibleServer> _parent;

    /// <summary>
    /// Creates a new PostgreSqlMigration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlMigration resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlMigration.</param>
    public PostgreSqlMigration(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DBforPostgreSQL/flexibleServers/migrations", resourceVersion ?? "2024-08-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _cancel = BicepValue<PostgreSqlMigrationCancel>.DefineProperty(this, "Cancel", ["properties", "cancel"]);
        _dbsToCancelMigrationOn = BicepList<string>.DefineProperty(this, "DbsToCancelMigrationOn", ["properties", "dbsToCancelMigrationOn"]);
        _dbsToMigrate = BicepList<string>.DefineProperty(this, "DbsToMigrate", ["properties", "dbsToMigrate"]);
        _dbsToTriggerCutoverOn = BicepList<string>.DefineProperty(this, "DbsToTriggerCutoverOn", ["properties", "dbsToTriggerCutoverOn"]);
        _migrationMode = BicepValue<PostgreSqlMigrationMode>.DefineProperty(this, "MigrationMode", ["properties", "migrationMode"]);
        _migrationWindowEndTimeInUtc = BicepValue<DateTimeOffset>.DefineProperty(this, "MigrationWindowEndTimeInUtc", ["properties", "migrationWindowEndTimeInUtc"]);
        _migrationWindowStartTimeInUtc = BicepValue<DateTimeOffset>.DefineProperty(this, "MigrationWindowStartTimeInUtc", ["properties", "migrationWindowStartTimeInUtc"]);
        _overwriteDbsInTarget = BicepValue<PostgreSqlMigrationOverwriteDbsInTarget>.DefineProperty(this, "OverwriteDbsInTarget", ["properties", "overwriteDbsInTarget"]);
        _secretParameters = BicepValue<PostgreSqlMigrationSecretParameters>.DefineProperty(this, "SecretParameters", ["properties", "secretParameters"]);
        _setupLogicalReplicationOnSourceDbIfNeeded = BicepValue<PostgreSqlMigrationLogicalReplicationOnSourceDb>.DefineProperty(this, "SetupLogicalReplicationOnSourceDbIfNeeded", ["properties", "setupLogicalReplicationOnSourceDbIfNeeded"]);
        _sourceDbServerFullyQualifiedDomainName = BicepValue<string>.DefineProperty(this, "SourceDbServerFullyQualifiedDomainName", ["properties", "sourceDbServerFullyQualifiedDomainName"]);
        _sourceDbServerResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SourceDbServerResourceId", ["properties", "sourceDbServerResourceId"]);
        _startDataMigration = BicepValue<PostgreSqlMigrationStartDataMigration>.DefineProperty(this, "StartDataMigration", ["properties", "startDataMigration"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _targetDbServerFullyQualifiedDomainName = BicepValue<string>.DefineProperty(this, "TargetDbServerFullyQualifiedDomainName", ["properties", "targetDbServerFullyQualifiedDomainName"]);
        _triggerCutover = BicepValue<PostgreSqlMigrationTriggerCutover>.DefineProperty(this, "TriggerCutover", ["properties", "triggerCutover"]);
        _currentStatus = BicepValue<PostgreSqlMigrationStatus>.DefineProperty(this, "CurrentStatus", ["properties", "currentStatus"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _migrationId = BicepValue<string>.DefineProperty(this, "MigrationId", ["properties", "migrationId"], isOutput: true);
        _sourceDbServerMetadata = BicepValue<PostgreSqlServerMetadata>.DefineProperty(this, "SourceDbServerMetadata", ["properties", "sourceDbServerMetadata"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _targetDbServerMetadata = BicepValue<PostgreSqlServerMetadata>.DefineProperty(this, "TargetDbServerMetadata", ["properties", "targetDbServerMetadata"], isOutput: true);
        _targetDbServerResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "TargetDbServerResourceId", ["properties", "targetDbServerResourceId"], isOutput: true);
        _parent = ResourceReference<PostgreSqlFlexibleServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlMigration resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing PostgreSqlMigration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlMigration resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlMigration.</param>
    /// <returns>The existing PostgreSqlMigration resource.</returns>
    public static PostgreSqlMigration FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
