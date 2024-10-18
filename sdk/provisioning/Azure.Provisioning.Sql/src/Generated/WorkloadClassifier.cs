// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// WorkloadClassifier.
/// </summary>
public partial class WorkloadClassifier : ProvisionableResource
{
    /// <summary>
    /// The name of the workload classifier to create/update.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The workload classifier context.
    /// </summary>
    public BicepValue<string> Context { get => _context; set => _context.Assign(value); }
    private readonly BicepValue<string> _context;

    /// <summary>
    /// The workload classifier end time for classification.
    /// </summary>
    public BicepValue<string> EndTime { get => _endTime; set => _endTime.Assign(value); }
    private readonly BicepValue<string> _endTime;

    /// <summary>
    /// The workload classifier importance.
    /// </summary>
    public BicepValue<string> Importance { get => _importance; set => _importance.Assign(value); }
    private readonly BicepValue<string> _importance;

    /// <summary>
    /// The workload classifier label.
    /// </summary>
    public BicepValue<string> Label { get => _label; set => _label.Assign(value); }
    private readonly BicepValue<string> _label;

    /// <summary>
    /// The workload classifier member name.
    /// </summary>
    public BicepValue<string> MemberName { get => _memberName; set => _memberName.Assign(value); }
    private readonly BicepValue<string> _memberName;

    /// <summary>
    /// The workload classifier start time for classification.
    /// </summary>
    public BicepValue<string> StartTime { get => _startTime; set => _startTime.Assign(value); }
    private readonly BicepValue<string> _startTime;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent WorkloadGroup.
    /// </summary>
    public WorkloadGroup? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WorkloadGroup> _parent;

    /// <summary>
    /// Creates a new WorkloadClassifier.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WorkloadClassifier resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WorkloadClassifier.</param>
    public WorkloadClassifier(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/workloadGroups/workloadClassifiers", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _context = BicepValue<string>.DefineProperty(this, "Context", ["properties", "context"]);
        _endTime = BicepValue<string>.DefineProperty(this, "EndTime", ["properties", "endTime"]);
        _importance = BicepValue<string>.DefineProperty(this, "Importance", ["properties", "importance"]);
        _label = BicepValue<string>.DefineProperty(this, "Label", ["properties", "label"]);
        _memberName = BicepValue<string>.DefineProperty(this, "MemberName", ["properties", "memberName"]);
        _startTime = BicepValue<string>.DefineProperty(this, "StartTime", ["properties", "startTime"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WorkloadGroup>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported WorkloadClassifier resource versions.
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
    /// Creates a reference to an existing WorkloadClassifier.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WorkloadClassifier resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WorkloadClassifier.</param>
    /// <returns>The existing WorkloadClassifier resource.</returns>
    public static WorkloadClassifier FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
