// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// Properties to configure keyVault Properties.
/// </summary>
public partial class CognitiveServicesKeyVaultProperties : ProvisionableConstruct
{
    /// <summary>
    /// Name of the Key from KeyVault.
    /// </summary>
    public BicepValue<string> KeyName { get => _keyName; set => _keyName.Assign(value); }
    private readonly BicepValue<string> _keyName;

    /// <summary>
    /// Version of the Key from KeyVault.
    /// </summary>
    public BicepValue<string> KeyVersion { get => _keyVersion; set => _keyVersion.Assign(value); }
    private readonly BicepValue<string> _keyVersion;

    /// <summary>
    /// Uri of KeyVault.
    /// </summary>
    public BicepValue<Uri> KeyVaultUri { get => _keyVaultUri; set => _keyVaultUri.Assign(value); }
    private readonly BicepValue<Uri> _keyVaultUri;

    /// <summary>
    /// Gets or sets the identity client id.
    /// </summary>
    public BicepValue<Guid> IdentityClientId { get => _identityClientId; set => _identityClientId.Assign(value); }
    private readonly BicepValue<Guid> _identityClientId;

    /// <summary>
    /// Creates a new CognitiveServicesKeyVaultProperties.
    /// </summary>
    public CognitiveServicesKeyVaultProperties()
    {
        _keyName = BicepValue<string>.DefineProperty(this, "KeyName", ["keyName"]);
        _keyVersion = BicepValue<string>.DefineProperty(this, "KeyVersion", ["keyVersion"]);
        _keyVaultUri = BicepValue<Uri>.DefineProperty(this, "KeyVaultUri", ["keyVaultUri"]);
        _identityClientId = BicepValue<Guid>.DefineProperty(this, "IdentityClientId", ["identityClientId"]);
    }
}
