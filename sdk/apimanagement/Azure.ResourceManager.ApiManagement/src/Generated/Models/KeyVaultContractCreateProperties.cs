// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Create keyVault contract details. </summary>
    public partial class KeyVaultContractCreateProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultContractCreateProperties"/>. </summary>
        public KeyVaultContractCreateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultContractCreateProperties"/>. </summary>
        /// <param name="secretIdentifier"> Key vault secret identifier for fetching secret. Providing a versioned secret will prevent auto-refresh. This requires API Management service to be configured with aka.ms/apimmsi. </param>
        /// <param name="identityClientId"> Null for SystemAssignedIdentity or Client Id for UserAssignedIdentity , which will be used to access key vault secret. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultContractCreateProperties(string secretIdentifier, string identityClientId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SecretIdentifier = secretIdentifier;
            IdentityClientId = identityClientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Key vault secret identifier for fetching secret. Providing a versioned secret will prevent auto-refresh. This requires API Management service to be configured with aka.ms/apimmsi. </summary>
        [WirePath("secretIdentifier")]
        public string SecretIdentifier { get; set; }
        /// <summary> Null for SystemAssignedIdentity or Client Id for UserAssignedIdentity , which will be used to access key vault secret. </summary>
        [WirePath("identityClientId")]
        public string IdentityClientId { get; set; }
    }
}
