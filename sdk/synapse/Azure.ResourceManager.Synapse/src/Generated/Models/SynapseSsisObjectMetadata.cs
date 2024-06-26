// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary>
    /// SSIS object metadata.
    /// Please note <see cref="SynapseSsisObjectMetadata"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SynapseSsisEnvironment"/>, <see cref="SynapseSsisFolder"/>, <see cref="SynapseSsisPackage"/> and <see cref="SynapseSsisProject"/>.
    /// </summary>
    public abstract partial class SynapseSsisObjectMetadata
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

        /// <summary> Initializes a new instance of <see cref="SynapseSsisObjectMetadata"/>. </summary>
        protected SynapseSsisObjectMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSsisObjectMetadata"/>. </summary>
        /// <param name="metadataType"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseSsisObjectMetadata(SynapseSsisObjectMetadataType metadataType, long? id, string name, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MetadataType = metadataType;
            Id = id;
            Name = name;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of metadata. </summary>
        internal SynapseSsisObjectMetadataType MetadataType { get; set; }
        /// <summary> Metadata id. </summary>
        public long? Id { get; }
        /// <summary> Metadata name. </summary>
        public string Name { get; }
        /// <summary> Metadata description. </summary>
        public string Description { get; }
    }
}
